using System;

namespace CisternaSolidaria
{
    // CLASE HIJA 2: una unidad educativa que pide agua para sus estudiantes.
    public class SolicitudEscuela : Solicitud
    {
        // Litros por estudiante en una jornada escolar (lavado de manos, banos, bebederos)
        public const double LITROS_POR_ESTUDIANTE = 2.5;
        // Litros fijos para la limpieza del establecimiento
        public const double LITROS_LIMPIEZA = 50;

        private int estudiantes;

        public SolicitudEscuela(string responsable, string celular, string zona, DateTime fecha,
                                int estudiantes)
            : base(responsable, celular, zona, fecha)
        {
            this.estudiantes = estudiantes;
        }

        public int Estudiantes
        {
            get { return estudiantes; }
        }

        public override string Tipo()
        {
            return "Escuela";
        }

        // Escuela: 2.5 L por estudiante + 50 L fijos de limpieza
        public override double LitrosPorDia()
        {
            return estudiantes * LITROS_POR_ESTUDIANTE + LITROS_LIMPIEZA;
        }

        public override string ALinea()
        {
            return base.ALinea() + ";" + estudiantes;
        }
    }
}
