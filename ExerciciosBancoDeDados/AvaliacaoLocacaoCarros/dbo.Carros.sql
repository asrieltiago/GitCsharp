CREATE TABLE [dbo].[Carros]
(
	[Id_Carro] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Modelo] VARCHAR(50) NOT NULL, 
    [Marca] VARCHAR(20) NOT NULL,
    [Ano] VARCHAR(4) NOT NULL,
	[Ativo] BIT NOT NULL,
	[UsuInclusao] INT NOT NULL,
    [UsuAlt] INT NOT NULL,
    [DatInclusao] DATE NOT NULL,
    [DatAlt] DATE NOT NULL,
	CONSTRAINT [FK_Carros_Usuarios_Inc] FOREIGN KEY ([UsuInclusao]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Carros_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
)
