using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODIN.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;  // Campo "Usuario" de la BD
        public string Rol { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;

        // Propiedad de conveniencia
        public string NombreCompleto => Nombre;
    }
}
