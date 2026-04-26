using Microsoft.Data.SqlClient;
using ODIN.Models;
using System.Data;

namespace ODIN.Services
{
    public static class TicketService
    {
        #region CRUD Básico de Tickets

        public static int InsertarTicket(Ticket ticket)
        {
            const string sql = """
                INSERT INTO dbo.Ticket 
                (Fecha, Area, UsuarioId, Incidencia, Riesgo, Descripcion, Estado, 
                 CreadoPor, FechaCreacion, Activo)
                VALUES 
                (SYSDATETIME(), @area, @usuarioId, @incidencia, @riesgo, @descripcion, 
                 'Abierto', @creadoPor, SYSDATETIME(), 1);

                SELECT SCOPE_IDENTITY();
                """;

            var id = Db.Scalar(sql,
                new SqlParameter("@area", ticket.Area),
                new SqlParameter("@usuarioId", ticket.UsuarioId),
                new SqlParameter("@incidencia", ticket.Incidencia),
                new SqlParameter("@riesgo", ticket.Riesgo),
                new SqlParameter("@descripcion", ticket.Descripcion ?? ""),
                new SqlParameter("@creadoPor", ticket.CreadoPor)
            );

            return Convert.ToInt32(id);
        }

        public static bool ActualizarTicket(Ticket ticket)
        {
            const string sql = """
                UPDATE dbo.Ticket 
                SET Area = @area,
                    Incidencia = @incidencia,
                    Riesgo = @riesgo,
                    Descripcion = @descripcion,
                    Estado = @estado,
                    FechaInicio = @fechaInicio,
                    FechaResolucion = @fechaResolucion,
                    Resolucion = @resolucion,
                    ModificadoPor = @modificadoPor,
                    FechaModificacion = SYSDATETIME()
                WHERE TicketId = @ticketId
                """;

            int filas = Db.Exec(sql,
                new SqlParameter("@ticketId", ticket.TicketId),
                new SqlParameter("@area", ticket.Area),
                new SqlParameter("@incidencia", ticket.Incidencia),
                new SqlParameter("@riesgo", ticket.Riesgo),
                new SqlParameter("@descripcion", ticket.Descripcion ?? ""),
                new SqlParameter("@estado", ticket.Estado),
                new SqlParameter("@fechaInicio", ticket.FechaInicio ?? (object)DBNull.Value),
                new SqlParameter("@fechaResolucion", ticket.FechaResolucion ?? (object)DBNull.Value),
                new SqlParameter("@resolucion", ticket.Resolucion ?? ""),
                new SqlParameter("@modificadoPor", ticket.ModificadoPor ?? (object)DBNull.Value)
            );

            return filas > 0;
        }

        public static bool EliminarTicket(int ticketId)
        {
            const string sql = "UPDATE dbo.Ticket SET Activo = 0 WHERE TicketId = @ticketId";
            int filas = Db.Exec(sql, new SqlParameter("@ticketId", ticketId));
            return filas > 0;
        }

        #endregion

        #region Consultas

        public static List<Ticket> GetAll()
        {
            const string sql = """
                SELECT t.TicketId, t.Fecha, t.Area, t.UsuarioId, u.Nombre AS UsuarioNombre,
                       t.Incidencia, t.Riesgo, t.Descripcion, t.Estado, 
                       t.FechaInicio, t.FechaResolucion, t.Resolucion,
                       t.CreadoPor, t.FechaCreacion
                FROM dbo.Ticket t
                LEFT JOIN dbo.Usuario u ON t.UsuarioId = u.UsuarioId
                WHERE t.Activo = 1
                ORDER BY t.Fecha DESC
                """;

            var dt = Db.Query(sql);
            var lista = new List<Ticket>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Ticket
                {
                    TicketId = Convert.ToInt32(row["TicketId"]),
                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    Area = row["Area"].ToString()!,
                    UsuarioId = Convert.ToInt32(row["UsuarioId"]),
                    UsuarioNombre = row["UsuarioNombre"].ToString()!,
                    Incidencia = row["Incidencia"].ToString()!,
                    Riesgo = row["Riesgo"].ToString()!,
                    Descripcion = row["Descripcion"].ToString() ?? "",
                    Estado = row["Estado"].ToString()!,
                    FechaInicio = row["FechaInicio"] == DBNull.Value ? null : Convert.ToDateTime(row["FechaInicio"]),
                    FechaResolucion = row["FechaResolucion"] == DBNull.Value ? null : Convert.ToDateTime(row["FechaResolucion"]),
                    Resolucion = row["Resolucion"].ToString() ?? "",
                    CreadoPor = Convert.ToInt32(row["CreadoPor"]),
                    FechaCreacion = Convert.ToDateTime(row["FechaCreacion"])
                });
            }

