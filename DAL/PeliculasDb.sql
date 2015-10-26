create database RegistroPeliculaDb;
use RegistroPeliculaDb;

create table Peliculas(
PeliculaId int identity(1,1),
Titulo varchar(50),
Descripcion varchar(100),
Ano int,
Calificacion int,
IMDB int,
CategoriaId int,
Imagen varchar(200),
Video varchar(200),
Estudio varchar(50)
);

select *from Peliculas

