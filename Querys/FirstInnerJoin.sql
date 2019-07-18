select
	     LV.Id, -- ID do Livro
         LV.nome as 'Nome Livro' , -- Nome do Livro
		 IIF (LV.Alocado = 1, 'Sim','Não') as 'Alocado',
		 BL.Nome as 'Nome Biblioteca' -- Nome da Biblioteca
from Biblioteca BL  -- Pai
inner join Livros LV on BL.Id= LV.Biblioteca -- BL e LV são novas IDs denominadas para as Data Bases
-- INNER JOIN traz SOMENTE os registros que possuem alguma relação com a outra planilha
--caso queira trazer TODOS os registros, mesmo que não existam na outra coluna, usamos o LEFT JOIN

select
	     Livros.Id, -- ID do Livro
         Livros.nome as 'Nome Livro' , -- Nome do Livro
		 IIF (Livros.Alocado = 1, 'Sim','Não') as 'Alocado',
		 Biblioteca.Nome as 'Nome Biblioteca' -- Nome da Biblioteca
from Biblioteca  -- Pai
inner join Livros on Biblioteca.Id= Livros.Biblioteca

select
	     BL.Nome,
		 COUNT(LV.Id) as 'QuantidadeDeLivros'
		 from Biblioteca BL  -- Pai
inner join Livros LV on BL.Id= LV.Biblioteca 
Group by BL.Nome


select
	     BL.Nome,
		 COUNT(LV.Id) as 'QuantidadeDeLivros',
		 US.Nome as 'UserName'

from Biblioteca BL  -- Pai
inner join Livros LV on BL.Id= LV.Biblioteca 
inner join Usuario US on LV.UsuInc = US.id
Group by BL.Nome, US.Nome