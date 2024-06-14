create database PuntodeVenta
use PuntodeVenta
create table Persona(
	id int identity primary key not null,
	nombre nvarchar(250),
	apellidos nvarchar(250),
	dni nvarchar(250),
	telefono nvarchar(250),
	usuario nvarchar(250),
	contrasena nvarchar(250)
)

insert into Persona values ('Eduardo','Alfaro','123-456','506-888','eafch','admin')
insert into Persona values ('Maria','Hernandez','789-101','506-666','majo','123456')
insert into Persona(nombre,dni,telefono,usuario,contrasena) values ('Tym','111-000','506-1010','tym','admin')
insert into Persona values ('Jorge','Quesada','666-111','506-666','blackwolf','555')
select * from Persona

create table Inventario(
	Id int identity primary key not null,
	Producto nvarchar(250) not null,
	Categoria nvarchar(250) not null,
	Precio float not null,
	Cantidad int not null
	)

alter table Inventario add Codigo nvarchar(100)

insert into Inventario values ('Mouse','Perfecto',10,50,'MP1'),('Teclado','Perfecto',20,50,'TP3'),('Monitor 1c1','Componente',200,10,'M1C4'),
('Monitor 2c1','Componente',250,5,'M1C6'),('Procesador i9','Componente',600,10,'PC7'),('RAM 8GB TB','Memoria',60,20,'R8GB8'),('Headset','Perifericos',120,5,'HP9'),
('Laptop TB mod1','Computadora',1500,5,'LTBMC10'),('RGB Luces para PC','Accesorios',10,10,'RLA11')

select * from Inventario

Create Table Clientes(
ID int identity primary key,
NombreCliente nvarchar(250),
ApellidoCliente nvarchar(250),
TelefonoCliente nvarchar(250),
CorreoC nvarchar(250),
CodigoCliente nvarchar(250),
Descuento float,
CantCompras int
)

insert into Clientes values ('Eduardo','Alfaro','1326546','ealfaro@hotmail.com','ed01',0.5,10),('Jorge','Quesada','6546866','jquesada@hotmail.com','jq26',0,0),
('Alexander','Chacón','9498435','achacon@hotmail.com','ac94',0,0),('Bryan','Archia','1205665','barchia@hotmail.com','ba12',0,0)

select * from Clientes

create table Facturacion(
	ID int identity primary key,
	Codigo Nvarchar(250),
	Producto Nvarchar(250),
	PrecioxUnidad float,
	Cantidad int,
	Cliente Nvarchar(250),
	CodigoCliente Nvarchar(250),
	DescuentoCliente float,
	MontoTotal float,
	NumFactura Nvarchar(250)
)

Alter Table Facturacion add PrecioTotal as (PrecioxUnidad*Cantidad)
Alter Table Facturacion drop column CodigoCliente
Alter Table Facturacion add Descuento float

select * from Facturacion

Select (Select distinct top 1 NumFactura from Facturacion order by NumFactura desc)+1

Select NombreCliente + ' '+ ApellidoCliente as Nombre, Descuento from Clientes where CodigoCliente=''

INSERT INTO Facturacion (Codigo, Producto, PrecioxUnidad, Cantidad, Descuento, Cliente, DescuentoCliente, MontoTotal, NumFactura) VALUES ('MP1','Mouse',10,2,0,'Eduardo Alfaro',0,5,65,4,3)
