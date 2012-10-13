
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/12/2012 22:49:52
-- Generated from EDMX file: C:\Users\Марина\Documents\Visual Studio 2010\Projects\pr2\pr2\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;

USE [database];

IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Professionworker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[workerSet] DROP CONSTRAINT [FK_Professionworker];

IF OBJECT_ID(N'[dbo].[FK_departmentworker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[workerSet] DROP CONSTRAINT [FK_departmentworker];

IF OBJECT_ID(N'[dbo].[FK_type_orderorders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ordersSet] DROP CONSTRAINT [FK_type_orderorders];

IF OBJECT_ID(N'[dbo].[FK_workerorders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ordersSet] DROP CONSTRAINT [FK_workerorders];

IF OBJECT_ID(N'[dbo].[FK_workerpj_work_dev]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[pj_work_devSet] DROP CONSTRAINT [FK_workerpj_work_dev];

IF OBJECT_ID(N'[dbo].[FK_deviationpj_work_dev]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[pj_work_devSet] DROP CONSTRAINT [FK_deviationpj_work_dev];


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[workerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[workerSet];

IF OBJECT_ID(N'[dbo].[ProfessionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfessionSet];

IF OBJECT_ID(N'[dbo].[departmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[departmentSet];

IF OBJECT_ID(N'[dbo].[ordersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ordersSet];

IF OBJECT_ID(N'[dbo].[type_orderSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[type_orderSet];

IF OBJECT_ID(N'[dbo].[deviationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[deviationSet];

IF OBJECT_ID(N'[dbo].[pj_work_devSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[pj_work_devSet];


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'workerSet'
CREATE TABLE [dbo].[workerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fname] nvarchar(max)  NOT NULL,
    [birthDate] datetime  NOT NULL,
    [adress] nvarchar(max)  NOT NULL,
    [passport] nvarchar(max)  NOT NULL,
    [id_profession] int  NOT NULL,
    [hDate] datetime  NOT NULL,
    [lname] nvarchar(max)  NOT NULL,
    [id_department_dep] int  NOT NULL,
    [name_dep] nvarchar(max)  NOT NULL
);


-- Creating table 'ProfessionSet'
CREATE TABLE [dbo].[ProfessionSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);


-- Creating table 'departmentSet'
CREATE TABLE [dbo].[departmentSet] (
    [Id_dep] int IDENTITY(1,1) NOT NULL,
    [dep_name] nvarchar(max)  NOT NULL
);


-- Creating table 'ordersSet'
CREATE TABLE [dbo].[ordersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_worker] int  NOT NULL,
    [id_type] int  NOT NULL,
    [text_ord] nvarchar(max)  NOT NULL,
    [date_ord] datetime  NOT NULL
);


-- Creating table 'type_orderSet'
CREATE TABLE [dbo].[type_orderSet] (
    [Id_type] int IDENTITY(1,1) NOT NULL,
    [type_name] nvarchar(max)  NOT NULL
);


-- Creating table 'deviationSet'
CREATE TABLE [dbo].[deviationSet] (
    [Id_worker] int IDENTITY(1,1) NOT NULL,
    [name_dev] nvarchar(max)  NOT NULL
);


-- Creating table 'pj_work_devSet'
CREATE TABLE [dbo].[pj_work_devSet] (
    [id_work] int IDENTITY(1,1) NOT NULL,
    [id_dev] int  NOT NULL,
    [id] int IDENTITY(1,1) NOT NULL
);


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'workerSet'
ALTER TABLE [dbo].[workerSet]
ADD CONSTRAINT [PK_workerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- Creating primary key on [id] in table 'ProfessionSet'
ALTER TABLE [dbo].[ProfessionSet]
ADD CONSTRAINT [PK_ProfessionSet]
    PRIMARY KEY CLUSTERED ([id] ASC);


-- Creating primary key on [Id_dep] in table 'departmentSet'
ALTER TABLE [dbo].[departmentSet]
ADD CONSTRAINT [PK_departmentSet]
    PRIMARY KEY CLUSTERED ([Id_dep] ASC);


-- Creating primary key on [Id] in table 'ordersSet'
ALTER TABLE [dbo].[ordersSet]
ADD CONSTRAINT [PK_ordersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- Creating primary key on [Id_type] in table 'type_orderSet'
ALTER TABLE [dbo].[type_orderSet]
ADD CONSTRAINT [PK_type_orderSet]
    PRIMARY KEY CLUSTERED ([Id_type] ASC);


-- Creating primary key on [Id_worker] in table 'deviationSet'
ALTER TABLE [dbo].[deviationSet]
ADD CONSTRAINT [PK_deviationSet]
    PRIMARY KEY CLUSTERED ([Id_worker] ASC);


-- Creating primary key on [id] in table 'pj_work_devSet'
ALTER TABLE [dbo].[pj_work_devSet]
ADD CONSTRAINT [PK_pj_work_devSet]
    PRIMARY KEY CLUSTERED ([id] ASC);


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_profession] in table 'workerSet'
ALTER TABLE [dbo].[workerSet]
ADD CONSTRAINT [FK_Professionworker]
    FOREIGN KEY ([id_profession])
    REFERENCES [dbo].[ProfessionSet]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Professionworker'
CREATE INDEX [IX_FK_Professionworker]
ON [dbo].[workerSet]
    ([id_profession]);

-- Creating foreign key on [id_department_dep] in table 'workerSet'
ALTER TABLE [dbo].[workerSet]
ADD CONSTRAINT [FK_departmentworker]
    FOREIGN KEY ([id_department_dep])
    REFERENCES [dbo].[departmentSet]
        ([Id_dep])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_departmentworker'
CREATE INDEX [IX_FK_departmentworker]
ON [dbo].[workerSet]
    ([id_department_dep]);


-- Creating foreign key on [id_type] in table 'ordersSet'
ALTER TABLE [dbo].[ordersSet]
ADD CONSTRAINT [FK_type_orderorders]
    FOREIGN KEY ([id_type])
    REFERENCES [dbo].[type_orderSet]
        ([Id_type])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_type_orderorders'
CREATE INDEX [IX_FK_type_orderorders]
ON [dbo].[ordersSet]
    ([id_type]);
GO

-- Creating foreign key on [id_worker] in table 'ordersSet'
ALTER TABLE [dbo].[ordersSet]
ADD CONSTRAINT [FK_workerorders]
    FOREIGN KEY ([id_worker])
    REFERENCES [dbo].[workerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_workerorders'
CREATE INDEX [IX_FK_workerorders]
ON [dbo].[ordersSet]
    ([id_worker]);


-- Creating foreign key on [id_work] in table 'pj_work_devSet'
ALTER TABLE [dbo].[pj_work_devSet]
ADD CONSTRAINT [FK_workerpj_work_dev]
    FOREIGN KEY ([id_work])
    REFERENCES [dbo].[workerSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_workerpj_work_dev'
CREATE INDEX [IX_FK_workerpj_work_dev]
ON [dbo].[pj_work_devSet]
    ([id_work]);


-- Creating foreign key on [id_dev] in table 'pj_work_devSet'
ALTER TABLE [dbo].[pj_work_devSet]
ADD CONSTRAINT [FK_deviationpj_work_dev]
    FOREIGN KEY ([id_dev])
    REFERENCES [dbo].[deviationSet]
        ([Id_worker])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_deviationpj_work_dev'
CREATE INDEX [IX_FK_deviationpj_work_dev]
ON [dbo].[pj_work_devSet]
    ([id_dev]);


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------