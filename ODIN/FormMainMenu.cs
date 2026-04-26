// FormMainMenu.cs
using ODIN.Models;
using System;
using System.Windows.Forms;

namespace ODIN
{
    public partial class FormMainMenu : Form
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
            toolStripStatusLabel1.Text = $"Usuario: {_usuario.NombreUsuario}";
            toolStripStatusLabel2.Text = $"Rol: {_usuario.Rol}";

            ActualizarReloj();
            relojTimer = new System.Windows.Forms.Timer();
            relojTimer.Interval = 1000;
            relojTimer.Tick += (s, args) => ActualizarReloj();
            relojTimer.Start();

            ConfigurarVisibilidadPorRol();

            this.Text = $"ODIN - Bienvenido, {_usuario.Nombre}";

            picNuevoTicket.SizeMode = PictureBoxSizeMode.Zoom;
            picNuevoTicket.Image = Properties.Resources.NewTicket;
        }

        private void ActualizarReloj()
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm:ss");
        }

        private void ConfigurarVisibilidadPorRol()
        {
            bool esAdmin = _usuario.Rol == "Administrador" || _usuario.Rol == "Supervisor";
            mnuGestion.Visible = esAdmin;
        }

        // ====================== EVENTOS DE BOTONES ======================

        private void pnlNuevoTicket_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioActual == null)
            {
                MessageBox.Show("No se ha podido obtener el usuario actual.\nPor favor inicia sesión nuevamente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var frm = new FrmNuevoTicket(Program.UsuarioActual);
            frm.ShowDialog();
        }

        private void pnlListaTickets_Click(object sender, EventArgs e)
        {
            using var frm = new FrmListaTickets();
            frm.ShowDialog();
        }

        private void pnlMisTickets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mis Tickets - Esta funcionalidad estará disponible pronto",
                "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ====================== MENÚ SUPERIOR ======================

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

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestión de Usuarios - Próximamente", "En desarrollo");
        }

        private void mnuAreas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestión de Áreas - Próximamente", "En desarrollo");
        }

        // Detener timer al cerrar
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            relojTimer?.Stop();
            relojTimer?.Dispose();
            base.OnFormClosing(e);
        }

        
    }
}