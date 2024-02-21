
Create database PruebaTec02EYCDDB

Use PruebaTec02EYCDDB

create table Directores (
IdDirectores int primary key identity (1,1),
Nombre varchar (100),
Nacionalidad VARCHAR(100),
FechaNacimiento DATE
)

create table Peliculas (
IdPelicula INT PRIMARY KEY identity (1,1),
Titulo VARCHAR(300) NOT NULL,
Imagen varbinary (max),
Sinopsis varchar (max),
AnioLanzamiento INT,
Genero Varchar (100),
IdDirectores int foreign key references Directores (IdDirectores)
)