
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2018 13:40:04
-- Generated from EDMX file: C:\Users\Mike\Nextcloud\Projects\Visual Studio\clanTournament\clanTournament\Models\CoCodbEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CoCodb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GuardianModel] DROP CONSTRAINT [FK_Team];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GuardianModel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GuardianModel];
GO
IF OBJECT_ID(N'[dbo].[TeamModel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamModel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GuardianModels'
CREATE TABLE [dbo].[GuardianModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MembershipId] nchar(50)  NOT NULL,
    [DisplayName] nchar(100)  NOT NULL,
    [MembershipType] int  NOT NULL,
    [TeamID] int  NOT NULL
);
GO

-- Creating table 'TeamModels'
CREATE TABLE [dbo].[TeamModels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeamName] nchar(50)  NOT NULL,
    [Seed] int  NOT NULL,
    [ClanName] nchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GuardianModels'
ALTER TABLE [dbo].[GuardianModels]
ADD CONSTRAINT [PK_GuardianModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeamModels'
ALTER TABLE [dbo].[TeamModels]
ADD CONSTRAINT [PK_TeamModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeamID] in table 'GuardianModels'
ALTER TABLE [dbo].[GuardianModels]
ADD CONSTRAINT [FK_Team1]
    FOREIGN KEY ([TeamID])
    REFERENCES [dbo].[TeamModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Team1'
CREATE INDEX [IX_FK_Team1]
ON [dbo].[GuardianModels]
    ([TeamID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------