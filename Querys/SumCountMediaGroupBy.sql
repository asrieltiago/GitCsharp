select 
		Nome,
		Materia,
		(Sum(Nota) / COUNT(Nota)) as 'Media', -- soma todas as notas de cada Nome e divide pelo número de provas
		COUNT(Nota) as 'Prova' -- conta o número de provas realizadas
from NotaAluno
GROUP BY Nome,Materia -- Agrupa por identificadores comuns
order by Nome asc -- Ordena de forma ascendente