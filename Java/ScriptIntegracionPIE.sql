USE [master]
GO
/****** Object:  Database [integracion_pie]    Script Date: 29-08-2019 16:14:11 ******/
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
/****** Object:  Table [dbo].[alumno]    Script Date: 29-08-2019 16:14:11 ******/
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
	[estado] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[rut_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[apoderado]    Script Date: 29-08-2019 16:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[apoderado](
	[rut_apoderado] [varchar](10) NOT NULL,
	[nombre_apoderado] [varchar](250) NULL,
	[fono_apoderado] [int] NULL,
	[direccion_apoderado] [varchar](250) NULL,
	[rut_fk_alumno] [varchar](10) NULL,
 CONSTRAINT [PK_apoderado] PRIMARY KEY CLUSTERED 
(
	[rut_apoderado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[citaciones]    Script Date: 29-08-2019 16:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citaciones](
	[id_citacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha_citacion] [date] NULL,
	[fecha_reunion] [date] NULL,
	[autoridad] [varchar](50) NULL,
	[hora] [varchar](20) NULL,
	[descripcion_fecha] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_citacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[curso]    Script Date: 29-08-2019 16:14:11 ******/
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
/****** Object:  Table [dbo].[ficha_diagnostico]    Script Date: 29-08-2019 16:14:11 ******/
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
	[puntaje_1] [varchar](50) NULL,
	[prueba_2] [varchar](200) NULL,
	[puntaje_2] [varchar](50) NULL,
	[prueba_3] [varchar](200) NULL,
	[puntaje_3] [varchar](50) NULL,
	[prueba_4] [varchar](200) NULL,
	[puntaje_4] [varchar](50) NULL,
	[prueba_5] [varchar](200) NULL,
	[puntaje_5] [varchar](50) NULL,
	[usuario] [int] NULL,
	[nombre_apoyo_1] [varchar](200) NULL,
	[nombre_apoyo_2] [varchar](200) NULL,
	[nombre_apoyo_3] [varchar](200) NULL,
	[nombre_apoyo_4] [varchar](200) NULL,
	[nombre_evaluador_1] [varchar](200) NULL,
	[nombre_evaluador_2] [varchar](200) NULL,
	[nombre_evaluador_3] [varchar](200) NULL,
	[nombre_evaluador_4] [varchar](200) NULL,
	[nombre_evaluador_5] [varchar](200) NULL,
	[numero_estudiante] [int] NULL,
	[rut_evaluador_1] [varchar](10) NULL,
	[rut_evaluador_2] [varchar](10) NULL,
	[rut_evaluador_3] [varchar](10) NULL,
	[rut_evaluador_4] [varchar](10) NULL,
	[rut_evaluador_5] [varchar](10) NULL,
	[profesion_evaluador_1] [varchar](200) NULL,
	[profesion_evaluador_2] [varchar](200) NULL,
	[profesion_evaluador_3] [varchar](200) NULL,
	[profesion_evaluador_4] [varchar](200) NULL,
	[profesion_evaluador_5] [varchar](200) NULL,
	[rut_apoyo_1] [varchar](10) NULL,
	[rut_apoyo_2] [varchar](10) NULL,
	[rut_apoyo_3] [varchar](10) NULL,
	[rut_apoyo_4] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_fichadiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesional_apoyo]    Script Date: 29-08-2019 16:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesional_apoyo](
	[id_profapoyo] [int] IDENTITY(1,1) NOT NULL,
	[rut_apoyo] [varchar](10) NULL,
	[nombre_apoyo] [varchar](200) NOT NULL,
	[estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_profapoyo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesional_evaluador]    Script Date: 29-08-2019 16:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesional_evaluador](
	[id_evaluador] [int] IDENTITY(1,1) NOT NULL,
	[rut_evaluador] [varchar](10) NULL,
	[nombre_evaluador] [varchar](200) NOT NULL,
	[profesion] [varchar](100) NULL,
	[estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_evaluador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_ficha]    Script Date: 29-08-2019 16:14:11 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 29-08-2019 16:14:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](100) NULL,
	[pass] [varchar](100) NULL,
	[tipo_usuario] [varchar](8) NULL,
	[Nombre_completo_usuario] [varchar](200) NULL,
	[estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'15676690-1', N'roberto pablo', N'riquelme', N'marin', 987876765, N'punta arenas', CAST(N'1998-01-07' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'16294876-8', N'catalina paulina', N'jara', N'rios', 96767667, N'mexico', CAST(N'2019-08-27' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'18772240-3', N'bernardo jesus', N'benavente', N'nuñez', 945456735, N'los aromos', CAST(N'2019-08-27' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'18787656-1', N'jabiera andrea', N'suares', N'carrillo', 987876765, N'punta arenas', CAST(N'1998-12-07' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'19764376-5', N'ALFONSO LUIS', N'PERES', N'PEREIRA', 962573672, N'LINARES SN NUMERO', CAST(N'2000-02-02' AS Date), N'HOMBRE', N'ARGENTINA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'19833884-1', N'abraham joseph', N'sanches', N'BRAVO', 963527432, N'TALCA', CAST(N'2010-10-18' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'19833884-2', N'GERARDO JORGE', N'VARGAS', N'BRAVO', 962148888, N'TALCA', CAST(N'2009-07-01' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'19837473-3', N'ANTONIA JULIA', N'URRUTIA', N'YAÑES', 976575432, N'NUEVA YORK', CAST(N'2009-06-19' AS Date), N'MUJER', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'19873563-9', N'ENRIQUE LUIS', N'MARQUEZ', N'YAÑEZ', 675654564, N'LOS PINOS SAN ANTONIO SANTIAGO', CAST(N'2013-05-07' AS Date), N'HOMBRE', N'CHILENA', N'inactivo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'21321312-1', N'RODRIGO ANTONIO', N'CACERES', N'SUAZO', 952374264, N'TALCA', CAST(N'2009-06-10' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'22876348-9', N'MARIA PILAR', N'AGUILAR', N'AGUILAR', 937576543, N'LOS ANGELES', CAST(N'2010-03-10' AS Date), N'MUJER', N'ARGENTINA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'31456765-1', N'martin mauricio', N'leal', N'paredes', 965656545, N'arica', CAST(N'1998-11-07' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'5882730-4', N'carolina lucia', N'palma', N'prieto', 976352427, N'los angeles', CAST(N'2009-06-19' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[alumno] ([rut_alumno], [nombres_alumno], [apellido_paterno], [apellido_materno], [fono_alumno], [direccion_alumno], [fecha_nacimiento], [sexo_alumno], [nacionalidad_alumno], [estado]) VALUES (N'9873563-9', N'JULIO ANDRES', N'RAMIRES', N'PALMA', 965326753, N'LOS ANGELES CALIFORNIA', CAST(N'2013-05-07' AS Date), N'HOMBRE', N'CHILENA', N'activo')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'11119898-2', N'MARIANA ANTONIA VILLAGRAN JARA', 967485362, N'LOS PINOS SANTIAGO', N'21321312-1')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'14179172-9', N'ERICA MARIA DEL CARMEN PALMA', 956456789, N'LOS PINOS LINARES', N'19764376-5')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'17876754-2', N'FABIOLA ANDREA QUIROZ RETAMAL', 972354274, N'LOS AROMOS LINARES', N'19833884-2')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'19401394-9', N'MARIO JESUS DUARTE PERES', 967485362, N'LOS PINOS SANTIAGO', N'16294876-8')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'19786654-2', N'JESUS ANDRES LEON LOPEZ', 967676567, N'SANTIAGO', N'22876348-9')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'222222-2', N'CECILIA ANGELICA RODRIGUES', 873657836, N'PUERTO MONTT', N'9873563-9')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'7408333-1 ', N'ANDREA BARBARA BULNES FREI', 988888767, N'SAN ANTONIO', N'18772240-3')
INSERT [dbo].[apoderado] ([rut_apoderado], [nombre_apoderado], [fono_apoderado], [direccion_apoderado], [rut_fk_alumno]) VALUES (N'78364578-4', N'ANTONIA MARIA LOPES RIVERA', 873657836, N'LINARES', N'19837473-3')
SET IDENTITY_INSERT [dbo].[citaciones] ON 

INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (12, CAST(N'2019-06-18' AS Date), CAST(N'2019-07-11' AS Date), N'Equipo P.I.E.', N'13:40 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (13, CAST(N'2019-06-18' AS Date), CAST(N'2019-06-08' AS Date), N'Equipo P.I.E.', N'12:43 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (14, CAST(N'2019-06-18' AS Date), CAST(N'2019-06-21' AS Date), N'Equipo P.I.E.', N'13:40 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (15, CAST(N'2019-06-18' AS Date), CAST(N'2019-06-24' AS Date), N'Profesora Diferencial', N'16:30 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (16, CAST(N'2019-06-18' AS Date), CAST(N'2019-07-25' AS Date), N'Equipo P.I.E.', N'15:12 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (17, CAST(N'2019-06-18' AS Date), CAST(N'2019-08-22' AS Date), N'Equipo P.I.E.', N'14:00 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (18, CAST(N'2019-06-18' AS Date), CAST(N'2019-09-13' AS Date), N'Psicologo', N'15:00 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (19, CAST(N'2019-06-18' AS Date), CAST(N'2019-06-27' AS Date), N'Profesora Diferencial', N'14:32 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (20, CAST(N'2019-06-18' AS Date), CAST(N'2019-08-22' AS Date), N'Equipo P.I.E.', N'17:00 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (21, CAST(N'2019-06-18' AS Date), CAST(N'2019-06-26' AS Date), N'Equipo P.I.E.', N'12:45 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (22, CAST(N'2019-06-18' AS Date), CAST(N'2019-07-10' AS Date), N'Equipo P.I.E.', N'16:00 hrs', N'Llancanao,  18 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (23, CAST(N'2019-06-20' AS Date), CAST(N'2019-11-13' AS Date), N'Terapeuta Ocupacional', N'11:00 hrs', N'Llancanao,  20 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (24, CAST(N'2019-06-20' AS Date), CAST(N'2019-05-17' AS Date), N'Director del Establecimiento', N'11:11 hrs', N'Llancanao,  20 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (25, CAST(N'2019-06-20' AS Date), CAST(N'2019-06-20' AS Date), N'', N'34:00 hrs', N'Llancanao,  20 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (26, CAST(N'2019-06-20' AS Date), CAST(N'2019-06-20' AS Date), N'Profesora Diferencial', N'12:00 hrs', N'Llancanao,  20 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (27, CAST(N'2019-06-20' AS Date), CAST(N'2019-06-20' AS Date), N'Equipo P.I.E.', N'12:56 hrs', N'Llancanao,  20 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (28, CAST(N'2019-06-22' AS Date), CAST(N'2019-07-11' AS Date), N'Profesora Diferencial', N'16:00 hrs', N'Llancanao,  22 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (29, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-24' AS Date), N'', N'4:33 hrs', N'Llancanao,  24 de junio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (30, CAST(N'2019-07-13' AS Date), CAST(N'2019-07-15' AS Date), N'Equipo P.I.E.', N'18:00 hrs', N'Llancanao,  13 de julio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (31, CAST(N'2019-07-18' AS Date), CAST(N'2019-07-20' AS Date), N'Equipo P.I.E.', N'17:00 hrs', N'Llancanao,  18 de julio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (32, CAST(N'2019-07-22' AS Date), CAST(N'2019-07-23' AS Date), N'Equipo P.I.E.', N'16:00 hrs', N'Llancanao,  22 de julio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (33, CAST(N'2019-07-24' AS Date), CAST(N'2019-07-25' AS Date), N'Equipo P.I.E.', N'17:00 hrs', N'Llancanao,  24 de julio del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (41, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-19' AS Date), N'Equipo P.I.E.', N'12:00 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (42, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-21' AS Date), N'Profesora Diferencial', N'19:00 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (43, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-20' AS Date), N'Equipo P.I.E.', N'17:00 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (44, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-20' AS Date), N'Equipo P.I.E.', N'16:00 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (45, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-19' AS Date), N'Equipo P.I.E.', N'17:00 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (46, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-20' AS Date), N'Equipo P.I.E.', N'14:10 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (47, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-19' AS Date), N'Equipo P.I.E.', N'19:30 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (48, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-19' AS Date), N'Equipo P.I.E.', N'15:00 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (49, CAST(N'2019-08-19' AS Date), CAST(N'2019-08-19' AS Date), N'Equipo P.I.E.', N'13:10 hrs', N'Llancanao,  19 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (50, CAST(N'2019-08-20' AS Date), CAST(N'2019-08-23' AS Date), N'Psicologo', N'18:00 hrs', N'Llancanao,  20 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (51, CAST(N'2019-08-23' AS Date), CAST(N'2019-08-24' AS Date), N'Psicologo', N'19:00 hrs', N'Llancanao,  23 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (52, CAST(N'2019-08-23' AS Date), CAST(N'2019-07-30' AS Date), N'Equipo P.I.E', N'19:25', N'Llancanao, 23 de agosto del 2019')
INSERT [dbo].[citaciones] ([id_citacion], [fecha_citacion], [fecha_reunion], [autoridad], [hora], [descripcion_fecha]) VALUES (53, CAST(N'2019-08-23' AS Date), CAST(N'2019-08-17' AS Date), N'Equipo P.I.E', N'19:00 hrs', N'Llancanao,  23 de agosto del 2019')
SET IDENTITY_INSERT [dbo].[citaciones] OFF
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

INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (77, N'19833884-1', 15, 14, 14, 14, 14, 18, 26, 16, 16, 5, 1, N'No accidente camino a casa', N'Si 2 años', N'el diagnostico es alentador', N'Si No', N'el alumno esta estable', CAST(N'2019-03-01' AS Date), N'prueba de conocimientos generales', N'8', N'', N'', N'', N'', N'', N'', N'', N'', 2, N'ANTONIO JOSE FUENTES CASTRO', N'CAROLINA CARMELA PINO PALMA', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'VACIO', N'VACIO', N'VACIO', N'VACIO', 6, N'19845458-2', N'x', N'x', N'x', N'x', N'PSICOLOGA', N'X', N'X', N'X', N'X', N'10989000-2', N'19898765-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (82, N'19837473-3', 15, 16, 14, 14, 14, 18, 16, 16, 16, 6, 1, N'No nmnbnbnbbnnbbbmmmbbmn', N'No mbbh', N'bhghjgjhggjghghggjhgjjgh', N'No', N'bnvbnvbnvnbvb', CAST(N'2019-07-22' AS Date), N'mnbnmbnmbnm', N'88', N'mm,mm,m', N'7', N'', N'', N'', N'', N'', N'', 2, N'ANTONIO JOSE FUENTES CASTRO', N'VACIO', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURO', N'VACIO', N'VACIO', N'VACIO', 8, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPEDAGOGA', N'X', N'X', N'X', N'10989000-2', N'x', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (95, N'15676690-1', 15, 16, 14, 14, 14, 18, 26, 16, 16, 5, 1, N'Si caida de bicicleta', N'No 1 año', N'brazo roto', N'No', N'reposo total', CAST(N'2019-08-14' AS Date), N'matematica', N'3', N'', N'', N'', N'', N'', N'', N'', N'', 2, N'ANTONIO JOSE FUENTES CASTRO', N'CAROLINA CARMELA PINO PALMA', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURO', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPEDAGOGA', N'X', N'X', N'X', N'10989000-2', N'19898765-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (96, N'31456765-1', 15, 16, 14, 14, 14, 18, 16, 16, 16, 5, 1, N'Si accidente camino al colegio', N'No 1 año', N'estable', N'Si No', N'reposo', CAST(N'2019-07-03' AS Date), N'religion', N'8', N'', N'', N'', N'', N'', N'', N'', N'', 2, N'ANTONIO JOSE FUENTES CASTRO', N'VACIO', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURO', N'VACIO', N'VACIO', N'VACIO', 21, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPEDAGOGA', N'X', N'X', N'X', N'10989000-2', N'x', N'x', N'x')
SET IDENTITY_INSERT [dbo].[ficha_diagnostico] OFF
SET IDENTITY_INSERT [dbo].[profesional_apoyo] ON 

INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (16, N'x', N'VACIO', N'activo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (17, N'19837878-2', N'MARIA ANGELICA LEAL ', N'inactivo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (18, N'10989000-2', N'ANTONIO JOSE FUENTES CASTRO', N'activo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (19, N'12998870-4', N'PILAR ESTEFANIA FUENTES JARA', N'inactivo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (26, N'19898765-2', N'CAROLINA CARMELA PINO PALMA', N'activo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (28, N'16767894-2', N'carmela lucila castro lagos', N'inactivo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (29, N'16789567-k', N'CECILIA ANGELICA JARA PALMA', N'activo')
INSERT [dbo].[profesional_apoyo] ([id_profapoyo], [rut_apoyo], [nombre_apoyo], [estado]) VALUES (30, N'20623087-8', N'MANUEL PEDRO HURDEMALES CASTRO', N'activo')
SET IDENTITY_INSERT [dbo].[profesional_apoyo] OFF
SET IDENTITY_INSERT [dbo].[profesional_evaluador] ON 

INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (14, N'x', N'VACIO', N'X', N'activo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (15, N'19845458-2', N'LUISA CECILIA JARA BUSTAMANTE', N'PSICOLOGA', N'activo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (16, N'15673345-0', N'PAULINA MARIA PINOCHET SEGURA', N'PSICOPEDAGOGA', N'activo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (17, N'12567876-2', N'JOSE LUIS RAMIREZ PEÑA', N'FONOAUDIOLOGO', N'activo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (18, N'10899983-2', N'RICARDO LUIS JARA MONTENEGRO', N'ENFERMERO', N'inactivo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (19, N'22876348-9', N'DANIEL CASTRO QUINTANILLA', N'TERAPEUTA', N'inactivo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (20, N'12456309-2', N'ROGELIO EMILIO MENDOZA CABRERA', N'FONOAUDIOLOGO', N'inactivo')
INSERT [dbo].[profesional_evaluador] ([id_evaluador], [rut_evaluador], [nombre_evaluador], [profesion], [estado]) VALUES (21, N'19962472-5', N'FRANCO ALEJANDRO RIU BULNEZ', N'AYUDANTE SOCIAL', N'activo')
SET IDENTITY_INSERT [dbo].[profesional_evaluador] OFF
SET IDENTITY_INSERT [dbo].[tipo_ficha] ON 

INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (5, N'N.E.E.P', N'NECESIDADES EDUCATIVAS ESPECIALES PERMANENTE')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (6, N'N.E.E.T', N'NECESIDADES EDUCATIVAS ESPECIALES TRANSITORIAS')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (7, N'T.E.L', N'TRASTORNO ESPECIFICO DEL LENGUAJE')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (8, N'T.E.L.E', N'TRASTORNO ESPECIFICO DEL LENGUAJE EXPRESIVO')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (9, N'T.E.L.M', N'TRASTORNO ESPECIFICO DEL LENGUAJE MIXTO')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (10, N'D.E.A', N'DIFICULTADES ESPECIFICAS DEL LENGUAJE')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (12, N'D.I.L', N'DISCAPACIDAD INTELECTUAL LEVE')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (13, N'D.I.M', N'DISCAPACIDAD INTELECTUAL MODERADA')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (14, N'F.I.L', N'FUNCIONAMEIENTO INTELECUAL LIMITROFE')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (15, N'R.G.D', N'RETRASO GLOBAL DEL DESARROLLO')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (16, N'T.E.A', N'TRASTORNO DEL ESPECTRO AUTISTA')
INSERT [dbo].[tipo_ficha] ([id_tipo], [nombre_tipo], [descripcion_tipoficha]) VALUES (17, N'T.D.A', N'TRASTORNO DE DEFICIT ATENCIONAL')
SET IDENTITY_INSERT [dbo].[tipo_ficha] OFF
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [pass], [tipo_usuario], [Nombre_completo_usuario], [estado]) VALUES (1, N'roy', N'1', N'admin', N'hjjghj', N'inactivo')
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [pass], [tipo_usuario], [Nombre_completo_usuario], [estado]) VALUES (2, N'r', N'1', N'admin', N'Roy Edder Hidalgo Riquelme', N'activo')
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [pass], [tipo_usuario], [Nombre_completo_usuario], [estado]) VALUES (3, N'cristian', N'1', N'admin', N'cristian oyarzun', N'activo')
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [pass], [tipo_usuario], [Nombre_completo_usuario], [estado]) VALUES (6, N'popos', N'12', N'admin', N'luis jara', N'inactivo')
INSERT [dbo].[usuario] ([id_usuario], [nombre_usuario], [pass], [tipo_usuario], [Nombre_completo_usuario], [estado]) VALUES (7, N'carlos', N'123', N'admin', N'CARLOS EDUARDO DURAN HERNANDEZ', N'activo')
SET IDENTITY_INSERT [dbo].[usuario] OFF
ALTER TABLE [dbo].[apoderado]  WITH CHECK ADD  CONSTRAINT [FK_apoderado_alumno] FOREIGN KEY([rut_fk_alumno])
REFERENCES [dbo].[alumno] ([rut_alumno])
GO
ALTER TABLE [dbo].[apoderado] CHECK CONSTRAINT [FK_apoderado_alumno]
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
/****** Object:  StoredProcedure [dbo].[buscador_ficha_rut]    Script Date: 29-08-2019 16:14:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create procedure [dbo].[buscador_ficha_rut]
  @rut_buscar varchar(10), 
   @fecha_buscar date 
 as

select ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo  
   from ficha_diagnostico , tipo_ficha , alumno , curso
   where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = @rut_buscar   and ficha_diagnostico.fecha_emision = @fecha_buscar 
  
GO
/****** Object:  StoredProcedure [dbo].[citaciones_reporte]    Script Date: 29-08-2019 16:14:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[citaciones_reporte]
  @fecha_actual varchar(10), 
   @fecha_reunion varchar(10)
   
 as
select top 1 citaciones.descripcion_fecha , citaciones.fecha_reunion , citaciones.autoridad , citaciones.hora from citaciones where citaciones.fecha_citacion = @fecha_actual    and citaciones.fecha_reunion = @fecha_reunion  order by id_citacion desc  
GO
/****** Object:  StoredProcedure [dbo].[lista_completa_alumno]    Script Date: 29-08-2019 16:14:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[lista_completa_alumno]

 as
 select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , curso.nombre 'Curso Alumno' from ficha_diagnostico , alumno , curso , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = curso.id_curso and alumno.estado= 'activo'
  
GO
/****** Object:  StoredProcedure [dbo].[reporte_por_curso]    Script Date: 29-08-2019 16:14:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_por_curso]
 @num_curso integer 
as
select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , curso.nombre 'Curso Alumno'  from ficha_diagnostico , alumno, curso , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = curso.id_curso  and ficha_diagnostico.curso_alumno = @num_curso  and alumno.estado= 'activo'
GO
USE [master]
GO
ALTER DATABASE [integracion_pie] SET  READ_WRITE 
GO
