CREATE DATABASE EGRESADOS
GO

USE EGRESADOS
GO

-- TABLAS DE LA BASE DE DATOS--

create table Usuarios(
    UsuarioID int identity(1,1) primary key,
    NombreUsuario nvarchar(100) unique not null,
    Contrasena nvarchar(100) not null,
    CorreoElectronico nvarchar(150) not null
)
GO

CREATE TABLE CarreraProfesional
(
    CodigoCarreraProfesional INT IDENTITY(1,1) PRIMARY KEY,
    NombreCarrera VARCHAR(90) NOT NULL,
    DescripcionCarrera VARCHAR(200) NOT NULL
)
GO

CREATE TABLE NivelesInformativo
(
    CodigoNivelInformativo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(30) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL
)
GO
CREATE TABLE EntregaTitulo
(
    CodigoTitulo INT IDENTITY(1,1) PRIMARY KEY,
    VerificacionTitulo VARCHAR(20) NOT NULL
)
GO
CREATE TABLE TipoTitulo
(
    CodigoTipoTitulo INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL
)
GO
CREATE TABLE Egresados
(
    CodigoMinedu VARCHAR(50) PRIMARY KEY,
    CodigoNInformativo INT NOT NULL,
    CodigoCarreraProfesional INT ,
    CodigoTitulo INT NOT NULL,
    CodigoTipoTitulo INT NOT NULL,
    Dni VARCHAR(8) NOT NULL,
    Nombres VARCHAR(70) NOT NULL,
    Apellidos VARCHAR(70) NOT NULL,
    FechaRegistro DATE NOT NULL,
    FOREIGN KEY (CodigoNInformativo) REFERENCES NivelesInformativo(CodigoNivelInformativo),
    FOREIGN KEY (CodigoCarreraProfesional) REFERENCES CarreraProfesional(CodigoCarreraProfesional),
    FOREIGN KEY (CodigoTitulo) REFERENCES EntregaTitulo(CodigoTitulo),
    FOREIGN KEY (CodigoTipoTitulo) REFERENCES TipoTitulo(CodigoTipoTitulo),
)
GO

-- --------- PROCEDIMIENTOS DE LA TABLA USUARIO -------------------

--PROCEDIMIENTO DE INSERTAR USARIO
CREATE PROC insertarusuario
    @NombreUsuario NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @CorreoElectronico NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Usuarios (NombreUsuario, Contrasena, CorreoElectronico) 
    VALUES (@NombreUsuario, @Contrasena, @CorreoElectronico);
END
GO

-- DE VALIDAR USUARIO
CREATE PROCEDURE sp_ValidarUsuario
    @NombreUsuario NVARCHAR(100),
    @Contrasena NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Contar si existe un usuario con el nombre de usuario y contraseña dados
    SELECT COUNT(1) 
    FROM Usuarios
    WHERE NombreUsuario = @NombreUsuario
      AND Contrasena = @Contrasena;
END
GO

-- DE RECUPERACION DE CONTRASEÑA
CREATE PROCEDURE Sp_RecuperacionContrasena
    @NombreUsuario NVARCHAR(100),  -- Permitir nulo
    @CorreoElectronico NVARCHAR(100)  -- Permitir nulo
AS
BEGIN
    SET NOCOUNT ON;

    SELECT NombreUsuario, CorreoElectronico, Contrasena 
	FROM Usuarios WHERE NombreUsuario = @NombreUsuario 
	OR CorreoElectronico = @CorreoElectronico
END
GO
-- --------- PROCEDIMIENTOS DE LA TABLA CARRERAS PROFESIONAL -------------------
-- INSERTAR CARRERAR PROFESIONAL
CREATE PROC insertarcarreras
    @NombreCarrera VARCHAR(90),
    @DescripcionCarrera VARCHAR(200)
AS
BEGIN
    INSERT INTO CarreraProfesional(NombreCarrera,DescripcionCarrera) 
    VALUES (@NombreCarrera, @DescripcionCarrera);
END
GO
-- MODIFICAR CARRERA PROFESIONAL
CREATE PROC modificarcarreras
    @CodigoCarreraProfesional INT,  -- ID de la carrera a modificar
    @NombreCarrera VARCHAR(90),
    @DescripcionCarrera VARCHAR(200)
AS
BEGIN
    -- Actualizar la carrera con el ID proporcionado
    UPDATE CarreraProfesional
    SET NombreCarrera = @NombreCarrera,
        DescripcionCarrera = @DescripcionCarrera
    WHERE CodigoCarreraProfesional = @CodigoCarreraProfesional;
END
GO
-- ELIMINAR CARRERA PROFESIONAL
CREATE PROC eliminarcarreras
    @CodigoCarreraProfesional INT
AS
BEGIN
    DELETE FROM CarreraProfesional
    WHERE CodigoCarreraProfesional = @CodigoCarreraProfesional;
END
GO
--CONSULTAR CARRERA PROFESIONAL
CREATE PROC consularcarrera
@CodigoCarreraProfesional int
AS
BEGIN
    SELECT CodigoCarreraProfesional,NombreCarrera,DescripcionCarrera
    FROM CarreraProfesional
    WHERE CodigoCarreraProfesional= @CodigoCarreraProfesional
