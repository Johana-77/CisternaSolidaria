using System;

namespace CisternaSolidaria
{
    // CLASE HIJA 1: una familia que pide agua para su casa.
    public class SolicitudFamilia : Solicitud
    {
        // Litros minimos por persona al dia (consumo basico: beber, cocinar, higiene)
        public const double LITROS_POR_PERSONA = 20;
        // Litros extra si en la casa hay un adulto mayor, un bebe o una persona con discapacidad
        public const double LITROS_EXTRA_VULNERABLE = 20;

        private int integrantes;
        private bool tieneVulnerable;

        public SolicitudFamilia(string responsable, string celular, string zona, DateTime fecha,
                                int integrantes, bool tieneVulnerable)
            : base(responsable, celular, zona, fecha)
        {
            this.integrantes = integrantes;
            this.tieneVulnerable = tieneVulnerable;
        }

        public int Integrantes
        {
            get { return integrantes; }
        }

        public bool TieneVulnerable
        {
            get { return tieneVulnerable; }
        }

        public override string Tipo()
        {
            return "Familia";
        }

        // Familia: 20 L por persona + 20 L extra si hay alguien vulnerable
        public override double LitrosPorDia()
        {
            double litros = integrantes * LITROS_POR_PERSONA;
            if (tieneVulnerable)
            {
                litros = litros + LITROS_EXTRA_VULNERABLE;
            }
            return litros;
        }

        public override string ALinea()
        {
            // Reutiliza la parte comun de la clase base y agrega lo propio
            return base.ALinea() + ";" + integrantes + ";" + (tieneVulnerable ? "1" : "0");
        }
    }
}
