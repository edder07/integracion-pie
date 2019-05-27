USE [master]
GO
/****** Object:  Database [integracion_pie]    Script Date: 27-05-2019 14:49:00 ******/
CREATE DATABASE [integracion_pie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'integracion_pie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\integracion_pie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'integracion_pie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\integracion_pie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [integracion_pie] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [integracion_pie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [integracion_pie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [integracion_pie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [integracion_pie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [integracion_pie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [integracion_pie] SET ARITHABORT OFF 
GO
ALTER DATABASE [integracion_pie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [integracion_pie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [integracion_pie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [integracion_pie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [integracion_pie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [integracion_pie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [integracion_pie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [integracion_pie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [integracion_pie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [integracion_pie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [integracion_pie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [integracion_pie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [integracion_pie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [integracion_pie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [integracion_pie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [integracion_pie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [integracion_pie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [integracion_pie] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [integracion_pie] SET  MULTI_USER 
GO
ALTER DATABASE [integracion_pie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [integracion_pie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [integracion_pie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [integracion_pie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [integracion_pie] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [integracion_pie] SET QUERY_STORE = OFF
GO
USE [integracion_pie]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [integracion_pie]
GO
/****** Object:  Table [dbo].[alumno]    Script Date: 27-05-2019 14:49:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumno](
	[rut_alumno] [varchar](10) NOT NULL,
	[nombres_alumno] [varchar](250) NULL,
	[apellido_paterno] [varchar](50) NULL,
	[apellido_materno] [varchar](50) NULL,
	[fono_alumno] [int] NULL,
	[direccion_alumno] [varchar](350) NULL,
	[fecha_nacimiento] [date] NULL,
	[sexo_alumno] [varchar](50) NULL,
	[nacionalidad_alumno] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[rut_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[apoderado]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[apoderado](
	[rut_apoderado] [varchar](10) NOT NULL,
	[nombre_apoderado] [varchar](250) NULL,
	[fono_apoderado] [int] NULL,
	[direccion_apoderado] [varchar](250) NULL,
 CONSTRAINT [PK_apoderado] PRIMARY KEY CLUSTERED 
(
	[rut_apoderado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[citaciones]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citaciones](
	[id_citacion] [int] IDENTITY(1,1) NOT NULL,
	[rut_alumno] [varchar](10) NULL,
	[rut_apoderado] [varchar](10) NULL,
	[fecha_citacion] [date] NULL,
	[motivo] [varchar](1000) NULL,
	[estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_citacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[curso]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[curso](
	[id_curso] [int] NOT NULL,
	[nombre] [varchar](20) NULL,
 CONSTRAINT [PK_curso] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ficha_diagnostico]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ficha_diagnostico](
	[id_fichadiagnostico] [int] IDENTITY(1,1) NOT NULL,
	[rut_alumno] [varchar](10) NULL,
	[id_evaluador_1] [int] NULL,
	[id_evaluador_2] [int] NULL,
	[id_evaluador_3] [int] NULL,
	[id_evaluador_4] [int] NULL,
	[id_evaluador_5] [int] NULL,
	[id_apoyo_1] [int] NULL,
	[id_apoyo_2] [int] NULL,
	[id_apoyo_3] [int] NULL,
	[id_apoyo_4] [int] NULL,
	[id_tipoficha] [int] NULL,
	[curso_alumno] [int] NULL,
	[nuevo_ingreso] [varchar](300) NULL,
	[continuidad] [varchar](20) NULL,
	[diagnostico] [varchar](600) NULL,
	[sindrome_asociado_diagnostico] [varchar](600) NULL,
	[observaciones_salud] [varchar](900) NULL,
	[fecha_emision] [date] NULL,
	[prueba_1] [varchar](200) NULL,
	[puntaje_1] [varchar](4) NULL,
	[prueba_2] [varchar](200) NULL,
	[puntaje_2] [varchar](4) NULL,
	[prueba_3] [varchar](200) NULL,
	[puntaje_3] [varchar](4) NULL,
	[prueba_4] [varchar](200) NULL,
	[puntaje_4] [varchar](4) NULL,
	[prueba_5] [varchar](200) NULL,
	[puntaje_5] [varchar](4) NULL,
	[usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fichadiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesional_apoyo]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesional_apoyo](
	[id_profapoyo] [int] IDENTITY(1,1) NOT NULL,
	[rut_apoyo] [varchar](10) NULL,
	[nombre_apoyo] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_profapoyo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesional_evaluador]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesional_evaluador](
	[id_evaluador] [int] IDENTITY(1,1) NOT NULL,
	[rut_evaluador] [varchar](10) NULL,
	[nombre_evaluador] [varchar](200) NOT NULL,
	[profesion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_evaluador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_ficha]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_ficha](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo] [varchar](80) NULL,
	[descripcion_tipoficha] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 27-05-2019 14:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](100) NULL,
	[pass] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno]) VALUES (N'19833884-2', N'ROY EDDER', N'HIDALGO', N'RIQUELME', 962148388, N'LINARES', CAST(N'1999-01-13' AS Date), N'HOMBRE', N'CHILENA')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno]) VALUES (N'42355676-5', N'ESTEBAN ANDRES', N'PAREDES', N'VARGAS', 986543643, N'LONGAVI', CAST(N'2009-01-16' AS Date), N'HOMBRE', N'CHILENA')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno]) VALUES (N'87654354-0', N'LUIS ANDRES', N'SILVA', N'REYES', 976646545, N'SANTIAGO', CAST(N'2010-02-03' AS Date), N'HOMBRE', N'CHILENA')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno]) VALUES (N'98375876-2', N'ANTONIA LUISA', N'LARA', N'JARA', 453445645, N'CALLE LOS AROMOS LINARES', CAST(N'2014-06-12' AS Date), N'MUJER', N'CHILENA')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado]) VALUES (N'1-1', N'paulina ', 43545345, N'dfgdfg')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (1, N'1° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (2, N'2° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (3, N'3° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (4, N'4° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (5, N'5° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (6, N'6° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (7, N'7° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (8, N'8° Basico')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (9, N'Kinder')
INSERT [dbo].[curso] ([id_curso], [nombre]) VALUES (10, N'Pre-Kinder')
SET IDENTITY_INSERT [dbo].[ficha_diagnostico] ON 

INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario]) VALUES (14, N'19833884-2', 15, 16, 14, 14, 14, 18, 17, 16, 16, 5, 1, N'SI SDSFDSFS', N'SI 1 año', N'VNVBNVBN', N'NO', N'VBNVBNBVNVB', CAST(N'2019-05-27' AS Date), N'vbnvbnbvnv', N'5', N'', N'', N'', N'', N'', N'', N'', N'', 1)
SET IDENTITY_INSERT [dbo].[ficha_diagnostico] OFF
SET IDENTITY_INSERT [dbo].[profesional_apoyo] ON 

INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo]) VALUES (16, N'x', N'VACIO')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo]) VALUES (17, N'19837878-2', N'MARIA ANGELICA LEAL LILLO')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo]) VALUES (18, N'10989000-2', N'ANTONIO JOSE FUENTES CIFUENTES')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo]) VALUES (19, N'12998870-4', N'PILAR ESTEFANIA FUENTES JARA')
SET IDENTITY_INSERT [dbo].[profesional_apoyo] OFF
SET IDENTITY_INSERT [dbo].[profesional_evaluador] ON 

INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion]) VALUES (14, N'x', N'VACIO', N'X')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion]) VALUES (15, N'19845458-2', N'LUISA CECILIA JARA BUSTAMANTE', N'PSICOLOGA')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion]) VALUES (16, N'15673345-0', N'PAULINA MARIA PINOCHET SEGIURA', N'PSICOPERATEUTICA')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion]) VALUES (17, N'12567876-2', N'JOSE LUIS RAMIREZ PEÑA', N'FONOAUDIOLOGO')
SET IDENTITY_INSERT [dbo].[profesional_evaluador] OFF
SET IDENTITY_INSERT [dbo].[tipo_ficha] ON 

INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (4, N'N.E.E', N'NECESIDADES EDUCATIVAS ESPECIALES')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (5, N'N.E.E.P', N'NECESIDADES EDUCATIVAS ESPECIALES PERMANENTE')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (6, N'N.E.E.T', N'NECESIDADES EDUCATIVAS ESPECIALES TRANSITORIAS')
SET IDENTITY_INSERT [dbo].[tipo_ficha] OFF
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [pass]) VALUES (1, N'roy', N'1')
SET IDENTITY_INSERT [dbo].[usuario] OFF
ALTER TABLE [dbo].[citaciones]  WITH CHECK ADD  CONSTRAINT [FK_citaciones_alumno] FOREIGN KEY([rut_alumno])
REFERENCES [dbo].[alumno] ([rut_alumno])
GO
ALTER TABLE [dbo].[citaciones] CHECK CONSTRAINT [FK_citaciones_alumno]
GO
ALTER TABLE [dbo].[citaciones]  WITH CHECK ADD  CONSTRAINT [FK_citaciones_apoderado] FOREIGN KEY([rut_apoderado])
REFERENCES [dbo].[apoderado] ([rut_apoderado])
GO
ALTER TABLE [dbo].[citaciones] CHECK CONSTRAINT [FK_citaciones_apoderado]
GO
ALTER TABLE [dbo].[citaciones]  WITH CHECK ADD  CONSTRAINT [FK_citaciones_citaciones] FOREIGN KEY([id_citacion])
REFERENCES [dbo].[citaciones] ([id_citacion])
GO
ALTER TABLE [dbo].[citaciones] CHECK CONSTRAINT [FK_citaciones_citaciones]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_alumno] FOREIGN KEY([rut_alumno])
REFERENCES [dbo].[alumno] ([rut_alumno])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_alumno]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_curso] FOREIGN KEY([curso_alumno])
REFERENCES [dbo].[curso] ([id_curso])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_curso]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo] FOREIGN KEY([id_apoyo_1])
REFERENCES [dbo].[profesional_apoyo] ([id_profapoyo])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo1] FOREIGN KEY([id_apoyo_2])
REFERENCES [dbo].[profesional_apoyo] ([id_profapoyo])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo1]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo2] FOREIGN KEY([id_apoyo_3])
REFERENCES [dbo].[profesional_apoyo] ([id_profapoyo])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo2]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo3] FOREIGN KEY([id_apoyo_4])
REFERENCES [dbo].[profesional_apoyo] ([id_profapoyo])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_apoyo3]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador] FOREIGN KEY([id_evaluador_1])
REFERENCES [dbo].[profesional_evaluador] ([id_evaluador])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador1] FOREIGN KEY([id_evaluador_2])
REFERENCES [dbo].[profesional_evaluador] ([id_evaluador])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador1]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador2] FOREIGN KEY([id_evaluador_3])
REFERENCES [dbo].[profesional_evaluador] ([id_evaluador])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador2]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador3] FOREIGN KEY([id_evaluador_4])
REFERENCES [dbo].[profesional_evaluador] ([id_evaluador])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador3]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador4] FOREIGN KEY([id_evaluador_5])
REFERENCES [dbo].[profesional_evaluador] ([id_evaluador])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_profesional_evaluador4]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_tipo_ficha] FOREIGN KEY([id_tipoficha])
REFERENCES [dbo].[tipo_ficha] ([id_tipo])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_tipo_ficha]
GO
ALTER TABLE [dbo].[ficha_diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_ficha_diagnostico_usuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[ficha_diagnostico] CHECK CONSTRAINT [FK_ficha_diagnostico_usuario]
GO
USE [master]
GO
ALTER DATABASE [integracion_pie] SET  READ_WRITE 
GO
