// FrmNuevoTicket.cs
using ODIN.Models;
using ODIN.Services;

namespace ODIN
{
    public partial class FrmNuevoTicket : Form
    {
        private readonly Usuario _usuarioActual;

        public FrmNuevoTicket(Usuario usuarioActual)
        {
            InitializeComponent();
            _usuarioActual = usuarioActual;
            CargarCombos();
        }

        private void CargarCombos()
        {
            // Cargar áreas (puedes ponerlas hardcodeadas o desde un servicio)
            cmbArea.Items.AddRange(new string[]
            {
                "Mercadeo", "TI", "Finanzas", "RRHH", "Operaciones",
                "Ventas", "Logística", "Calidad", "Administración"
            });

            cmbRiesgo.SelectedIndex = 0; // Bajo por defecto
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIncidencia.Text))
            {
                MessageBox.Show("Debe ingresar una incidencia.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIncidencia.Focus();
                return;
            }

            if (cmbArea.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un área.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbArea.Focus();
                return;
            }

            var nuevoTicket = new Ticket
            {
                Area = cmbArea.Text,
                UsuarioId = _usuarioActual.UsuarioId,
                Incidencia = txtIncidencia.Text.Trim(),
                Riesgo = cmbRiesgo.Text,
                Descripcion = txtDescripcion.Text.Trim(),
                CreadoPor = _usuarioActual.UsuarioId
            };

            try
            {
                int ticketId = TicketService.InsertarTicket(nuevoTicket);

                MessageBox.Show($"Ticket #{ticketId} creado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear ticket: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdjuntarEvidencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de adjuntar evidencia - Próximamente", "En desarrollo");
            // Aquí iría la lógica para subir fotos
        }
    }
}