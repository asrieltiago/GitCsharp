INSERT INTO pessoas
(Nome, Nascimento, Sexo, Peso, Altura, Nacionalidade)
values
('John', '1975-04-01', 'M', 85.90, 2.15, 'EUA'),
('Enzo', '2014-02-01', 'M', 30.60, 1.30, 'EUA'),
('Jared', '2013-07-06', 'M', 32.90, 1.15, 'Canada'),
('Valentina', '2015-04-01', 'F', 30.50, 1.20, 'Italia');
go
select * from pessoas;