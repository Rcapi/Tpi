
DROP DATABASE IF EXISTS Ferreteria;
CREATE database Ferreteria;
USE Ferreteria;

CREATE TABLE Usuario (
    Dni VARCHAR(10) PRIMARY KEY,
	Clave VARCHAR(50) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NULL,
    Telefono VARCHAR(20) NULL,
    Direccion VARCHAR(100) NULL,
    Ciudad VARCHAR(50) NULL

);


CREATE TABLE Cliente (
    NroCli INT IDENTITY(1,1) PRIMARY KEY,
    Dni VARCHAR(10) NOT NULL,
    FOREIGN KEY (Dni) REFERENCES Usuario(Dni)
);

CREATE TABLE Administrador (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Dni VARCHAR(10) NOT NULL,
    FOREIGN KEY (Dni) REFERENCES Usuario(Dni)
);

CREATE TABLE Empleado (
    Legajo INT IDENTITY(1,1) PRIMARY KEY,
	Dni VARCHAR(10) NOT NULL,
    FOREIGN KEY (Dni) REFERENCES Usuario(Dni)
);

CREATE TABLE Proveedor (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(40) NOT NULL,
    Email VARCHAR(100) NULL,
    Telefono VARCHAR(20) NULL,
    Direccion VARCHAR(100) NULL,
    Ciudad VARCHAR(50) NULL,
);

CREATE TABLE Producto (
    Codigo VARCHAR(30) PRIMARY KEY,
    Nombre VARCHAR(40) NOT NULL,
    Descripcion VARCHAR(255) NULL,
    Precio FLOAT NULL,
    Stock INT NULL
);


CREATE TABLE Herramienta (
    Modelo VARCHAR(30),
    Codigo VARCHAR(30),
    FOREIGN KEY (Codigo) REFERENCES Producto(Codigo),
	PRIMARY KEY (Modelo, Codigo)
);

CREATE TABLE EquipoDeSeguridad (
    Talle VARCHAR(5),
    Codigo VARCHAR(30),
	Peso FLOAT NULL,
	TipoEquipo VARCHAR(50) NULL,
	Normativa VARCHAR(50) NULL,
    PRIMARY KEY (Talle, Codigo),
    FOREIGN KEY (Codigo) REFERENCES Producto(Codigo)
);

CREATE TABLE ElementoDeSujecion (
    TipoElemento VARCHAR(30),
	Codigo VARCHAR(30),
	Longitud FLOAT NULL,
	Capacidad FLOAT NULL,
    PRIMARY KEY (TipoElemento, Codigo),
    FOREIGN KEY (Codigo) REFERENCES Producto(Codigo)
);

CREATE TABLE MaterialDeConstruccion (
    Marca VARCHAR(30),
    Codigo VARCHAR(30),
	Medidas VARCHAR(15) NULL,
	TipoMaterial VARCHAR(30) NULL,
    PRIMARY KEY (Marca, Codigo),
    FOREIGN KEY (Codigo) REFERENCES Producto(Codigo)
);

CREATE TABLE HerramientaManual (
    Tipo VARCHAR(50),
    Modelo VARCHAR(30),
    Codigo VARCHAR(30),
    PRIMARY KEY (Tipo, Modelo, Codigo),
    FOREIGN KEY (Modelo, Codigo) REFERENCES Herramienta(Modelo, Codigo)
);

CREATE TABLE HerramientaElectrica (
    Potencia VARCHAR(50),
    Modelo VARCHAR(30),
	Codigo VARCHAR(30),
    PRIMARY KEY (Potencia, Modelo),
    FOREIGN KEY (Modelo, Codigo) REFERENCES Herramienta(Modelo, Codigo)
);

CREATE TABLE Ventas (
    NumeroVenta INT IDENTITY(1,1) PRIMARY KEY
);

INSERT INTO Usuario (Dni, Clave, Nombre, Apellido, Email, Telefono, Direccion, Ciudad)
VALUES ('12345678', '1234','NombreUsuario', 'ApellidoUsuario', 'correo@example.com', '1234567890', 'DirecciónUsuario', 'CiudadUsuario');


INSERT INTO Cliente (Dni)
VALUES ('12345678');

INSERT INTO Usuario (Dni, Clave, Nombre, Apellido, Email, Telefono, Direccion, Ciudad)
VALUES ('87654321', 'asd', 'sss', 'aaa', 'mail@example.com', '1311313131', 'Direc', 'Ciu');


INSERT INTO Cliente (Dni)
VALUES ('87654321');

select * from Usuario;
select * from Cliente;
