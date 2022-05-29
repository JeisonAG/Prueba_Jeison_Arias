USE PRUEBA_DB
GO

CREATE PROCEDURE [dbo].[GetUsuarios]
AS
BEGIN

	SELECT [IdUsuario]
		  ,[Nombre]
		  ,[Apellido]
		  ,[Correo]
		  ,[FechaNacimiento]
		  ,[Telefono]
		  ,[PaisResidencia]
		  ,[Contacto]
	  FROM [dbo].[Usuarios]

END

