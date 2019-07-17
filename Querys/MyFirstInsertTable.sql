insert into dbo.AulaCsharp
	(Aluno, Idade, Ativo, UsuInsc, UsuAlt, DatInc, DatAlt)
	values
	('Maria', 29, 1, 1, 1, GETDATE(), GETDATE())
	go
	select * from AulaCsharp