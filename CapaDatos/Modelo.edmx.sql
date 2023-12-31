
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2023 15:39:22
-- Generated from EDMX file: C:\Users\USER\source\repos\SellPoint\CapaDatos\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_BOUTIQUE];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CONTROL_PERMISOCONTROL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL_PERMISO] DROP CONSTRAINT [FK_CONTROL_PERMISOCONTROL];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROLMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL] DROP CONSTRAINT [FK_CONTROLMODULO];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROLUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL] DROP CONSTRAINT [FK_CONTROLUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROL_PERMISOUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL_PERMISO] DROP CONSTRAINT [FK_CONTROL_PERMISOUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROL_PERMISOUSUARIOAUTORIZA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL_PERMISO] DROP CONSTRAINT [FK_CONTROL_PERMISOUSUARIOAUTORIZA];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOEMPLEADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIOEMPLEADO];
GO
IF OBJECT_ID(N'[dbo].[FK_MODULO_PERMISOMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO_PERMISO] DROP CONSTRAINT [FK_MODULO_PERMISOMODULO];
GO
IF OBJECT_ID(N'[dbo].[FK_MODULOMODULOPADRE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO] DROP CONSTRAINT [FK_MODULOMODULOPADRE];
GO
IF OBJECT_ID(N'[dbo].[FK_MODULO_PERMISOUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO_PERMISO] DROP CONSTRAINT [FK_MODULO_PERMISOUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_MODULO_PERMISOUSUARIO1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO_PERMISO] DROP CONSTRAINT [FK_MODULO_PERMISOUSUARIO1];
GO
IF OBJECT_ID(N'[dbo].[FK_MODULO_PERMISOUSUARIOASIGNA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO_PERMISO] DROP CONSTRAINT [FK_MODULO_PERMISOUSUARIOASIGNA];
GO
IF OBJECT_ID(N'[dbo].[FK_PROVEEDORPERSONA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROVEEDOR] DROP CONSTRAINT [FK_PROVEEDORPERSONA];
GO
IF OBJECT_ID(N'[dbo].[FK_MARCAPROVEEDOR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MARCA] DROP CONSTRAINT [FK_MARCAPROVEEDOR];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTOMARCA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRODUCTO] DROP CONSTRAINT [FK_PRODUCTOMARCA];
GO
IF OBJECT_ID(N'[dbo].[FK_CLIENTEPERSONA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CLIENTE] DROP CONSTRAINT [FK_CLIENTEPERSONA];
GO
IF OBJECT_ID(N'[dbo].[FK_MOVIMIENTOPRODUCTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MOVIMIENTO] DROP CONSTRAINT [FK_MOVIMIENTOPRODUCTO];
GO
IF OBJECT_ID(N'[dbo].[FK_MOVIMIENTOTIPO_MOVIMIENTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MOVIMIENTO] DROP CONSTRAINT [FK_MOVIMIENTOTIPO_MOVIMIENTO];
GO
IF OBJECT_ID(N'[dbo].[FK_MOVIMIENTOUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MOVIMIENTO] DROP CONSTRAINT [FK_MOVIMIENTOUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTO_IMPUESTOIMPUESTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRODUCTO_IMPUESTO] DROP CONSTRAINT [FK_PRODUCTO_IMPUESTOIMPUESTO];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTO_IMPUESTOPRODUCTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRODUCTO_IMPUESTO] DROP CONSTRAINT [FK_PRODUCTO_IMPUESTOPRODUCTO];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDENCOMPRAUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDENCOMPRA] DROP CONSTRAINT [FK_ORDENCOMPRAUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_PROVEEDORORDENCOMPRA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDENCOMPRA] DROP CONSTRAINT [FK_PROVEEDORORDENCOMPRA];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDENCOMPRAMARCA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDENCOMPRA] DROP CONSTRAINT [FK_ORDENCOMPRAMARCA];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDENCOMPRA_PARTIDAPRODUCTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDENCOMPRA_PARTIDA] DROP CONSTRAINT [FK_ORDENCOMPRA_PARTIDAPRODUCTO];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDENCOMPRA_PARTIDAORDENCOMPRA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDENCOMPRA_PARTIDA] DROP CONSTRAINT [FK_ORDENCOMPRA_PARTIDAORDENCOMPRA];
GO
IF OBJECT_ID(N'[dbo].[FK_PRODUCTOESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PRODUCTO] DROP CONSTRAINT [FK_PRODUCTOESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_MARCAESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MARCA] DROP CONSTRAINT [FK_MARCAESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_PROVEEDORESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROVEEDOR] DROP CONSTRAINT [FK_PROVEEDORESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDENCOMPRAESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDENCOMPRA] DROP CONSTRAINT [FK_ORDENCOMPRAESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTAUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA] DROP CONSTRAINT [FK_VENTAUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTAESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA] DROP CONSTRAINT [FK_VENTAESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTA_PARTIDAPRODUCTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA_PARTIDA] DROP CONSTRAINT [FK_VENTA_PARTIDAPRODUCTO];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTA_PARTIDAVENTA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA_PARTIDA] DROP CONSTRAINT [FK_VENTA_PARTIDAVENTA];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTACLIENTE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA] DROP CONSTRAINT [FK_VENTACLIENTE];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTAMETODOPAGO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA] DROP CONSTRAINT [FK_VENTAMETODOPAGO];
GO
IF OBJECT_ID(N'[dbo].[FK_VENTAFORMAPAGO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VENTA] DROP CONSTRAINT [FK_VENTAFORMAPAGO];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOROL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIOROL];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIOESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADO] DROP CONSTRAINT [FK_EMPLEADOESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOPUESTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADO] DROP CONSTRAINT [FK_EMPLEADOPUESTO];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOPERSONA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADO] DROP CONSTRAINT [FK_EMPLEADOPERSONA];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CONTROL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CONTROL];
GO
IF OBJECT_ID(N'[dbo].[CONTROL_PERMISO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CONTROL_PERMISO];
GO
IF OBJECT_ID(N'[dbo].[EMPLEADO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EMPLEADO];
GO
IF OBJECT_ID(N'[dbo].[ESTADO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ESTADO];
GO
IF OBJECT_ID(N'[dbo].[MODULO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MODULO];
GO
IF OBJECT_ID(N'[dbo].[MODULO_PERMISO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MODULO_PERMISO];
GO
IF OBJECT_ID(N'[dbo].[PERSONA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PERSONA];
GO
IF OBJECT_ID(N'[dbo].[PUESTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PUESTO];
GO
IF OBJECT_ID(N'[dbo].[ROL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ROL];
GO
IF OBJECT_ID(N'[dbo].[USUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIO];
GO
IF OBJECT_ID(N'[dbo].[PRODUCTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODUCTO];
GO
IF OBJECT_ID(N'[dbo].[PROVEEDOR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROVEEDOR];
GO
IF OBJECT_ID(N'[dbo].[MARCA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MARCA];
GO
IF OBJECT_ID(N'[dbo].[ORDENCOMPRA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORDENCOMPRA];
GO
IF OBJECT_ID(N'[dbo].[VENTA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENTA];
GO
IF OBJECT_ID(N'[dbo].[VENTA_PARTIDA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENTA_PARTIDA];
GO
IF OBJECT_ID(N'[dbo].[CLIENTE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLIENTE];
GO
IF OBJECT_ID(N'[dbo].[MOVIMIENTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MOVIMIENTO];
GO
IF OBJECT_ID(N'[dbo].[IMPUESTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IMPUESTO];
GO
IF OBJECT_ID(N'[dbo].[PRODUCTO_IMPUESTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PRODUCTO_IMPUESTO];
GO
IF OBJECT_ID(N'[dbo].[ORDENCOMPRA_PARTIDA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORDENCOMPRA_PARTIDA];
GO
IF OBJECT_ID(N'[dbo].[TIPO_MOVIMIENTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TIPO_MOVIMIENTO];
GO
IF OBJECT_ID(N'[dbo].[METODOPAGO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[METODOPAGO];
GO
IF OBJECT_ID(N'[dbo].[FORMAPAGO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FORMAPAGO];
GO
IF OBJECT_ID(N'[dbo].[VARIABLEGLOBAL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VARIABLEGLOBAL];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CONTROL'
CREATE TABLE [dbo].[CONTROL] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(65)  NOT NULL,
    [MODULOId] int  NOT NULL,
    [USUARIOId] int  NOT NULL
);
GO

-- Creating table 'CONTROL_PERMISO'
CREATE TABLE [dbo].[CONTROL_PERMISO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CONTROLId] int  NOT NULL,
    [USUARIOSolicitaId] int  NOT NULL,
    [USUARIOAutorizaId] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [ReadOnly] bit  NOT NULL,
    [Hide] bit  NOT NULL,
    [FechaAsignacion] datetime  NOT NULL,
    [Baja] bit  NOT NULL
);
GO

-- Creating table 'EMPLEADO'
CREATE TABLE [dbo].[EMPLEADO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rfc] nvarchar(13)  NULL,
    [FechaIngreso] datetime  NOT NULL,
    [ESTADOId] int  NOT NULL,
    [PUESTOId] int  NOT NULL,
    [PERSONAId] int  NOT NULL
);
GO

-- Creating table 'ESTADO'
CREATE TABLE [dbo].[ESTADO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(35)  NULL,
    [Proceso] nvarchar(65)  NOT NULL
);
GO

-- Creating table 'MODULO'
CREATE TABLE [dbo].[MODULO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(150)  NOT NULL,
    [Ruta] nvarchar(max)  NOT NULL,
    [Icono] nvarchar(max)  NOT NULL,
    [MODULOPadreId] int  NULL
);
GO

-- Creating table 'MODULO_PERMISO'
CREATE TABLE [dbo].[MODULO_PERMISO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaAsignacion] datetime  NOT NULL,
    [Baja] bit  NOT NULL,
    [MODULOId] int  NOT NULL,
    [USUARIOSolicitaId] int  NOT NULL,
    [USUARIOAutorizaId] int  NOT NULL,
    [USUARIOAsignaId] int  NOT NULL
);
GO

-- Creating table 'PERSONA'
CREATE TABLE [dbo].[PERSONA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombres] nvarchar(65)  NOT NULL,
    [ApellidoPaterno] nvarchar(65)  NOT NULL,
    [ApellidoMaterno] nvarchar(65)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL
);
GO

-- Creating table 'PUESTO'
CREATE TABLE [dbo].[PUESTO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(35)  NULL
);
GO

-- Creating table 'ROL'
CREATE TABLE [dbo].[ROL] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(35)  NULL
);
GO

-- Creating table 'USUARIO'
CREATE TABLE [dbo].[USUARIO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Alias] nvarchar(35)  NOT NULL,
    [Password] nvarchar(255)  NOT NULL,
    [FechaRegistro] datetime  NOT NULL,
    [EMPLEADOId] int  NOT NULL,
    [ROLId] int  NOT NULL,
    [ESTADOId] int  NOT NULL
);
GO

-- Creating table 'PRODUCTO'
CREATE TABLE [dbo].[PRODUCTO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Clave] nvarchar(35)  NOT NULL,
    [Nombre] nchar(380)  NOT NULL,
    [PrecioCompra] decimal(18,7)  NOT NULL,
    [PrecioVenta] decimal(18,7)  NOT NULL,
    [CodigoBarras] nvarchar(255)  NOT NULL,
    [MARCAId] int  NOT NULL,
    [FechaRegistro] datetime  NOT NULL,
    [ESTADOId] int  NOT NULL
);
GO

-- Creating table 'PROVEEDOR'
CREATE TABLE [dbo].[PROVEEDOR] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RazonSocial] nvarchar(380)  NOT NULL,
    [Clave] nchar(5)  NOT NULL,
    [PERSONAIdRepresentante] int  NOT NULL,
    [FechaRegistro] datetime  NOT NULL,
    [ESTADOId] int  NOT NULL
);
GO

-- Creating table 'MARCA'
CREATE TABLE [dbo].[MARCA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Clave] nvarchar(max)  NOT NULL,
    [PROVEEDORId] int  NOT NULL,
    [FechaRegistro] nvarchar(max)  NOT NULL,
    [ESTADOId] int  NOT NULL
);
GO

-- Creating table 'ORDENCOMPRA'
CREATE TABLE [dbo].[ORDENCOMPRA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaEmision] datetime  NOT NULL,
    [USUARIOIdGenero] int  NOT NULL,
    [PROVEEDORId] int  NOT NULL,
    [MARCAId] int  NOT NULL,
    [Subtotal] decimal(18,7)  NOT NULL,
    [Impuestos] decimal(18,7)  NOT NULL,
    [Total] decimal(18,7)  NOT NULL,
    [ESTADOId] int  NOT NULL
);
GO

-- Creating table 'VENTA'
CREATE TABLE [dbo].[VENTA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeroReferencia] nchar(13)  NOT NULL,
    [ESTADOId] int  NOT NULL,
    [CLIENTEId] int  NOT NULL,
    [NombreCliente0] nvarchar(255)  NOT NULL,
    [METODOPAGOId] int  NOT NULL,
    [FORMAPAGOId] int  NOT NULL,
    [FechaEmision] datetime  NOT NULL,
    [USUARIOIdGenero] int  NOT NULL,
    [Subtotal] decimal(18,7)  NOT NULL,
    [Impuestos] decimal(18,7)  NOT NULL,
    [Total] decimal(18,7)  NOT NULL
);
GO

-- Creating table 'VENTA_PARTIDA'
CREATE TABLE [dbo].[VENTA_PARTIDA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRODUCTOId] int  NOT NULL,
    [VENTAId] int  NOT NULL,
    [Cantidad] decimal(18,7)  NOT NULL,
    [Precio] decimal(18,7)  NOT NULL,
    [Impuestos] decimal(18,7)  NOT NULL,
    [Subtotal] decimal(18,7)  NOT NULL,
    [Total] decimal(18,7)  NOT NULL,
    [Baja] bit  NOT NULL
);
GO

-- Creating table 'CLIENTE'
CREATE TABLE [dbo].[CLIENTE] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Clave] nchar(5)  NOT NULL,
    [PERSONAId] int  NOT NULL,
    [RFC] nvarchar(13)  NOT NULL,
    [RazonSocial] nvarchar(255)  NOT NULL,
    [FechaRegistro] datetime  NOT NULL
);
GO

-- Creating table 'MOVIMIENTO'
CREATE TABLE [dbo].[MOVIMIENTO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaRegistro] datetime  NOT NULL,
    [PRODUCTOId] int  NOT NULL,
    [Cantidad] decimal(18,7)  NOT NULL,
    [TIPO_MOVIMIENTOId] int  NOT NULL,
    [Precio] decimal(18,7)  NOT NULL,
    [FolioDocumento] nchar(13)  NOT NULL,
    [IdDocumento] nvarchar(max)  NOT NULL,
    [Entidad] nvarchar(65)  NOT NULL,
    [USUARIOIdRealizo] int  NOT NULL
);
GO

-- Creating table 'IMPUESTO'
CREATE TABLE [dbo].[IMPUESTO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(35)  NOT NULL,
    [Porcentaje] decimal(18,7)  NOT NULL
);
GO

-- Creating table 'PRODUCTO_IMPUESTO'
CREATE TABLE [dbo].[PRODUCTO_IMPUESTO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRODUCTOId] int  NOT NULL,
    [IMPUESTOId] int  NOT NULL,
    [Baja] bit  NOT NULL
);
GO

-- Creating table 'ORDENCOMPRA_PARTIDA'
CREATE TABLE [dbo].[ORDENCOMPRA_PARTIDA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PRODUCTOId] int  NOT NULL,
    [ORDENCOMPRAId] int  NOT NULL,
    [Precio] decimal(18,7)  NOT NULL,
    [Impuesto] decimal(18,7)  NOT NULL,
    [Cantidad] decimal(18,7)  NOT NULL,
    [Monto] decimal(18,7)  NOT NULL,
    [Total] decimal(18,7)  NOT NULL,
    [Baja] bit  NOT NULL
);
GO

-- Creating table 'TIPO_MOVIMIENTO'
CREATE TABLE [dbo].[TIPO_MOVIMIENTO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(35)  NOT NULL,
    [Tipo] bit  NOT NULL,
    [Baja] bit  NOT NULL
);
GO

-- Creating table 'METODOPAGO'
CREATE TABLE [dbo].[METODOPAGO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(35)  NOT NULL
);
GO

-- Creating table 'FORMAPAGO'
CREATE TABLE [dbo].[FORMAPAGO] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(35)  NOT NULL
);
GO

-- Creating table 'VARIABLEGLOBAL'
CREATE TABLE [dbo].[VARIABLEGLOBAL] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(65)  NOT NULL,
    [Tipo] nchar(15)  NOT NULL,
    [Valor] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CONTROL'
ALTER TABLE [dbo].[CONTROL]
ADD CONSTRAINT [PK_CONTROL]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CONTROL_PERMISO'
ALTER TABLE [dbo].[CONTROL_PERMISO]
ADD CONSTRAINT [PK_CONTROL_PERMISO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EMPLEADO'
ALTER TABLE [dbo].[EMPLEADO]
ADD CONSTRAINT [PK_EMPLEADO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ESTADO'
ALTER TABLE [dbo].[ESTADO]
ADD CONSTRAINT [PK_ESTADO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MODULO'
ALTER TABLE [dbo].[MODULO]
ADD CONSTRAINT [PK_MODULO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MODULO_PERMISO'
ALTER TABLE [dbo].[MODULO_PERMISO]
ADD CONSTRAINT [PK_MODULO_PERMISO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PERSONA'
ALTER TABLE [dbo].[PERSONA]
ADD CONSTRAINT [PK_PERSONA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PUESTO'
ALTER TABLE [dbo].[PUESTO]
ADD CONSTRAINT [PK_PUESTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ROL'
ALTER TABLE [dbo].[ROL]
ADD CONSTRAINT [PK_ROL]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [PK_USUARIO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PRODUCTO'
ALTER TABLE [dbo].[PRODUCTO]
ADD CONSTRAINT [PK_PRODUCTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PROVEEDOR'
ALTER TABLE [dbo].[PROVEEDOR]
ADD CONSTRAINT [PK_PROVEEDOR]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MARCA'
ALTER TABLE [dbo].[MARCA]
ADD CONSTRAINT [PK_MARCA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ORDENCOMPRA'
ALTER TABLE [dbo].[ORDENCOMPRA]
ADD CONSTRAINT [PK_ORDENCOMPRA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VENTA'
ALTER TABLE [dbo].[VENTA]
ADD CONSTRAINT [PK_VENTA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VENTA_PARTIDA'
ALTER TABLE [dbo].[VENTA_PARTIDA]
ADD CONSTRAINT [PK_VENTA_PARTIDA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CLIENTE'
ALTER TABLE [dbo].[CLIENTE]
ADD CONSTRAINT [PK_CLIENTE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MOVIMIENTO'
ALTER TABLE [dbo].[MOVIMIENTO]
ADD CONSTRAINT [PK_MOVIMIENTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IMPUESTO'
ALTER TABLE [dbo].[IMPUESTO]
ADD CONSTRAINT [PK_IMPUESTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PRODUCTO_IMPUESTO'
ALTER TABLE [dbo].[PRODUCTO_IMPUESTO]
ADD CONSTRAINT [PK_PRODUCTO_IMPUESTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ORDENCOMPRA_PARTIDA'
ALTER TABLE [dbo].[ORDENCOMPRA_PARTIDA]
ADD CONSTRAINT [PK_ORDENCOMPRA_PARTIDA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TIPO_MOVIMIENTO'
ALTER TABLE [dbo].[TIPO_MOVIMIENTO]
ADD CONSTRAINT [PK_TIPO_MOVIMIENTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'METODOPAGO'
ALTER TABLE [dbo].[METODOPAGO]
ADD CONSTRAINT [PK_METODOPAGO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FORMAPAGO'
ALTER TABLE [dbo].[FORMAPAGO]
ADD CONSTRAINT [PK_FORMAPAGO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VARIABLEGLOBAL'
ALTER TABLE [dbo].[VARIABLEGLOBAL]
ADD CONSTRAINT [PK_VARIABLEGLOBAL]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CONTROLId] in table 'CONTROL_PERMISO'
ALTER TABLE [dbo].[CONTROL_PERMISO]
ADD CONSTRAINT [FK_CONTROL_PERMISOCONTROL]
    FOREIGN KEY ([CONTROLId])
    REFERENCES [dbo].[CONTROL]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CONTROL_PERMISOCONTROL'
CREATE INDEX [IX_FK_CONTROL_PERMISOCONTROL]
ON [dbo].[CONTROL_PERMISO]
    ([CONTROLId]);
GO

-- Creating foreign key on [MODULOId] in table 'CONTROL'
ALTER TABLE [dbo].[CONTROL]
ADD CONSTRAINT [FK_CONTROLMODULO]
    FOREIGN KEY ([MODULOId])
    REFERENCES [dbo].[MODULO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CONTROLMODULO'
CREATE INDEX [IX_FK_CONTROLMODULO]
ON [dbo].[CONTROL]
    ([MODULOId]);
GO

-- Creating foreign key on [USUARIOId] in table 'CONTROL'
ALTER TABLE [dbo].[CONTROL]
ADD CONSTRAINT [FK_CONTROLUSUARIO]
    FOREIGN KEY ([USUARIOId])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CONTROLUSUARIO'
CREATE INDEX [IX_FK_CONTROLUSUARIO]
ON [dbo].[CONTROL]
    ([USUARIOId]);
GO

-- Creating foreign key on [USUARIOSolicitaId] in table 'CONTROL_PERMISO'
ALTER TABLE [dbo].[CONTROL_PERMISO]
ADD CONSTRAINT [FK_CONTROL_PERMISOUSUARIO]
    FOREIGN KEY ([USUARIOSolicitaId])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CONTROL_PERMISOUSUARIO'
CREATE INDEX [IX_FK_CONTROL_PERMISOUSUARIO]
ON [dbo].[CONTROL_PERMISO]
    ([USUARIOSolicitaId]);
GO

-- Creating foreign key on [USUARIOAutorizaId] in table 'CONTROL_PERMISO'
ALTER TABLE [dbo].[CONTROL_PERMISO]
ADD CONSTRAINT [FK_CONTROL_PERMISOUSUARIOAUTORIZA]
    FOREIGN KEY ([USUARIOAutorizaId])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CONTROL_PERMISOUSUARIOAUTORIZA'
CREATE INDEX [IX_FK_CONTROL_PERMISOUSUARIOAUTORIZA]
ON [dbo].[CONTROL_PERMISO]
    ([USUARIOAutorizaId]);
GO

-- Creating foreign key on [EMPLEADOId] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK_USUARIOEMPLEADO]
    FOREIGN KEY ([EMPLEADOId])
    REFERENCES [dbo].[EMPLEADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOEMPLEADO'
CREATE INDEX [IX_FK_USUARIOEMPLEADO]
ON [dbo].[USUARIO]
    ([EMPLEADOId]);
GO

-- Creating foreign key on [MODULOId] in table 'MODULO_PERMISO'
ALTER TABLE [dbo].[MODULO_PERMISO]
ADD CONSTRAINT [FK_MODULO_PERMISOMODULO]
    FOREIGN KEY ([MODULOId])
    REFERENCES [dbo].[MODULO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULO_PERMISOMODULO'
CREATE INDEX [IX_FK_MODULO_PERMISOMODULO]
ON [dbo].[MODULO_PERMISO]
    ([MODULOId]);
GO

-- Creating foreign key on [MODULOPadreId] in table 'MODULO'
ALTER TABLE [dbo].[MODULO]
ADD CONSTRAINT [FK_MODULOMODULOPADRE]
    FOREIGN KEY ([MODULOPadreId])
    REFERENCES [dbo].[MODULO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULOMODULOPADRE'
CREATE INDEX [IX_FK_MODULOMODULOPADRE]
ON [dbo].[MODULO]
    ([MODULOPadreId]);
GO

-- Creating foreign key on [USUARIOSolicitaId] in table 'MODULO_PERMISO'
ALTER TABLE [dbo].[MODULO_PERMISO]
ADD CONSTRAINT [FK_MODULO_PERMISOUSUARIO]
    FOREIGN KEY ([USUARIOSolicitaId])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULO_PERMISOUSUARIO'
CREATE INDEX [IX_FK_MODULO_PERMISOUSUARIO]
ON [dbo].[MODULO_PERMISO]
    ([USUARIOSolicitaId]);
GO

-- Creating foreign key on [USUARIOAutorizaId] in table 'MODULO_PERMISO'
ALTER TABLE [dbo].[MODULO_PERMISO]
ADD CONSTRAINT [FK_MODULO_PERMISOUSUARIO1]
    FOREIGN KEY ([USUARIOAutorizaId])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULO_PERMISOUSUARIO1'
CREATE INDEX [IX_FK_MODULO_PERMISOUSUARIO1]
ON [dbo].[MODULO_PERMISO]
    ([USUARIOAutorizaId]);
GO

-- Creating foreign key on [USUARIOAsignaId] in table 'MODULO_PERMISO'
ALTER TABLE [dbo].[MODULO_PERMISO]
ADD CONSTRAINT [FK_MODULO_PERMISOUSUARIOASIGNA]
    FOREIGN KEY ([USUARIOAsignaId])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULO_PERMISOUSUARIOASIGNA'
CREATE INDEX [IX_FK_MODULO_PERMISOUSUARIOASIGNA]
ON [dbo].[MODULO_PERMISO]
    ([USUARIOAsignaId]);
GO

-- Creating foreign key on [PERSONAIdRepresentante] in table 'PROVEEDOR'
ALTER TABLE [dbo].[PROVEEDOR]
ADD CONSTRAINT [FK_PROVEEDORPERSONA]
    FOREIGN KEY ([PERSONAIdRepresentante])
    REFERENCES [dbo].[PERSONA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PROVEEDORPERSONA'
CREATE INDEX [IX_FK_PROVEEDORPERSONA]
ON [dbo].[PROVEEDOR]
    ([PERSONAIdRepresentante]);
GO

-- Creating foreign key on [PROVEEDORId] in table 'MARCA'
ALTER TABLE [dbo].[MARCA]
ADD CONSTRAINT [FK_MARCAPROVEEDOR]
    FOREIGN KEY ([PROVEEDORId])
    REFERENCES [dbo].[PROVEEDOR]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MARCAPROVEEDOR'
CREATE INDEX [IX_FK_MARCAPROVEEDOR]
ON [dbo].[MARCA]
    ([PROVEEDORId]);
GO

-- Creating foreign key on [MARCAId] in table 'PRODUCTO'
ALTER TABLE [dbo].[PRODUCTO]
ADD CONSTRAINT [FK_PRODUCTOMARCA]
    FOREIGN KEY ([MARCAId])
    REFERENCES [dbo].[MARCA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTOMARCA'
CREATE INDEX [IX_FK_PRODUCTOMARCA]
ON [dbo].[PRODUCTO]
    ([MARCAId]);
GO

-- Creating foreign key on [PERSONAId] in table 'CLIENTE'
ALTER TABLE [dbo].[CLIENTE]
ADD CONSTRAINT [FK_CLIENTEPERSONA]
    FOREIGN KEY ([PERSONAId])
    REFERENCES [dbo].[PERSONA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CLIENTEPERSONA'
CREATE INDEX [IX_FK_CLIENTEPERSONA]
ON [dbo].[CLIENTE]
    ([PERSONAId]);
GO

-- Creating foreign key on [PRODUCTOId] in table 'MOVIMIENTO'
ALTER TABLE [dbo].[MOVIMIENTO]
ADD CONSTRAINT [FK_MOVIMIENTOPRODUCTO]
    FOREIGN KEY ([PRODUCTOId])
    REFERENCES [dbo].[PRODUCTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MOVIMIENTOPRODUCTO'
CREATE INDEX [IX_FK_MOVIMIENTOPRODUCTO]
ON [dbo].[MOVIMIENTO]
    ([PRODUCTOId]);
GO

-- Creating foreign key on [TIPO_MOVIMIENTOId] in table 'MOVIMIENTO'
ALTER TABLE [dbo].[MOVIMIENTO]
ADD CONSTRAINT [FK_MOVIMIENTOTIPO_MOVIMIENTO]
    FOREIGN KEY ([TIPO_MOVIMIENTOId])
    REFERENCES [dbo].[TIPO_MOVIMIENTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MOVIMIENTOTIPO_MOVIMIENTO'
CREATE INDEX [IX_FK_MOVIMIENTOTIPO_MOVIMIENTO]
ON [dbo].[MOVIMIENTO]
    ([TIPO_MOVIMIENTOId]);
GO

-- Creating foreign key on [USUARIOIdRealizo] in table 'MOVIMIENTO'
ALTER TABLE [dbo].[MOVIMIENTO]
ADD CONSTRAINT [FK_MOVIMIENTOUSUARIO]
    FOREIGN KEY ([USUARIOIdRealizo])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MOVIMIENTOUSUARIO'
CREATE INDEX [IX_FK_MOVIMIENTOUSUARIO]
ON [dbo].[MOVIMIENTO]
    ([USUARIOIdRealizo]);
GO

-- Creating foreign key on [IMPUESTOId] in table 'PRODUCTO_IMPUESTO'
ALTER TABLE [dbo].[PRODUCTO_IMPUESTO]
ADD CONSTRAINT [FK_PRODUCTO_IMPUESTOIMPUESTO]
    FOREIGN KEY ([IMPUESTOId])
    REFERENCES [dbo].[IMPUESTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTO_IMPUESTOIMPUESTO'
CREATE INDEX [IX_FK_PRODUCTO_IMPUESTOIMPUESTO]
ON [dbo].[PRODUCTO_IMPUESTO]
    ([IMPUESTOId]);
GO

-- Creating foreign key on [PRODUCTOId] in table 'PRODUCTO_IMPUESTO'
ALTER TABLE [dbo].[PRODUCTO_IMPUESTO]
ADD CONSTRAINT [FK_PRODUCTO_IMPUESTOPRODUCTO]
    FOREIGN KEY ([PRODUCTOId])
    REFERENCES [dbo].[PRODUCTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTO_IMPUESTOPRODUCTO'
CREATE INDEX [IX_FK_PRODUCTO_IMPUESTOPRODUCTO]
ON [dbo].[PRODUCTO_IMPUESTO]
    ([PRODUCTOId]);
GO

-- Creating foreign key on [USUARIOIdGenero] in table 'ORDENCOMPRA'
ALTER TABLE [dbo].[ORDENCOMPRA]
ADD CONSTRAINT [FK_ORDENCOMPRAUSUARIO]
    FOREIGN KEY ([USUARIOIdGenero])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDENCOMPRAUSUARIO'
CREATE INDEX [IX_FK_ORDENCOMPRAUSUARIO]
ON [dbo].[ORDENCOMPRA]
    ([USUARIOIdGenero]);
GO

-- Creating foreign key on [PROVEEDORId] in table 'ORDENCOMPRA'
ALTER TABLE [dbo].[ORDENCOMPRA]
ADD CONSTRAINT [FK_PROVEEDORORDENCOMPRA]
    FOREIGN KEY ([PROVEEDORId])
    REFERENCES [dbo].[PROVEEDOR]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PROVEEDORORDENCOMPRA'
CREATE INDEX [IX_FK_PROVEEDORORDENCOMPRA]
ON [dbo].[ORDENCOMPRA]
    ([PROVEEDORId]);
GO

-- Creating foreign key on [MARCAId] in table 'ORDENCOMPRA'
ALTER TABLE [dbo].[ORDENCOMPRA]
ADD CONSTRAINT [FK_ORDENCOMPRAMARCA]
    FOREIGN KEY ([MARCAId])
    REFERENCES [dbo].[MARCA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDENCOMPRAMARCA'
CREATE INDEX [IX_FK_ORDENCOMPRAMARCA]
ON [dbo].[ORDENCOMPRA]
    ([MARCAId]);
GO

-- Creating foreign key on [PRODUCTOId] in table 'ORDENCOMPRA_PARTIDA'
ALTER TABLE [dbo].[ORDENCOMPRA_PARTIDA]
ADD CONSTRAINT [FK_ORDENCOMPRA_PARTIDAPRODUCTO]
    FOREIGN KEY ([PRODUCTOId])
    REFERENCES [dbo].[PRODUCTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDENCOMPRA_PARTIDAPRODUCTO'
CREATE INDEX [IX_FK_ORDENCOMPRA_PARTIDAPRODUCTO]
ON [dbo].[ORDENCOMPRA_PARTIDA]
    ([PRODUCTOId]);
GO

-- Creating foreign key on [ORDENCOMPRAId] in table 'ORDENCOMPRA_PARTIDA'
ALTER TABLE [dbo].[ORDENCOMPRA_PARTIDA]
ADD CONSTRAINT [FK_ORDENCOMPRA_PARTIDAORDENCOMPRA]
    FOREIGN KEY ([ORDENCOMPRAId])
    REFERENCES [dbo].[ORDENCOMPRA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDENCOMPRA_PARTIDAORDENCOMPRA'
CREATE INDEX [IX_FK_ORDENCOMPRA_PARTIDAORDENCOMPRA]
ON [dbo].[ORDENCOMPRA_PARTIDA]
    ([ORDENCOMPRAId]);
GO

-- Creating foreign key on [ESTADOId] in table 'PRODUCTO'
ALTER TABLE [dbo].[PRODUCTO]
ADD CONSTRAINT [FK_PRODUCTOESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PRODUCTOESTADO'
CREATE INDEX [IX_FK_PRODUCTOESTADO]
ON [dbo].[PRODUCTO]
    ([ESTADOId]);
GO

-- Creating foreign key on [ESTADOId] in table 'MARCA'
ALTER TABLE [dbo].[MARCA]
ADD CONSTRAINT [FK_MARCAESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MARCAESTADO'
CREATE INDEX [IX_FK_MARCAESTADO]
ON [dbo].[MARCA]
    ([ESTADOId]);
GO

-- Creating foreign key on [ESTADOId] in table 'PROVEEDOR'
ALTER TABLE [dbo].[PROVEEDOR]
ADD CONSTRAINT [FK_PROVEEDORESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PROVEEDORESTADO'
CREATE INDEX [IX_FK_PROVEEDORESTADO]
ON [dbo].[PROVEEDOR]
    ([ESTADOId]);
GO

-- Creating foreign key on [ESTADOId] in table 'ORDENCOMPRA'
ALTER TABLE [dbo].[ORDENCOMPRA]
ADD CONSTRAINT [FK_ORDENCOMPRAESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDENCOMPRAESTADO'
CREATE INDEX [IX_FK_ORDENCOMPRAESTADO]
ON [dbo].[ORDENCOMPRA]
    ([ESTADOId]);
GO

-- Creating foreign key on [USUARIOIdGenero] in table 'VENTA'
ALTER TABLE [dbo].[VENTA]
ADD CONSTRAINT [FK_VENTAUSUARIO]
    FOREIGN KEY ([USUARIOIdGenero])
    REFERENCES [dbo].[USUARIO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTAUSUARIO'
CREATE INDEX [IX_FK_VENTAUSUARIO]
ON [dbo].[VENTA]
    ([USUARIOIdGenero]);
GO

-- Creating foreign key on [ESTADOId] in table 'VENTA'
ALTER TABLE [dbo].[VENTA]
ADD CONSTRAINT [FK_VENTAESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTAESTADO'
CREATE INDEX [IX_FK_VENTAESTADO]
ON [dbo].[VENTA]
    ([ESTADOId]);
GO

-- Creating foreign key on [PRODUCTOId] in table 'VENTA_PARTIDA'
ALTER TABLE [dbo].[VENTA_PARTIDA]
ADD CONSTRAINT [FK_VENTA_PARTIDAPRODUCTO]
    FOREIGN KEY ([PRODUCTOId])
    REFERENCES [dbo].[PRODUCTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTA_PARTIDAPRODUCTO'
CREATE INDEX [IX_FK_VENTA_PARTIDAPRODUCTO]
ON [dbo].[VENTA_PARTIDA]
    ([PRODUCTOId]);
GO

-- Creating foreign key on [VENTAId] in table 'VENTA_PARTIDA'
ALTER TABLE [dbo].[VENTA_PARTIDA]
ADD CONSTRAINT [FK_VENTA_PARTIDAVENTA]
    FOREIGN KEY ([VENTAId])
    REFERENCES [dbo].[VENTA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTA_PARTIDAVENTA'
CREATE INDEX [IX_FK_VENTA_PARTIDAVENTA]
ON [dbo].[VENTA_PARTIDA]
    ([VENTAId]);
GO

-- Creating foreign key on [CLIENTEId] in table 'VENTA'
ALTER TABLE [dbo].[VENTA]
ADD CONSTRAINT [FK_VENTACLIENTE]
    FOREIGN KEY ([CLIENTEId])
    REFERENCES [dbo].[CLIENTE]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTACLIENTE'
CREATE INDEX [IX_FK_VENTACLIENTE]
ON [dbo].[VENTA]
    ([CLIENTEId]);
GO

-- Creating foreign key on [METODOPAGOId] in table 'VENTA'
ALTER TABLE [dbo].[VENTA]
ADD CONSTRAINT [FK_VENTAMETODOPAGO]
    FOREIGN KEY ([METODOPAGOId])
    REFERENCES [dbo].[METODOPAGO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTAMETODOPAGO'
CREATE INDEX [IX_FK_VENTAMETODOPAGO]
ON [dbo].[VENTA]
    ([METODOPAGOId]);
GO

-- Creating foreign key on [FORMAPAGOId] in table 'VENTA'
ALTER TABLE [dbo].[VENTA]
ADD CONSTRAINT [FK_VENTAFORMAPAGO]
    FOREIGN KEY ([FORMAPAGOId])
    REFERENCES [dbo].[FORMAPAGO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VENTAFORMAPAGO'
CREATE INDEX [IX_FK_VENTAFORMAPAGO]
ON [dbo].[VENTA]
    ([FORMAPAGOId]);
GO

-- Creating foreign key on [ROLId] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK_USUARIOROL]
    FOREIGN KEY ([ROLId])
    REFERENCES [dbo].[ROL]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOROL'
CREATE INDEX [IX_FK_USUARIOROL]
ON [dbo].[USUARIO]
    ([ROLId]);
GO

-- Creating foreign key on [ESTADOId] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK_USUARIOESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOESTADO'
CREATE INDEX [IX_FK_USUARIOESTADO]
ON [dbo].[USUARIO]
    ([ESTADOId]);
GO

-- Creating foreign key on [ESTADOId] in table 'EMPLEADO'
ALTER TABLE [dbo].[EMPLEADO]
ADD CONSTRAINT [FK_EMPLEADOESTADO]
    FOREIGN KEY ([ESTADOId])
    REFERENCES [dbo].[ESTADO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOESTADO'
CREATE INDEX [IX_FK_EMPLEADOESTADO]
ON [dbo].[EMPLEADO]
    ([ESTADOId]);
GO

-- Creating foreign key on [PUESTOId] in table 'EMPLEADO'
ALTER TABLE [dbo].[EMPLEADO]
ADD CONSTRAINT [FK_EMPLEADOPUESTO]
    FOREIGN KEY ([PUESTOId])
    REFERENCES [dbo].[PUESTO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOPUESTO'
CREATE INDEX [IX_FK_EMPLEADOPUESTO]
ON [dbo].[EMPLEADO]
    ([PUESTOId]);
GO

-- Creating foreign key on [PERSONAId] in table 'EMPLEADO'
ALTER TABLE [dbo].[EMPLEADO]
ADD CONSTRAINT [FK_EMPLEADOPERSONA]
    FOREIGN KEY ([PERSONAId])
    REFERENCES [dbo].[PERSONA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMPLEADOPERSONA'
CREATE INDEX [IX_FK_EMPLEADOPERSONA]
ON [dbo].[EMPLEADO]
    ([PERSONAId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------