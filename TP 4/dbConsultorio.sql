USE [dbConsultorio]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 20/6/2022 06:10:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Dni] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Fecha_Consulta] [nvarchar](50) NOT NULL,
	[Horario] [nvarchar](50) NOT NULL,
	[Obra_Social] [nvarchar](50) NOT NULL,
	[Tipo_Consulta] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([Id], [Nombre], [Apellido], [Dni], [Mail], [Telefono], [Fecha_Consulta], [Horario], [Obra_Social], [Tipo_Consulta]) VALUES (1, N'Lucas', N'Diaz Giosso', N'26457859', N'lucas@prueba.com', N'1165986589', N'06/06/2022', N'11 - 12 hs', N'Galeno', N'Nutricion')
INSERT [dbo].[Pacientes] ([Id], [Nombre], [Apellido], [Dni], [Mail], [Telefono], [Fecha_Consulta], [Horario], [Obra_Social], [Tipo_Consulta]) VALUES (2, N'Lucas', N'Rodriguez', N'26564823', N'lucasrodriguez@prueba.com', N'1165987415', N'05/06/2022', N'10 - 11 hs', N'Osde', N'Nutricion')
INSERT [dbo].[Pacientes] ([Id], [Nombre], [Apellido], [Dni], [Mail], [Telefono], [Fecha_Consulta], [Horario], [Obra_Social], [Tipo_Consulta]) VALUES (3, N'Lautaro', N'Galarza', N'34567654', N'lautaro@prueba.com', N'1123456745', N'15/06/2022', N'9 - 10 hs', N'Galeno', N'Ginecologia')
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
