using ODIN.Models;
using ODIN.Services;
using System;
using System.Collections.Generic;
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
            CargarTickets();
        }

        private void CargarFiltros()
        {
            cmbFiltroEstado.SelectedIndex = 0; // "Todos"
        }

        private void CargarTickets()
        {
            try
            {
                var tickets = TicketService.GetAll();
                dgvTickets.DataSource = tickets;

                // Configurar columnas visibles
                if (dgvTickets.Columns.Count > 0)
                {
                    dgvTickets.Columns["TicketId"].HeaderText = "ID";
                    dgvTickets.Columns["TicketId"].Width = 60;

                    dgvTickets.Columns["FechaCorta"].HeaderText = "Fecha";
                    dgvTickets.Columns["FechaCorta"].Width = 90;

                    dgvTickets.Columns["Area"].Width = 120;
                    dgvTickets.Columns["UsuarioNombre"].HeaderText = "Usuario";
                    dgvTickets.Columns["Incidencia"].HeaderText = "Incidencia";
                    dgvTickets.Columns["Riesgo"].Width = 80;
                    dgvTickets.Columns["Estado"].Width = 100;

                    // Ocultar columnas que no queremos mostrar por ahora
                    dgvTickets.Columns["Descripcion"].Visible = false;
                    dgvTickets.Columns["Fecha"].Visible = false;
                    dgvTickets.Columns["UsuarioId"].Visible = false;
                    dgvTickets.Columns["CreadoPor"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tickets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoTicket_Click(object sender, EventArgs e)
        {
            using var frm = new FrmNuevoTicket(Program.UsuarioActual); // Pasamos el usuario logueado
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTickets(); // Recargar lista después de crear
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null) return;

            var ticket = dgvTickets.CurrentRow.DataBoundItem as Ticket;
            if (ticket == null) return;

            MessageBox.Show($"Detalle del Ticket #{ticket.TicketId}\n\n" +
                           $"Incidencia: {ticket.Incidencia}\n" +
                           $"Estado: {ticket.Estado}\n" +
                           $"Descripción: {ticket.Descripcion}",
                           "Detalle del Ticket");
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

            if (MessageBox.Show($"¿Desea cerrar el ticket #{ticket.TicketId}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ticket.Estado = "Cerrado";
                ticket.FechaResolucion = DateTime.Now;
                TicketService.ActualizarTicket(ticket);
                CargarTickets();
                MessageBox.Show("Ticket cerrado correctamente.", "Éxito");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtro básico por estado (puedes mejorarlo después)
            MessageBox.Show("Filtro avanzado - Próximamente", "En desarrollo");
        }

        private void dgvTickets_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null) return;

            var ticket = dgvTickets.CurrentRow.DataBoundItem as Ticket;
            if (ticket == null) return;

            // Aquí puedes abrir el detalle del ticket
            MessageBox.Show($"Ticket #{ticket.TicketId} - {ticket.Incidencia}\n\n" +
                           $"Estado: {ticket.Estado}\n" +
                           $"Área: {ticket.Area}",
                           "Detalle del Ticket");
        }
    }
}