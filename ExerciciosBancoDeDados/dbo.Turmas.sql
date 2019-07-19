CREATE TABLE [dbo].[Turmas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Disciplina] VARCHAR(50) NOT NULL,
	[DataInicio] DATE NOT NULL,
	[DataFim] DATE NOT NULL,
	[Ativo] BIT NOT NULL,
	[Observacao] VARCHAR(300) NULL
)
