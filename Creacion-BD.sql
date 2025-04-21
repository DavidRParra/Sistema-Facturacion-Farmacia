CREATE DATABASE FACTURACION_FARMACIA;

USE FACTURACION_FARMACIA;

drop table CATEGORIA;
drop Database FACTURACION_FARMACIA;

CREATE TABLE CLIENTE (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    Cedula_rnc VARCHAR(20) DEFAULT(NULL),
    Telefono VARCHAR(15),
    Direccion VARCHAR(MAX) DEFAULT(NULL),
    Email VARCHAR(60) DEFAULT(NULL),
    Fecha_Ingreso DATE DEFAULT(GETDATE())
);

CREATE TABLE LABORATORIO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(60) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Direccion VARCHAR(MAX) NOT NULL
);

CREATE TABLE EMPLEADO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(30) NOT NULL,
    Cedula VARCHAR(20) NOT NULL UNIQUE,
    Telefono VARCHAR(15) NOT NULL,
    Direccion VARCHAR(MAX) NOT NULL,
    Email VARCHAR(60) NOT NULL,
    Fecha_Ingreso DATE DEFAULT(GETDATE())
);

CREATE TABLE CATEGORIA (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE PROVEEDOR (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ID_Laboratorio INT NOT NULL,
    Nombre VARCHAR(60) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Direccion VARCHAR(MAX) NOT NULL,
    Email VARCHAR(60) NOT NULL,
    FOREIGN KEY (ID_Laboratorio) REFERENCES LABORATORIO(ID)
);

CREATE TABLE USUARIO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ID_Empleado INT NOT NULL UNIQUE,
    Usuario VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(40) NOT NULL,
    Rol VARCHAR(20) NOT NULL,
    Nivel INT NOT NULL,
    FOREIGN KEY (ID_Empleado) REFERENCES EMPLEADO(ID)
);

CREATE TABLE PRODUCTO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ID_Categoria INT NOT NULL,
    ID_Laboratorio INT NOT NULL,
    Nombre VARCHAR(70) NOT NULL,
    Codigo_Barra VARCHAR(60) NOT NULL UNIQUE,
    Descripcion VARCHAR(MAX) NOT NULL,
    Precio_Compra DECIMAL(10,2) NOT NULL,
    Precio_Venta DECIMAL(10,2) NOT NULL,
    ITBIS BIT NOT NULL,
    Stock_Actual INT NOT NULL,
    Fecha_Vencimiento DATE NOT NULL,
    Controlado BIT NOT NULL,
    FOREIGN KEY (ID_Categoria) REFERENCES CATEGORIA(ID),
    FOREIGN KEY (ID_Laboratorio) REFERENCES LABORATORIO(ID)
);

CREATE TABLE RECETA_MEDICA (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ID_Cliente INT,
    Medico VARCHAR(100) NOT NULL,
    Institucion VARCHAR(100) NOT NULL,
    Foto_Receta VARCHAR(MAX) NOT NULL,
    Fecha_Emision DATE NOT NULL,
    FOREIGN KEY (ID_Cliente) REFERENCES CLIENTE(ID)
);

CREATE TABLE FACTURA (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ID_Cliente INT,
    ID_Receta_Medica INT,
    Fecha DATE DEFAULT(GETDATE()),
    Total DECIMAL(10,2),
    ITBIS DECIMAL(10,2),
    Descuento DECIMAL(10,2),
    Metodo_Pago VARCHAR(30) NOT NULL,
    RNC VARCHAR(20),
    ID_Usuario INT NOT NULL,
    FOREIGN KEY (ID_Cliente) REFERENCES CLIENTE(ID),
    FOREIGN KEY (ID_Receta_Medica) REFERENCES RECETA_MEDICA(ID),
    FOREIGN KEY (ID_Usuario) REFERENCES USUARIO(ID)
);

CREATE TABLE DETALLE_FACTURA (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ID_Factura INT NOT NULL,
    ID_Producto INT NOT NULL,
    Cantidad INT NOT NULL,
    Precio_Unitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (ID_Factura) REFERENCES FACTURA(ID),
    FOREIGN KEY (ID_Producto) REFERENCES PRODUCTO(ID)
);

