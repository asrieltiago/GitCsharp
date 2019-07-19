CREATE TABLE [dbo].[Notas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Aluno] INT NOT NULL,
	[Nota] INT NOT NULL, 
	[Presenca] BIT NOT NULL

	CONSTRAINT [FK_Nota_To_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [Alunos]([Id])

)
