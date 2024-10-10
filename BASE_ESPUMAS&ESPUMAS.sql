create database EspumasyEspumas
go

use EspumasyEspumas
go

create table Categoria_Productos
(
	IdCategoria char(3) primary key not null,
	Categoria varchar(50) not null,
	Descripcion varchar(50)not null
)

create table Productos
(
	IdProducto char(4)primary key,
	Nombre_Producto varchar(50),
	Descripcion varchar(50),
	stock float,
	IdCategoria char(3),
	foreign key (IdCategoria) references Categoria_Productos(IdCategoria)
);

create table Tipo_Clientes
(
 IdTipo char(3) primary key,
 Tipo_Cliente varchar(45)
);

CREATE TABLE Clientes
(
    IdCliente CHAR(4) PRIMARY KEY,
    Nombre_Cliente VARCHAR(50),
    Apellidos_Cliente VARCHAR(50),
    DNI_RUC INT,
    Sexo VARCHAR(20),
    Telefono_Celular INT,
    Direccion VARCHAR(300),
    IdTipo CHAR(3),
    FOREIGN KEY (IdTipo) REFERENCES Tipo_Clientes(IdTipo)
);

CREATE TABLE Usuarios
(
	idUsuario char(4) PRIMARY KEY,
	usuario varchar(15),
	contrasena varchar(50)
);

select*from Usuarios;
create table Cargos
(
IdCargo char(3) primary key,
cargo varchar(50)
)
go



create table Empleados
(
	IdEmpleado char(4) primary key,
	IdUsuario char(4),
	foreign key (IdUsuario) references Usuarios(idUsuario),
	Nombre_Empleados  varchar(50),
	Apellido_Empleado varchar(50),
	DNI int,
	IdCargo char(3)
	foreign key (IdCargo) references Cargos(IdCargo) 
);


create table Tipos_Pagos
(
	IdTipo char(3) primary key,
	Tipo_pago varchar(20)
);

create table Tipo_Documentos
(
	IdDocumento char(3)  primary key,
	Nombre_Documento varchar(30),
);

create table Facturas
(
	num_facturas varchar(10) primary key,
	FechaEmision datetime default getdate(),
	FechaTaslado datetime,
	IdDocumentos char(3),
	IdTipo char(3),
	foreign key (IdDocumentos) references Tipo_Documentos(IdDocumento),
	foreign key (IdTipo) references Tipos_Pagos(IdTipo),
);

create table Boletas
(
	num_boletas varchar(10) primary key,
	FechaEmision datetime default getdate(),
	FechaTaslado datetime,
	IdDocumentos char(3),
	IdTipo char(3),
	foreign key (IdDocumentos) references Tipo_Documentos(IdDocumento),
	foreign key (IdTipo) references Tipos_Pagos(IdTipo),
);


create table Detalle_Documentos
(
	detalle_documento INT IDENTITY(1,1) PRIMARY KEY,
	Cantidad float,
	Precio float,
	SubTotal float,
	IGV float,
	Total float,

	IdProducto char(4),
	IdEmpleado char(4),
	IdCliente char(4),
	idUsuario char(4),
	num_facturas varchar(10),
	num_boletas varchar(10),

	foreign key (IdProducto) references Productos(IdProducto),
	foreign key (IdEmpleado) references Empleados(IdEmpleado),
	foreign key (IdCliente) references Clientes(IdCliente),
	foreign key (idUsuario) references Usuarios(idUsuario),
	foreign key (num_facturas) references Facturas(num_facturas),
	foreign key (num_boletas) references Boletas(num_boletas)
);



DELETE FROM Detalle_Documentos
WHERE num_facturas = 'F000000000';


DELETE FROM Facturas
WHERE num_facturas = 'F000000000';

----CRUD DE LA TABLA CATEGORIA_PRODUCTO--------
GO
CREATE FUNCTION FN_Incrementar_IDCategoria()
RETURNS CHAR(3)
AS
BEGIN
    DECLARE @valor_nuevo CHAR(3)

    SELECT @valor_nuevo = MAX(IDCATEGORIA) FROM Categoria_Productos;

    IF (@valor_nuevo IS NULL)
    BEGIN
        SET @valor_nuevo = 'C01';
    END
    ELSE
    BEGIN
        DECLARE @max_value INT;
        SET @max_value = CAST(SUBSTRING(@valor_nuevo, 2, 2) AS INT);
        SET @max_value = @max_value + 1;
        SET @valor_nuevo = 'C' + RIGHT('0' + CAST(@max_value AS VARCHAR(2)), 2);
    END

    RETURN @valor_nuevo;
