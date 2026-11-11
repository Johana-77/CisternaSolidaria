using System;
using System.Globalization;

namespace CisternaSolidaria
{
    // CLASE BASE: una solicitud de agua que llega a la cisterna.
    // Las clases hijas (SolicitudFamilia y SolicitudEscuela) heredan de esta.
    public class Solicitud
    {
        // Formato fijo para guardar la fecha en el archivo (no depende de la configuracion de Windows)
        public const string FORMATO_FECHA = "yyyy-MM-dd HH:mm";

        protected string responsable;
        protected string celular;
        protected string zona;
        protected DateTime fecha;

        public Solicitud(string responsable, string celular, string zona, DateTime fecha)
        {
            this.responsable = responsable;
            this.celular = celular;
            this.zona = zona;
            this.fecha = fecha;
        }

        public string Responsable
        {
            get { return responsable; }
        }

        public string Celular
        {
            get { return celular; }
        }

        public string Zona
        {
            get { return zona; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        // Nombre del tipo de solicitud (cada hija devuelve el suyo)
        public virtual string Tipo()
        {
            return "General";
        }

        // METODO QUE SE SOBRESCRIBE: litros de agua que necesita por dia.
        // Cada hija lo calcula de forma distinta.
        public virtual double LitrosPorDia()
        {
            return 100;
        }

        // Convierte el objeto en una linea de texto para guardarlo en el archivo
        public virtual string ALinea()
        {
            return Tipo() + ";" + responsable + ";" + celular + ";" + zona + ";"
                + fecha.ToString(FORMATO_FECHA, CultureInfo.InvariantCulture);
        }

        // Texto que se muestra en la lista de la ventana
        public override string ToString()
        {
            return "[" + Tipo() + "] " + responsable + " - " + zona + " - "
                + LitrosPorDia().ToString("0.0") + " L/día";
        }
    }
}
