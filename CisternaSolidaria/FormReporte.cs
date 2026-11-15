using System;
using System.Windows.Forms;

namespace CisternaSolidaria
{
    // VENTANA 3: reporte que recorre la cola y calcula los litros necesarios
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
            this.Text = Datos.TituloVentana("Reporte");
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            lstDetalle.Items.Clear();

            int familias = 0;
            int escuelas = 0;
            int casasConVulnerable = 0;
            double litrosFamilias = 0;
            double litrosEscuelas = 0;

            foreach (Solicitud s in Datos.Cola)
            {
                // POLIMORFISMO: cada objeto usa SU versión de LitrosPorDia()
                double litros = s.LitrosPorDia();

                lstDetalle.Items.Add(s.Tipo() + " | " + s.Responsable + " | " + s.Zona +
                    " | " + litros.ToString("0.0") + " L");

                if (s is SolicitudFamilia)
                {
                    familias++;
                    litrosFamilias += litros;
                    if (((SolicitudFamilia)s).TieneVulnerable) casasConVulnerable++;
                }
                else if (s is SolicitudEscuela)
                {
                    escuelas++;
                    litrosEscuelas += litros;
                }
            }

            double total = litrosFamilias + litrosEscuelas;
            // Viajes de cisterna necesarios (se redondea hacia arriba)
            int viajes = (int)Math.Ceiling(total / Datos.CAPACIDAD_CISTERNA);

            if (Datos.Cola.Count == 0)
            {
                lstDetalle.Items.Add("(No hay solicitudes en espera)");
            }

            lblResumen.Text =
                "Solicitudes en espera: " + Datos.Cola.Count + "\n" +
                "Familias: " + familias + "  (" + litrosFamilias.ToString("0.0") + " L/día)   -   " +
                "con adulto mayor, bebé o discapacidad: " + casasConVulnerable + "\n" +
                "Escuelas: " + escuelas + "  (" + litrosEscuelas.ToString("0.0") + " L/día)\n" +
                "TOTAL por día: " + total.ToString("0.0") + " L   -   por semana: " + (total * 7).ToString("0.0") + " L\n" +
                "Viajes de cisterna por día (" + Datos.CAPACIDAD_CISTERNA + " L c/u): " + viajes;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
