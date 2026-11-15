namespace CisternaSolidaria
{
    partial class FormIngreso
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuarioTxt = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 147);
            this.lblTitulo.Location = new System.Drawing.Point(40, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cisterna Solidaria";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(330, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Agua por orden de llegada - Zona Sur de Cochabamba";
            //
            // lblUsuarioTxt
            //
            this.lblUsuarioTxt.AutoSize = true;
            this.lblUsuarioTxt.Location = new System.Drawing.Point(42, 108);
            this.lblUsuarioTxt.Name = "lblUsuarioTxt";
            this.lblUsuarioTxt.Size = new System.Drawing.Size(58, 19);
            this.lblUsuarioTxt.TabIndex = 2;
            this.lblUsuarioTxt.Text = "Usuario:";
            //
            // txtUsuario
            //
            this.txtUsuario.Location = new System.Drawing.Point(150, 105);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(240, 25);
            this.txtUsuario.TabIndex = 3;
            //
            // lblClave
            //
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(42, 148);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 19);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Contraseña:";
            //
            // txtClave
            //
            this.txtClave.Location = new System.Drawing.Point(150, 145);
            this.txtClave.MaxLength = 30;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(240, 25);
            this.txtClave.TabIndex = 5;
            this.txtClave.UseSystemPasswordChar = true;
            //
            // btnIngresar
            //
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(150, 190);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(240, 38);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // lblIntentos
            //
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIntentos.Location = new System.Drawing.Point(150, 240);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(135, 19);
            this.lblIntentos.TabIndex = 7;
            this.lblIntentos.Text = "Intentos restantes: 3";
            //
            // FormIngreso
            //
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 252);
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblUsuarioTxt);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblIntentos);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cisterna Solidaria";
            this.Load += new System.EventHandler(this.FormIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuarioTxt;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblIntentos;
    }
}
