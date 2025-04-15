CREATE DATABASE FACTURACION_FARMACIA;

USE FACTURACION_FARMACIA;

--Tablas independientes
create table ClIENTE(
    ID int primary key identity(1,1),
    Nombre varchar(20) not null,
    Apellido varchar(20) not null,
    Cedula_rnc varchar(20) default(null),
    Telefono varchar(15),
    Direccion text default(null),
    Email varchar(60) default(null),
    Fecha_Ingreso date default(getdate())
);

create table Laboratorio(
    ID int primary key identity(1,1),
    Nombre varchar(60) not null,
    Telefono varchar(15) not null,
    Direccion text not null
);

create table EMPLEADO(
    ID int primary key identity(1,1),
    Nombre varchar(20) not null,
    Apellido varchar(30) not null,
    Cedula varchar(20) not null,
    Telefono varchar(15) not null,
    Direccion text not null,
    Email varchar(60) not null,
    Fecha_Ingreso date default(getdate())
);

create table CATEGORIA(
ID int Primary key identity(1,1),
Nombre varchar(50) not null
);

--Tablas dependientes
create Table PROVEEDOR(
    ID int primary key identity(1,1),
    ID_Laboratorio int not null,
    Nombre varchar(60) not null,
    Telefono varchar(15) not null,
    Direccion text not null,
    Email varchar(60) not null,
    foreign key (ID_Laboratorio) references LABORATORIO (ID)
);

create table USUARIO(
    ID int primary key identity(1,1),
    ID_Empleado int not null,
    Usuario varchar(20) not null,
    Password varchar(40) not null,
    Rol varchar(20) not null,
    Nivel int not null
    foreign key (ID_Empleado) references EMPLEADO(ID)
);

create table PRODUCTO(
    ID int primary key identity(1,1),
    ID_Categoria int not null,
    ID_Laboratorio int not null,
    Nombre varchar(70) not null,
    Codigo_Barra varchar(60) not null,
    Descripcion text not null,
    Precio_Compra decimal(10,2) not null,
    Precio_Venta decimal(10,2) not null,
    ITBIS bit not null,
    Stock_Actual int not null,
    Fecha_Vencimiento date not null,
    Controlado bit not null,
    foreign key (ID_Categoria) references CATEGORIA(ID),
    foreign key (ID_Laboratorio) references LABORATORIO (ID)
)

create table RECETA_MEDICA(
    ID int primary key identity(1,1),
    ID_Cliente int,
    Medico varchar(100) not null,
    Institucion varchar(100) not null,
    Foto_Receta text not null,
    Fecha_Emision date not null
    foreign key (ID_Cliente) references CLIENTE (ID)
);

create table FACTURA(
    ID int primary key identity(1,1),
    ID_Cliente int,
    ID_Receta_Medica int,
    Fecha date default(getdate()),
    total decimal(10,2),
    ITBIS decimal(10,2),
    Descuento decimal(10,2),
    Metodo_Pago varchar(30) not null,
    RNC varchar(20)not null,
    ID_Usuario int not null,
    foreign key (ID_Cliente) references CLIENTE (ID),
    foreign key (ID_Receta_Medica) references RECETA_MEDICA (ID),
    foreign key (ID_Usuario) references USUARIO (ID)
);

create table DETALLE_FACTURA(
    ID int primary key identity(1,1),
    ID_Factura int not null,
    ID_Producto int not null,
    Cantidad int not null,
    Precio_Unitario decimal(10,2) not null,
    Subtotal decimal(10,2) not null,
    foreign key (ID_Factura) references FACTURA (ID),
    foreign key (ID_Producto) references PRODUCTO (ID)
);