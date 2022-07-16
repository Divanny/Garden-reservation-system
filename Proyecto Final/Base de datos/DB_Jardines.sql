create database jardines;
use jardines;

/* Tabla usuarios */
drop table if exists usuario;
create table usuario (
	id int not null primary key auto_increment,
    nombre varchar(15) not null,
    apellido varchar(15) not null,
    username varchar(20) not null unique,
    correo varchar(50) not null unique,
    contraseña longtext,
    fecha_nacimiento date,
    fecha_registro datetime,
    pregunta_seguridad text,
    rol enum ('U', 'A')
);

insert into usuario (nombre, apellido, username, correo, contraseña, fecha_nacimiento, fecha_registro, pregunta_seguridad, rol) values ('Emil', 'Solano', 'E1000', 'emilsolano@gmail.com', 'admin12345', '2003-08-16', '2022-07-15 08:03:02', 'Doki', 'A');
insert into usuario (nombre, apellido, username, correo, contraseña, fecha_nacimiento, fecha_registro, pregunta_seguridad, rol) values ('Divanny', 'Perez', 'Divanny', 'divannyjpm@gmail.com', 'admin12345', '2004-06-01', '2022-07-15 08:03:02', 'Chiqui', 'A');
insert into usuario (nombre, apellido, username, correo, contraseña, fecha_nacimiento, fecha_registro, pregunta_seguridad, rol) values ('Ronnie', 'Difo', 'ridifo', 'ridifo@gmail.com', 'admin12345', '2003-10-12', '2022-07-15 08:03:02', 'Toby', 'A');

select * from usuario;

/* Tabla ------------*/
