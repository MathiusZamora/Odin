namespace ODIN
{
    partial class FrmListaTickets
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
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltroArea = new System.Windows.Forms.Label();
            this.cmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevoTicket = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnCerrarTicket = new System.Windows.Forms.Button();

            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 80, 140);
            this.lblTitulo.Location = new System.Drawing.Point(40, 20);
            this.lblTitulo.Text = "Lista de Tickets";

            // panelFiltros
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Location = new System.Drawing.Point(40, 70);
            this.panelFiltros.Size = new System.Drawing.Size(920, 60);
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(15);

            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Location = new System.Drawing.Point(20, 20);
            this.lblFiltroEstado.Text = "Estado:";

            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.Items.AddRange(new object[] { "Todos", "Abierto", "En Proceso", "Resuelto", "Cerrado" });
            this.cmbFiltroEstado.Location = new System.Drawing.Point(80, 18);
            this.cmbFiltroEstado.Size = new System.Drawing.Size(140, 28);

            this.lblFiltroArea.AutoSize = true;
            this.lblFiltroArea.Location = new System.Drawing.Point(250, 20);
            this.lblFiltroArea.Text = "Área:";

            this.cmbFiltroArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroArea.Location = new System.Drawing.Point(300, 18);
            this.cmbFiltroArea.Size = new System.Drawing.Size(180, 28);

            this.btnBuscar.Location = new System.Drawing.Point(510, 17);
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += btnBuscar_Click;

            this.btnNuevoTicket.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNuevoTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTicket.FlatAppearance.BorderSize = 0;
            this.btnNuevoTicket.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTicket.Location = new System.Drawing.Point(820, 17);
            this.btnNuevoTicket.Size = new System.Drawing.Size(120, 32);
            this.btnNuevoTicket.Text = "Nuevo Ticket";
            this.btnNuevoTicket.Click += btnNuevoTicket_Click;

            // DataGridView
            this.dgvTickets.Location = new System.Drawing.Point(40, 150);
            this.dgvTickets.Size = new System.Drawing.Size(920, 380);
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.DoubleClick += dgvTickets_DoubleClick;

            // Botones inferiores
            this.btnVerDetalle.Location = new System.Drawing.Point(40, 550);
            this.btnVerDetalle.Size = new System.Drawing.Size(140, 40);
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.Click += btnVerDetalle_Click;

            this.btnCerrarTicket.Location = new System.Drawing.Point(200, 550);
            this.btnCerrarTicket.Size = new System.Drawing.Size(140, 40);
            this.btnCerrarTicket.Text = "Cerrar Ticket";
            this.btnCerrarTicket.Click += btnCerrarTicket_Click;

            // FrmListaTickets
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnCerrarTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODIN - Lista de Tickets";
            this.Load += FrmListaTickets_Load;

            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label lblFiltroArea;
        private System.Windows.Forms.ComboBox cmbFiltroArea;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevoTicket;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnCerrarTicket;
    }
}