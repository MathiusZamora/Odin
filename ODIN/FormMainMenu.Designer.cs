namespace ODIN
{
    partial class FormMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevoTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListaTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAreas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.pnlNuevoTicket = new System.Windows.Forms.Panel();
            this.picNuevoTicket = new System.Windows.Forms.PictureBox();
            this.lblNuevoTicket = new System.Windows.Forms.Label();
            this.pnlListaTickets = new System.Windows.Forms.Panel();
            this.picListaTickets = new System.Windows.Forms.PictureBox();
            this.lblListaTickets = new System.Windows.Forms.Label();
            this.pnlMisTickets = new System.Windows.Forms.Panel();
            this.picMisTickets = new System.Windows.Forms.PictureBox();
            this.lblMisTickets = new System.Windows.Forms.Label();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevoTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picListaTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMisTickets)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuArchivo, this.mnuTickets, this.mnuGestion });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);

            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuCerrarSesion });
            this.mnuArchivo.Text = "Archivo";

            this.mnuCerrarSesion.Text = "Cerrar Sesión";
            this.mnuCerrarSesion.Click += mnuCerrarSesion_Click;

            this.mnuTickets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuNuevoTicket, this.mnuListaTickets });
            this.mnuTickets.Text = "Tickets";

            this.mnuNuevoTicket.Text = "Nuevo Ticket";
            this.mnuNuevoTicket.Click += mnuNuevoTicket_Click;

            this.mnuListaTickets.Text = "Lista de Tickets";
            this.mnuListaTickets.Click += mnuListaTickets_Click;

            this.mnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuUsuarios, this.mnuAreas });
            this.mnuGestion.Text = "Gestión";
            this.mnuGestion.Visible = false; // Se activará según rol

            this.mnuUsuarios.Text = "Gestión de Usuarios";
            this.mnuUsuarios.Click += mnuUsuarios_Click;

            this.mnuAreas.Text = "Áreas / Departamentos";
            this.mnuAreas.Click += mnuAreas_Click;

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1, this.toolStripStatusLabel2, this.toolStripStatusLabel3 });
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 25);

            this.toolStripStatusLabel1.Text = "Usuario: ";
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel3.Text = "Fecha y Hora";

            // Panel de botones grandes
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelBotones.Padding = new System.Windows.Forms.Padding(60);

            // Botón Nuevo Ticket
            this.pnlNuevoTicket.Size = new System.Drawing.Size(220, 220);
            this.pnlNuevoTicket.BackColor = System.Drawing.Color.White;
            this.pnlNuevoTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevoTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNuevoTicket.Location = new System.Drawing.Point(100, 80);
            this.pnlNuevoTicket.Click += pnlNuevoTicket_Click;

            this.picNuevoTicket.Size = new System.Drawing.Size(100, 100);
            this.picNuevoTicket.Location = new System.Drawing.Point(60, 30);
            this.picNuevoTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblNuevoTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevoTicket.Location = new System.Drawing.Point(20, 150);
            this.lblNuevoTicket.Text = "Nuevo Ticket";
            this.lblNuevoTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Botón Lista de Tickets
            this.pnlListaTickets.Size = new System.Drawing.Size(220, 220);
            this.pnlListaTickets.BackColor = System.Drawing.Color.White;
            this.pnlListaTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListaTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlListaTickets.Location = new System.Drawing.Point(380, 80);
            this.pnlListaTickets.Click += pnlListaTickets_Click;

            this.picListaTickets.Size = new System.Drawing.Size(100, 100);
            this.picListaTickets.Location = new System.Drawing.Point(60, 30);
            this.picListaTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblListaTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListaTickets.Location = new System.Drawing.Point(20, 150);
            this.lblListaTickets.Text = "Lista de Tickets";
            this.lblListaTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Botón Mis Tickets
            this.pnlMisTickets.Size = new System.Drawing.Size(220, 220);
            this.pnlMisTickets.BackColor = System.Drawing.Color.White;
            this.pnlMisTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMisTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMisTickets.Location = new System.Drawing.Point(660, 80);
            this.pnlMisTickets.Click += pnlMisTickets_Click;

            this.picMisTickets.Size = new System.Drawing.Size(100, 100);
            this.picMisTickets.Location = new System.Drawing.Point(60, 30);
            this.picMisTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblMisTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMisTickets.Location = new System.Drawing.Point(20, 150);
            this.lblMisTickets.Text = "Mis Tickets";
            this.lblMisTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormMainMenu
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODIN - Sistema de Gestión de Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += FormMainMenu_Load;

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevoTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picListaTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMisTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuTickets;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevoTicket;
        private System.Windows.Forms.ToolStripMenuItem mnuListaTickets;
        private System.Windows.Forms.ToolStripMenuItem mnuGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAreas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel pnlNuevoTicket;
        private System.Windows.Forms.PictureBox picNuevoTicket;
        private System.Windows.Forms.Label lblNuevoTicket;
        private System.Windows.Forms.Panel pnlListaTickets;
        private System.Windows.Forms.PictureBox picListaTickets;
        private System.Windows.Forms.Label lblListaTickets;
        private System.Windows.Forms.Panel pnlMisTickets;
        private System.Windows.Forms.PictureBox picMisTickets;
        private System.Windows.Forms.Label lblMisTickets;
    }
}