END
GO

CREATE PROCEDURE InsertCategoria
    @IdCategoria CHAR(3),
    @Categoria VARCHAR(50),
    @Descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO Categoria_Productos (IdCategoria, Categoria, Descripcion)
    VALUES (@IdCategoria, @Categoria, @Descripcion)
END
GO


CREATE PROCEDURE UpdateCategoria
    @IdCategoria CHAR(3),
    @Categoria VARCHAR(50),
    @Descripcion VARCHAR(50)
AS
BEGIN
    UPDATE Categoria_Productos
    SET Categoria = @Categoria, Descripcion = @Descripcion
    WHERE IdCategoria = @IdCategoria
END
GO

CREATE PROCEDURE DeleteCategoria
    @IdCategoria CHAR(3)
AS
BEGIN
    DELETE FROM Categoria_Productos
    WHERE IdCategoria = @IdCategoria
END
GO

CREATE PROCEDURE sp_buscar
@id VARCHAR(3)
AS
SELECT*FROM Categoria_Productos WHERE IdCategoria=@id 
GO

CREATE PROC idcat
AS
select IdCategoria from Categoria_Productos
go

CREATE PROCEDURE GetCategoria
AS
BEGIN
    SELECT * FROM Categoria_Productos
END
GO

create PROCEDURE SelecCategoria
@idcat VARCHAR(4)
AS
BEGIN
    SELECT IdCategoria,Categoria,Descripcion
    FROM Categoria_Productos
    WHERE IdCategoria= @idcat
END
GO
------CRUD DE LA TABLA PRODUCTOS-------
GO
CREATE FUNCTION FN_Incrementar_IDproducto()
RETURNS CHAR(4)
AS
BEGIN
    DECLARE @valor_nuevo CHAR(4)

    SELECT @valor_nuevo = MAX(IDPRODUCTO) FROM Productos;

    IF (@valor_nuevo IS NULL)
    BEGIN
        SET @valor_nuevo = 'P001';
    END
    ELSE
    BEGIN
        DECLARE @max_value INT;
        SET @max_value = CAST(SUBSTRING(@valor_nuevo, 3, 3) AS INT);
        SET @max_value = @max_value + 1;
        SET @valor_nuevo = 'P' + RIGHT('00' + CAST(@max_value AS VARCHAR(3)), 3);
    END

    RETURN @valor_nuevo;
END
GO

CREATE PROCEDURE InsertProducto
    @IdProducto CHAR(4),
    @Nombre_Producto VARCHAR(50),
    @Descripcion VARCHAR(50),
    @Stock FLOAT,
    @Categoria VARCHAR(50)
AS
BEGIN
    DECLARE @idCategoria CHAR(3)

    SELECT @Categoria=IdCategoria
    FROM Categoria_Productos
    WHERE @Categoria=Categoria
    INSERT INTO Productos (IdProducto, Nombre_Producto, Descripcion, Stock, IdCategoria)
    VALUES (@IdProducto, @Nombre_Producto, @Descripcion, @Stock, @Categoria)
END
GO

CREATE PROCEDURE UpdateProducto
    @IdProducto CHAR(4),
    @Nombre_Producto VARCHAR(50),
    @Descripcion VARCHAR(50),
    @Stock FLOAT,
    @Categoria VARCHAR(50)
AS
BEGIN
    DECLARE @idCategoria CHAR(3)

    SELECT @idCategoria = IdCategoria
    FROM Categoria_Productos
    WHERE Categoria = @Categoria

    UPDATE Productos
    SET Nombre_Producto = @Nombre_Producto,
        Descripcion = @Descripcion,
        Stock = @Stock,
        IdCategoria = @idCategoria
    WHERE IdProducto = @IdProducto
END
GO

CREATE PROCEDURE DeleteProducto
    @IdProducto CHAR(4)
AS
BEGIN
    DELETE FROM Productos
    WHERE IdProducto = @IdProducto
END
GO

create proc idproducto
as
select IdProducto from Productos
go

CREATE PROCEDURE buscarProducto
@id char(4)
AS
BEGIN
    SELECT IdProducto, Nombre_Producto, P.Descripcion, stock, CP.Categoria   FROM Productos P inner join Categoria_Productos CP on
	P.IdCategoria=CP.IdCategoria  WHERE P.IdProducto=@id
