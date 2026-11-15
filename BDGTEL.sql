USE [master]
GO
/****** Objeto: Database [GTEL_System] Fecha de script: 15/11/2026 10:57:37 ******/
CREATE DATABASE [GTEL_System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GTEL_System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\GTEL_System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GTEL_System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\GTEL_System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GTEL_System] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GTEL_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GTEL_System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GTEL_System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GTEL_System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GTEL_System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GTEL_System] SET ARITHABORT OFF 
GO
ALTER DATABASE [GTEL_System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GTEL_System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GTEL_System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GTEL_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GTEL_System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GTEL_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GTEL_System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GTEL_System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GTEL_System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GTEL_System] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GTEL_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GTEL_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GTEL_System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GTEL_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GTEL_System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GTEL_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GTEL_System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GTEL_System] SET RECOVERY FULL 
GO
ALTER DATABASE [GTEL_System] SET  MULTI_USER 
GO
ALTER DATABASE [GTEL_System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GTEL_System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GTEL_System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GTEL_System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GTEL_System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GTEL_System] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [GTEL_System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GTEL_System] SET QUERY_STORE = ON
GO
ALTER DATABASE [GTEL_System] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GTEL_System]
GO
/****** Objeto: UserDefinedTableType [dbo].[TipoDetalleFactura] Fecha de script: 15/11/2026 10:57:38 ******/
CREATE TYPE [dbo].[TipoDetalleFactura] AS TABLE(
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (IGNORE_DUP_KEY = OFF),
	CHECK (([Cantidad]>(0)))
)
GO
/****** Objeto: Table [dbo].[Categoria] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Cliente] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[Cedula] [varchar](20) NOT NULL,
	[Telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[DetalleFactura] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](10, 2) NOT NULL,
	[Subtotal] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Factura] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Subtotal] [decimal](12, 2) NOT NULL,
	[IVA] [decimal](12, 2) NOT NULL,
	[Total] [decimal](12, 2) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[MovimientoInventario] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimientoInventario](
	[IdMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[TipoMovimiento] [varchar](10) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ExistenciasAntes] [int] NOT NULL,
	[ExistenciasDespues] [int] NOT NULL,
	[FechaMovimiento] [datetime2](0) NOT NULL,
	[Observacion] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Producto] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](120) NOT NULL,
	[PrecioCompra] [decimal](10, 2) NOT NULL,
	[PrecioVenta] [decimal](10, 2) NOT NULL,
	[Existencias] [int] NOT NULL,
	[StockMinimo] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Rol] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[Usuario] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contrasena] [char](64) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IntentosFallidos] [int] NOT NULL,
	[Bloqueado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (2, N'Cocinas')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (3, N'Lavadoras')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (5, N'Microondas')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (6, N'Otros')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (1, N'Refrigeradoras')
INSERT [dbo].[Categoria] ([IdCategoria], [NombreCategoria]) VALUES (4, N'Televisores')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (1, N'Refrigeradora Mabe 12 pies', CAST(17500.00 AS Decimal(10, 2)), CAST(20500.00 AS Decimal(10, 2)), 8, 2, 1)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (2, N'Refrigeradora LG 14 pies', CAST(24000.00 AS Decimal(10, 2)), CAST(28000.00 AS Decimal(10, 2)), 8, 2, 1)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (3, N'Cocina Mabe 4 quemadores', CAST(8000.00 AS Decimal(10, 2)), CAST(9500.00 AS Decimal(10, 2)), 10, 3, 2)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (4, N'Lavadora Whirlpool 16 kg', CAST(18000.00 AS Decimal(10, 2)), CAST(21000.00 AS Decimal(10, 2)), 10, 3, 3)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (5, N'Televisor Samsung Smart TV 50 pulgadas', CAST(12000.00 AS Decimal(10, 2)), CAST(14500.00 AS Decimal(10, 2)), 10, 2, 4)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (6, N'Microondas Panasonic 30 litros', CAST(4000.00 AS Decimal(10, 2)), CAST(4800.00 AS Decimal(10, 2)), 10, 2, 5)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (7, N'Televisor Samsung Smart TV 50 pulgadas', CAST(12000.00 AS Decimal(10, 2)), CAST(14500.00 AS Decimal(10, 2)), 10, 2, 4)
INSERT [dbo].[Producto] ([IdProducto], [NombreProducto], [PrecioCompra], [PrecioVenta], [Existencias], [StockMinimo], [IdCategoria]) VALUES (8, N'REFRIGERADORA MABE 5.6', CAST(5600.00 AS Decimal(10, 2)), CAST(7000.00 AS Decimal(10, 2)), 16, 2, 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (2, N'Cajero')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [NombreUsuario], [Contrasena], [IdRol], [IntentosFallidos], [Bloqueado]) VALUES (1, N'AdminGTEL', N'79E38C1D7752865736BF7382ACA28534E69D2E7B8E5D98BF5B5851E134E5D28F', 1, 0, 0)
INSERT [dbo].[Usuario] ([IdUsuario], [NombreUsuario], [Contrasena], [IdRol], [IntentosFallidos], [Bloqueado]) VALUES (2, N'Cajero', N'98D0153CE8F7663A3EAC47C9C1E099CE055BA1B41A4B4E370A9C54B9F4CE6591', 2, 0, 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Objeto: Index [UQ__Categori__A21FBE9F18B4DD81] Fecha de script: 15/11/2026 10:57:38 ******/
ALTER TABLE [dbo].[Categoria] ADD UNIQUE NONCLUSTERED 
(
	[NombreCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Objeto: Index [UQ__Cliente__B4ADFE3881E55591] Fecha de script: 15/11/2026 10:57:38 ******/
ALTER TABLE [dbo].[Cliente] ADD UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Objeto: Index [UQ__Rol__4F0B537F161FAEC2] Fecha de script: 15/11/2026 10:57:38 ******/
ALTER TABLE [dbo].[Rol] ADD UNIQUE NONCLUSTERED 
(
	[NombreRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Objeto: Index [UQ__Usuario__6B0F5AE005603640] Fecha de script: 15/11/2026 10:57:38 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT (sysdatetime()) FOR [Fecha]
GO
ALTER TABLE [dbo].[MovimientoInventario] ADD  CONSTRAINT [DF_MovimientoInventario_Fecha]  DEFAULT (sysdatetime()) FOR [FechaMovimiento]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [Existencias]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [StockMinimo]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_IntentosFallidos]  DEFAULT ((0)) FOR [IntentosFallidos]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_Bloqueado]  DEFAULT ((0)) FOR [Bloqueado]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Factura] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Factura] ([IdFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Factura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Usuario]
GO
ALTER TABLE [dbo].[MovimientoInventario]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoInventario_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[MovimientoInventario] CHECK CONSTRAINT [FK_MovimientoInventario_Producto]
GO
ALTER TABLE [dbo].[MovimientoInventario]  WITH CHECK ADD  CONSTRAINT [FK_MovimientoInventario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[MovimientoInventario] CHECK CONSTRAINT [FK_MovimientoInventario_Usuario]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [CK_DetalleFactura_Cantidad] CHECK  (([Cantidad]>(0)))
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [CK_DetalleFactura_Cantidad]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [CK_DetalleFactura_Precios] CHECK  (([PrecioUnitario]>=(0) AND [Subtotal]>=(0)))
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [CK_DetalleFactura_Precios]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [CK_Factura_Montos] CHECK  (([Subtotal]>=(0) AND [IVA]>=(0) AND [Total]>=(0)))
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [CK_Factura_Montos]
GO
ALTER TABLE [dbo].[MovimientoInventario]  WITH CHECK ADD  CONSTRAINT [CK_MovimientoInventario_Cantidad] CHECK  (([Cantidad]>(0)))
GO
ALTER TABLE [dbo].[MovimientoInventario] CHECK CONSTRAINT [CK_MovimientoInventario_Cantidad]
GO
ALTER TABLE [dbo].[MovimientoInventario]  WITH CHECK ADD  CONSTRAINT [CK_MovimientoInventario_Tipo] CHECK  (([TipoMovimiento]='VENTA' OR [TipoMovimiento]='SALIDA' OR [TipoMovimiento]='ENTRADA'))
GO
ALTER TABLE [dbo].[MovimientoInventario] CHECK CONSTRAINT [CK_MovimientoInventario_Tipo]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [CK_Producto_Existencias] CHECK  (([Existencias]>=(0) AND [StockMinimo]>=(0)))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [CK_Producto_Existencias]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [CK_Producto_Precios] CHECK  (([PrecioCompra]>=(0) AND [PrecioVenta]>=(0)))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [CK_Producto_Precios]
GO
/****** Objeto: StoredProcedure [dbo].[sp_ActualizarCliente] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ActualizarCliente]
    @IdCliente INT,
    @Nombres VARCHAR(100),
    @Telefono VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Cliente
        WHERE IdCliente = @IdCliente
    )
    BEGIN
        SELECT 0 AS Codigo, 'El cliente no existe.' AS Mensaje;
        RETURN;
    END;

    IF @Nombres IS NULL OR LTRIM(RTRIM(@Nombres)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'El nombre es obligatorio.' AS Mensaje;
        RETURN;
    END;

    UPDATE dbo.Cliente
    SET
        Nombres = @Nombres,
        Telefono = @Telefono
    WHERE IdCliente = @IdCliente;

    SELECT 1 AS Codigo, 'Cliente actualizado correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ActualizarExistencias] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_ActualizarExistencias]
    @IdProducto INT,
    @IdUsuario INT,
    @TipoMovimiento VARCHAR(10),
    @Cantidad INT,
    @Observacion VARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF @TipoMovimiento NOT IN ('ENTRADA','SALIDA') OR @Cantidad <= 0
    BEGIN
        SELECT 0 AS Codigo, N'Tipo de movimiento o cantidad inválida.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE IdUsuario = @IdUsuario)
    BEGIN
        SELECT 0 AS Codigo, N'El usuario indicado no existe.' AS Mensaje;
        RETURN;
    END;

    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @Antes INT, @Despues INT;
        SELECT @Antes = Existencias FROM dbo.Producto WITH (UPDLOCK, HOLDLOCK) WHERE IdProducto = @IdProducto;
        IF @Antes IS NULL
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 0 AS Codigo, N'El producto indicado no existe.' AS Mensaje;
            RETURN;
        END;

        IF @TipoMovimiento = 'SALIDA' AND @Antes < @Cantidad
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 0 AS Codigo, N'No hay existencias suficientes.' AS Mensaje;
            RETURN;
        END;

        SET @Despues = CASE WHEN @TipoMovimiento = 'ENTRADA' THEN @Antes + @Cantidad ELSE @Antes - @Cantidad END;
        UPDATE dbo.Producto SET Existencias = @Despues WHERE IdProducto = @IdProducto;
        INSERT INTO dbo.MovimientoInventario
            (IdProducto, IdUsuario, TipoMovimiento, Cantidad, ExistenciasAntes, ExistenciasDespues, Observacion)
        VALUES
            (@IdProducto, @IdUsuario, @TipoMovimiento, @Cantidad, @Antes, @Despues, @Observacion);

        COMMIT TRANSACTION;
        SELECT 1 AS Codigo, N'Existencias actualizadas correctamente.' AS Mensaje, @Antes AS ExistenciasAntes, @Despues AS ExistenciasDespues;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SELECT 0 AS Codigo, ERROR_MESSAGE() AS Mensaje;
    END CATCH;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ActualizarProducto] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ActualizarProducto]
    @IdProducto INT,
    @NombreProducto VARCHAR(120),
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @StockMinimo INT,
    @IdCategoria INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Producto
        WHERE IdProducto = @IdProducto
    )
    BEGIN
        SELECT 0 AS Codigo, 'El producto no existe.' AS Mensaje;
        RETURN;
    END;

    IF @NombreProducto IS NULL
       OR LTRIM(RTRIM(@NombreProducto)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'El nombre es obligatorio.' AS Mensaje;
        RETURN;
    END;

    IF @PrecioCompra < 0 OR @PrecioVenta < 0
       OR @StockMinimo < 0
    BEGIN
        SELECT 0 AS Codigo, 'Los valores no pueden ser negativos.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Categoria
        WHERE IdCategoria = @IdCategoria
    )
    BEGIN
        SELECT 0 AS Codigo, 'La categoría no existe.' AS Mensaje;
        RETURN;
    END;

    UPDATE dbo.Producto
    SET
        NombreProducto = @NombreProducto,
        PrecioCompra = @PrecioCompra,
        PrecioVenta = @PrecioVenta,
        StockMinimo = @StockMinimo,
        IdCategoria = @IdCategoria
    WHERE IdProducto = @IdProducto;

    SELECT 1 AS Codigo, 'Producto actualizado correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_BuscarClientePorCedula] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_BuscarClientePorCedula]
    @Cedula VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdCliente,
        Nombres,
        Cedula,
        Telefono
    FROM dbo.Cliente
    WHERE Cedula = @Cedula;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_BuscarProducto] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_BuscarProducto]
    @NombreProducto VARCHAR(120)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.IdProducto,
        P.NombreProducto,
        P.PrecioCompra,
        P.PrecioVenta,
        P.Existencias,
        P.StockMinimo,
        P.IdCategoria,
        C.NombreCategoria
    FROM dbo.Producto P
    INNER JOIN dbo.Categoria C
        ON P.IdCategoria = C.IdCategoria
    WHERE P.NombreProducto LIKE '%' + @NombreProducto + '%'
    ORDER BY P.NombreProducto ASC;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_CambiarContrasena] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CambiarContrasena]
    @IdUsuario INT,
    @ContrasenaActual VARCHAR(100),
    @ContrasenaNueva VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Usuario
        WHERE IdUsuario = @IdUsuario
    )
    BEGIN
        SELECT 0 AS Codigo, 'El usuario no existe.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Usuario
        WHERE IdUsuario = @IdUsuario
        AND Contrasena =
            CONVERT(CHAR(64), HASHBYTES('SHA2_256', @ContrasenaActual), 2)
    )
    BEGIN
        SELECT 0 AS Codigo, 'La contraseña actual es incorrecta.' AS Mensaje;
        RETURN;
    END;

    IF @ContrasenaNueva IS NULL OR LEN(@ContrasenaNueva) < 8
    BEGIN
        SELECT 0 AS Codigo, 'La nueva contraseña debe tener al menos 8 caracteres.' AS Mensaje;
        RETURN;
    END;

    UPDATE dbo.Usuario
    SET Contrasena =
        CONVERT(CHAR(64), HASHBYTES('SHA2_256', @ContrasenaNueva), 2)
    WHERE IdUsuario = @IdUsuario;

    SELECT 1 AS Codigo, 'Contraseña actualizada correctamente.' AS Mensaje;
END;
GO: 




SET ANSI_NULLS ON

GO
/****** Objeto: StoredProcedure [dbo].[sp_CambiarEstadoUsuario] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CambiarEstadoUsuario]
    @IdUsuario INT,
    @Bloqueado BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Usuario
        WHERE IdUsuario = @IdUsuario
    )
    BEGIN
        SELECT 0 AS Codigo, 'El usuario no existe.' AS Mensaje;
        RETURN;
    END;

    UPDATE dbo.Usuario
    SET
        Bloqueado = @Bloqueado,
        IntentosFallidos = 0
    WHERE IdUsuario = @IdUsuario;

    SELECT 1 AS Codigo,
        'Estado del usuario actualizado correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarCategorias] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ListarCategorias]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdCategoria,
        NombreCategoria
    FROM dbo.Categoria
    ORDER BY NombreCategoria ASC;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarClientes] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ListarClientes]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdCliente,
        Nombres,
        Cedula,
        Telefono
    FROM dbo.Cliente
    ORDER BY Nombres ASC;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarFacturas] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE   PROCEDURE [dbo].[sp_ListarFacturas]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        F.IdFactura,
        F.IdCliente,
        C.Nombres AS NombreCliente,
        F.IdUsuario,
        U.NombreUsuario,
        F.Subtotal,
        F.IVA,
        F.Total
    FROM dbo.Factura F
    INNER JOIN dbo.Cliente C ON C.IdCliente = F.IdCliente
    INNER JOIN dbo.Usuario U ON U.IdUsuario = F.IdUsuario
    ORDER BY F.IdFactura DESC;
END;


GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarMovimientosInventario] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarMovimientosInventario]
    @IdProducto INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT M.IdMovimiento, M.IdProducto, P.NombreProducto, M.IdUsuario, U.NombreUsuario,
           M.TipoMovimiento, M.Cantidad, M.ExistenciasAntes, M.ExistenciasDespues,
           M.FechaMovimiento, M.Observacion
    FROM dbo.MovimientoInventario M
    INNER JOIN dbo.Producto P ON P.IdProducto = M.IdProducto
    INNER JOIN dbo.Usuario U ON U.IdUsuario = M.IdUsuario
    WHERE @IdProducto IS NULL OR M.IdProducto = @IdProducto
    ORDER BY M.FechaMovimiento DESC, M.IdMovimiento DESC;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarProductos] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ListarProductos]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.IdProducto,
        P.NombreProducto,
        P.PrecioCompra,
        P.PrecioVenta,
        P.Existencias,
        P.StockMinimo,
        P.IdCategoria,
        C.NombreCategoria
    FROM dbo.Producto P
    INNER JOIN dbo.Categoria C
        ON P.IdCategoria = C.IdCategoria
    ORDER BY P.NombreProducto ASC;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarProductosStockBajo] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ListarProductosStockBajo]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.IdProducto,
        P.NombreProducto,
        C.NombreCategoria,
        P.Existencias,
        P.StockMinimo,
        P.PrecioVenta
    FROM dbo.Producto P
    INNER JOIN dbo.Categoria C
        ON P.IdCategoria = C.IdCategoria
    WHERE P.Existencias <= P.StockMinimo
    ORDER BY P.Existencias ASC;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarRoles] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ListarRoles]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        IdRol,
        NombreRol
    FROM dbo.Rol
    ORDER BY IdRol;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ListarUsuarios] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ListarUsuarios]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        U.IdUsuario,
        U.NombreUsuario,
        R.NombreRol,
        U.IntentosFallidos,
        U.Bloqueado
    FROM dbo.Usuario U
    INNER JOIN dbo.Rol R
        ON U.IdRol = R.IdRol
    ORDER BY U.IdUsuario;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ObtenerFactura] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[sp_ObtenerFactura]
    @IdFactura INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM dbo.Factura WHERE IdFactura = @IdFactura)
    BEGIN
        SELECT 0 AS Codigo, N'La factura indicada no existe.' AS Mensaje;
        RETURN;
    END;

    SELECT
        F.IdFactura,
        F.IdCliente,
        C.Nombres AS NombreCliente,
        C.Cedula,
        C.Telefono,
        F.IdUsuario,
        U.NombreUsuario,
        F.Subtotal,
        F.IVA,
        F.Total
    FROM dbo.Factura F
    INNER JOIN dbo.Cliente C ON C.IdCliente = F.IdCliente
    INNER JOIN dbo.Usuario U ON U.IdUsuario = F.IdUsuario
    WHERE F.IdFactura = @IdFactura;

    SELECT
        DF.IdDetalle,
        DF.IdProducto,
        P.NombreProducto,
        DF.Cantidad,
        DF.PrecioUnitario,
        DF.Subtotal
    FROM dbo.DetalleFactura DF
    INNER JOIN dbo.Producto P ON P.IdProducto = DF.IdProducto
    WHERE DF.IdFactura = @IdFactura
    ORDER BY DF.IdDetalle;
END;


GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarCategoria] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_RegistrarCategoria]
    @NombreCategoria VARCHAR(60)
AS
BEGIN
    SET NOCOUNT ON;

    IF @NombreCategoria IS NULL
       OR LTRIM(RTRIM(@NombreCategoria)) = ''
    BEGIN
        SELECT 0 AS Codigo,
        'El nombre de la categoría es obligatorio.' AS Mensaje;
        RETURN;
    END;

    IF EXISTS (
        SELECT 1
        FROM dbo.Categoria
        WHERE NombreCategoria = @NombreCategoria
    )
    BEGIN
        SELECT 0 AS Codigo,
        'La categoría ya existe.' AS Mensaje;
        RETURN;
    END;

    INSERT INTO dbo.Categoria (NombreCategoria)
    VALUES (@NombreCategoria);

    SELECT 1 AS Codigo,
    'Categoría registrada correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarCliente] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_RegistrarCliente]
    @Nombres VARCHAR(100),
    @Cedula VARCHAR(20),
    @Telefono VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Nombres IS NULL OR LTRIM(RTRIM(@Nombres)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'El nombre es obligatorio.' AS Mensaje;
        RETURN;
    END;

    IF @Cedula IS NULL OR LTRIM(RTRIM(@Cedula)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'La cédula es obligatoria.' AS Mensaje;
        RETURN;
    END;

    IF EXISTS (
        SELECT 1
        FROM dbo.Cliente
        WHERE Cedula = @Cedula
    )
    BEGIN
        SELECT 0 AS Codigo, 'La cédula ya está registrada.' AS Mensaje;
        RETURN;
    END;

    INSERT INTO dbo.Cliente (
        Nombres,
        Cedula,
        Telefono
    )
    VALUES (
        @Nombres,
        @Cedula,
        @Telefono
    );

    SELECT 1 AS Codigo, 'Cliente registrado correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarFactura] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_RegistrarFactura]
    @IdCliente INT,
    @IdUsuario INT,
    @Detalles dbo.TipoDetalleFactura READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE
        @Subtotal DECIMAL(18,2),
        @IVA DECIMAL(18,2),
        @Total DECIMAL(18,2),
        @IdFactura INT;

    IF NOT EXISTS (SELECT 1 FROM @Detalles)
    BEGIN
        SELECT 0 AS Codigo, N'La factura debe contener al menos un producto.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM dbo.Cliente WHERE IdCliente = @IdCliente)
    BEGIN
        SELECT 0 AS Codigo, N'El cliente indicado no existe.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE IdUsuario = @IdUsuario)
    BEGIN
        SELECT 0 AS Codigo, N'El usuario indicado no existe.' AS Mensaje;
        RETURN;
    END;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS
        (
            SELECT 1
            FROM @Detalles D
            LEFT JOIN dbo.Producto P WITH (UPDLOCK, HOLDLOCK)
                ON P.IdProducto = D.IdProducto
            WHERE P.IdProducto IS NULL
        )
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 0 AS Codigo, N'Uno o más productos no existen.' AS Mensaje;
            RETURN;
        END;

        IF EXISTS
        (
            SELECT 1
            FROM @Detalles D
            INNER JOIN dbo.Producto P WITH (UPDLOCK, HOLDLOCK)
                ON P.IdProducto = D.IdProducto
            WHERE D.Cantidad <= 0 OR P.Existencias < D.Cantidad
        )
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 0 AS Codigo, N'Cantidad inválida o existencias insuficientes.' AS Mensaje;
            RETURN;
        END;

        SELECT @Subtotal =
            SUM(CONVERT(DECIMAL(18,2), D.Cantidad) * P.PrecioVenta)
        FROM @Detalles D
        INNER JOIN dbo.Producto P WITH (UPDLOCK, HOLDLOCK)
            ON P.IdProducto = D.IdProducto;

        SET @IVA = ROUND(@Subtotal * 0.15, 2);
        SET @Total = @Subtotal + @IVA;

        INSERT INTO dbo.Factura
            (IdCliente, IdUsuario, Subtotal, IVA, Total)
        VALUES
            (@IdCliente, @IdUsuario, @Subtotal, @IVA, @Total);

        SET @IdFactura = CONVERT(INT, SCOPE_IDENTITY());

        INSERT INTO dbo.DetalleFactura
            (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal)
        SELECT
            @IdFactura,
            D.IdProducto,
            D.Cantidad,
            P.PrecioVenta,
            CONVERT(DECIMAL(18,2), D.Cantidad) * P.PrecioVenta
        FROM @Detalles D
        INNER JOIN dbo.Producto P
            ON P.IdProducto = D.IdProducto;

        UPDATE P
        SET P.Existencias = P.Existencias - D.Cantidad
        FROM dbo.Producto P
        INNER JOIN @Detalles D
            ON D.IdProducto = P.IdProducto;

        INSERT INTO dbo.MovimientoInventario
            (IdProducto, IdUsuario, TipoMovimiento, Cantidad, ExistenciasAntes, ExistenciasDespues, Observacion)
        SELECT D.IdProducto, @IdUsuario, 'VENTA', D.Cantidad,
               P.Existencias + D.Cantidad, P.Existencias,
               CONCAT('Venta asociada a factura #', @IdFactura)
        FROM @Detalles D
        INNER JOIN dbo.Producto P ON P.IdProducto = D.IdProducto;

        COMMIT TRANSACTION;

        SELECT 1 AS Codigo,
               N'Factura registrada correctamente.' AS Mensaje,
               @IdFactura AS IdFactura,
               @Subtotal AS Subtotal,
               @IVA AS IVA,
               @Total AS Total;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0
            ROLLBACK TRANSACTION;

        SELECT 0 AS Codigo, ERROR_MESSAGE() AS Mensaje;
    END CATCH;
END;


GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarMovimientoInventario] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_RegistrarMovimientoInventario]
    @IdProducto INT,
    @IdUsuario INT,
    @TipoMovimiento VARCHAR(10),
    @Cantidad INT,
    @Observacion VARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF @TipoMovimiento NOT IN ('Entrada', 'Salida')
    BEGIN
        SELECT 0 AS Codigo, 'El tipo debe ser Entrada o Salida.' AS Mensaje;
        RETURN;
    END;

    IF @Cantidad IS NULL OR @Cantidad <= 0
    BEGIN
        SELECT 0 AS Codigo, 'La cantidad debe ser mayor que cero.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (SELECT 1 FROM dbo.Usuario WHERE IdUsuario = @IdUsuario)
    BEGIN
        SELECT 0 AS Codigo, 'El usuario no existe.' AS Mensaje;
        RETURN;
    END;

    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @ExistenciasActuales INT;

        SELECT @ExistenciasActuales = Existencias
        FROM dbo.Producto WITH (UPDLOCK, HOLDLOCK)
        WHERE IdProducto = @IdProducto;

        IF @ExistenciasActuales IS NULL
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 0 AS Codigo, 'El producto no existe.' AS Mensaje;
            RETURN;
        END;

        IF @TipoMovimiento = 'Salida' AND @ExistenciasActuales < @Cantidad
        BEGIN
            ROLLBACK TRANSACTION;
            SELECT 0 AS Codigo, 'No hay existencias suficientes para registrar la salida.' AS Mensaje;
            RETURN;
        END;

        UPDATE dbo.Producto
        SET Existencias = CASE
            WHEN @TipoMovimiento = 'Entrada' THEN Existencias + @Cantidad
            ELSE Existencias - @Cantidad
        END
        WHERE IdProducto = @IdProducto;

        INSERT INTO dbo.MovimientoInventario
            (IdProducto, IdUsuario, TipoMovimiento, Cantidad, Observacion)
        VALUES
            (@IdProducto, @IdUsuario, @TipoMovimiento, @Cantidad, @Observacion);

        COMMIT TRANSACTION;

        SELECT 1 AS Codigo,
               'Movimiento registrado correctamente.' AS Mensaje,
               (SELECT Existencias FROM dbo.Producto WHERE IdProducto = @IdProducto) AS ExistenciasActuales;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SELECT 0 AS Codigo, ERROR_MESSAGE() AS Mensaje;
    END CATCH;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarProducto] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_RegistrarProducto]
    @NombreProducto VARCHAR(120),
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @Existencias INT,
    @StockMinimo INT,
    @IdCategoria INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @NombreProducto IS NULL
       OR LTRIM(RTRIM(@NombreProducto)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'El nombre del producto es obligatorio.' AS Mensaje;
        RETURN;
    END;

    IF @PrecioCompra < 0 OR @PrecioVenta < 0
    BEGIN
        SELECT 0 AS Codigo, 'Los precios no pueden ser negativos.' AS Mensaje;
        RETURN;
    END;

    IF @Existencias < 0 OR @StockMinimo < 0
    BEGIN
        SELECT 0 AS Codigo, 'Las existencias y el stock mínimo no pueden ser negativos.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Categoria
        WHERE IdCategoria = @IdCategoria
    )
    BEGIN
        SELECT 0 AS Codigo, 'La categoría seleccionada no existe.' AS Mensaje;
        RETURN;
    END;

    INSERT INTO dbo.Producto (
        NombreProducto,
        PrecioCompra,
        PrecioVenta,
        Existencias,
        StockMinimo,
        IdCategoria
    )
    VALUES (
        @NombreProducto,
        @PrecioCompra,
        @PrecioVenta,
        @Existencias,
        @StockMinimo,
        @IdCategoria
    );

    SELECT 1 AS Codigo, 'Producto registrado correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarUsuario] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_RegistrarUsuario]
    @NombreUsuario VARCHAR(50),
    @Contrasena VARCHAR(100),
    @IdRol INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @NombreUsuario IS NULL OR LTRIM(RTRIM(@NombreUsuario)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'El nombre de usuario es obligatorio.' AS Mensaje;
        RETURN;
    END;

    IF @Contrasena IS NULL OR LTRIM(RTRIM(@Contrasena)) = ''
    BEGIN
        SELECT 0 AS Codigo, 'La contraseña es obligatoria.' AS Mensaje;
        RETURN;
    END;

    IF LEN(@Contrasena) < 8
    BEGIN
        SELECT 0 AS Codigo, 'La contraseña debe tener al menos 8 caracteres.' AS Mensaje;
        RETURN;
    END;

    IF EXISTS (
        SELECT 1
        FROM dbo.Usuario
        WHERE NombreUsuario = @NombreUsuario
    )
    BEGIN
        SELECT 0 AS Codigo, 'El nombre de usuario ya existe.' AS Mensaje;
        RETURN;
    END;

    IF NOT EXISTS (
        SELECT 1
        FROM dbo.Rol
        WHERE IdRol = @IdRol
    )
    BEGIN
        SELECT 0 AS Codigo, 'El rol seleccionado no existe.' AS Mensaje;
        RETURN;
    END;

    INSERT INTO dbo.Usuario (
        NombreUsuario,
        Contrasena,
        IdRol,
        IntentosFallidos,
        Bloqueado
    )
    VALUES (
        @NombreUsuario,
        CONVERT(CHAR(64), HASHBYTES('SHA2_256', @Contrasena), 2),
        @IdRol,
        0,
        0
    );

    SELECT
        1 AS Codigo,
        'Usuario registrado correctamente.' AS Mensaje;
END;

GO
/****** Objeto: StoredProcedure [dbo].[sp_ValidarAcceso] Fecha de script: 15/11/2026 10:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[sp_ValidarAcceso]
    @NombreUsuario VARCHAR(50),
    @Contrasena VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE
        @IdUsuario INT = NULL,
        @IdRol INT = NULL,
        @NombreRol VARCHAR(30) = NULL,
        @HashGuardado CHAR(64) = NULL,
        @IntentosFallidos INT = 0,
        @Bloqueado BIT = 0,
        @HashIngresado CHAR(64);

    -- Todas las rutas devuelven las mismas columnas:
    -- Codigo, Mensaje, IdUsuario, NombreUsuario, IdRol, NombreRol,
    -- IntentosFallidos y Bloqueado.

    IF NULLIF(LTRIM(RTRIM(@NombreUsuario)), '') IS NULL
       OR @Contrasena IS NULL
    BEGIN
        SELECT
            CAST(0 AS INT) AS Codigo,
            CAST('Debe ingresar usuario y contrasena.' AS VARCHAR(150)) AS Mensaje,
            CAST(NULL AS INT) AS IdUsuario,
            CAST(NULL AS VARCHAR(50)) AS NombreUsuario,
            CAST(NULL AS INT) AS IdRol,
            CAST(NULL AS VARCHAR(30)) AS NombreRol,
            CAST(0 AS INT) AS IntentosFallidos,
            CAST(0 AS BIT) AS Bloqueado;
        RETURN;
    END;

    SET @HashIngresado =
        CONVERT(CHAR(64), HASHBYTES('SHA2_256', @Contrasena), 2);

    BEGIN TRY
        BEGIN TRANSACTION;

        SELECT
            @IdUsuario = U.IdUsuario,
            @IdRol = U.IdRol,
            @NombreRol = R.NombreRol,
            @HashGuardado = U.Contrasena,
            @IntentosFallidos = U.IntentosFallidos,
            @Bloqueado = U.Bloqueado
        FROM dbo.Usuario AS U WITH (UPDLOCK, HOLDLOCK)
        INNER JOIN dbo.Rol AS R
            ON R.IdRol = U.IdRol
        WHERE U.NombreUsuario = @NombreUsuario;

        IF @IdUsuario IS NULL
        BEGIN
            COMMIT TRANSACTION;

            SELECT
                CAST(0 AS INT) AS Codigo,
                CAST('Usuario no encontrado.' AS VARCHAR(150)) AS Mensaje,
                CAST(NULL AS INT) AS IdUsuario,
                CAST(NULL AS VARCHAR(50)) AS NombreUsuario,
                CAST(NULL AS INT) AS IdRol,
                CAST(NULL AS VARCHAR(30)) AS NombreRol,
                CAST(0 AS INT) AS IntentosFallidos,
                CAST(0 AS BIT) AS Bloqueado;
            RETURN;
        END;

        IF @Bloqueado = 1
        BEGIN
            COMMIT TRANSACTION;

            SELECT
                CAST(2 AS INT) AS Codigo,
                CAST('Usuario bloqueado. Contacte al administrador.' AS VARCHAR(150)) AS Mensaje,
                @IdUsuario AS IdUsuario,
                @NombreUsuario AS NombreUsuario,
                @IdRol AS IdRol,
                @NombreRol AS NombreRol,
                @IntentosFallidos AS IntentosFallidos,
                @Bloqueado AS Bloqueado;
            RETURN;
        END;

        IF @HashGuardado <> @HashIngresado
        BEGIN
            UPDATE dbo.Usuario
            SET
                IntentosFallidos = IntentosFallidos + 1,
                Bloqueado = CASE
                    WHEN IntentosFallidos + 1 >= 3 THEN 1
                    ELSE 0
                END
            WHERE IdUsuario = @IdUsuario;

            SELECT
                @IntentosFallidos = IntentosFallidos,
                @Bloqueado = Bloqueado
            FROM dbo.Usuario
            WHERE IdUsuario = @IdUsuario;

            COMMIT TRANSACTION;

            SELECT
                CASE WHEN @Bloqueado = 1 THEN 2 ELSE 0 END AS Codigo,
                CAST(
                    CASE
                        WHEN @Bloqueado = 1 THEN 'Cuenta bloqueada tras tres intentos fallidos.'
                        ELSE 'Contrasena incorrecta. Intentos restantes: '
                             + CONVERT(VARCHAR(2), 3 - @IntentosFallidos) + '.'
                    END
                    AS VARCHAR(150)
                ) AS Mensaje,
                @IdUsuario AS IdUsuario,
                @NombreUsuario AS NombreUsuario,
                @IdRol AS IdRol,
                @NombreRol AS NombreRol,
                @IntentosFallidos AS IntentosFallidos,
                @Bloqueado AS Bloqueado;
            RETURN;
        END;

        UPDATE dbo.Usuario
        SET IntentosFallidos = 0
        WHERE IdUsuario = @IdUsuario;

        COMMIT TRANSACTION;

        SELECT
            CAST(1 AS INT) AS Codigo,
            CAST('Acceso correcto.' AS VARCHAR(150)) AS Mensaje,
            @IdUsuario AS IdUsuario,
            @NombreUsuario AS NombreUsuario,
            @IdRol AS IdRol,
            @NombreRol AS NombreRol,
            CAST(0 AS INT) AS IntentosFallidos,
            CAST(0 AS BIT) AS Bloqueado;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0
            ROLLBACK TRANSACTION;

        SELECT
            CAST(0 AS INT) AS Codigo,
            CAST('No fue posible validar el acceso.' AS VARCHAR(150)) AS Mensaje,
            CAST(NULL AS INT) AS IdUsuario,
            CAST(NULL AS VARCHAR(50)) AS NombreUsuario,
            CAST(NULL AS INT) AS IdRol,
            CAST(NULL AS VARCHAR(30)) AS NombreRol,
            CAST(0 AS INT) AS IntentosFallidos,
            CAST(0 AS BIT) AS Bloqueado;
    END CATCH;
END;

GO
USE [master]
GO
ALTER DATABASE [GTEL_System] SET  READ_WRITE 
GO

