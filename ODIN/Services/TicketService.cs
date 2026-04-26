// Services/TicketService.cs
using Microsoft.Data.SqlClient;
using ODIN.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace ODIN.Services
{
    public static class TicketService
    {
        #region === CRUD DE TICKETS ===

        /// <summary>
        /// Crea un nuevo ticket y devuelve su ID
        /// </summary>
        public static int InsertarTicket(Ticket ticket)
        {
            const string sql = """
                INSERT INTO dbo.Ticket 
                (Area, UsuarioId, Incidencia, Riesgo, Descripcion, Estado, CreadoPor, FechaCreacion, Activo)
                VALUES 
                (@area, @usuarioId, @incidencia, @riesgo, @descripcion, 'Abierto', @creadoPor, SYSDATETIME(), 1);

                SELECT SCOPE_IDENTITY();
                """;

            var resultado = Db.Scalar(sql,
                new SqlParameter("@area", ticket.Area),
                new SqlParameter("@usuarioId", ticket.UsuarioId),
                new SqlParameter("@incidencia", ticket.Incidencia),
                new SqlParameter("@riesgo", ticket.Riesgo),
                new SqlParameter("@descripcion", ticket.Descripcion ?? (object)DBNull.Value),
                new SqlParameter("@creadoPor", ticket.CreadoPor)
            );

            return Convert.ToInt32(resultado);
        }

        /// <summary>
        /// Actualiza un ticket existente
        /// </summary>
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
                WHERE TicketId = @ticketId AND Activo = 1
                """;

            int filas = Db.Exec(sql,
                new SqlParameter("@ticketId", ticket.TicketId),
                new SqlParameter("@area", ticket.Area),
                new SqlParameter("@incidencia", ticket.Incidencia),
                new SqlParameter("@riesgo", ticket.Riesgo),
                new SqlParameter("@descripcion", ticket.Descripcion ?? (object)DBNull.Value),
                new SqlParameter("@estado", ticket.Estado),
                new SqlParameter("@fechaInicio", ticket.FechaInicio.HasValue ? ticket.FechaInicio.Value : (object)DBNull.Value),
                new SqlParameter("@fechaResolucion", ticket.FechaResolucion.HasValue ? ticket.FechaResolucion.Value : (object)DBNull.Value),
                new SqlParameter("@resolucion", ticket.Resolucion ?? (object)DBNull.Value),
                new SqlParameter("@modificadoPor", ticket.ModificadoPor.HasValue ? ticket.ModificadoPor.Value : (object)DBNull.Value)
            );

            return filas > 0;
        }

        /// <summary>
        /// Elimina lógicamente un ticket (cambia Activo = 0)
        /// </summary>
        public static bool EliminarTicket(int ticketId)
        {
            const string sql = "UPDATE dbo.Ticket SET Activo = 0 WHERE TicketId = @ticketId";
            int filas = Db.Exec(sql, new SqlParameter("@ticketId", ticketId));
            return filas > 0;
        }

        #endregion

        #region === CONSULTAS ===

        /// <summary>
        /// Obtiene todos los tickets activos
        /// </summary>
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
                    UsuarioNombre = row["UsuarioNombre"].ToString() ?? "Desconocido",
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

        /// <summary>
        /// Obtiene un ticket por su ID
        /// </summary>
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

        /// <summary>
        /// Obtiene los tickets de un usuario específico (Mis Tickets)
        /// </summary>
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
            var lista = new List<Ticket>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Ticket
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
                });
            }

            return lista;
        }

        #endregion

        #region === EVIDENCIAS ===

        public static int InsertarEvidencia(Evidencia evidencia)
        {
            const string sql = """
                INSERT INTO dbo.Evidencia (TicketId, NombreArchivo, RutaArchivo, TipoArchivo, SubidoPor, FechaSubida)
                VALUES (@ticketId, @nombreArchivo, @rutaArchivo, @tipoArchivo, @subidoPor, SYSDATETIME());

                SELECT SCOPE_IDENTITY();
                """;

            var id = Db.Scalar(sql,
                new SqlParameter("@ticketId", evidencia.TicketId),
                new SqlParameter("@nombreArchivo", evidencia.NombreArchivo),
                new SqlParameter("@rutaArchivo", evidencia.RutaArchivo),
                new SqlParameter("@tipoArchivo", evidencia.TipoArchivo ?? "png"),
                new SqlParameter("@subidoPor", evidencia.SubidoPor)
            );

            return Convert.ToInt32(id);
        }

        #endregion
    }
}