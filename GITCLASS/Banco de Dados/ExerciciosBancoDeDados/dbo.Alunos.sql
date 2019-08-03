CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Nome] VARCHAR(100) NOT NULL,
	[Turma] INT NOT NULL,
	[Ativo] BIT NOT NULL, 
    CONSTRAINT [FK_Alunos_Turmas] FOREIGN KEY ([Turma]) REFERENCES [Turmas]([Id])
	
)