INSERT INTO CLIENTE (Nombre, Apellido, Cedula_rnc, Telefono, Direccion, Email)
VALUES
('Juan', 'Pérez', '001-1234567-8', '809-555-1212', 'Calle Principal #123, La Vega', 'juan.perez@email.com'),
('María', 'Gómez', '002-2345678-9', '829-555-3434', 'Av. Central #45, Concepción de La Vega', 'maria.gomez@email.com'),
('Carlos', 'Rodríguez', NULL, '849-555-5656', 'Calle Secundaria #789, Jarabacoa', 'carlos.rodriguez@email.com'),
('Ana', 'Martínez', '003-3456789-0', '809-666-7878', 'Residencial Los Robles, La Vega', 'ana.martinez@email.com'),
('Pedro', 'Sánchez', NULL, '829-666-9090', 'Carretera Duarte Km 5, Santiago', 'pedro.sanchez@email.com'),
('Laura', 'Fernández', '004-4567890-1', '849-777-1212', 'Calle Las Flores #10, Constanza', 'laura.fernandez@email.com'),
('Miguel', 'Díaz', NULL, '809-777-3434', 'Sector Villa Rosa, La Vega', 'miguel.diaz@email.com'),
('Sofía', 'López', '005-5678901-2', '829-888-5656', 'Av. Pedro Rivera, Bonao', 'sofia.lopez@email.com'),
('Javier', 'Ramírez', NULL, '849-888-7878', 'Calle El Sol #22, Moca', 'javier.ramirez@email.com'),
('Isabel', 'Torres', '006-6789012-3', '809-999-9090', 'Urb. La Primavera, La Vega', 'isabel.torres@email.com');

INSERT INTO LABORATORIO (Nombre, Telefono, Direccion)
VALUES
('Laboratorios Alfa', '809-555-1001', 'Av. Independencia #100, Santo Domingo'),
('Laboratorios Beta', '809-555-1002', 'Calle Duarte #45, Santiago'),
('Farmacéutica Gama', '809-555-1003', 'Av. 27 de Febrero #23, Santo Domingo'),
('BioSalud RD', '809-555-1004', 'Calle Mella #67, La Vega'),
('Laboratorio Omega', '809-555-1005', 'Zona Franca, San Cristóbal'),
('MedicRD', '809-555-1006', 'Av. Libertad #99, San Pedro de Macorís'),
('NaturalPharma', '809-555-1007', 'Parque Industrial, Moca'),
('GenPharm', '809-555-1008', 'Calle Restauración #11, Bonao'),
('Salud Vital', '809-555-1009', 'Av. Las Américas, Santo Domingo Este'),
('DomiLab', '809-555-1010', 'Calle Principal #88, Higüey');

INSERT INTO EMPLEADO (Nombre, Apellido, Cedula, Telefono, Direccion, Email)
VALUES
('Luis', 'Ramírez', '001-1234567-1', '809-111-1001', 'Calle 1, Santo Domingo', 'luis.ramirez@email.com'),
('Carmen', 'Fernández', '002-2345678-2', '809-111-1002', 'Calle 2, Santiago', 'carmen.fernandez@email.com'),
('José', 'Martínez', '003-3456789-3', '809-111-1003', 'Av. Bolívar #12, La Vega', 'jose.martinez@email.com'),
('Patricia', 'Gómez', '004-4567890-4', '809-111-1004', 'Zona Norte, San Cristóbal', 'patricia.gomez@email.com'),
('Miguel', 'López', '005-5678901-5', '809-111-1005', 'Residencial Ana, Moca', 'miguel.lopez@email.com'),
('Laura', 'Santos', '006-6789012-6', '809-111-1006', 'Barrio Nuevo, Bonao', 'laura.santos@email.com'),
('Pedro', 'Morales', '007-7890123-7', '809-111-1007', 'Calle 5, Constanza', 'pedro.morales@email.com'),
('Sandra', 'Torres', '008-8901234-8', '809-111-1008', 'Urbanización Caribe, Higüey', 'sandra.torres@email.com'),
('Andrés', 'Castillo', '009-9012345-9', '809-111-1009', 'Calle Las Rosas #9, Santiago', 'andres.castillo@email.com'),
('Valeria', 'Núñez', '010-0123456-0', '809-111-1010', 'Av. Central, San Pedro de Macorís', 'valeria.nunez@email.com'),
('ADMIN', 'admin', '000-0000000-0', '0000000000', 'admin #admin', 'admin@admin.admin');

