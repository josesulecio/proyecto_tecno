CREATE DATABASE CRUD
USE CRUD
CREATE TABLE USUARIOS(
Usuario int PRIMARY KEY NOT NULL,
contraseña varchar(25),
Rol varchar(25)
);
INSERT INTO USUARIOS VALUES ('2006','Christian','Sandoval','10','Administrador');
INSERT INTO USUARIOS VALUES ('2005','Daniel','Juarez','20','Secretaria'); 
INSERT INTO USUARIOS VALUES ('2007','Jose','Barrios','07','Usuario'); 

drop table USUARIOS

CREATE TABLE USUARIOS(
ID int primary key not null,
nombre varchar(25),
apellido varchar(25),
contraseña varchar(25),
rol varchar(25),
);
create table Datos(
id int primary key not null,
nombre varchar (25),
apellido varchar (25),
edad varchar (25),
correo varchar (25),
);

INSERT INTO Datos VALUES ('2008','Jose','Barrios','18','jose@gmail.com'); 
INSERT INTO Datos VALUES ('2023','Jose','Barrios','17','jose@gmail.com'); 

drop table Datos