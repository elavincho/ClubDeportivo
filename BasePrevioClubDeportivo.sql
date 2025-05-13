drop database if exists Previoproyecto;
create database Previoproyecto;
use Previoproyecto;

create table roles(
RolUsuario int,
NombreRol varchar(30),
constraint primary key(RolUsuario)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuarios(
CodigoUsuario int auto_increment,
NombreUsuario varchar (20),
PasswordUsuario varchar (15),
RolUsuario int,
Activo boolean default true,
constraint pk_usuario primary key (CodigoUsuario),
constraint fk_usuario foreign key(RolUsuario) references roles(RolUsuario)
);

insert into usuarios(CodigoUsuario,NombreUsuario,PasswordUsuario,RolUsuario) values
(1,'Ema2025','123456',120);


-- Tabla Persona (base para Socio)
CREATE TABLE Personas (
    idPersona INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    tipoDocumento VARCHAR(20) NOT NULL,
    nroDocumento VARCHAR(20) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    email VARCHAR(30) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    CONSTRAINT UQ_Personas_nroDocumento UNIQUE (nroDocumento)
);

-- Tabla Socios (hereda de Persona)
CREATE TABLE Socios (
    idSocio INT PRIMARY KEY AUTO_INCREMENT,
    idPersona INT NOT NULL,
    numeroSocio INT NOT NULL,
    tipoSocio VARCHAR(20) NOT NULL,
    fechaAlta DATE NOT NULL DEFAULT (CURRENT_DATE),
    fechaPago DATE NOT NULL,
    estadoCuota VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Socios_Personas FOREIGN KEY (idPersona) REFERENCES Personas(idPersona),
    CONSTRAINT UQ_Socios_numeroSocio UNIQUE (numeroSocio),
    CONSTRAINT UQ_Socios_idPersona UNIQUE (idPersona)
);