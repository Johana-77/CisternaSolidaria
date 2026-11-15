using System;
using System.Windows.Forms;

namespace CisternaSolidaria
{
    // VENTANA 2: registrar solicitudes, ver la cola y atender (eliminar) la primera
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            this.Text = Datos.TituloVentana("Registro");
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            cmbZona.Items.Clear();
            cmbZona.Items.AddRange(Datos.Zonas);
            rbFamilia.Checked = true;
            lblUsuario.Text = "Operador: " + Datos.Usuario;
            ActualizarTipo();
            ActualizarLista();
        }

        // Cambia la etiqueta de cantidad según el tipo elegido
        private void rbTipo_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTipo();
        }

        private void ActualizarTipo()
        {
            if (rbFamilia.Checked)
            {
                lblCantidad.Text = "Integrantes (1-15):";
                chkVulnerable.Enabled = true;
            }
            else
            {
                lblCantidad.Text = "Estudiantes (10-2000):";
                chkVulnerable.Checked = false;
                chkVulnerable.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtResponsable.Text.Trim();
            string celular = txtCelular.Text.Trim();
            int cantidad;

            // 1) Campos vacíos
            if (!Validador.NoVacio(nombre) || !Validador.NoVacio(celular) ||
                !Validador.NoVacio(txtCantidad.Text) || cmbZona.SelectedIndex < 0)
            {
                MessageBox.Show("Completa todos los campos y elige una zona.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Solo letras en el nombre
            if (!Validador.SoloLetras(nombre))
            {
                MessageBox.Show("El nombre del responsable solo puede tener letras y espacios.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResponsable.Focus();
                return;
            }
            if (!Validador.LargoEntre(nombre, 3, 40))
            {
                MessageBox.Show("El nombre debe tener entre 3 y 40 letras.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResponsable.Focus();
                return;
            }

            // 3) Regla propia: celular boliviano
            if (!Validador.CelularBoliviano(celular))
            {
                MessageBox.Show("El celular debe tener 8 dígitos y empezar con 6 o 7.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                return;
            }

            // 4) Regla propia: no repetir responsable en la cola
            if (Validador.ResponsableYaEnCola(nombre, Datos.Cola))
            {
                MessageBox.Show(nombre + " ya tiene una solicitud en espera. " +
                    "Debe ser atendida antes de pedir otra.", "Solicitud repetida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5) Número dentro de rango, según el tipo; se crea el objeto de la clase hija
            string zona = cmbZona.SelectedItem.ToString();
            Solicitud nueva;

            if (rbFamilia.Checked)
            {
                if (!Validador.EnteroEnRango(txtCantidad.Text, 1, 15, out cantidad))
                {
                    MessageBox.Show("Los integrantes deben ser un número entre 1 y 15.", "Dato inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }
                nueva = new SolicitudFamilia(nombre, celular, zona, DateTime.Now, cantidad, chkVulnerable.Checked);
            }
            else
            {
                if (!Validador.EnteroEnRango(txtCantidad.Text, 10, 2000, out cantidad))
                {
                    MessageBox.Show("Los estudiantes deben ser un número entre 10 y 2000.", "Dato inválido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }
                nueva = new SolicitudEscuela(nombre, celular, zona, DateTime.Now, cantidad);
            }

            // Todo bien: se agrega al FINAL de la cola y se guarda en el archivo
            Datos.Cola.Enqueue(nueva);
            ArchivoDatos.Guardar();

            MessageBox.Show("Solicitud registrada.\nPosición en la cola: " + Datos.Cola.Count +
                "\nNecesita " + nueva.LitrosPorDia().ToString("0.0") + " litros por día.",
                "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            ActualizarLista();
        }

        // Atender = la cisterna entrega agua a la PRIMERA solicitud y sale de la cola
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (Datos.Cola.Count == 0)
            {
                MessageBox.Show("No hay solicitudes en espera.", "Cola vacía",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Solicitud primera = Datos.Cola.Peek(); // se mira sin sacarla
            DialogResult respuesta = MessageBox.Show(
                "¿La cisterna ya entregó el agua a " + primera.Responsable + " (" + primera.Zona + ")?",
                "Confirmar entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            Solicitud atendida = Datos.Cola.Dequeue(); // ahora sí sale de la cola
            ArchivoDatos.Guardar();

            MessageBox.Show("Atendida: " + atendida.Responsable + "\nSe entregaron " +
                atendida.LitrosPorDia().ToString("0.0") + " litros.", "Entrega registrada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarLista();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte reporte = new FormReporte();
            reporte.ShowDialog(); // al cerrar el reporte se vuelve a esta ventana
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Como la ventana de ingreso está oculta, al cerrar esta se termina la aplicación
        private void FormRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Recorre la cola y la muestra en la lista
        private void ActualizarLista()
        {
            lstCola.Items.Clear();
            int posicion = 1;
            foreach (Solicitud s in Datos.Cola)
            {
                lstCola.Items.Add(posicion + ". " + s.ToString());
                posicion++;
            }

            lblTotal.Text = "En espera: " + Datos.Cola.Count;
            if (Datos.Cola.Count > 0)
                lblSiguiente.Text = "Siguiente en recibir agua: " + Datos.Cola.Peek().Responsable;
            else
                lblSiguiente.Text = "Siguiente en recibir agua: (nadie)";
        }

        private void LimpiarCampos()
        {
            txtResponsable.Clear();
            txtCelular.Clear();
            txtCantidad.Clear();
            cmbZona.SelectedIndex = -1;
            chkVulnerable.Checked = false;
            txtResponsable.Focus();
        }
    }
}
