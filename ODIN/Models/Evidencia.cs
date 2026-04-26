using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ODIN.Models
{
    public class Evidencia
    {
        public int EvidenciaId { get; set; }
        public int TicketId { get; set; }
        public string NombreArchivo { get; set; } = string.Empty;
        public string RutaArchivo { get; set; } = string.Empty;     // Ruta relativa o absoluta
        public string TipoArchivo { get; set; } = string.Empty;     // png, jpg, pdf...
        public DateTime FechaSubida { get; set; } = DateTime.Now;
        public int SubidoPor { get; set; }
        public string SubidoPorNombre { get; set; } = string.Empty;

        // Propiedad de conveniencia
        public string RutaCompleta => RutaArchivo;
    }
}
