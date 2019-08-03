select 
		Tipo,
		Vendas,
		MONTH(DataVenda) as 'Mês Venda'

	from FoodTruckZezinho
	group by Tipo, Vendas, MONTH(DataVenda)
	order by MONTH(DataVenda) asc




select 'Dogao' as 'Dogao',
			SUM(Temp.Total) as 'Vendas',
			Temp.MesVenda
		from (select
					Tipo,
					Vendas,
					(SUM(Vendas)) as 'Total',
					MONTH(DataVenda) as 'MesVenda'
				from FoodTruckZezinho	
			group by Tipo, Vendas, MONTH(DataVenda)) Temp
	group by Temp.MesVenda