END
GO

CREATE PROC catego
AS
select Categoria from Categoria_Productos
go

CREATE PROCEDURE GetProductos
AS
BEGIN
    SELECT IdProducto, Nombre_Producto, P.Descripcion, stock, CP.Categoria   FROM Productos P inner join Categoria_Productos CP on
	P.IdCategoria=CP.IdCategoria   
END
GO

create proc produc
as
select Nombre_Producto from Productos
go

CREATE PROCEDURE SelecProducto
@idproc VARCHAR(4)
AS
BEGIN
    SELECT IdProducto, Nombre_Producto,P.Descripcion,stock,CP.Categoria
    FROM Productos P inner join Categoria_Productos CP on
	p.IdCategoria=CP.IdCategoria
    WHERE IdProducto= @idproc
END
GO

----CRUD DE LA TABLA TIPO_CLIENTE----
insert into Tipo_Clientes values('T01','Natural');
insert into Tipo_Clientes values('T02','jurídico')
select*from Tipo_Clientes;

go
create proc sp_tipocl
as
select Tipo_Cliente from Tipo_Clientes
go
----CRUD DE LA TABLA CLIENTES-----
GO
CREATE FUNCTION FN_Incrementar_IdCliente()
RETURNS CHAR(4)
AS
BEGIN
    DECLARE @valor_nuevo CHAR(4)

    SELECT @valor_nuevo = MAX(IdCliente) FROM Clientes;

    IF (@valor_nuevo IS NULL)
    BEGIN
        SET @valor_nuevo = 'C001';
    END
    ELSE
    BEGIN
        DECLARE @max_value INT;
        SET @max_value = CAST(SUBSTRING(@valor_nuevo, 2, 3) AS INT);
        SET @max_value = @max_value + 1;
        SET @valor_nuevo = 'C' + RIGHT('00' + CAST(@max_value AS VARCHAR(3)), 3);
    END

    RETURN @valor_nuevo;
END
GO

GO
CREATE PROCEDURE sp_InsertarCliente
	@Codigo char(4),
    @Nombre_Cliente VARCHAR(50),
    @Apellidos_Cliente VARCHAR(50),
    @DNI_RUC INT,
    @Sexo VARCHAR(20),
    @Telefono_Celular INT,
    @Direccion VARCHAR(300),
    @Tipo varchar(45)
AS
BEGIN
    DECLARE @IdTipo CHAR(3);
	SELECT @Tipo=IdTipo
    FROM Tipo_Clientes
    WHERE @Tipo=Tipo_Cliente

    INSERT INTO Clientes (IdCliente, Nombre_Cliente, Apellidos_Cliente, DNI_RUC, Sexo, Telefono_Celular, Direccion, IdTipo)
    VALUES (@Codigo, @Nombre_Cliente, @Apellidos_Cliente, @DNI_RUC, @Sexo, @Telefono_Celular, @Direccion, @Tipo);
END
GO

CREATE PROCEDURE sp_ActualizarCliente
    @Codigo CHAR(4),
    @Nombre_Cliente VARCHAR(50),
    @Apellidos_Cliente VARCHAR(50),
    @DNI_RUC INT,
    @Sexo VARCHAR(20),
    @Telefono_Celular INT,
    @Direccion VARCHAR(300),
    @Tipo_Cliente varchar(45)
AS
BEGIN
	DECLARE @idTipo CHAR(3)

    SELECT @idTipo = IdTipo
    FROM Tipo_Clientes
    WHERE @Tipo_Cliente = Tipo_Cliente

    UPDATE Clientes
    SET
        Nombre_Cliente = @Nombre_Cliente,
        Apellidos_Cliente = @Apellidos_Cliente,
        DNI_RUC = @DNI_RUC,
        Sexo = @Sexo,
        Telefono_Celular = @Telefono_Celular,
        Direccion = @Direccion,
        IdTipo = @IdTipo
    WHERE IdCliente = @Codigo;
END
GO

CREATE PROCEDURE sp_EliminarCliente
    @IdCliente CHAR(4)
AS
BEGIN
    DELETE FROM Clientes WHERE IdCliente = @IdCliente;
END
GO


CREATE PROCEDURE sp_buscar_cliente
    @IdCliente CHAR(4)
AS
BEGIN
    SELECT *
    FROM Clientes
    WHERE IdCliente = @IdCliente;