INSERT INTO CATEGORIA (Nombre)
VALUES
('Medicamentos Generales'),
('Suplementos Alimenticios'),
('Productos de Higiene'),
('Cosméticos'),
('Equipos Médicos'),
('Vitamínicos'),
('Productos Naturales'),
('Productos Farmacéuticos de Venta Libre'),
('Vitaminas y Minerales'),
('Productos Herbolarios');

INSERT INTO PROVEEDOR (ID_Laboratorio, Nombre, Telefono, Direccion, Email)
VALUES
(1, 'Proveedores Farma S.A.', '809-555-2001', 'Calle Principal #10, Santo Domingo', 'proveedorA@email.com'),
(2, 'Salud y Bienestar S.A.', '809-555-2002', 'Av. Duarte #23, Santiago', 'proveedorB@email.com'),
(3, 'Distribuidora Médica RD', '809-555-2003', 'Calle 4, La Vega', 'proveedorC@email.com'),
(4, 'Productos de Higiene RD', '809-555-2004', 'Calle 5, Moca', 'proveedorD@email.com'),
(5, 'Vitamínicos Globales', '809-555-2005', 'Zona Industrial #11, San Cristóbal', 'proveedorE@email.com'),
(6, 'Farmacéutica del Caribe', '809-555-2006', 'Av. Las Américas #77, Santo Domingo Este', 'proveedorF@email.com'),
(7, 'Distribuidora Natural', '809-555-2007', 'Calle Libertad #5, Bonao', 'proveedorG@email.com'),
(8, 'Cosméticos y Farma', '809-555-2008', 'Calle Central #8, Higüey', 'proveedorH@email.com'),
(9, 'Medicamentos RD', '809-555-2009', 'Calle Las Flores #3, Constanza', 'proveedorI@email.com'),
(10, 'Farmacéutica Internacional', '809-555-2010', 'Calle 3, San Pedro de Macorís', 'proveedorJ@email.com'),
(1, 'FarmaPlus', '809-555-2011', 'Calle 9, Santiago', 'proveedorK@email.com'),
(2, 'Laboratorios La Vega', '809-555-2012', 'Av. Independencia #19, Santo Domingo', 'proveedorL@email.com'),
(3, 'Productos Naturales RD', '809-555-2013', 'Calle 7, La Vega', 'proveedorM@email.com'),
(4, 'Distribución de Salud', '809-555-2014', 'Av. Duarte #15, Moca', 'proveedorN@email.com'),
(5, 'Medicinas RD', '809-555-2015', 'Calle 6, San Cristóbal', 'proveedorO@email.com'),
(6, 'PharmaCielo', '809-555-2016', 'Calle 2, Santo Domingo Este', 'proveedorP@email.com'),
(7, 'Cosméticos y Salud', '809-555-2017', 'Calle 4, Bonao', 'proveedorQ@email.com'),
(8, 'Herbolarios de RD', '809-555-2018', 'Av. Las Américas #45, Higüey', 'proveedorR@email.com'),
(9, 'FarmaPlus Dominicana', '809-555-2019', 'Calle 8, Constanza', 'proveedorS@email.com'),
(10, 'Salud RD', '809-555-2020', 'Calle Principal #12, San Pedro de Macorís', 'proveedorT@email.com');

