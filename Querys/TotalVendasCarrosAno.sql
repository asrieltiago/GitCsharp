select 
		Modelo,
		Ano,
		(SUM(Vendas)) as 'Total Vendas',
		(SUM(Vendas) / COUNT (*)) as 'Media Vendas',
		YEAR(DataVenda) as 'Ano Venda'
	from TabelaCarros	
	where YEAR(DataVenda) = 2019
	group by MODELO, ANO, YEAR(DataVenda)
	order by MODELO asc
