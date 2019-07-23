select Nome from Marcas where UsuInc = 1;
--Trazer somente as marcas que Felipe cadastrou

select Nome from Marcas where UsuInc = 2;
--Trazer somente as marcas que Giomar cadastrou

select Count(Nome) as 'Marcas Felipe' from Marcas where UsuInc = 1
order by 'Marcas Felipe' desc;
--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor

select Count(Nome) as 'Marcas Giomar' from Marcas where UsuInc = 2
order by 'Marcas Giomar' asc;
--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior

select Count(Nome) as 'Total Marcas' from Marcas where UsuInc between 1 and 2;
--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 

select Modelo as 'Carros Felipe' from Carros 
where UsuInc = 1;
--Trazer somente os carros que Felipe cadastrou

select Modelo as 'Carros Giomar' from Carros 
where UsuInc = 2;
--Trazer somente os carros que Giomar cadastrou

select Count(Modelo) as 'Qtde Carros Felipe' from Carros where UsuInc = 1
order by 'Qtde Carros Felipe' desc;
--Trazer somente a quantidade de carros que Felipe cadastrou do maior para menor

select Count(Modelo) as 'Qtde Carros Giomar' from Carros where UsuInc = 2
order by 'Qtde Carros Giomar' asc;
--Trazer somente a quantidade de carros que Giomar cadastrou do menor para maior

select Count(Modelo) as 'Qtde Carros Total' from Carros where UsuInc between 1 and 2;
--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 

select CA.Marca, MA.Nome, CA.Modelo from Carros CA
inner join Marcas MA on CA.Marca = MA.Id
where MA.UsuInc = 1;
--Trazer somente os carros das marcas que Felipe cadastrou

select CA.Marca, MA.Nome, CA.Modelo from Carros CA
inner join Marcas MA on CA.Marca = MA.Id
where MA.UsuInc = 2;
--Trazer somente os carros das marcas que Giomar cadastrou

select Count(CA.Marca) as 'Qtde Carros Marcas Felipe' from Carros CA
inner join Marcas MA on CA.Marca = MA.Id
where MA.UsuInc = 1
order by 'Qtde Carros Marcas Felipe' asc;
--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor

select Count(CA.Marca) as 'Qtde Carros Marcas Giomar' from Carros CA
inner join Marcas MA on CA.Marca = MA.Id
where MA.UsuInc = 2
order by 'Qtde Carros Marcas Giomar' desc;
-- Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior

select SUM(Valor * Quantidade) as 'Vendas'
	   from Vendas
where YEAR(DatInc) = '2019';
--Trazer o valor total de vendas 2019 isolado

select SUM(Quantidade) as 'Qtde Vendas 2019' from Vendas
where YEAR(DatInc) = '2019';
--Trazer a quantidade total de vendas 2019 isolado

select SUM(Valor * Quantidade) as 'Total $ Vendas',
	   YEAR(DatInc) as 'Ano'
	   from Vendas
	group by YEAR(DatInc)
	order by 'Total $ Vendas' desc;
--Trazer o valor total de vendas em cada ano e ordernar do maior para o menor

select SUM(Quantidade) as 'Qtde Vendas',
	   YEAR(DatInc) as 'Ano'
	   from Vendas
	group by YEAR(DatInc)
	order by 'Qtde Vendas' desc;
--Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor

select SUM(Quantidade) as 'Qtde Vendas',
	   MONTH(DatInc) as 'Mês',
	   YEAR(DatInc) as 'Ano'
	   from Vendas
	   group by MONTH(DatInc), YEAR(DatInc)
	   order by 'Qtde Vendas' desc;
--Trazer o mês de cada ano que retornou a maior quantidade de vendas
		-- Tradução "Retornar agrupado por mês e ordernar do maior para menor"

select SUM(Valor * Quantidade) as 'Valor Vendido',
	   MONTH(DatInc) as 'Mês',
	   YEAR(DatInc) as 'Ano'
	   from Vendas
	group by MONTH(DatInc), YEAR(DatInc)
	order by 'Valor Vendido' desc;
--Trazer o mês de cada ano que retornou o maior valor de vendas
		-- Tradução "Retornar agrupado por mês e ordernar do maior para menor"

select SUM(Valor * Quantidade) as 'Total Vendido Felipe' from Vendas where UsuInc = 1;
--Trazer o valor total de vendas que Felipe realizou

select SUM(Valor * Quantidade) as 'Total Vendido Giomar' from Vendas where UsuInc = 2;
--Trazer o valor total de vendas que Giomar realizou

select SUM(Quantidade) as 'Qtde Vendas Felipe' from Vendas where UsuInc = 1;
--Trazer a quantidade total de vendas que Felipe realizou

select SUM(Quantidade) as 'Qtde Vendas Giomar' from Vendas where UsuInc = 2;
--Trazer a quantidade total de vendas que Giomar realizou

select SUM(Quantidade) as 'Qtde Total Vendas' from Vendas where UsuInc between 1 and 2
order by 'Qtde Total Vendas' desc;
--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select SUM(Valor * Quantidade) as 'Valor x Quantidade' from Vendas where UsuInc between 1 and 2
order by SUM(Valor * Quantidade) desc;
--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select SUM(V.Valor * V.Quantidade) as 'Total Vendido Marca', MA.Nome, YEAR(V.DatInc) as 'Ano' from Vendas V
inner join Carros CA on V.Carro = CA.Id
inner join Marcas MA on CA.Marca = MA.Id 
group by MA.Nome, YEAR(V.DatInc)
order by 'Total Vendido Marca' desc;
--Trazer a marca mais vendida de todos os anos
		-- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"

select SUM(V.Valor * V.Quantidade) as 'Total Vendido Marca', MA.Nome from Vendas V
inner join Carros CA on V.Carro = CA.Id
inner join Marcas MA on CA.Marca = MA.Id
group by MA.Nome
order by 'Total Vendido Marca' desc;
--Trazer o valor total da marca mais vendida de todos os anos

select CA.Modelo, SUM(V.Quantidade) as 'Quantidade' from Vendas V
inner join Carros CA on V.Carro = CA.Id
group by CA.Modelo
order by SUM(V.Quantidade) desc;
--Trazer a quantidade do carro mais vendido de todos os anos

select V.Carro, CA.Modelo, V.Valor * V.Quantidade  as 'Total Carro' from Vendas V
inner join Carros CA on V.Carro = CA.Id
group by V.Carro, CA.Modelo, V.Valor * V.Quantidade
order by V.Valor * V.Quantidade desc;
--Trazer o valor do carro mais vendido de todos os anos


