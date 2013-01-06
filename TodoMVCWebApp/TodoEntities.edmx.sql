
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/04/2013 17:03:18
-- Generated from EDMX file: c:\users\mike\documents\visual studio 2012\Projects\Git\Tutorials\TodoMVCWebApp\TodoMVCWebApp\TodoEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TodoDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Todoes'
CREATE TABLE [dbo].[Todoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Order] int  NOT NULL,
    [Done] bit  NOT NULL,
    [Text] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Todoes'
ALTER TABLE [dbo].[Todoes]
ADD CONSTRAINT [PK_Todoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------