namespace ODIN
{
    partial class FrmNuevoTicket
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.txtIncidencia = new System.Windows.Forms.TextBox();
            this.lblRiesgo = new System.Windows.Forms.Label();
            this.cmbRiesgo = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            //this.lblEvidencia = new System.Windows.Forms.Label();
            this.btnAdjuntarEvidencia = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 80, 140);
            this.lblTitulo.Location = new System.Drawing.Point(50, 30);
            this.lblTitulo.Text = "Nuevo Ticket";

            // lblArea
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(50, 80);
            this.lblArea.Text = "Área / Departamento";

            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArea.Location = new System.Drawing.Point(50, 105);
            this.cmbArea.Size = new System.Drawing.Size(400, 28);

            // lblIncidencia
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIncidencia.Location = new System.Drawing.Point(50, 150);
            this.lblIncidencia.Text = "Incidencia (Título)";

            this.txtIncidencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIncidencia.Location = new System.Drawing.Point(50, 175);
            this.txtIncidencia.Size = new System.Drawing.Size(400, 30);

            // lblRiesgo
            this.lblRiesgo.AutoSize = true;
            this.lblRiesgo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRiesgo.Location = new System.Drawing.Point(50, 220);
            this.lblRiesgo.Text = "Nivel de Riesgo";

            this.cmbRiesgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRiesgo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRiesgo.Items.AddRange(new object[] { "Bajo", "Medio", "Alto", "Crítico" });
            this.cmbRiesgo.Location = new System.Drawing.Point(50, 245);
            this.cmbRiesgo.Size = new System.Drawing.Size(150, 28);

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(50, 290);
            this.lblDescripcion.Text = "Descripción detallada";

            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(50, 315);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Size = new System.Drawing.Size(400, 120);
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // btnAdjuntarEvidencia
            this.btnAdjuntarEvidencia.Location = new System.Drawing.Point(50, 450);
            this.btnAdjuntarEvidencia.Size = new System.Drawing.Size(180, 35);
            this.btnAdjuntarEvidencia.Text = "📎 Adjuntar Evidencia";
            this.btnAdjuntarEvidencia.Click += btnAdjuntarEvidencia_Click;

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(270, 500);
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.Text = "GUARDAR TICKET";
            this.btnGuardar.Click += btnGuardar_Click;

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(50, 500);
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += btnCancelar_Click;

            // FrmNuevoTicket
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblIncidencia);
            this.Controls.Add(this.txtIncidencia);
            this.Controls.Add(this.lblRiesgo);
            this.Controls.Add(this.cmbRiesgo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnAdjuntarEvidencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODIN - Nuevo Ticket";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.TextBox txtIncidencia;
        private System.Windows.Forms.Label lblRiesgo;
        private System.Windows.Forms.ComboBox cmbRiesgo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAdjuntarEvidencia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}