            return lista;
        }

        public static Ticket? GetById(int ticketId)
        {
            const string sql = """
                SELECT t.*, u.Nombre AS UsuarioNombre 
                FROM dbo.Ticket t
                LEFT JOIN dbo.Usuario u ON t.UsuarioId = u.UsuarioId
                WHERE t.TicketId = @ticketId AND t.Activo = 1
                """;

            var dt = Db.Query(sql, new SqlParameter("@ticketId", ticketId));

            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];

            return new Ticket
            {
                TicketId = Convert.ToInt32(row["TicketId"]),
                Fecha = Convert.ToDateTime(row["Fecha"]),
                Area = row["Area"].ToString()!,
                UsuarioId = Convert.ToInt32(row["UsuarioId"]),
                UsuarioNombre = row["UsuarioNombre"].ToString() ?? "",
                Incidencia = row["Incidencia"].ToString()!,
                Riesgo = row["Riesgo"].ToString()!,
                Descripcion = row["Descripcion"].ToString() ?? "",
                Estado = row["Estado"].ToString()!,
                FechaInicio = row["FechaInicio"] == DBNull.Value ? null : Convert.ToDateTime(row["FechaInicio"]),
                FechaResolucion = row["FechaResolucion"] == DBNull.Value ? null : Convert.ToDateTime(row["FechaResolucion"]),
                Resolucion = row["Resolucion"].ToString() ?? "",
                CreadoPor = Convert.ToInt32(row["CreadoPor"])
            };
        }

        // Tickets por usuario (Mis Tickets)
        public static List<Ticket> GetByUsuario(int usuarioId)
        {
            const string sql = """
                SELECT t.*, u.Nombre AS UsuarioNombre 
                FROM dbo.Ticket t
                LEFT JOIN dbo.Usuario u ON t.UsuarioId = u.UsuarioId
                WHERE t.UsuarioId = @usuarioId AND t.Activo = 1
                ORDER BY t.Fecha DESC
                """;

            var dt = Db.Query(sql, new SqlParameter("@usuarioId", usuarioId));
            // ... mismo mapeo que en GetAll() ...
            // (puedes reutilizar código o duplicar por simplicidad)
            return new List<Ticket>(); // ← Completa con el mapeo similar a GetAll()
        }

        #endregion

        #region Evidencias

        public static int InsertarEvidencia(Evidencia evidencia)
        {
            const string sql = """
                INSERT INTO dbo.Evidencia 
                (TicketId, NombreArchivo, RutaArchivo, TipoArchivo, SubidoPor)
                VALUES (@ticketId, @nombreArchivo, @rutaArchivo, @tipoArchivo, @subidoPor);

                SELECT SCOPE_IDENTITY();
                """;

            var id = Db.Scalar(sql,
                new SqlParameter("@ticketId", evidencia.TicketId),
                new SqlParameter("@nombreArchivo", evidencia.NombreArchivo),
                new SqlParameter("@rutaArchivo", evidencia.RutaArchivo),
                new SqlParameter("@tipoArchivo", evidencia.TipoArchivo),
                new SqlParameter("@subidoPor", evidencia.SubidoPor)
            );

            return Convert.ToInt32(id);
        }

        #endregion
    }
} 