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

create table usuario(
CodigoUsuario int auto_increment,
NombreUsuario varchar (20),
PasswordUsuario varchar (15),
RolUsuario int,
Activo boolean default true,
constraint pk_usuario primary key (CodigoUsuario),
constraint fk_usuario foreign key(RolUsuario) references roles(RolUsuario)
);

insert into usuario(CodigoUsuario,NombreUsuario,PasswordUsuario,RolUsuario) values
(1,'Ema2025','123456',120);
