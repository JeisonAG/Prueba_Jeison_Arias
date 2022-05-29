USE PRUEBA_DB
GO

CREATE PROCEDURE [dbo].[InsertarUsuarios]
  @Nombre				VARCHAR(30) = NULL
 ,@Apellido				VARCHAR (30) = NULL
 ,@Correo				VARCHAR (50) = NULL
 ,@FechaNacimiento		DATETIME = NULL
 ,@Telefono				INT = NULL
 ,@PaisResidencia		VARCHAR(5) = NULL
 ,@Contacto				BIT = NULL
AS
BEGIN
BEGIN TRAN Trans

	BEGIN TRY
        
			INSERT INTO [dbo].[Usuarios]
				   ([Nombre]
				   ,[Apellido]
				   ,[Correo]
				   ,[FechaNacimiento]
				   ,[Telefono]
				   ,[PaisResidencia]
				   ,[Contacto])
			SELECT
					 @Nombre
					,@Apellido
					,@Correo
					,@FechaNacimiento
					,@Telefono
					,@PaisResidencia
					,@Contacto

			DECLARE @IdUsuario INT =(SELECT MAX(IdUsuario) FROM [dbo].[Usuarios])

			INSERT INTO [dbo].[Actividades]
					([CreatedDate]
					,[IdUsuario]
					,[Actividad])
			SELECT 
					GETDATE()
					,@IdUsuario
					,'Creación de Usuario'


		COMMIT TRAN Trans

END TRY

	BEGIN CATCH

		ROLLBACK TRAN Trans

	END CATCH

END

