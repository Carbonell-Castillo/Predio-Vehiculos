/*Ejecutar procedimientos*/

/*Añadir cliente*/
exec addCliente
@DPI ='123456789456',
@nombre ='Alexander Lemus',
@direccion ='zona 11, 6ta calle',
@telefono ='56789789',
@NIT = '1234567891345';

/*Añadir vehiculo*/
exec addVehiculo
@placa = '1y8uy',
@DPI= '123456789456',
@modelo= '2000',
@nCilindros =4,
@marca= 'Mazda';

/*ver cliente*/
exec verClientes;

/*Ver vehiculos*/
exec verVehiculos;

/*Ver vehiculo marca*/
exec verVehiculoMarca
@marca = '%hon%';

/*Ver vehiculo modelo*/
exec verVehiculoModelo
@inicio=2000,
@final=2004;

/*Ver Vehiculo propetario*/
exec verVehiculoPropetario
@nombre='J%';

