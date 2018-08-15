
--Procedimiento almacenado de Guardar Cargo
CREATE PROCEDURE Sp_Guardar_Cargo
	@Cargo varchar(15)
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO Cargo
		VALUES(@Cargo)
	END
GO

--Procedimiento almacenado de Mostrar Todo Cargo
CREATE PROCEDURE Sp_Mostrar_Todo_Cargo
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Cargo
	END
GO

--Procedimiento almacenado de Mostrar un Cargo
CREATE PROCEDURE Sp_Mostrar_Un_Cargo
	@IdCargo int
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Cargo
		WHERE Id_Cargo = @IdCargo
	END
Go

--Procedimiento almacenado de Actualizar Cargo
CREATE PROCEDURE Sp_Actualizar_Cargo
	@IdCargo int,
	@Cargo varchar(15)
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Cargo
		SET Cargo = @Cargo
		WHERE Id_Cargo = @IdCargo
	END
GO

--Procedimiento almacenado de Eliminar Cargo
CREATE PROCEDURE Sp_Eliminar_Cargo
	@IdCargo int
AS
	BEGIN
		SET NOCOUNT OFF
		DELETE 
		FROM Cargo
		WHERE Id_Cargo = @IdCargo
	END
GO

--Procedimiento almacenado de Mostrar Sacramentos
CREATE PROCEDURE Sp_Mostrar_Sacramentos
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Sacramento
	END
GO

--Procedimiento almacenado de Listar Empleado en el Form Sacramento
CREATE PROCEDURE Sp_Listar_Empleado_Sacramento
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto
		FROM Empleado
	END
GO

--Procedimiento almacenado de Listar Lugar en el Form Sacramento
CREATE PROCEDURE Sp_Listar_Lugar_Sacramento
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Lugar
	END
GO
--Procedimiento almacenado de Mostrar Todo Sacramento 
CREATE PROCEDURE Sp_Mostrar_Todo_Sacramento
AS
	BEGIN
		SET NOCOUNT OFF
		SELECT R.Id_Registro_Sacramento, CONCAT(F.Nombre, ' ', F.Apellido) AS NombreCompleto, S.Sacramento, R.Fecha, L.Lugar, S.Id_Sacramento
		FROM Registrosacramento R INNER JOIN SacramentoXFeligres SF
								  on R.Id_Registro_Sacramento = SF.Id_Registro_Sacramento
								  INNER JOIN Feligres F
								  on SF.Feligres_Num_Identidad = F.Num_Identidad
								  INNER JOIN Sacramento S
								  on R.Id_Sacramento = S.Id_Sacramento
								  INNER JOIN Lugar L
								  on R.Id_Lugar = L.Id_Lugar
	END
GO

--Procedimiento almacenado de Guardar Registro Sacramento
CREATE PROCEDURE Sp_Guardar_Registro_Sacramento
	@Id_Sacramento int,
	@Fecha date,
	@Num_Identidad char(15),
	@Id_Lugar int,
	@Numero_Libro int,
	@Numero_Pagina int,
	@Numero_Acta int
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO Registrosacramento
		VALUES(@Id_Sacramento, @Fecha, @Num_Identidad, @Id_Lugar, @Numero_Libro, @Numero_Pagina, @Numero_Acta)
		SELECT CAST(scope_identity() AS int)
	END
GO

--Procedimiento almacenado de Guardar Sacramento por Feligres
CREATE PROCEDURE Sp_Guardar_Sacramento_Por_Feligres
	@Id_Registro_Sacramento int,
	@Feligres_Num_Identidad char(15)
AS	
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO SacramentoXFeligres
		VALUES(@Id_Registro_Sacramento, @Feligres_Num_Identidad)
	END
GO

--Procedimiento almacenado de Guardar Padrino por Sacramento
CREATE PROCEDURE Sp_Guardar_Padrino_Por_Sacramento
	@Id_Registro_Sacramento int,
	@Feligres_Num_Identidad char(15),
	@De_Novio bit
AS
	BEGIN
		SET NOCOUNT OFF
		INSERT INTO PadrinoXSacramento
		VALUES(@Id_Registro_Sacramento, @Feligres_Num_Identidad, @De_Novio)
	END
GO

--Procedimiento almacenado de Actualizar Registro Sacramento
CREATE PROCEDURE Sp_Actualizar_RegistroSacramento
	@Id_Registro_Sacramento int,
	@Id_Sacramento int,
	@Fecha date,
	@Num_Identidad char(15),
	@Id_Lugar int,
	@Numero_Libro int,
	@Numero_Pagina int,
	@Numero_Acta int
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE Registrosacramento
		SET	Id_Sacramento = @Id_Sacramento,
			Fecha = @Fecha,
			Num_Identidad = @Num_Identidad,
			Id_Lugar = @Id_Lugar,
			Numero_Libro = @Numero_Libro,
			Numero_Pagina = @Numero_Pagina,
			Numero_Acta = @Numero_Acta
		WHERE Id_Registro_Sacramento = @Id_Registro_Sacramento
	END
