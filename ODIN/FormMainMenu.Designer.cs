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
            menuStrip1 = new MenuStrip();
            mnuArchivo = new ToolStripMenuItem();
            mnuCerrarSesion = new ToolStripMenuItem();
            mnuGestion = new ToolStripMenuItem();
            mnuUsuarios = new ToolStripMenuItem();
            mnuAreas = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            pnlNuevoTicket = new Panel();
            picNuevoTicket = new PictureBox();
            lblNuevoTicket = new Label();
            pnlListaTickets = new Panel();
            picListaTickets = new PictureBox();
            lblListaTickets = new Label();
            pnlMisTickets = new Panel();
            picMisTickets = new PictureBox();
            lblMisTickets = new Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNuevoTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picListaTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMisTickets).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArchivo, mnuGestion });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(962, 24);
            menuStrip1.TabIndex = 4;
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnuCerrarSesion });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(60, 20);
            mnuArchivo.Text = "Archivo";
            // 
            // mnuCerrarSesion
            // 
            mnuCerrarSesion.Name = "mnuCerrarSesion";
            mnuCerrarSesion.Size = new Size(143, 22);
            mnuCerrarSesion.Text = "Cerrar Sesión";
            mnuCerrarSesion.Click += mnuCerrarSesion_Click;
            // 
            // mnuGestion
            // 
            mnuGestion.DropDownItems.AddRange(new ToolStripItem[] { mnuUsuarios, mnuAreas });
            mnuGestion.Name = "mnuGestion";
            mnuGestion.Size = new Size(59, 20);
            mnuGestion.Text = "Gestión";
            // 
            // mnuUsuarios
            // 
            mnuUsuarios.Name = "mnuUsuarios";
            mnuUsuarios.Size = new Size(178, 22);
            mnuUsuarios.Text = "Gestión de Usuarios";
            mnuUsuarios.Click += mnuUsuarios_Click;
            // 
            // mnuAreas
            // 
            mnuAreas.Name = "mnuAreas";
            mnuAreas.Size = new Size(178, 22);
            mnuAreas.Text = "Gestión de Áreas";
            mnuAreas.Click += mnuAreas_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 634);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(962, 22);
            statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(53, 17);
            toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(820, 17);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(76, 17);
            toolStripStatusLabel3.Text = "Fecha y Hora";
            // 
            // pnlNuevoTicket
            // 
            pnlNuevoTicket.BackColor = Color.White;
            pnlNuevoTicket.BorderStyle = BorderStyle.FixedSingle;
            pnlNuevoTicket.Cursor = Cursors.Hand;
            pnlNuevoTicket.Location = new Point(105, 112);
            pnlNuevoTicket.Name = "pnlNuevoTicket";
            pnlNuevoTicket.Size = new Size(193, 244);
            pnlNuevoTicket.TabIndex = 0;
            pnlNuevoTicket.Click += pnlNuevoTicket_Click;
            // 
            // picNuevoTicket
            // 
            picNuevoTicket.Location = new Point(50, 40);
            picNuevoTicket.Name = "picNuevoTicket";
            picNuevoTicket.Size = new Size(120, 120);
            picNuevoTicket.SizeMode = PictureBoxSizeMode.Zoom;
            picNuevoTicket.TabIndex = 0;
            picNuevoTicket.TabStop = false;
            // 
            // lblNuevoTicket
            // 
            lblNuevoTicket.AutoSize = true;
            lblNuevoTicket.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNuevoTicket.Location = new Point(40, 180);
            lblNuevoTicket.Name = "lblNuevoTicket";
            lblNuevoTicket.Size = new Size(100, 23);
            lblNuevoTicket.TabIndex = 0;
            lblNuevoTicket.Text = "Nuevo Ticket";
            // 
            // pnlListaTickets
            // 
            pnlListaTickets.BackColor = Color.White;
            pnlListaTickets.BorderStyle = BorderStyle.FixedSingle;
            pnlListaTickets.Cursor = Cursors.Hand;
            pnlListaTickets.Location = new Point(368, 112);
            pnlListaTickets.Name = "pnlListaTickets";
            pnlListaTickets.Size = new Size(193, 244);
            pnlListaTickets.TabIndex = 1;
            pnlListaTickets.Click += pnlListaTickets_Click;
            // 
            // picListaTickets
            // 
            picListaTickets.Location = new Point(50, 40);
            picListaTickets.Name = "picListaTickets";
            picListaTickets.Size = new Size(120, 120);
            picListaTickets.SizeMode = PictureBoxSizeMode.Zoom;
            picListaTickets.TabIndex = 0;
            picListaTickets.TabStop = false;
            // 
            // lblListaTickets
            // 
            lblListaTickets.AutoSize = true;
            lblListaTickets.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblListaTickets.Location = new Point(30, 180);
            lblListaTickets.Name = "lblListaTickets";
            lblListaTickets.Size = new Size(100, 23);
            lblListaTickets.TabIndex = 0;
            lblListaTickets.Text = "Lista de Tickets";
            // 
            // pnlMisTickets
            // 
            pnlMisTickets.BackColor = Color.White;
            pnlMisTickets.BorderStyle = BorderStyle.FixedSingle;
            pnlMisTickets.Cursor = Cursors.Hand;
            pnlMisTickets.Location = new Point(630, 112);
            pnlMisTickets.Name = "pnlMisTickets";
            pnlMisTickets.Size = new Size(193, 244);
            pnlMisTickets.TabIndex = 2;
            pnlMisTickets.Click += pnlMisTickets_Click;
            // 
            // picMisTickets
            // 
            picMisTickets.Location = new Point(50, 40);
            picMisTickets.Name = "picMisTickets";
            picMisTickets.Size = new Size(120, 120);
            picMisTickets.SizeMode = PictureBoxSizeMode.Zoom;
            picMisTickets.TabIndex = 0;
            picMisTickets.TabStop = false;
            // 
            // lblMisTickets
            // 
            lblMisTickets.AutoSize = true;
            lblMisTickets.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMisTickets.Location = new Point(45, 180);
            lblMisTickets.Name = "lblMisTickets";
            lblMisTickets.Size = new Size(100, 23);
            lblMisTickets.TabIndex = 0;
            lblMisTickets.Text = "Mis Tickets";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 656);
            Controls.Add(pnlNuevoTicket);
            Controls.Add(pnlListaTickets);
            Controls.Add(pnlMisTickets);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ODIN - Sistema de Gestión de Tickets";
            WindowState = FormWindowState.Maximized;
            Load += FormMainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNuevoTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)picListaTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMisTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
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