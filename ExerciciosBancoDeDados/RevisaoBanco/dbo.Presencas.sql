CREATE TABLE [dbo].[Presencas] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [Diario] INT NOT NULL,
    [Aluno]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Presenca_Diarios] FOREIGN KEY ([Diario]) REFERENCES [dbo].[Diarios] ([Id]),
    CONSTRAINT [FK_Presenca_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UC_Presenca_Insert]
    ON [dbo].[Presencas]([Diario] ASC, [Aluno] ASC);

