create database Biblioteca;
GO

use Biblioteca;
GO

create table Libro
(
codigo_libro bigint primary key,
nombre_libro nvarchar(255),
estado_libro nvarchar(255) default 'no prestado'
);
GO

INSERT INTO Libro (codigo_libro, nombre_libro)
VALUES
    (9783141338404, 'El Gran Gatsby'),
    (9788420656464, 'Cien años de soledad'),
    (9788426416658, 'Matar a un ruiseñor'),
    (9780452284234, '1984'),
    (9780061120084, 'To Kill a Mockingbird'),
    (9788437607172 , 'Don Quijote de la Mancha'),
    (9788420656136, 'La Odisea'),
    (9780451526837, 'Hamlet'),
    (9781847494140, 'Orgullo y prejuicio'),
    (9780261102551, 'El Hobbit');
GO

create table Estudiante
(
codigo_estudiante int primary key,
nombre_estudiante nvarchar(255),
telefono_estudiante bigint
);
GO

INSERT INTO Estudiante (codigo_estudiante, nombre_estudiante, telefono_estudiante)
VALUES
    (1, 'Juan', 3123456789),
    (2, 'María', 3156789012),
    (3, 'Carlos', 3001234567),
    (4, 'Ana', 3178901234),
    (5, 'Luis', 3145678901),
    (6, 'Laura', 3102345678),
    (7, 'Pedro', 3137890123),
    (8, 'Isabel', 3114567890),
    (9, 'Miguel', 3189012345),
    (10, 'Sofía', 3190123456);
GO

create table Prestamo
(
codigo_prestamo int primary key identity,
codigo_libro bigint,
codigo_estudiante int,
constraint fk_prestamo_libro
foreign key (codigo_libro) references Libro(codigo_libro),
constraint fk_prestamo_estudiante
foreign key (codigo_estudiante) references Estudiante(codigo_estudiante)
);
GO

create table Usuario
(
codigo_usuario int primary key identity,
nombre_usuario nvarchar(255),
contraseña_usuario nvarchar(255),
rol_usuario nvarchar(255)
);
GO

INSERT INTO Usuario ( nombre_usuario, contraseña_usuario, rol_usuario)
VALUES
    ('John', 'clave123', 'Administrador libros'),
    ('Emily', 'segura456', 'Adminsitrador libros'),
    ('Michael', 'mipassword', 'Administrador libros'),
    ('Jennifer', 'contraseña1', 'Administrador libros'),
    ('David', 'segura123', 'Administrador libros'),
    ('Sophia', 'miclave', 'Administrador estudiantes'),
    ('James', 'password123', 'Administrador estudiantes'),
    ('Olivia', 'contraseña2', 'Administrador estudiantes'),
    ('Daniel', 'segura789', 'Administrador estudiantes'),
    ('Isabella', 'miclave123', 'Administrador estudiantes');
GO