INSERT INTO PRODUCTO (ID_Categoria, ID_Laboratorio, Nombre, Codigo_Barra, Descripcion, Precio_Compra, Precio_Venta, ITBIS, Stock_Actual, Fecha_Vencimiento, Controlado)
VALUES
(1, 1, 'Paracetamol 500mg', '1234567890123', 'Analgésico y antipirético', 10.00, 20.00, 0.18, 150, '2025-12-31', 0),
(1, 2, 'Ibuprofeno 400mg', '1234567890124', 'Antiinflamatorio', 12.00, 25.00, 0.18, 120, '2026-01-15', 0),
(2, 3, 'Vitamina C 1000mg', '1234567890125', 'Suplemento vitamínico', 8.00, 15.00, 0.18, 200, '2025-11-30', 0),
(3, 4, 'Jabón Líquido Antibacterial', '1234567890126', 'Jabón líquido para el baño', 5.00, 10.00, 0.18, 500, '2025-07-10', 0),
(4, 5, 'Crema Hidratante', '1234567890127', 'Crema para piel seca', 20.00, 40.00, 0.18, 80, '2025-09-10', 0),
(2, 6, 'Omega 3', '1234567890128', 'Suplemento de ácidos grasos', 15.00, 30.00, 0.18, 100, '2025-10-25', 0),
(1, 7, 'Aspirina 100mg', '1234567890129', 'Antiinflamatorio y analgésico', 7.00, 14.00, 0.18, 180, '2025-08-01', 0),
(3, 8, 'Multivitamínico', '1234567890130', 'Suplemento de vitaminas y minerales', 12.00, 25.00, 0.18, 250, '2026-02-20', 0),
(5, 9, 'Termómetro Digital', '1234567890131', 'Termómetro para medir temperatura corporal', 50.00, 100.00, 0.18, 60, '2027-05-30', 1),
(6, 10, 'Cinta Elástica', '1234567890132', 'Cinta para soporte de lesiones deportivas', 7.00, 15.00, 0.18, 75, '2026-06-15', 1),
(4, 1, 'Shampoo Anticaspa', '1234567890133', 'Shampoo para tratar la caspa', 9.00, 18.00, 0.18, 150, '2025-08-20', 0),
(3, 2, 'Colágeno', '1234567890134', 'Suplemento para mejorar la piel', 25.00, 50.00, 0.18, 120, '2026-03-10', 0),
(1, 3, 'Amoxicilina 500mg', '1234567890135', 'Antibiótico', 10.00, 20.00, 0.18, 300, '2025-09-25', 0),
(5, 4, 'Curitas', '1234567890136', 'Vendaje adhesivo para heridas pequeñas', 1.00, 3.00, 0.18, 500, '2025-07-05', 0),
(2, 5, 'Zinc', '1234567890137', 'Suplemento mineral', 5.00, 10.00, 0.18, 400, '2025-12-01', 0),
(1, 6, 'Clindamicina 300mg', '1234567890138', 'Antibiótico para infecciones', 9.00, 18.00, 0.18, 200, '2025-10-05', 0),
(4, 7, 'Desodorante Antitranspirante', '1234567890139', 'Desodorante para protección todo el día', 6.00, 12.00, 0.18, 300, '2025-08-12', 0),
(2, 8, 'Vitamina D3', '1234567890140', 'Suplemento vitamínico', 5.00, 10.00, 0.18, 150, '2025-11-01', 0),
(6, 9, 'Bandas de Kinesiología', '1234567890141', 'Bandas elásticas para rehabilitación', 8.00, 16.00, 0.18, 200, '2026-05-10', 1),
(3, 10, 'Biotina', '1234567890142', 'Suplemento para el cabello', 20.00, 40.00, 0.18, 180, '2025-12-15', 0),
(1, 1, 'Losartán 50mg', '1234567890143', 'Antihipertensivo', 15.00, 30.00, 0.18, 200, '2025-10-22', 0),
(5, 2, 'Gasa Esterilizada', '1234567890144', 'Material para vendajes y curaciones', 3.00, 6.00, 0.18, 400, '2025-09-12', 0),
(4, 3, 'Crema Anticelulitis', '1234567890145', 'Crema para reducir la celulitis', 18.00, 36.00, 0.18, 100, '2026-01-25', 0),
(2, 4, 'Ácido Fólico', '1234567890146', 'Suplemento para mujeres embarazadas', 6.00, 12.00, 0.18, 500, '2026-07-20', 0),
(1, 5, 'Ciprofloxacino 500mg', '1234567890147', 'Antibiótico', 8.00, 16.00, 0.18, 300, '2025-08-01', 0),
(3, 6, 'Ácido Ascórbico', '1234567890148', 'Suplemento de vitamina C', 7.00, 14.00, 0.18, 200, '2025-10-30', 0),
(6, 7, 'Rodillera de Compresión', '1234567890149', 'Rodillera para lesiones deportivas', 12.00, 24.00, 0.18, 150, '2026-04-05', 1),
(5, 8, 'Crema Para Quemaduras', '1234567890150', 'Crema para aliviar quemaduras leves', 10.00, 20.00, 0.18, 100, '2025-09-10', 0),
(2, 9, 'Magnesio', '1234567890151', 'Suplemento mineral', 4.00, 8.00, 0.18, 400, '2025-12-12', 0),
(4, 10, 'Gel Antibacterial', '1234567890152', 'Gel para desinfección de manos', 3.00, 6.00, 0.18, 500, '2026-01-10', 0),
(3, 1, 'Ácido Hialurónico', '1234567890153', 'Suplemento para la piel', 15.00, 30.00, 0.18, 100, '2025-11-20', 0),
(1, 2, 'Loratadina 10mg', '1234567890154', 'Antialérgico', 9.00, 18.00, 0.18, 250, '2025-10-15', 0),
(5, 3, 'Vendaje Elástico', '1234567890155', 'Vendaje para esguinces y torceduras', 5.00, 10.00, 0.18, 300, '2025-07-05', 0),
(2, 4, 'Suplemento de Calcio', '1234567890156', 'Suplemento mineral', 6.00, 12.00, 0.18, 200, '2025-11-01', 0),
(6, 5, 'Muletas', '1234567890157', 'Muletas de apoyo para la movilidad', 25.00, 50.00, 0.18, 50, '2027-06-25', 1),
(1, 6, 'Cefalexina 500mg', '1234567890158', 'Antibiótico', 8.00, 16.00, 0.18, 350, '2025-09-15', 0),
(4, 7, 'Crema para Rozaduras', '1234567890159', 'Crema para piel irritada', 4.00, 8.00, 0.18, 450, '2025-07-25', 0),
(2, 8, 'Vitamina B12', '1234567890160', 'Suplemento vitamínico', 10.00, 20.00, 0.18, 250, '2025-11-30', 0),
(3, 9, 'Proteína en Polvo', '1234567890161', 'Suplemento para deportistas', 20.00, 40.00, 0.18, 120, '2026-02-05', 0),
(5, 10, 'Inhalador', '1234567890162', 'Dispositivo para asma', 15.00, 30.00, 0.18, 100, '2027-03-15', 1),
(1, 2, 'Ranitidina 150mg', '1234567890163', 'Antihistamínico para problemas gástricos', 7.00, 14.00, 0.18, 220, '2025-10-20', 0),
(3, 3, 'Ginseng', '1234567890164', 'Suplemento energético natural', 12.00, 24.00, 0.18, 150, '2026-04-10', 0),
(4, 4, 'Loción Corporal', '1234567890165', 'Loción para hidratación corporal', 8.00, 16.00, 0.18, 250, '2025-09-30', 0),
(6, 5, 'Silla de Ruedas', '1234567890166', 'Silla de ruedas estándar', 100.00, 200.00, 0.18, 30, '2027-02-25', 1),
(5, 6, 'Guantes de Examinación', '1234567890167', 'Guantes de látex para exámenes médicos', 4.00, 8.00, 0.18, 350, '2025-06-15', 0),
(1, 7, 'Tetrahidrozolina 0.05%', '1234567890168', 'Gotas oftálmicas', 5.00, 10.00, 0.18, 200, '2025-07-05', 0),
(3, 8, 'Proteína Vegetal', '1234567890169', 'Suplemento de proteínas a base de plantas', 22.00, 45.00, 0.18, 120, '2026-03-10', 0),
(2, 9, 'Bromelina', '1234567890170', 'Suplemento digestivo', 10.00, 20.00, 0.18, 180, '2025-08-25', 0),
(4, 10, 'Aceite Esencial de Lavanda', '1234567890171', 'Aceite esencial para relajación y aromaterapia', 15.00, 30.00, 0.18, 100, '2026-01-12', 0),
(6, 1, 'Andador Médico', '1234567890172', 'Andador de aluminio para asistencia en movilidad', 50.00, 100.00, 0.18, 40, '2027-04-30', 1);

insert into USUARIO(ID_Empleado, Usuario, Password, Rol, Nivel)
values
(11, 'admin', 'admin', 'Administrador', 0);

select * from USUARIO