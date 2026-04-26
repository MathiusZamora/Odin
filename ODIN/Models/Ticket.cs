using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ODIN.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Area { get; set; } = string.Empty;
        public int UsuarioId { get; set; }
        public string UsuarioNombre { get; set; } = string.Empty;   // Para mostrar
        public string Incidencia { get; set; } = string.Empty;
        public string Riesgo { get; set; } = "Bajo";                // Bajo, Medio, Alto, Crítico
        public string Descripcion { get; set; } = string.Empty;
        public string Estado { get; set; } = "Abierto";             // Abierto, En Proceso, Resuelto, Cerrado
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public string Resolucion { get; set; } = string.Empty;
        public int CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public int? ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Activo { get; set; } = true;

        // Propiedades calculadas útiles
        public string FechaCorta => Fecha.ToString("dd/MM/yyyy");
        public string HoraInicio => FechaInicio?.ToString("HH:mm") ?? "";
        public string HoraResolucion => FechaResolucion?.ToString("HH:mm") ?? "";
    }
}