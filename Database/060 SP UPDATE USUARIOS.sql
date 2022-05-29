USE PRUEBA_DB
GO

CREATE PROCEDURE [dbo].[UpdateUsuarios]
  @IdUsuario			INT = NULL
 ,@Nombre				VARCHAR(30) = NULL
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
        

		UPDATE U
		   SET [Nombre] = @Nombre
			  ,[Apellido] = @Apellido
			  ,[Correo] = @Correo
			  ,[FechaNacimiento] = @FechaNacimiento
			  ,[Telefono] = @Telefono
			  ,[PaisResidencia] = @PaisResidencia
			  ,[Contacto] = @Contacto
			--SELECT *
			FROM [dbo].[Usuarios] U
		 WHERE U.IdUsuario = @IdUsuario

		
		INSERT INTO [dbo].[Actividades]
				([CreatedDate]
				,[IdUsuario]
				,[Actividad])
		SELECT 
				GETDATE()
				,@IdUsuario
				,'Actualización de Usuario'


		COMMIT TRAN Trans

END TRY

	BEGIN CATCH

		ROLLBACK TRAN Trans

	END CATCH

END

