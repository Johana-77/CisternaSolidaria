namespace CisternaSolidaria
{
    partial class FormReporte
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
            this.lstDetalle = new System.Windows.Forms.ListBox();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpResumen.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 147);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reporte: agua necesaria en la cola";
            //
            // lstDetalle
            //
            this.lstDetalle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstDetalle.FormattingEnabled = true;
            this.lstDetalle.HorizontalScrollbar = true;
            this.lstDetalle.ItemHeight = 17;
            this.lstDetalle.Location = new System.Drawing.Point(20, 55);
            this.lstDetalle.Name = "lstDetalle";
            this.lstDetalle.Size = new System.Drawing.Size(700, 225);
            this.lstDetalle.TabIndex = 1;
            //
            // grpResumen
            //
            this.grpResumen.Controls.Add(this.lblResumen);
            this.grpResumen.Location = new System.Drawing.Point(20, 292);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Size = new System.Drawing.Size(700, 140);
            this.grpResumen.TabIndex = 2;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Totales";
            //
            // lblResumen
            //
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(15, 28);
            this.lblResumen.MaximumSize = new System.Drawing.Size(670, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(70, 19);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "Resumen";
            //
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(600, 445);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 36);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // FormReporte
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 252);
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(740, 495);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstDetalle);
            this.Controls.Add(this.grpResumen);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            this.grpResumen.ResumeLayout(false);
            this.grpResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstDetalle;
        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnVolver;
    }
}
