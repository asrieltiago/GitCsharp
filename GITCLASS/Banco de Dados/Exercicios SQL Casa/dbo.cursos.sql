CREATE TABLE [dbo].[cursos] (
	[Id]		INT	PRIMARY KEY IDENTITY(1,1),
    [nome]      VARCHAR (30) NOT NULL,
    [descricao] TEXT         NULL,
    [carga]     INT          NULL,
    [totaulas]  INT          NULL,
    [ano]       VARCHAR (4)  DEFAULT ('2016') NULL,
    UNIQUE NONCLUSTERED ([nome] ASC)
);

