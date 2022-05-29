USE PRUEBA_DB
GO

CREATE TABLE [dbo].[Actividades] (
	[IdActividad]			INT IDENTITY(1,1) NOT NULL,
	[CreatedDate]			DATETIME     NOT NULL,
    [IdUsuario]				INT			 NOT NULL,
    [Actividad]             VARCHAR(30)	 NOT NULL,

    CONSTRAINT [PK_Actividades] PRIMARY KEY CLUSTERED ([IdActividad] ASC),
    CONSTRAINT [FK_Actividades_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario]),
   
);