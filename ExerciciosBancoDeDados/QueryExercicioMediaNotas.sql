select 

	AL.Nome,
	TM.Disciplina,
	Sum(NT.Nota) as 'Soma Notas',	
	(Sum(NT.Nota) / 4) as 'Media',
	IIF(Sum(NT.Nota) / COUNT(NT.NOTA) >= 7 and (COUNT(NT.Presenca) >= 3), 'Aprovado', 'Reprovado') as 'Status'
	
	from Alunos AL	
inner join Notas NT on AL.Id = NT.Aluno
inner join Turmas TM on TM.Id = AL.Turma
group by AL.Nome, TM.Disciplina
