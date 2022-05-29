USE [PRUEBA_DB]
GO

INSERT INTO [dbo].[Usuarios]
           ([Nombre]
           ,[Apellido]
           ,[Correo]
           ,[FechaNacimiento]
           ,[Telefono]
           ,[PaisResidencia]
           ,[Contacto])
SELECT
           'Carlos'
           ,'Mendez'
           ,'cmendez@prueba.com'
           ,GETDATE()
           ,88888888
           ,'CRI'
           ,1
UNION
SELECT
           'Juan'
           ,'Perez'
           ,'jperez@prueba.com'
           ,GETDATE()
           ,77777777
           ,'GTM'
           ,0
GO

