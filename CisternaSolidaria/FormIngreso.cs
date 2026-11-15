using System;
using System.Windows.Forms;

namespace CisternaSolidaria
{
    // VENTANA 1: ingreso con usuario y contraseña (máximo 3 intentos)
    public partial class FormIngreso : Form
    {
        private const string USUARIO_VALIDO = "operador";
        private const string CLAVE_VALIDA = "Agua2026";
        private const int MAX_INTENTOS = 3;

        private int intentos = 0;

        public FormIngreso()
        {
            InitializeComponent();
            // El nombre de la estudiante aparece en el título de la primera ventana
            this.Text = Datos.NOMBRE_APP + " - " + Datos.NOMBRE_ESTUDIANTE;
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {
            // Se cargan los datos guardados UNA sola vez, al abrir la aplicación
            ArchivoDatos.Cargar();
            lblIntentos.Text = "Intentos restantes: " + MAX_INTENTOS;

            if (ArchivoDatos.LineasDanadas > 0)
            {
                MessageBox.Show("Se ignoraron " + ArchivoDatos.LineasDanadas +
                    " línea(s) dañada(s) del archivo. El resto de los datos se cargó bien.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Campos vacíos: se avisa, pero no se gasta un intento
            if (!Validador.NoVacio(txtUsuario.Text) || !Validador.NoVacio(txtClave.Text))
            {
                MessageBox.Show("Escribe tu usuario y tu contraseña.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUsuario.Text.Trim() == USUARIO_VALIDO && txtClave.Text == CLAVE_VALIDA)
            {
                Datos.Usuario = txtUsuario.Text.Trim();
                FormRegistro siguiente = new FormRegistro();
                siguiente.Show();
                this.Hide();
                return;
            }

            intentos++;
            int restantes = MAX_INTENTOS - intentos;
            txtClave.Clear();

            if (restantes <= 0)
            {
                // Bloqueo: ya no se puede volver a intentar
                txtUsuario.Enabled = false;
                txtClave.Enabled = false;
                btnIngresar.Enabled = false;
                lblIntentos.Text = "Ingreso bloqueado";
                MessageBox.Show("Superaste los 3 intentos. El ingreso quedó bloqueado por seguridad.",
                    "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblIntentos.Text = "Intentos restantes: " + restantes;
                MessageBox.Show("Usuario o contraseña incorrectos. Te quedan " + restantes + " intento(s).",
                    "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Focus();
            }
        }
    }
}
