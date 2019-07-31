select L.Carro as 'ID',
	   C.Modelo,
	   COUNT(L.Carro) as 'Quantidade'
from Locacao L
	inner join Carros C on L.Carro = C.Id_Carro
	inner join Clientes CL on L.ClienteAloc = CL.Id
GROUP BY L.Carro, C.Modelo
-- O CARRO MAIS ALOCADO ANUALMENTE FOI O FOCUS.


select COUNT(Carro) as 'Quantidade',
	   YEAR(DatInc) as 'Ano'
from Locacao
GROUP BY YEAR(DatInc)
-- FORAM ALOCADOS 17 CARROS EM 2019.


select COUNT(Carro) as 'Quantidade',
	   MONTH(DatInc) as 'Mês'	   
from Locacao 
GROUP BY MONTH(DatInc)
-- Relatório Mensal.
