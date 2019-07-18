select 
		Tipo,
		SUM(Vendas) as 'Total Vendas',
		MONTH(DataVenda) as 'Mês Venda'
from FoodTruckZezinho
where MONTH(DataVenda) BETWEEN 4 AND 6 -- Traz somente as informações ENTRE os meses selecionados
group by Tipo, MONTH(DataVenda)
order by 'Total Vendas' desc



--select 'Total' as 'Dogao',
--			SUM(Temp.Total) as 'Vendas',
--			Temp.MesVenda
--		from (select
--					Tipo,
--					Vendas,
--					(SUM(Vendas)) as 'Total',
--					MONTH(DataVenda) as 'MesVenda'
--				from FoodTruckZezinho	
--			group by Tipo, Vendas, MONTH(DataVenda)) Temp
--	group by Temp.MesVenda


