select TURMAS.Nome as 'Turma',
		ALUNOS.Aluno as 'Aluno'
from Turmas TURMAS
	inner join TurmaAlunos TA on TA.Id = TA.Turma
	inner join Alunos A on TA.Aluno = A.Id
-- Trago todos os alunos da turma
select 
	D.[Data],
	TA.Aluno,
	ISNULL(N.Nota,0) as 'Nota',
	IIF(ISNULL(P.Id,0) > 0, 'Presente', 'Ausente') as 'Presenças'	

	from Diarios D 
	inner join TurmaAlunos TA on d.Turma = TA.Turma
	left join Presencas P on D.Id = P.Diario and TA.Aluno = P.Aluno
	left join Notas N on TA.Aluno = N.Aluno and D.Id = N.Diario