END
GO
-- VEREFICAR CARRERA PROFESIONAL 
CREATE PROC verificarcarreras
AS
BEGIN
SELECT CodigoCarreraProfesional AS "Codigo Carrera", NombreCarrera AS "Carrera", DescripcionCarrera AS "Descripcion" FROM CarreraProfesional
END 
GO
-- --------- PROCEDIMIENTOS DE LA TABLA NIVELES INFORMATIVOS -------------------
--CONSULTAR NIVELES INFORMATIVOS
CREATE PROC insertarnivelesinformativos
    @Nombre VARCHAR(30),
    @Descripcion VARCHAR(200)
AS
BEGIN
    INSERT INTO NivelesInformativo(Nombre,Descripcion) 
    VALUES (@Nombre, @Descripcion);
END
GO
-- MODIFICAR NIVELES INFORMATIVOS
CREATE PROC modificarnivelesinformativos
    @CodigoNivelInformativo INT,  -- ID de la carrera a modificar
    @Nombre VARCHAR(30),
    @Descripcion VARCHAR(200)
AS
BEGIN
    -- Actualizar la carrera con el ID proporcionado
    UPDATE NivelesInformativo
    SET Nombre = @Nombre,
        Descripcion = @Descripcion
    WHERE CodigoNivelInformativo = @CodigoNivelInformativo;
END
GO
-- ELIMINAR NIVELES INFORMATIVOS
CREATE PROC eliminarnivelesinformativos
    @CodigoNivelInformativo INT
AS
BEGIN
    DELETE FROM NivelesInformativo
    WHERE CodigoNivelInformativo = @CodigoNivelInformativo;
END
GO
--CONSULTAR NIVELES INFORMATIVOS
CREATE PROC consultarnivelesinformativos
@CodigoNivelInformativo int
AS
BEGIN
    SELECT CodigoNivelInformativo,Nombre,Descripcion
    FROM NivelesInformativo
    WHERE CodigoNivelInformativo= @CodigoNivelInformativo
END
GO
-- VEREFICAR CURSOS CORTOS
CREATE PROC verificarnivelesinformativos
AS
BEGIN
SELECT CodigoNivelInformativo AS "Codigo Nivel Informativo", Nombre AS "Nivel Informativo", Descripcion AS "Descripcion" FROM NivelesInformativo
END 
GO

-- INSERCION DE DATOS A LA TABLA ENTREGA TITULO--
INSERT INTO EntregaTitulo (VerificacionTitulo)
VALUES ('Original');

INSERT INTO EntregaTitulo (VerificacionTitulo)
VALUES ('Duplicado');
delete from EntregaTitulo

-- INSERCION DE DATOS A LA TABLA TIPO TITULO--
INSERT INTO TipoTitulo (Nombre, Descripcion)
VALUES ('Bachiller', 'Grado académico otorgado después de completar un programa de pregrado.');

INSERT INTO TipoTitulo (Nombre, Descripcion)
VALUES ('Egresado', 'Persona que ha completado sus estudios en una institución educativa, pero aún no ha obtenido un grado académico.');

INSERT INTO TipoTitulo (Nombre, Descripcion)
VALUES ('Titulado', 'Grado académico obtenido tras cumplir con los requisitos de titulación, como un proyecto final o tesis, después de finalizar los estudios de pregrado.');

select*from TipoTitulo

---- --------- PROCEDIMIENTOS DE LA TABLA EGRESADOS -------------------

-- -INSERTAR EGRESADOS

CREATE PROC insertaregresados
@CodigoMinedu VARCHAR(50),
@NombreNivelInformativo VARCHAR(50),
@NombreCarrera VARCHAR(90), 
@VerificacionTitulo VARCHAR(20),
@NombreTitulo VARCHAR(50),
@Dni VARCHAR(8),
@Nombres VARCHAR(70),
@Apellidos VARCHAR(70),
@FechaRegistro DATE
AS
BEGIN
	-- Obtener el código del nivel informativo
	DECLARE @CodigoNivelInformativo INT
	SELECT @CodigoNivelInformativo = CodigoNivelInformativo
	FROM NivelesInformativo
	WHERE @NombreNivelInformativo = Nombre

	-- Obtener el código de la carrera profesional
	DECLARE @CodigoCarreraProfesional INT
	SELECT @CodigoCarreraProfesional = CodigoCarreraProfesional
	FROM CarreraProfesional
	WHERE @NombreCarrera = NombreCarrera

	-- Obtener el código del título
	DECLARE @CodigoTitulo INT
	SELECT @CodigoTitulo = CodigoTitulo
	FROM EntregaTitulo
	WHERE @VerificacionTitulo = VerificacionTitulo

	-- Obtener el código del tipo de título
	DECLARE @CodigoTipoTitulo INT
	SELECT @CodigoTipoTitulo = CodigoTipoTitulo
	FROM TipoTitulo
	WHERE @NombreTitulo = Nombre

	-- Insertar el registro en la tabla de Egresados
	INSERT INTO Egresados(CodigoMinedu, CodigoNInformativo, CodigoCarreraProfesional, CodigoTitulo, CodigoTipoTitulo,Dni,Nombres, Apellidos, FechaRegistro)
	VALUES(@CodigoMinedu, @CodigoNivelInformativo, @CodigoCarreraProfesional, @CodigoTitulo, @CodigoTipoTitulo,@Dni,@Nombres, @Apellidos, @FechaRegistro)
END
GO





