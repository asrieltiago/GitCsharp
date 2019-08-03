select 'Carros' as 'Carros',
			SUM(Temp.Media) as 'Vendas',
			Temp.AnoVenda
		from (select
					Modelo,
					Ano,
					(SUM(Vendas) / COUNT (*)) as 'Media',
					YEAR(DataVenda) as 'AnoVenda'
				from TabelaCarros	
			group by MODELO, ANO, YEAR(DataVenda)) Temp
	group by Temp.AnoVenda