END
GO

create proc cliente
as
select concat(Nombre_Cliente,' ',Apellidos_Cliente)as Cliente from Clientes
go


CREATE PROCEDURE datoscliente
    @nombre VARCHAR(100)
AS
BEGIN
    SELECT DNI_RUC, Direccion
    FROM Clientes
    WHERE CONCAT(Nombre_Cliente,' ',Apellidos_Cliente) = @nombre
END
GO

GO 
CREATE PROC VerCleintes
as
select IdCliente,Nombre_Cliente,Apellidos_Cliente,DNI_RUC,Sexo,Telefono_Celular,Direccion from Clientes C inner join
Tipo_Clientes TC on C.IdTipo=TC.IdTipo
GO

-----CRUD USUARIO----

INSERT INTO Usuarios(idUsuario,usuario, contrasena)
VALUES ('USR1','Soledad126','123456789')

go
create proc usurio
as
select usuario from Usuarios
go



GO
ALTER PROC  sp_cambiar
@usuario varchar(15),
@contrasena varchar(50)
as
BEGIN
    UPDATE Usuarios
    SET usuario = @usuario, contrasena = @contrasena
    WHERE idUsuario = 'USR1'
END  
GO

select*from Usuarios;
-----CRUD CARGO
insert into Cargos values ('CR1','Vendedora');

-----CRUD EMPLEADOS

insert into Empleados values('EPM2','USR1','Soledad Noemí','León Angeles',32129310,'CR1');
select*from Empleados;
select IdEmpleado, U.usuario, Nombre_Empleados, Apellido_Empleado, DNI, C.cargo from Empleados E inner join Cargos C on
E.IdCargo=C.IdCargo inner join Usuarios U on E.IdUsuario=U.idUsuario 
go
create proc emple
as
select concat(Nombre_Empleados,'  ',Apellido_Empleado)as Empleado from Empleados
go

-----CRUD  TIPO PAGO
insert into  Tipos_Pagos values('TP1','Financiero');
insert into  Tipos_Pagos values('TP2','Yape');
insert into Tipos_Pagos values('TP3','Efectivo');
insert into Tipos_Pagos values('TP4','Transferencia');
select * from  Tipos_Pagos;
go
create proc pagos
as
select Tipo_pago from Tipos_Pagos
go

-----Crud tipo documento
insert into Tipo_Documentos values ('TD1','Facturas');
insert into Tipo_Documentos values ('TD2','Boletas');
go
create proc facturanomb
as
select Nombre_Documento from Tipo_Documentos where IdDocumento='TD1'
go

create proc boletanomb
as
select Nombre_Documento from Tipo_Documentos where IdDocumento='TD2'
go
-----Factura---
GO
CREATE FUNCTION FN_Incrementar_NumFactura()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @valor_nuevo VARCHAR(10)

    SELECT @valor_nuevo = MAX(num_facturas) FROM Facturas;

    IF (@valor_nuevo IS NULL)
    BEGIN
        SET @valor_nuevo = 'F000000001';
    END
    ELSE
    BEGIN
        DECLARE @max_value INT;
        SET @max_value =
		CAST(SUBSTRING(@valor_nuevo, 2, 9) AS INT);
        SET @max_value = @max_value + 1;
        SET @valor_nuevo = 'F' + RIGHT('00000000' + CAST(@max_value AS VARCHAR(9)), 9);
    END

    RETURN @valor_nuevo;
END
GO

GO
CREATE PROCEDURE Insertar_Facturas
@num_facturas varchar(10),
@FechaTaslado datetime,
@Nombre_Documento varchar(30),
@pago varchar(20)
AS
BEGIN
	DECLARE @IdTipo char(3)
	SELECT @IdTipo=IdTipo
	FROM Tipos_Pagos
	WHERE Tipo_pago=@pago

	DECLARE @IdDocumentos CHAR(3)

    SELECT @IdDocumentos = IdDocumento
    FROM Tipo_Documentos
    WHERE Nombre_Documento = @Nombre_Documento

    INSERT INTO Facturas (num_facturas, FechaTaslado, IdDocumentos,IdTipo,FechaEmision)
    VALUES (@num_facturas, @FechaTaslado, @IdDocumentos,@IdTipo,GETDATE())
END
Go




CREATE PROCEDURE Eliminar_Facturas
@num_facturas varchar(10)
AS
BEGIN
    DELETE FROM Facturas
    WHERE num_facturas = @num_facturas
