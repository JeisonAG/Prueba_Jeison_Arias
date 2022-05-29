USE PRUEBA_DB
GO

CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario]			INT	IDENTITY(1,1) NOT NULL,
    [Nombre]            VARCHAR(30)	 NOT NULL,
    [Apellido]			VARCHAR(30)  NOT NULL,
    [Correo]			VARCHAR(50)  NOT NULL,
	[FechaNacimiento]	DATETIME     NOT NULL,
    [Telefono]          INT			 NULL,
	[PaisResidencia]	VARCHAR(5)   NOT NULL,
    [Contacto]          BIT			 NOT NULL,


    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);
