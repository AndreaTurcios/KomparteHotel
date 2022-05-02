--LEER
--Video de ayuda
--https://www.youtube.com/watch?v=_H8vswpMSOw
Use dbkomparte;

create procedure MostrarEmpleados
as
select * from empleado
go

exec MostrarEmpleados;

/**
Vista a mostrar
-ID
-Usuario
-Position
-Email
-Estado
-TipoEmpleado
-Hotel
*/


/***************************************/
select * from empleado

select 
		emp.ID_empleado as ID, 
		emp.nombre_usuario as Usuario,
		emp.nombre_empleado as Nombre , 
		emp.correo as Correo,
		emp.DUI_empleado as DUI,
		emp.telefono as Telefono,
		emp.direccion as Direccion,
		(select emp_e.estado from estado_empleado emp_e where emp_e.ID_estado_empleado = emp.pk_estado_empleado) as Estado,
		(select emp_t.tipo_empleado from tipo_empleado emp_t where emp_t.ID_tipo_empleado = emp.pk_tipo_empleado) as Rol,
		(select emp_h.encargado_hotel from hotel emp_h where emp_h.ID_hotel=emp.pk_hotel_empleado) as Rol
from empleado as emp 

select * from estado_empleado;
select emp_e.estado from estado_empleado emp_e where emp_e.ID_estado_empleado = 1 ;

select * from tipo_empleado;
select emp_t.tipo_empleado from tipo_empleado emp_t where emp_t.ID_tipo_empleado = 1;

select * from hotel;
select emp_h.encargado_hotel from hotel emp_h where emp_h.ID_hotel=1;


/***********************Vista */
create or alter view view_all_empleados 
as
select 
		emp.ID_empleado as ID, 
		emp.nombre_usuario as Usuario,
		emp.nombre_empleado as Nombre , 
		emp.correo as Correo,
		emp.DUI_empleado as DUI,
		emp.telefono as Telefono,
		emp.direccion as Direccion,
		(select top 1 emp_e.estado from estado_empleado emp_e where emp_e.ID_estado_empleado = emp.pk_estado_empleado) as Estado,
		(select top 1 emp_t.tipo_empleado from tipo_empleado emp_t where emp_t.ID_tipo_empleado = emp.pk_tipo_empleado) as Rol,
		(select top 1 emp_h.encargado_hotel from hotel emp_h where emp_h.ID_hotel=emp.pk_hotel_empleado) as Cargo
from empleado as emp
go


select * from view_all_empleados;

/******************Procedimiento Empleado**************/
/*
Ver  todos los empleados 
*/

create procedure proc_all_empleados
as
select * from view_all_empleados;
go

exec proc_all_empleados;


create procedure proc_create_empleado
@nombre varchar(30),
@usuario varchar(35),
@contrasenia varchar(35),
@dui varchar(30),
@telefono varchar(30),
@direccion varchar(30),
@correo varchar(50),
@pk_estado int,
@pk_rol int,
@pk_cargo int
as
insert into empleado values (@nombre, @usuario, @contrasenia, @dui, @telefono, @direccion, @correo, @pk_estado, @pK_rol, @pk_cargo)	
go

exec proc_create_empleado 'Eduardo','Eduardo91','123456789','0123456789','7463-2720','Casa','eduardo@gmail.com',1,1,1
go

create procedure proc_edit_empleado
@nombre varchar(30),
@usuario varchar(35),
@contrasenia varchar(35),
@dui varchar(30),
@telefono varchar(30),
@direccion varchar(30),
@correo varchar(50),
@pk_estado int,
@pk_rol int,
@pk_cargo int,
@id int
as
update empleado set
					nombre_empleado = @nombre,
					nombre_usuario = @usuario,
					contrasenia_usuario	= @contrasenia,
					DUI_empleado = @dui,
					telefono = @telefono,
					direccion = @direccion,
					correo = @correo,
					pk_estado_empleado = @pk_estado,
					pk_tipo_empleado = @pk_cargo,
					pk_hotel_empleado = @pk_cargo
where ID_empleado = @id
go

exec proc_edit_empleado 'EduardoProcedure','Eduardo91','123456789','0123456789','7463-2720','Casa','eduardo@gmail.com',1,1,1,7

create procedure proc_one_empleado
@id int
as
select * from empleado where ID_empleado = @id;
go

exec proc_one_empleado 7
go

select * from tipo_empleado
select * from tipo_empleado where ID_tipo_empleado = 1
go

select * from estado_empleado;
select * from estado_empleado where ID_estado_empleado = 1;
go


create procedure proc_delete_empleado
@id int
as
delete empleado where ID_empleado = @id;
go

exec proc_delete_empleado 12


/*********************************************************************/
/*********************************************************************/
/**************************Cliente ***********************************/
select * from cliente;
select * from hotel;
select * from estado_cliente;

create or alter view view_all_cliente 
as
select 
	cli.ID_cliente as ID,
	cli.nombre_cliente as Nombre,
	cli.DUI_cliente as DUI,
	cli.telefono AS Telefono,
	cli.direccion as Direccion,
	cli.correo as Correo,
	(select estado from estado_cliente where ID_estado_cliente = cli.pk_estado_cliente) as Estado,
	(select emp_h.encargado_hotel from hotel emp_h where emp_h.ID_hotel = cli.pk_hotel_cliente) as Hotel
from cliente as cli

select estado from estado_cliente where ID_estado_cliente =1;

select * from hotel;
select emp_h.encargado_hotel from hotel emp_h where emp_h.ID_hotel=1;

select * from view_all_cliente;

create procedure proc_all_clientes
as
select * from view_all_cliente;
go

exec proc_all_clientes

create procedure proc_create_cliente
@nombre varchar(30),
@dui varchar(30),
@telefono varchar(30),
@direccion varchar(30),
@correo varchar(50),
@pk_estado int,
@pk_hotel int
as
insert into cliente values(@nombre, @dui, @telefono, @direccion, @correo, @pk_estado, @pk_hotel)
go

exec proc_create_cliente 'Erick', '789456123', '2000-0000', 'Casa', 'eduarod@dominico.com',1,1


create procedure proc_one_cliente
@id int
as
select * from cliente where ID_cliente = @id;
go


exec proc_one_cliente 1
go

create procedure pro_edit_cliente
@nombre varchar(30),
@dui varchar(30),
@telefono varchar(30),
@direccion varchar(30),
@correo varchar(50),
@pk_estado int,
@pk_hotel int,
@id int
as
update cliente set
					nombre_cliente = @nombre,
					DUI_cliente= @dui,
					telefono = @telefono,
					direccion = @direccion,
					correo = @correo,
					pk_estado_cliente = @pk_estado,
					pk_hotel_cliente = @pk_hotel
where ID_cliente = @id
go

exec proc_all_clientes
exec pro_edit_cliente 'Erick2', '123456789', '2020-2020', 'Casa', 'eduarod@dominico.com',1,1,1

/*********************************************************************/
/*********************************************************************/
/**************************Estado Cliente*****************************/
select * from estado_cliente;

create procedure proc_create_estado_cliente

as
insert into estado_cliente values(@estado)
go

exec proc_create_estado_cliente 'cansado'



create procedure proc_edit_estado_cliente
@estado varchar(30),
@id int
as
update estado_cliente set
					estado = @estado
where ID_estado_cliente = @id
go

exec proc_edit_estado_cliente 'procedure', 3


create procedure proc_delete_estado_cliente
@id int
as
delete from estado_cliente 
where ID_estado_cliente = @id
go

exec proc_delete_estado_cliente 3
go

select * from estado_cliente where ID_estado_cliente = 1; 