END
GO

------Detalles_Documentos_Facturas
GO
CREATE PROCEDURE Insetar_DT_Facturas
@num_factura varchar(10),
@nombrecliente varchar(200),
@nombrevendedora varchar(200),
@usuario varchar(15),
@Nombre_Producto varchar(50),
@cantidad float,
@precio float
AS
BEGIN
	DECLARE @IdCliente varchar(4)
	SELECT @IdCliente=IdCliente
	FROM Clientes
	WHERE CONCAT(Nombre_Cliente,' ',Apellidos_Cliente)=@nombrecliente

	DECLARE @IdEmpleado char(4)
	SELECT @IdEmpleado=IdEmpleado
	FROM Empleados
	WHERE CONCAT(Nombre_Empleados,'  ',Apellido_Empleado)=@nombrevendedora

	DECLARE @idUsuario char(4)
	SELECT @idUsuario=idUsuario
	FROM Usuarios
	WHERE usuario=@usuario

	DECLARE @IdProducto char(4)
	SELECT @IdProducto=IdProducto
	FROM Productos
	WHERE Nombre_Producto=@Nombre_Producto


	DECLARE @Subtotal float
	DECLARE @IGV float
	DECLARE @Total float

	SET @Subtotal = @cantidad * @precio
	SET @IGV = @Subtotal * 0.18
	SET @Total = @Subtotal + @IGV

	insert into Detalle_Documentos (num_facturas,IdCliente,IdEmpleado,idUsuario,IdProducto,Cantidad,Precio,SubTotal,IGV,Total)
	values(@num_factura,@IdCliente,@IdEmpleado,@idUsuario,@IdProducto,@cantidad,@precio,@Subtotal,@IGV,@Total)
END
GO



CREATE PROCEDURE Eliminar_DT_Facturas
@num_factura varchar(10)
AS
BEGIN
    DELETE FROM Detalle_Documentos
    WHERE num_facturas = @num_factura
END
GO
select*from Boletas;
select*from Detalle_Documentos

create proc facturahecha
@num varchar(10)
as
select DD.num_facturas, p.Nombre_Producto,Cantidad,Precio,SubTotal from Detalle_Documentos DD inner join Facturas F on 
DD.num_facturas=F.num_facturas inner join Productos P on DD.IdProducto=P.IdProducto WHERE DD.num_facturas=@num
go
--533
delete from Detalle_Documentos where num_facturas=num_facturas
delete from Facturas where num_facturas=num_facturas
delete from Detalle_Documentos where num_boletas=num_boletas
delete from Boletas where num_boletas=num_boletas

go
alter proc IGTT
@num varchar(10)
AS
SELECT  SUM(DD.SubTotal) AS Subtotal,SUM(DD.IGV) AS Total_IGV, SUM(DD.Total) AS Total
FROM Detalle_Documentos DD
INNER JOIN Facturas F ON DD.num_facturas = F.num_facturas
INNER JOIN Productos P ON DD.IdProducto = P.IdProducto
WHERE DD.num_facturas=@num
GROUP BY DD.num_facturas
GO
---CRUD Boletas

GO
CREATE FUNCTION FN_Incrementar_NumBoletas()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @valor_nuevo VARCHAR(10)

    SELECT @valor_nuevo = MAX(num_boletas) FROM Boletas;

    IF (@valor_nuevo IS NULL)
    BEGIN
        SET @valor_nuevo = 'B000000001';
    END
    ELSE
    BEGIN
        DECLARE @max_value INT;
        SET @max_value =
		CAST(SUBSTRING(@valor_nuevo, 2, 9) AS INT);
        SET @max_value = @max_value + 1;
        SET @valor_nuevo = 'B' + RIGHT('00000000' + CAST(@max_value AS VARCHAR(9)), 9);
    END

    RETURN @valor_nuevo;
END
GO

GO
CREATE PROCEDURE Insertar_Boletas
@num_boletas varchar(10),
@FechaTaslado datetime,
@Nombre_Documento varchar(30),
@pago varchar(20)
AS
BEGIN
	DECLARE @IdTipo char(3)
	SELECT @IdTipo=IdTipo
	FROM Tipos_Pagos
	WHERE Tipo_pago=@pago

	DECLARE @IdDocumentos CHAR(3)

    SELECT @IdDocumentos = IdDocumento
    FROM Tipo_Documentos
    WHERE Nombre_Documento = @Nombre_Documento

    INSERT INTO Boletas(num_boletas, FechaTaslado, IdDocumentos,IdTipo,FechaEmision)
    VALUES (@num_boletas, @FechaTaslado, @IdDocumentos,@IdTipo,GETDATE())
