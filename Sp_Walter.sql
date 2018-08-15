
--Procedimiento Almacenado de Guardar Lugar
CREATE PROCEDURE Sp_Guardar_Lugar
	@Lugar varchar(15)
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO Lugar
		VALUES(@Lugar)
	END
GO

--Procedimiento Almacenado de Actualizar Lugar
CREATE PROCEDURE Sp_Actualizar_Lugar
	@IdLugar int,
	@Lugar varchar(15)
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Lugar
		SET Lugar = @Lugar
		WHERE Id_Lugar = @IdLugar
	END
GO

--Procedimiento Almacenado de Eliminar Lugar
CREATE PROCEDURE Sp_Eliminar_Lugar
	@IdLugar int
AS
	BEGIN
		SET NOCOUNT OFF
		DELETE 
		FROM Lugar
		WHERE Id_Lugar = @IdLugar
	END
GO

--Procedimiento Almacenado de Mostrar Lugar
CREATE PROCEDURE Sp_Mostrar_Todo_Lugar
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Lugar
	END
GO

--Procedimiento Almacenado de Mostrar un Lugar
CREATE PROCEDURE Sp_Mostrar_Un_Lugar
	@IdLugar int
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Lugar
		WHERE Id_Lugar = @IdLugar
	END
Go

--Procedimiento Almacenado de Guardar Empleado
CREATE PROCEDURE Sp_Guardar_Empleado
	@Num_Identidad char(15),
	@Nombre varchar(30),
	@Apellido varchar(30),
	@Correo varchar(30),
	@Direccion varchar(100),
	@Telefono char(9),
	@IdSexo int,
	@IdCargo int,
	@Estado bit
AS
	BEGIN
	  SET NOCOUNT OFF
		INSERT INTO Empleado
		VALUES(@Num_Identidad, @Nombre, @Apellido, @Telefono, @Direccion,@Correo, @IdCargo, @IdSexo, @Estado)
	END

GO

--Procedimiento Almacenado de Actualizar Empleado
CREATE PROCEDURE Sp_Actualizar_Empleado
	@Num_Identidad char(15),
	@Nombre varchar(30),
	@Apellido varchar(30),
	@Correo varchar(30),
	@Direccion varchar(100),
	@Telefono char(9),
	@IdSexo int,
	@IdCargo int,
	@Estado bit
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Empleado 
		SET Num_Identidad = @Num_Identidad, 
			Nombre = @Nombre, 
			Apellido = @Apellido, 
			Telefono = @Telefono, 
			Direccion = @Direccion, 
			Correo = @Correo, 
			Id_Sexo = @IdSexo, 
			Id_Cargo = @IdCargo, 
			Estado = @Estado
		WHERE Num_Identidad = @Num_Identidad
	END

GO

--Procedimiento Almacenado de Eliminar Empleado
CREATE PROCEDURE Sp_Eliminar_Empleado
	@Num_Identidad char(15)
AS
	BEGIN
		SET NOCOUNT OFF
		DELETE
		FROM Empleado
		WHERE Num_Identidad = @Num_Identidad
	END

GO

--Procedimiento Almacenado de Mostrar Empleado
CREATE PROCEDURE Sp_Mostrar_Todo_Empleado
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Empleado
	END
GO

--Procedimiento Almacenado de Mostrar un Empleado
CREATE PROCEDURE Sp_Mostrar_Un_Empleado
	@Num_Identidad char(15)
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Empleado
		WHERE Num_Identidad = @Num_Identidad
	END
Go


--Procedimiento Almacenado de Mostrar los Cargos
CREATE PROCEDURE Sp_Mostrar_Cargo
AS
	BEGIN
	  SET NOCOUNT ON
		SELECT * 
		FROM Cargo
	END

GO