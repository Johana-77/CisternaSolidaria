using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CisternaSolidaria
{
    // Clase encargada del archivo de texto: guardar y cargar la cola.
    public static class ArchivoDatos
    {
        // El archivo se crea junto al .exe (carpeta bin\Debug)
        public static readonly string RUTA = Path.Combine(Application.StartupPath, "solicitudes.txt");

        // Cuantas lineas del archivo estaban danadas en la ultima carga
        public static int LineasDanadas = 0;

        public static void Guardar()
        {
            List<string> lineas = new List<string>();
            foreach (Solicitud s in Datos.Cola)
            {
                lineas.Add(s.ALinea());
            }
            try
            {
                File.WriteAllLines(RUTA, lineas, Encoding.UTF8);
            }
            catch (IOException ex)
            {
                MessageBox.Show("No se pudo guardar el archivo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("No hay permiso para guardar el archivo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Se llama UNA sola vez, en el Load de la primera ventana
        public static void Cargar()
        {
            Datos.Cola.Clear();
            LineasDanadas = 0;

            if (!File.Exists(RUTA)) return; // primera vez: todavia no hay archivo

            string[] lineas;
            try
            {
                lineas = File.ReadAllLines(RUTA, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer el archivo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string linea in lineas)
            {
                if (linea.Trim() == "") continue;
                try
                {
                    Datos.Cola.Enqueue(DesdeLinea(linea));
                }
                catch (Exception)
                {
                    // Linea danada: se cuenta, se ignora y se sigue con la siguiente
                    LineasDanadas++;
                }
            }
        }

        // Convierte una linea del archivo en el objeto correcto (Familia o Escuela).
        // Si algo esta mal, lanza una excepcion que se atrapa en Cargar().
        private static Solicitud DesdeLinea(string linea)
        {
            string[] p = linea.Split(';');
            if (p.Length < 6) throw new FormatException("Faltan datos");

            // Se vuelven a validar los datos por si alguien edito el archivo a mano
            if (!Validador.SoloLetras(p[1])) throw new FormatException("Nombre invalido");
            if (!Validador.CelularBoliviano(p[2])) throw new FormatException("Celular invalido");
            if (Array.IndexOf(Datos.Zonas, p[3]) < 0) throw new FormatException("Zona invalida");

            DateTime fecha = DateTime.ParseExact(p[4], Solicitud.FORMATO_FECHA, CultureInfo.InvariantCulture);
            int cantidad;

            if (p[0] == "Familia" && p.Length == 7)
            {
                if (!Validador.EnteroEnRango(p[5], 1, 15, out cantidad)) throw new FormatException("Integrantes");
                if (p[6] != "0" && p[6] != "1") throw new FormatException("Vulnerable");
                return new SolicitudFamilia(p[1], p[2], p[3], fecha, cantidad, p[6] == "1");
            }
            if (p[0] == "Escuela" && p.Length == 6)
            {
                if (!Validador.EnteroEnRango(p[5], 10, 2000, out cantidad)) throw new FormatException("Estudiantes");
                return new SolicitudEscuela(p[1], p[2], p[3], fecha, cantidad);
            }
            throw new FormatException("Tipo desconocido");
        }
    }
}
