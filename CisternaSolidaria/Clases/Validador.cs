using System;
using System.Collections.Generic;

namespace CisternaSolidaria
{
    // Clase reutilizable: revisa el texto de los TextBox y responde true o false.
    // La usan todas las ventanas y tambien ArchivoDatos al cargar.
    public static class Validador
    {
        // El texto no esta vacio ni tiene solo espacios
        public static bool NoVacio(string texto)
        {
            return texto != null && texto.Trim() != "";
        }

        // Solo letras (incluye a, e, n con tilde) y espacios
        public static bool SoloLetras(string texto)
        {
            if (!NoVacio(texto)) return false;
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ') return false;
            }
            return true;
        }

        // La cantidad de caracteres esta entre min y max
        public static bool LargoEntre(string texto, int min, int max)
        {
            if (texto == null) return false;
            int largo = texto.Trim().Length;
            return largo >= min && largo <= max;
        }

        // Numero entero dentro de un rango
        public static bool EnteroEnRango(string texto, int min, int max, out int valor)
        {
            return int.TryParse(texto.Trim(), out valor) && valor >= min && valor <= max;
        }

        // REGLA PROPIA 1: celular boliviano = 8 digitos y empieza con 6 o 7
        public static bool CelularBoliviano(string texto)
        {
            if (texto == null) return false;
            texto = texto.Trim();
            if (texto.Length != 8) return false;
            if (texto[0] != '6' && texto[0] != '7') return false;
            foreach (char c in texto)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        // REGLA PROPIA 2: una persona no puede tener dos solicitudes en espera
        // (asi nadie acapara el agua de la cisterna)
        public static bool ResponsableYaEnCola(string nombre, Queue<Solicitud> cola)
        {
            string buscado = nombre.Trim().ToUpper();
            foreach (Solicitud s in cola)
            {
                if (s.Responsable.Trim().ToUpper() == buscado) return true;
            }
            return false;
        }
    }
}