GO

--Procedimiento almacenado de Actualizar Sacramento por Feligres
CREATE PROCEDURE Sp_Actualizar_Sacramento_Por_Feligres
	@Id_Registro_Sacramento int,
	@Feligres_Num_Identidad char(15)
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE SacramentoXFeligres
		SET Feligres_Num_Identidad = @Feligres_Num_Identidad
		WHERE Id_Registro_Sacramento = @Id_Registro_Sacramento
	END
GO

--Procedimiento almacenado de Actualizar Padrinos por Feligres
CREATE PROCEDURE Sp_Actualizar_Padrinos_Feligres
	@Id_Registro_Sacramento int,
	@Feligres_Num_Identidad char(15),
	@Feligres_Num_Identidad_Anterior char(15)
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE PadrinoXSacramento
		SET Feligres_Num_Identidad = @Feligres_Num_Identidad,
			Id_Registro_Sacramento = @Id_Registro_Sacramento
		WHERE Id_Registro_Sacramento = @Id_Registro_Sacramento AND
			  Feligres_Num_Identidad = @Feligres_Num_Identidad_Anterior		
	END
GO

--Procedimiento almacenado de Mostrar un Sacramento para editarlo
CREATE PROCEDURE Sp_Mostrar_Un_Sacramento
	@Id_Registro_Sacramento int
AS 
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM Registrosacramento 
		WHERE Id_Registro_Sacramento = @Id_Registro_Sacramento
	END
GO

--Procedimiento almacenado de Mostrar Feligres Sacramento
CREATE PROCEDURE Sp_Mostrar_Feligres_Sacramento
	@Id_Registro_Sacramento int
AS 
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM SacramentoXFeligres 
		WHERE Id_Registro_Sacramento = @Id_Registro_Sacramento
	END
GO

--Procedimiento almacenado de Mostrar Padrinos del feligres
CREATE PROCEDURE Sp_Mostrar_Padrinos_Feligres
	@Id_Registro_Sacramento int
AS 
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM PadrinoXSacramento 
		WHERE Id_Registro_Sacramento = 33
	END
GO

--Procedimiento almacenado de Seleccionar Novios
CREATE PROCEDURE Sp_Seleccionar_Novios
	@Id_Registro_Sacramento int
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM SacramentoXFeligres
		WHERE Id_Registro_Sacramento = @Id_Registro_Sacramento
	END
GO

--Procedimiento almacenado de Existe Sacramento Feligres para saber si ya tiene registrado dicho sacramneto para no vover agregarlo
CREATE PROCEDURE Sp_Existe_Sacramento_Feligres
	@Id_Sacramento int,
	@Feligres_Num_Identidad char(15)
AS
	BEGIN
		SET NOCOUNT ON
		SELECT COUNT(*)
		FROM SacramentoXFeligres SF INNER JOIN Registrosacramento R
									on SF.Id_Registro_Sacramento = R.Id_Registro_Sacramento
		WHERE R.Id_Sacramento = @Id_Sacramento AND SF.Feligres_Num_Identidad = @Feligres_Num_Identidad
	END
GO

--Procedimiento almacenado de Guardar Datos Generales
CREATE PROCEDURE Sp_Guardar_Datos_Generales
	@Id_Dato int,
	@Nombre_Parroquia nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@Id_Usuario int,
	@Logo image
AS
	BEGIN
		SET NOCOUNT OFF
		UPDATE DatosGenerales
		SET Nombre_Parroquia = @Nombre_Parroquia,
			Direccion = @Direccion,
			Telefono = @Telefono,
			Id_Usuario = @Id_Usuario,
			Logo = @Logo
		WHERE Id_Dato = @Id_Dato
	END
GO

--Procedimiento almacenado de Mostrar los Datos Generales
CREATE PROCEDURE Sp_Mostrar_Datos_Generales
AS
	BEGIN
		SET NOCOUNT ON
		SELECT *
		FROM DatosGenerales
		WHERE Id_Dato = 1
	END
GO

--Procedimiento almacenado de Login
CREATE PROCEDURE dbo.Sp_Login
  @Usuario NVARCHAR(50),
  @Contrasena NVARCHAR(50)
AS
  BEGIN
  	  SET NOCOUNT ON
      SELECT * 
      FROM Usuario 
      WHERE Usuario = @Usuario AND Contraseña = @Contrasena AND Estado = 1
  END
GO