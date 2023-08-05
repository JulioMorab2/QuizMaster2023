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