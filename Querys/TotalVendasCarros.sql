select 
		Modelo,
		Ano,
		(SUM(Vendas)) as 'Total Vendas',
		(SUM(Vendas) / COUNT (*)) as 'Media Vendas',
		YEAR(DataVenda) as 'Ano Venda'
	from TabelaCarros	
	group by MODELO, ANO, YEAR(DataVenda)
	order by MODELO asc
