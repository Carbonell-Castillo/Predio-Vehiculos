create table cliente(
	DPI varchar(13),
	nombre varchar(30),
	direccion varchar(30),
	telefono varchar(10),
	NIT varchar(13)
)

create table vehiculo(
	placa char(30) primary key,
	DPI char(13),
	modelo int,
	nCilindros int,
	marca char(30)
)
/*Modelo de char a int*/
alter table vehiculo alter column modelo int(4);