END
Go



GO
CREATE PROCEDURE Eliminar_boletas
@num_boletas varchar(10)
AS
BEGIN
    DELETE FROM Boletas
    WHERE num_boletas = @num_boletas
END
GO

---Detalles Documentos Boletas
GO
CREATE PROCEDURE Insetar_DT_Boletas
@num_boleta varchar(10),
@nombrecliente varchar(200),
@nombrevendedora varchar(200),
@usuario varchar(15),
@Nombre_Producto varchar(50),
@cantidad float,
@precio float
AS
BEGIN
	DECLARE @IdCliente varchar(4)
	SELECT @IdCliente=IdCliente
	FROM Clientes
	WHERE CONCAT(Nombre_Cliente,' ',Apellidos_Cliente)=@nombrecliente

	DECLARE @IdEmpleado char(4)
	SELECT @IdEmpleado=IdEmpleado
	FROM Empleados
	WHERE CONCAT(Nombre_Empleados,'  ',Apellido_Empleado)=@nombrevendedora

	DECLARE @idUsuario char(4)
	SELECT @idUsuario=idUsuario
	FROM Usuarios
	WHERE usuario=@usuario

	DECLARE @IdProducto char(4)
	SELECT @IdProducto=IdProducto
	FROM Productos
	WHERE Nombre_Producto=@Nombre_Producto

	DECLARE @Total float

	SET @Total = @cantidad * @precio


	insert into Detalle_Documentos (num_boletas,IdCliente,IdEmpleado,idUsuario,IdProducto,Cantidad,Precio,Total)
	values(@num_boleta,@IdCliente,@IdEmpleado,@idUsuario,@IdProducto,@cantidad,@precio,@Total)
END
GO



GO
CREATE PROCEDURE Eliminar_DT_Boletas
@num_boleta varchar(10)
AS
BEGIN
    DELETE FROM Detalle_Documentos
    WHERE num_boletas = @num_boleta
END
GO

GO
create proc boletafecha
@num varchar(10)
as
select DD.num_boletas, p.Nombre_Producto,Cantidad,Precio,Total from Detalle_Documentos DD inner join Boletas B on 
DD.num_boletas=B.num_boletas inner join Productos P on DD.IdProducto=P.IdProducto WHERE DD.num_boletas=@num
GO

GO
create proc TOTAL
@num varchar(10)
AS
SELECT SUM(DD.Total) AS Total
FROM Detalle_Documentos DD
INNER JOIN Boletas B ON DD.num_facturas = B.num_boletas
INNER JOIN Productos P ON DD.IdProducto = P.IdProducto
WHERE DD.num_facturas=@num
GROUP BY DD.num_facturas
GO

GO
CREATE PROCEDURE RestarStock
    @Producto char(50),
    @CantidadComprada float
AS
BEGIN
    UPDATE Productos
    SET stock = stock - @CantidadComprada
    WHERE Nombre_Producto = @Producto;
END
GO

CREATE PROCEDURE AumentarStock
    @Producto char(50),
    @CantidadComprada float
AS
BEGIN
    UPDATE Productos
    SET stock = stock + @CantidadComprada
    WHERE Nombre_Producto = @Producto;
END
GO
go
create proc verstock
@nombre varchar(50)
as
select stock from Productos
where Nombre_Producto=@nombre
go

GO
CREATE PROC financiasB
AS
SELECT CONCAT(C.Nombre_Cliente,' ',c.Apellidos_Cliente)as Nombre, P.Nombre_Producto,TD.Nombre_Documento,B.FechaEmision,DT.Precio,DT.Cantidad,DT.Total from Detalle_Documentos DT inner join Clientes C on
DT.IdCliente=C.IdCliente inner join Productos P on DT.IdProducto=P.IdProducto inner join Boletas B on DT.num_boletas=B.num_boletas inner join
Tipo_Documentos TD on B.IdDocumentos=TD.IdDocumento inner join Tipos_Pagos TP on B.IdTipo=TP.IdTipo where TP.IdTipo='TP1'
GO

select*from Boletas
select*from Facturas
delete from Boletas 
where num_boletas=num_boletas
select*from Usuarios;

