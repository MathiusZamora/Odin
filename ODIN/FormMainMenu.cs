using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODIN.Models;

namespace ODIN
{
    public partial class FormMainMenu : Form   // BaseForm
    {
        private readonly Usuario _usuario;
        private System.Windows.Forms.Timer relojTimer;

        public FormMainMenu(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // Información del usuario
            toolStripStatusLabel1.Text = $"Usuario: {_usuario.NombreUsuario}";
            toolStripStatusLabel2.Text = $"Rol: {_usuario.Rol}";

            // Reloj en tiempo real
            ActualizarReloj();
            relojTimer = new System.Windows.Forms.Timer();
            relojTimer.Interval = 1000;                    // 1 segundo
            relojTimer.Tick += (s, args) => ActualizarReloj();
            relojTimer.Start();

            // Configurar visibilidad según rol
            ConfigurarMenuPorRol();

            this.Text = $"ODIN - Bienvenido, {_usuario.Nombre}";
        }

        private void ActualizarReloj()
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm:ss");
        }

        private void ConfigurarMenuPorRol()
        {
            bool esAdmin = _usuario.Rol == "Administrador";

            // Menú Gestión solo visible para Administradores
            mnuGestion.Visible = esAdmin;
            mnuUsuarios.Visible = esAdmin;
            mnuAreas.Visible = esAdmin;

            // Por ahora todos pueden ver tickets
            mnuTickets.Visible = true;
        }

        // ==================== EVENTOS DE BOTONES ====================

        private void pnlNuevoTicket_Click(object sender, EventArgs e)
        {
            // Aquí abrirás el formulario para crear nuevo ticket
            MessageBox.Show("Abrir formulario de Nuevo Ticket", "Nuevo Ticket");
            // new FrmNuevoTicket(_usuario).ShowDialog();
        }

        private void pnlListaTickets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir Lista de Todos los Tickets", "Lista de Tickets");
            // new FrmListaTickets().ShowDialog();
        }

        private void pnlMisTickets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir Mis Tickets", "Mis Tickets");
            // new FrmMisTickets(_usuario).ShowDialog();
        }

        // ==================== MENÚ SUPERIOR ====================

        private void mnuNuevoTicket_Click(object sender, EventArgs e)
        {
            pnlNuevoTicket_Click(sender, e);
        }

        private void mnuListaTickets_Click(object sender, EventArgs e)
        {
            pnlListaTickets_Click(sender, e);
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestión de Usuarios - Próximamente", "En desarrollo");
            // new FrmGestionUsuarios().ShowDialog();
        }

        private void mnuAreas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestión de Áreas - Próximamente", "En desarrollo");
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                relojTimer?.Stop();
                this.Hide();
                new FrmLogin().Show();
            }
        }

        // Buena práctica: detener el timer al cerrar el formulario
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            relojTimer?.Stop();
            relojTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}