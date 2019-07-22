CREATE TABLE [dbo].[pessoas] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Nome]          VARCHAR (30)   NOT NULL,
    [Nascimento]    DATE           NOT NULL,
    [Profissao]     VARCHAR (20)   NULL,
    [Sexo]          VARCHAR (1)    NOT NULL,
    [Peso]          DECIMAL (5, 2) NULL,
    [Altura]        DECIMAL (3, 2) NULL,
    [Nacionalidade] VARCHAR (20)   DEFAULT ('BRASIL') NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Sexo]='F' OR [Sexo]='M')
);

