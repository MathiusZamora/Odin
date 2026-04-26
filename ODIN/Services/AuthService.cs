using BCrypt.Net;
using Microsoft.Data.SqlClient;
using ODIN.Models;
using System.Data;

namespace ODIN.Services
{
    public static class AuthService
    {
        public static Usuario? Login(string usuario, string clave)
        {
            const string sql = """
                SELECT UsuarioId, Nombre, Usuario, Rol, Activo, ClaveHash 
                FROM dbo.Usuario 
                WHERE Usuario = @usuario AND Activo = 1
                """;

            var dt = Db.Query(sql, new SqlParameter("@usuario", usuario));

            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            string hash = row["ClaveHash"].ToString()!;

            if (!BCrypt.Net.BCrypt.Verify(clave, hash))
                return null;

            return new Usuario
            {
                UsuarioId = Convert.ToInt32(row["UsuarioId"]),
                Nombre = row["Nombre"].ToString()!,
                NombreUsuario = row["Usuario"].ToString()!,
                Rol = row["Rol"].ToString()!,
                Activo = true
            };
        }

        // Crea el usuario admin por defecto la primera vez
        public static void CrearAdminSiNoExiste()
        {
            const string sqlCheck = "SELECT COUNT(*) FROM dbo.Usuario WHERE Usuario = 'admin'";
            var existe = (int?)Db.Scalar(sqlCheck) ?? 0;

            if (existe > 0) return;

            string hash = BCrypt.Net.BCrypt.HashPassword("admin123");

            const string sqlInsert = """
                INSERT INTO dbo.Usuario (Nombre, Usuario, ClaveHash, Rol, Activo)
                VALUES ('Administrador del Sistema', 'admin', @hash, 'Administrador', 1)
                """;

            Db.Exec(sqlInsert, new SqlParameter("@hash", hash));
        }
    }
}
