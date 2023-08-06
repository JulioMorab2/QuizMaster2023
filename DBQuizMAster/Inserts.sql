--USE [QuizMaster]
--GO

INSERT INTO [dbo].[Usuarios]
           ([NombreUsuario]
           ,[Contraseña]
           ,[Rol]
           ,[esProfesor])
     VALUES
           ('admin'
           ,'admin'
           ,'administrador'
           ,0)

	
		   
INSERT INTO [dbo].[Usuarios]
           ([NombreUsuario]
           ,[Contraseña]
           ,[Rol]
           ,[esProfesor])
     VALUES
           ('profesor'
           ,'profesor'
           ,'profesor'
           ,1
		   )



		   	   
INSERT INTO [dbo].[Usuarios]
           ([NombreUsuario]
           ,[Contraseña]
           ,[Rol]
           ,[esProfesor])
     VALUES
           ('estudiante'
           ,'estudiante'
           ,'estudiante'
           ,1
		   )

		   
INSERT INTO [dbo].[AlumnosGrupos]
           ([Descripcion])
     VALUES
           ('GRUPO 1')

		   INSERT INTO [dbo].[AlumnosGrupos]
           ([Descripcion])
     VALUES
           ('GRUPO 2')

		   

INSERT INTO [dbo].[Cat_TipoDocumento]
           ([Descripcion]
           ,[Estado])
     VALUES
           ('Cedula'
           ,1)

		   
INSERT INTO [dbo].[Cat_TipoDocumento]
           ([Descripcion]
           ,[Estado])
     VALUES
           ('RUC'
           ,1)

		   
		   
INSERT INTO [dbo].[Cat_TipoDocumento]
           ([Descripcion]
           ,[Estado])
     VALUES
           ('Refugiado'
           ,1)
GO


select * from Cat_TipoDocumento

select * from Alumnos

select * from AlumnosGrupos


select * from Usuarios