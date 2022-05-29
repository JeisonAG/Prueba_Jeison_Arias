USE PRUEBA_DB
GO

CREATE PROCEDURE [dbo].[DeleteUsuarios]
  @IdUsuario			INT = NULL
AS
BEGIN
BEGIN TRAN Trans

	BEGIN TRY
        

		DELETE U
		FROM [dbo].[Usuarios] U
		WHERE U.IdUsuario = @IdUsuario

		
		INSERT INTO [dbo].[Actividades]
				([CreatedDate]
				,[IdUsuario]
				,[Actividad])
		SELECT 
				GETDATE()
				,@IdUsuario
				,'Eliminacion de Usuario'


		COMMIT TRAN Trans

END TRY

	BEGIN CATCH

		ROLLBACK TRAN Trans

	END CATCH

END

