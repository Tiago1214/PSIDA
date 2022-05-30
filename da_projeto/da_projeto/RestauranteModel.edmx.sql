
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2022 19:23:02
-- Generated from EDMX file: C:\Universidade\2Semestre\DA\PSIDA\da_projeto\da_projeto\RestauranteModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [restaurantedb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteItemMenu] DROP CONSTRAINT [FK_RestauranteItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidoes] DROP CONSTRAINT [FK_TrabalhadorPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidoes] DROP CONSTRAINT [FK_ClientePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantePedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidoes] DROP CONSTRAINT [FK_RestaurantePedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentoes] DROP CONSTRAINT [FK_PedidoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoMetodoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamentoes] DROP CONSTRAINT [FK_PagamentoMetodoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoEstado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pedidoes] DROP CONSTRAINT [FK_PedidoEstado];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenus] DROP CONSTRAINT [FK_ItemMenuCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas] DROP CONSTRAINT [FK_PessoaMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurantes] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoas_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Moradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moradas];
GO
IF OBJECT_ID(N'[dbo].[Pessoas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas];
GO
IF OBJECT_ID(N'[dbo].[Restaurantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurantes];
GO
IF OBJECT_ID(N'[dbo].[ItemMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenus];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Pedidoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pedidoes];
GO
IF OBJECT_ID(N'[dbo].[Pagamentoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamentoes];
GO
IF OBJECT_ID(N'[dbo].[MetodoPagamentoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodoPagamentoes];
GO
IF OBJECT_ID(N'[dbo].[Estadoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estadoes];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[Pessoas_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoas_Cliente];
GO
IF OBJECT_ID(N'[dbo].[RestauranteItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestauranteItemMenu];
GO
IF OBJECT_ID(N'[dbo].[PedidoItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoItemMenu];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Moradas'
CREATE TABLE [dbo].[Moradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [pais] nvarchar(max)  NOT NULL,
    [rua] nvarchar(max)  NOT NULL,
    [cidade] nvarchar(max)  NOT NULL,
    [codpostal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [telemovel] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Restaurantes'
CREATE TABLE [dbo].[Restaurantes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenus'
CREATE TABLE [dbo].[ItemMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [fotografia] nvarchar(max)  NOT NULL,
    [ingredientes] nvarchar(max)  NOT NULL,
    [preco] nvarchar(max)  NOT NULL,
    [ativo] nvarchar(max)  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pedidoes'
CREATE TABLE [dbo].[Pedidoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [valortotal] nvarchar(max)  NOT NULL,
    [TrabalhadorId] int  NOT NULL,
    [ClienteId] int  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [EstadoId] int  NOT NULL
);
GO

-- Creating table 'Pagamentoes'
CREATE TABLE [dbo].[Pagamentoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [valor] nvarchar(max)  NOT NULL,
    [PedidoId] int  NOT NULL,
    [MetodoPagamentoId] int  NOT NULL
);
GO

-- Creating table 'MetodoPagamentoes'
CREATE TABLE [dbo].[MetodoPagamentoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [metodopagamento] nvarchar(max)  NOT NULL,
    [ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Estadoes'
CREATE TABLE [dbo].[Estadoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoas_Trabalhador'
CREATE TABLE [dbo].[Pessoas_Trabalhador] (
    [salario] nvarchar(max)  NOT NULL,
    [posicao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoas_Cliente'
CREATE TABLE [dbo].[Pessoas_Cliente] (
    [totalgasto] nvarchar(max)  NOT NULL,
    [numcontribuinte] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'RestauranteItemMenu'
CREATE TABLE [dbo].[RestauranteItemMenu] (
    [Restaurantes_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoItemMenu'
CREATE TABLE [dbo].[PedidoItemMenu] (
    [Pedidoes_Id] int  NOT NULL,
    [ItemMenus_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Moradas'
ALTER TABLE [dbo].[Moradas]
ADD CONSTRAINT [PK_Moradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [PK_Restaurantes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [PK_ItemMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pedidoes'
ALTER TABLE [dbo].[Pedidoes]
ADD CONSTRAINT [PK_Pedidoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamentoes'
ALTER TABLE [dbo].[Pagamentoes]
ADD CONSTRAINT [PK_Pagamentoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamentoes'
ALTER TABLE [dbo].[MetodoPagamentoes]
ADD CONSTRAINT [PK_MetodoPagamentoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estadoes'
ALTER TABLE [dbo].[Estadoes]
ADD CONSTRAINT [PK_Estadoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [PK_Pessoas_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [PK_Pessoas_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Restaurantes_Id], [ItemMenus_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [PK_RestauranteItemMenu]
    PRIMARY KEY CLUSTERED ([Restaurantes_Id], [ItemMenus_Id] ASC);
GO

-- Creating primary key on [Pedidoes_Id], [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [PK_PedidoItemMenu]
    PRIMARY KEY CLUSTERED ([Pedidoes_Id], [ItemMenus_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Restaurantes_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_Restaurante]
    FOREIGN KEY ([Restaurantes_Id])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteItemMenu_ItemMenu'
CREATE INDEX [IX_FK_RestauranteItemMenu_ItemMenu]
ON [dbo].[RestauranteItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [TrabalhadorId] in table 'Pedidoes'
ALTER TABLE [dbo].[Pedidoes]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([TrabalhadorId])
    REFERENCES [dbo].[Pessoas_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[Pedidoes]
    ([TrabalhadorId]);
GO

-- Creating foreign key on [ClienteId] in table 'Pedidoes'
ALTER TABLE [dbo].[Pedidoes]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Pessoas_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[Pedidoes]
    ([ClienteId]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pedidoes'
ALTER TABLE [dbo].[Pedidoes]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurantes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[Pedidoes]
    ([RestauranteId]);
GO

-- Creating foreign key on [PedidoId] in table 'Pagamentoes'
ALTER TABLE [dbo].[Pagamentoes]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([PedidoId])
    REFERENCES [dbo].[Pedidoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[Pagamentoes]
    ([PedidoId]);
GO

-- Creating foreign key on [MetodoPagamentoId] in table 'Pagamentoes'
ALTER TABLE [dbo].[Pagamentoes]
ADD CONSTRAINT [FK_PagamentoMetodoPagamento]
    FOREIGN KEY ([MetodoPagamentoId])
    REFERENCES [dbo].[MetodoPagamentoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoMetodoPagamento'
CREATE INDEX [IX_FK_PagamentoMetodoPagamento]
ON [dbo].[Pagamentoes]
    ([MetodoPagamentoId]);
GO

-- Creating foreign key on [EstadoId] in table 'Pedidoes'
ALTER TABLE [dbo].[Pedidoes]
ADD CONSTRAINT [FK_PedidoEstado]
    FOREIGN KEY ([EstadoId])
    REFERENCES [dbo].[Estadoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoEstado'
CREATE INDEX [IX_FK_PedidoEstado]
ON [dbo].[Pedidoes]
    ([EstadoId]);
GO

-- Creating foreign key on [CategoriaId] in table 'ItemMenus'
ALTER TABLE [dbo].[ItemMenus]
ADD CONSTRAINT [FK_ItemMenuCategoria]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuCategoria'
CREATE INDEX [IX_FK_ItemMenuCategoria]
ON [dbo].[ItemMenus]
    ([CategoriaId]);
GO

-- Creating foreign key on [Pedidoes_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_Pedido]
    FOREIGN KEY ([Pedidoes_Id])
    REFERENCES [dbo].[Pedidoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenus_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenus_Id])
    REFERENCES [dbo].[ItemMenus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoItemMenu_ItemMenu'
CREATE INDEX [IX_FK_PedidoItemMenu_ItemMenu]
ON [dbo].[PedidoItemMenu]
    ([ItemMenus_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[Pessoas]
    ([Morada_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'Restaurantes'
ALTER TABLE [dbo].[Restaurantes]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Moradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[Restaurantes]
    ([Morada_Id]);
GO

-- Creating foreign key on [Id] in table 'Pessoas_Trabalhador'
ALTER TABLE [dbo].[Pessoas_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoas_Cliente'
ALTER TABLE [dbo].[Pessoas_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------