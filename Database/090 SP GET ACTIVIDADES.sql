USE PRUEBA_DB
GO

CREATE PROCEDURE [dbo].[GetActividades]
AS
BEGIN

		SELECT [IdActividad]
			  ,[CreatedDate]
			  ,[IdUsuario]
			  ,[Actividad]
		  FROM [dbo].[Actividades]


END

