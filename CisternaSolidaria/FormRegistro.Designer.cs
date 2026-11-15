namespace CisternaSolidaria
{
    partial class FormRegistro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rbFamilia = new System.Windows.Forms.RadioButton();
            this.rbEscuela = new System.Windows.Forms.RadioButton();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.chkVulnerable = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblRegla = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 147);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cola de entrega de la cisterna";
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsuario.Location = new System.Drawing.Point(700, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Operador:";
            //
            // grpDatos
            //
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.rbFamilia);
            this.grpDatos.Controls.Add(this.rbEscuela);
            this.grpDatos.Controls.Add(this.lblResponsable);
            this.grpDatos.Controls.Add(this.txtResponsable);
            this.grpDatos.Controls.Add(this.lblCelular);
            this.grpDatos.Controls.Add(this.txtCelular);
            this.grpDatos.Controls.Add(this.lblZona);
            this.grpDatos.Controls.Add(this.cmbZona);
            this.grpDatos.Controls.Add(this.lblCantidad);
            this.grpDatos.Controls.Add(this.txtCantidad);
            this.grpDatos.Controls.Add(this.chkVulnerable);
            this.grpDatos.Controls.Add(this.btnRegistrar);
            this.grpDatos.Controls.Add(this.lblRegla);
            this.grpDatos.Location = new System.Drawing.Point(20, 60);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(400, 420);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Nueva solicitud de agua";
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 35);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 19);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            //
            // rbFamilia
            //
            this.rbFamilia.AutoSize = true;
            this.rbFamilia.Checked = true;
            this.rbFamilia.Location = new System.Drawing.Point(180, 33);
            this.rbFamilia.Name = "rbFamilia";
            this.rbFamilia.Size = new System.Drawing.Size(70, 23);
            this.rbFamilia.TabIndex = 1;
            this.rbFamilia.TabStop = true;
            this.rbFamilia.Text = "Familia";
            this.rbFamilia.UseVisualStyleBackColor = true;
            this.rbFamilia.CheckedChanged += new System.EventHandler(this.rbTipo_CheckedChanged);
            //
            // rbEscuela
            //
            this.rbEscuela.AutoSize = true;
            this.rbEscuela.Location = new System.Drawing.Point(265, 33);
            this.rbEscuela.Name = "rbEscuela";
            this.rbEscuela.Size = new System.Drawing.Size(72, 23);
            this.rbEscuela.TabIndex = 2;
            this.rbEscuela.Text = "Escuela";
            this.rbEscuela.UseVisualStyleBackColor = true;
            this.rbEscuela.CheckedChanged += new System.EventHandler(this.rbTipo_CheckedChanged);
            //
            // lblResponsable
            //
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(15, 78);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(88, 19);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "Responsable:";
            //
            // txtResponsable
            //
            this.txtResponsable.Location = new System.Drawing.Point(180, 75);
            this.txtResponsable.MaxLength = 40;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(200, 25);
            this.txtResponsable.TabIndex = 4;
            //
            // lblCelular
            //
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(15, 120);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(55, 19);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Celular:";
            //
            // txtCelular
            //
            this.txtCelular.Location = new System.Drawing.Point(180, 117);
            this.txtCelular.MaxLength = 8;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 25);
            this.txtCelular.TabIndex = 6;
            //
            // lblZona
            //
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(15, 162);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(41, 19);
            this.lblZona.TabIndex = 7;
            this.lblZona.Text = "Zona:";
            //
            // cmbZona
            //
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(180, 159);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(200, 25);
            this.cmbZona.TabIndex = 8;
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(15, 204);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(130, 19);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Integrantes (1-15):";
            //
            // txtCantidad
            //
            this.txtCantidad.Location = new System.Drawing.Point(180, 201);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 25);
            this.txtCantidad.TabIndex = 10;
            //
            // chkVulnerable
            //
            this.chkVulnerable.AutoSize = true;
            this.chkVulnerable.Location = new System.Drawing.Point(15, 243);
            this.chkVulnerable.Name = "chkVulnerable";
            this.chkVulnerable.Size = new System.Drawing.Size(340, 23);
            this.chkVulnerable.TabIndex = 11;
            this.chkVulnerable.Text = "Hay adulto mayor, bebé o persona con discapacidad";
            this.chkVulnerable.UseVisualStyleBackColor = true;
            //
            // btnRegistrar
            //
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(15, 290);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(365, 40);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar solicitud";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            //
            // lblRegla
            //
            this.lblRegla.AutoSize = true;
            this.lblRegla.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblRegla.ForeColor = System.Drawing.Color.DimGray;
            this.lblRegla.Location = new System.Drawing.Point(15, 345);
            this.lblRegla.MaximumSize = new System.Drawing.Size(365, 0);
            this.lblRegla.Name = "lblRegla";
            this.lblRegla.Size = new System.Drawing.Size(360, 45);
            this.lblRegla.TabIndex = 13;
            this.lblRegla.Text = "Reglas: cada persona puede tener una sola solicitud en espera. " +
                "El celular debe ser boliviano (8 dígitos, empieza con 6 o 7).";
            //
            // lblCola
            //
            this.lblCola.AutoSize = true;
            this.lblCola.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCola.Location = new System.Drawing.Point(440, 62);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(300, 19);
            this.lblCola.TabIndex = 3;
            this.lblCola.Text = "Solicitudes en espera (orden de llegada):";
            //
            // lstCola
            //
            this.lstCola.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstCola.FormattingEnabled = true;
            this.lstCola.HorizontalScrollbar = true;
            this.lstCola.ItemHeight = 17;
            this.lstCola.Location = new System.Drawing.Point(440, 88);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(440, 293);
            this.lstCola.TabIndex = 4;
            //
            // lblSiguiente
            //
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSiguiente.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblSiguiente.Location = new System.Drawing.Point(440, 392);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(190, 19);
            this.lblSiguiente.TabIndex = 5;
            this.lblSiguiente.Text = "Siguiente en recibir agua:";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(440, 416);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 19);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "En espera: 0";
            //
            // btnAtender
            //
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.Location = new System.Drawing.Point(440, 442);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(215, 38);
            this.btnAtender.TabIndex = 7;
            this.btnAtender.Text = "Atender siguiente";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            //
            // btnReporte
            //
            this.btnReporte.Location = new System.Drawing.Point(665, 442);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(215, 38);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Ver reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            //
            // btnSalir
            //
            this.btnSalir.Location = new System.Drawing.Point(780, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // FormRegistro
            //
            this.AcceptButton = this.btnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 252);
            this.ClientSize = new System.Drawing.Size(900, 545);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistro_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RadioButton rbFamilia;
        private System.Windows.Forms.RadioButton rbEscuela;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.CheckBox chkVulnerable;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRegla;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}
