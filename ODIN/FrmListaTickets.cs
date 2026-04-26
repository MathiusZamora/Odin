using ODIN.Models;
using ODIN.Services;
using System;
using System.Windows.Forms;

namespace ODIN
{
    public partial class FrmListaTickets : Form
    {
        public FrmListaTickets()
        {
            InitializeComponent();
        }

        private void FrmListaTickets_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            CargarTodosLosTickets();
        }

        private void CargarFiltros()
        {
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add("Todos");
            cmbFiltroEstado.Items.Add("Abierto");
            cmbFiltroEstado.Items.Add("En Proceso");
            cmbFiltroEstado.Items.Add("Resuelto");
            cmbFiltroEstado.Items.Add("Cerrado");
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void CargarTodosLosTickets()
        {
            try
            {
                var tickets = TicketService.GetAll();
                dgvTickets.DataSource = tickets;

                // Configuración visual del DataGridView
                dgvTickets.Columns["TicketId"].HeaderText = "ID";
                dgvTickets.Columns["TicketId"].Width = 70;

                dgvTickets.Columns["FechaCorta"].HeaderText = "Fecha";
                dgvTickets.Columns["FechaCorta"].Width = 100;

                dgvTickets.Columns["Area"].Width = 130;
                dgvTickets.Columns["UsuarioNombre"].HeaderText = "Usuario";
                dgvTickets.Columns["Incidencia"].HeaderText = "Incidencia";
                dgvTickets.Columns["Riesgo"].Width = 90;
                dgvTickets.Columns["Estado"].Width = 110;

                // Ocultar columnas técnicas
                dgvTickets.Columns["Descripcion"].Visible = false;
                dgvTickets.Columns["UsuarioId"].Visible = false;
                dgvTickets.Columns["CreadoPor"].Visible = false;
                dgvTickets.Columns["Fecha"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los tickets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoTicket_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioActual == null)
            {
                MessageBox.Show("No se pudo obtener el usuario actual.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var frm = new FrmNuevoTicket(Program.UsuarioActual);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTodosLosTickets(); // Recargar lista
            }
        }

        private void dgvTickets_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null) return;

            var ticket = dgvTickets.CurrentRow.DataBoundItem as Ticket;
            if (ticket == null) return;

            MessageBox.Show($"Ticket #{ticket.TicketId}\n\n" +
                           $"Incidencia: {ticket.Incidencia}\n" +
                           $"Estado: {ticket.Estado}\n" +
                           $"Área: {ticket.Area}\n" +
                           $"Descripción: {ticket.Descripcion}",
                           "Detalle del Ticket",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            dgvTickets_DoubleClick(sender, e);
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null) return;

            var ticket = dgvTickets.CurrentRow.DataBoundItem as Ticket;
            if (ticket == null) return;

            if (ticket.Estado == "Cerrado")
            {
                MessageBox.Show("Este ticket ya está cerrado.", "Información");
                return;
            }

            if (MessageBox.Show($"¿Desea marcar como cerrado el ticket #{ticket.TicketId}?",
                "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ticket.Estado = "Cerrado";
                ticket.FechaResolucion = DateTime.Now;
                bool exito = TicketService.ActualizarTicket(ticket);

                if (exito)
                {
                    MessageBox.Show("Ticket cerrado correctamente.", "Éxito");
                    CargarTodosLosTickets();
                }
                else
                {
                    MessageBox.Show("No se pudo cerrar el ticket.", "Error");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtro avanzado estará disponible pronto.", "En desarrollo");
        }
    }
}