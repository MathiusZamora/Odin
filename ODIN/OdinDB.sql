-- BASE DE DATOS: ODIN
-- Sistema de Gestión de Tickets / Incidencias


IF DB_ID('ODIN') IS NULL
    CREATE DATABASE ODIN;
GO

USE ODIN;
GO

-- Tabla de Usuarios (similar a StockLite)
CREATE TABLE dbo.Usuario (
    UsuarioId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Usuario VARCHAR(50) NOT NULL UNIQUE,
    ClaveHash VARCHAR(200) NOT NULL,
    Rol VARCHAR(30) NOT NULL,           -- Administrador, Soporte, Usuario, Supervisor
    Activo BIT NOT NULL DEFAULT 1,
    FechaCreacion DATETIME2 DEFAULT SYSUTCDATETIME()
);
GO

-- Tabla principal de Tickets/Incidencias
CREATE TABLE dbo.Ticket (
    TicketId INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Area VARCHAR(100) NOT NULL,                    -- Ej: Mercadeo, TI, Finanzas, RRHH, etc.
    UsuarioId INT NOT NULL FOREIGN KEY REFERENCES Usuario(UsuarioId),
    Incidencia VARCHAR(500) NOT NULL,
    Riesgo VARCHAR(20) NOT NULL,                   -- Bajo, Medio, Alto, Crítico
    Descripcion NVARCHAR(MAX) NULL,
    Estado VARCHAR(30) NOT NULL DEFAULT 'Abierto', -- Abierto, En Proceso, Resuelto, Cerrado
    FechaInicio DATETIME2 NULL,
    FechaResolucion DATETIME2 NULL,
    Resolucion NVARCHAR(MAX) NULL,
    CreadoPor INT NOT NULL,
    FechaCreacion DATETIME2 DEFAULT SYSUTCDATETIME(),
    ModificadoPor INT NULL,
    FechaModificacion DATETIME2 NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Tabla para Evidencias (Fotos / Archivos adjuntos)
CREATE TABLE dbo.Evidencia (
    EvidenciaId INT IDENTITY(1,1) PRIMARY KEY,
    TicketId INT NOT NULL FOREIGN KEY REFERENCES Ticket(TicketId),
    NombreArchivo VARCHAR(255) NOT NULL,
    RutaArchivo VARCHAR(500) NOT NULL,           -- Ruta física o relativa en el servidor
    TipoArchivo VARCHAR(50) NULL,                -- png, jpg, pdf, etc.
    FechaSubida DATETIME2 DEFAULT SYSUTCDATETIME(),
    SubidoPor INT NOT NULL
);
GO

-- Índices recomendados
CREATE INDEX IX_Ticket_Fecha ON dbo.Ticket(Fecha);
CREATE INDEX IX_Ticket_Estado ON dbo.Ticket(Estado);
CREATE INDEX IX_Ticket_Area ON dbo.Ticket(Area);
CREATE INDEX IX_Evidencia_Ticket ON dbo.Evidencia(TicketId);
GO