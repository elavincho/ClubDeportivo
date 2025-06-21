DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE roles(
RolUsuario INT,
NombreRol VARCHAR(30),
CONSTRAINT PRIMARY KEY(RolUsuario)
);

INSERT INTO roles VALUES
(120,'ADMIN'),
(121,'Empleado');

CREATE TABLE usuarios(
CodigoUsuario INT AUTO_INCREMENT,
NombreUsuario VARCHAR (20),
PasswordUsuario VARCHAR (15),
RolUsuario INT,
Activo BOOLEAN DEFAULT TRUE,
CONSTRAINT pk_usuario PRIMARY KEY (CodigoUsuario),
CONSTRAINT fk_usuario FOREIGN KEY(RolUsuario) references roles(RolUsuario)
);

INSERT INTO usuarios(CodigoUsuario,NombreUsuario,PasswordUsuario,RolUsuario) VALUES
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

-- Tabla AptoFisico
CREATE TABLE AptoFisico (
    idAptoFisico INT PRIMARY KEY AUTO_INCREMENT,
    numeroSocio INT NOT NULL,
    nombreMedico VARCHAR(20) NOT NULL,
    matricula VARCHAR(20) NOT NULL,
    esApto VARCHAR(20) NOT NULL,
    vtoAptoFisico DATE NOT NULL,
    CONSTRAINT UQ_AptoFisico_numeroSocio UNIQUE (numeroSocio)
);

-- Tabla Pagos
CREATE TABLE Pagos (
    idCuota INT PRIMARY KEY AUTO_INCREMENT,
    nroComprobante INT NOT NULL,
    numeroSocio INT NOT NULL,
    tipo VARCHAR(20),
    actividad VARCHAR(50),
    importe DECIMAL(10,2),
    metodoPago VARCHAR(20),
    cuotas INT,
    fechaPago DATE,
    vencimiento DATE,
    FOREIGN KEY (numeroSocio) REFERENCES socios(numeroSocio)
);


/* PROCEDIMIENTO ALMACENADO */
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

delimiter //  
CREATE PROCEDURE IngresoLogin(IN Usuario VARCHAR(20), IN Pass VARCHAR(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
BEGIN
  /* Proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  SELECT NombreRol
	FROM usuarios u INNER JOIN roles r ON u.RolUsuario = r.RolUsuario
		WHERE NombreUsuario = Usuario AND PasswordUsuario = Pass /* se compara con los parametros */
			AND Activo = 1; /* el usuario debe estar activo */
END 
//

/* ==========================
Si queremos probar el procedure se usa call
====================================================== */

CALL IngresoLogin('dato1', 'dato2')//

/* ===============================
Si los datos de los parametros existen la consulta arroja 1 FILA
Si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */