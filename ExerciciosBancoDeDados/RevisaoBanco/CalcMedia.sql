select 
		A.Aluno,
		SUM(N.Nota) / COUNT(d.[Data])

from Alunos A
		inner join TurmaAlunos TA on A.Id = TA.Aluno
		inner join Diarios D on TA.Turma = D.Turma
		left join Notas N on D.Id = N.Diario and A.Id = N.Aluno
	where TA.Turma = 1

group by A.Aluno