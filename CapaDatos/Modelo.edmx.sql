
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/03/2023 19:51:16
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
IF OBJECT_ID(N'[dbo].[FK_CONTROL_PERMISOUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL_PERMISO] DROP CONSTRAINT [FK_CONTROL_PERMISOUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROL_PERMISOUSUARIOAUTORIZA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL_PERMISO] DROP CONSTRAINT [FK_CONTROL_PERMISOUSUARIOAUTORIZA];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROLMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL] DROP CONSTRAINT [FK_CONTROLMODULO];
GO
IF OBJECT_ID(N'[dbo].[FK_CONTROLUSUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONTROL] DROP CONSTRAINT [FK_CONTROLUSUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADO] DROP CONSTRAINT [FK_EMPLEADOESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOPERSONA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADO] DROP CONSTRAINT [FK_EMPLEADOPERSONA];
GO
IF OBJECT_ID(N'[dbo].[FK_EMPLEADOPUESTO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMPLEADO] DROP CONSTRAINT [FK_EMPLEADOPUESTO];
GO
IF OBJECT_ID(N'[dbo].[FK_MODULO_PERMISOMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO_PERMISO] DROP CONSTRAINT [FK_MODULO_PERMISOMODULO];
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
IF OBJECT_ID(N'[dbo].[FK_MODULOMODULOPADRE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODULO] DROP CONSTRAINT [FK_MODULOMODULOPADRE];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOEMPLEADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIOEMPLEADO];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOESTADO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIOESTADO];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOROL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_USUARIOROL];
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
    [Rfc] nvarchar(13)  NOT NULL,
    [FechaIngreso] datetime  NOT NULL,
    [ESTADOId] int  NOT NULL,
    [PUESTOId] int  NOT NULL,
    [PERSONAId] int  NOT NULL,
    [Baja] bit  NOT NULL
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
    [ApellidoMATERNO] nvarchar(65)  NOT NULL,
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------