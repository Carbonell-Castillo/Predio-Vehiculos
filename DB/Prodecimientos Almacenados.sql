/*addCliente*/
create procedure addCliente
@DPI varchar(30),
@nombre varchar(30),
@direccion varchar(30),
@telefono varchar(10),
@NIT varchar(13)
as 
insert into cliente(DPI, nombre, direccion, telefono, NIT)
values(@DPI, @nombre, @direccion,@telefono, @NIT);
go;

/*addVehiculo*/
create procedure addVehiculo
@placa char(30),
@DPI char(13),
@modelo int,
@nCilindros int,
@marca char(30)
as 
insert into vehiculo(placa, DPI, modelo, nCilindros, marca)
values(@placa, @DPI, @modelo, @nCilindros, @marca);
go;

/*verClientes*/
create procedure verClientes
as 
select * from cliente;
go;

/*verVehiculos*/
create procedure verVehiculos
as
select vehiculo.DPI, nombre, direccion, telefono, placa, modelo, nCilindros as cilindros, marca
from vehiculo inner join cliente
on vehiculo.DPI = cliente.DPI;
go;

/*verVehiculoMarca*/
create procedure verVehiculoMarca
@marca char(30)
as
select vehiculo.DPI, nombre, direccion, telefono, placa, modelo, nCilindros as cilindros, marca
from vehiculo inner join cliente
on vehiculo.DPI = cliente.DPI
where marca like @marca;
go;

/*verVehiculoModelo*/
create procedure verVehiculoModelo
@inicio int,
@final int
as
select vehiculo.DPI, nombre, direccion, telefono, placa, modelo, nCilindros as cilindros, marca
from vehiculo inner join cliente
on vehiculo.DPI = cliente.DPI
where modelo >=@inicio and modelo<=@final;
go;

/*verVehiculoPropetario*/
create procedure verVehiculoPropetario
@nombre varchar(30)
as
select vehiculo.DPI, nombre, direccion, telefono, placa, modelo, nCilindros as cilindros, marca
from vehiculo inner join cliente
on vehiculo.DPI = cliente.DPI
where nombre like @nombre;
go;

