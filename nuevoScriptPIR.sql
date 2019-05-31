USE [master]
GO
/****** Object:  Database [integracion_pie]    Script Date: 31-05-2019 13:39:01 ******/
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
/****** Object:  Table [dbo].[alumno]    Script Date: 31-05-2019 13:39:01 ******/
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
/****** Object:  Table [dbo].[apoderado]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[citaciones]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[curso]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[ficha_diagnostico]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[profesional_apoyo]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[profesional_evaluador]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[tipo_ficha]    Script Date: 31-05-2019 13:39:02 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 31-05-2019 13:39:03 ******/
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

INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (14, N'19833884-2', 15, 16, 14, 14, 14, 18, 17, 16, 16, 5, 1, N'SI SDSFDSFS', N'SI 1 año', N'VNVBNVBN', N'NO', N'VBNVBNBVNVB', CAST(N'2019-05-27' AS Date), N'vbnvbnbvnv', N'5', N'', N'', N'', N'', N'', N'', N'', N'', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (17, N'42355676-5', 15, 16, 14, 14, 14, 17, 18, 19, 16, 4, 6, N'SI SE LE DIAGNOSTICO ESE PROBLEMA EN INTEGRACION', N'NO 1', N'EL DIAGNOSTICO DICE QUE DEBE TENER CUIDADDOS INTENSIVOS', N'NO', N'EL ALUMNO SE ENCUENTRA ESRTABLE', CAST(N'2009-05-13' AS Date), N'prueba de conocimiento', N'4', N'', N'', N'', N'', N'', N'', N'', N'', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (18, N'87654354-0', 15, 16, 17, 14, 14, 17, 18, 19, 16, 4, 3, N'SI CVXCVVX', N'NO 2', N'BVCBCVBVCBCVB', N'NO', N'VBCVBCVBCVBVC', CAST(N'2014-06-13' AS Date), N'cvbcvbcvb', N'4,5 ', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (19, N'98375876-2', 15, 16, 14, 14, 14, 17, 18, 19, 16, 5, 2, N'SI CBVVBCVBCB', N'NO 2', N'CVBVBVBVCB', N'NO', N'CBCVBCVBCVB', CAST(N'2014-06-04' AS Date), N'cvbcvbcvbcvb', N'4 ', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (20, N'42355676-5', 15, 16, 16, 14, 14, 17, 18, 16, 16, 6, 2, N'NO', N'NO 2', N'MHJGHJGJHGJH', N'NO', N'HJGJHGJHGHJ', CAST(N'2019-05-29' AS Date), N'ghjghjghj', N'5', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', 1, N'19845458-2', N'15673345-0', N'15673345-0', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'PSICOPERATEUTICA', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (21, N'87654354-0', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 1, N'SI PRESENTO ESTOS SINTOMAS DE MANERA SILENCIOSA', N'SI 2', N'EL DIAGNOSTICO ES PROMETEDOR YA QUE SE ENCUENTRA EN CONSTANTE EVALUACION', N'NO', N'EL ALUMNO ESTA ESTABLE SIN RIEGO ALGUNO', CAST(N'2019-05-29' AS Date), N'conocimiento general', N'5', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 1, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (22, N'19833884-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 2, N'SI EL ALUMNO SUFRIO VARIOS SINTOMAS', N'SI 2', N'EL DIAGNOSTICO ES PROMETEDOR PERO SOLO SI SE TIENE EN CONSTANTE EVALUACION', N'NO', N'EL ALUMNO ESTA ESTABLE SIN RIESGO VITAS', CAST(N'2014-08-07' AS Date), N'contar numeros reales', N'4', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (23, N'19833884-2', 15, 16, 17, 14, 14, 17, 18, 19, 16, 4, 1, N'NO', N'SI 2', N'SDFDSF', N'NO', N'SDFSFDSFSD', CAST(N'2017-05-11' AS Date), N'dfdsfsdf', N'3', N'dgfdgdfgdfg', N'6', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', 1, N'19845458-2', N'15673345-0', N'12567876-2', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'FONOAUDIOLOGO', N'X', N'X', N'19837878-2', N'10989000-2', N'12998870-4', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (24, N'87654354-0', 15, 16, 17, 14, 14, 17, 19, 16, 16, 6, 2, N'NO', N'NO 2', N'DSFSDFSDF', N'NO', N'SDFSDFDS', CAST(N'2019-05-29' AS Date), N'sdfsdfsdfsdfsdfsdfs dsfsfsfs scfsdfsdfsdfsdf', N'2', N'sdfsdfs sfsfs sdfsfdsdfsdfs', N'5', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'12567876-2', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'FONOAUDIOLOGO', N'X', N'X', N'19837878-2', N'12998870-4', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (26, N'87654354-0', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 3, N'NO', N'NO 2', N'SDFSDFDGFFD SHFJKSHFKJDFV KJSDFHJSKF SDKJFHSKJFHKS SKJFHKJSFHJKSF ISHFSHFKJSHFKJS SFHJSKHFJKSHFKS KJSFH', N'NO', N'SDFSFSDFSDFSDFSDFS', CAST(N'2009-06-19' AS Date), N'sdfsfsdfs', N'2', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (27, N'19833884-2', 15, 14, 14, 14, 14, 17, 16, 16, 16, 4, 2, N'NO', N'NO 2', N'DSFSDFDS FGD FGFHFGH FH FGH GF  H FG   G H F G H FG H GF H  FGHFG H FG H FG HFGH FG HFH F H FGH  F H F  H FG  H FG H FG', N'NO', N'VVBCVB', CAST(N'2044-06-24' AS Date), N'cvbcvbcvbcv', N'3', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'VACIO', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'VACIO', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'x', N'x', N'x', N'x', N'PSICOLOGA', N'X', N'X', N'X', N'X', N'19837878-2', N'x', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (28, N'19833884-2', 15, 16, 17, 14, 14, 18, 19, 16, 16, 5, 2, N'NO', N'NO 2', N'DDDDDDDDDDDDDDDDDDDDDDDDDDDD', N'NO', N'OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO', CAST(N'2044-06-23' AS Date), N'pppppppppppppppppppppppppppppppppppppp', N'2', N'q1111111111111111111qqqqqqqqqqqqq11', N'5', N'vbnbv  cbdfhc dbfcgdc  fcv dfgdgdfgdfgdgdgdf', N'6', N'', N'', N'', N'', 1, N'ANTONIO JOSE FUENTES CIFUENTES', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'12567876-2', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'FONOAUDIOLOGO', N'X', N'X', N'10989000-2', N'12998870-4', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (29, N'87654354-0', 15, 16, 14, 14, 14, 17, 18, 16, 16, 4, 8, N'NO', N'NO 2', N'DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD', N'NO', N'OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO', CAST(N'2014-05-14' AS Date), N'yttttttttttttttttttttttttttttttttttttttttttttttn gfopoooooooooooooooooooooooo', N'7', N'pppppppppppppppppooooooooooooooooooooooooooooooooooooooooo', N'6', N'rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrreeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee', N'5', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 4, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (30, N'19833884-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 4, 1, N'NO', N'NO 33', N'FGHFHFDHFGDFHDHJKHKHGJGH', N'NO', N'HFGHFDFGFGHDFH', CAST(N'1989-05-16' AS Date), N'fghdffghfgh fghdhdfhfdhdf fhfhf fghfhfdhdfhdfhdfhfdhfdhdf', N'4', N'hfbvhhgrrttttttttttt tttttttttttuuuuuuuuuuuuuuuu uuuuuuuuuu', N'6', N'yyyyyyyyyyyyyyyyyyyy rrrrrrrrrrrrrrrrrrrrrrrrrrr qqqqqqqqqqqqqqqqqq', N'5', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (31, N'19833884-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 4, 2, N'NO', N'NO 4', N'GHFGHFGHFTR  JGKHKHKJKHJKHJKHJKHJKHJKHHJ FHFJ', N'NO', N'GHJGHJGJGH HJGHJYUKUILIOIOIOLOIL,J FGFHFGFGF', CAST(N'1998-08-14' AS Date), N'awrwf-ljslkhvjkdfvndsbnv kjdfhvkjsvhsjadkskadfsj kjsfhdkjfasjfhskjhfjskf', N'3', N'ertekljke ckljkrhewj cskhrkwrw euriowuroiwuroiwe', N'3', N'wkjrwhrjkw jkwyriuwyriuwe jkwryuwyiuwe kjwrykwuyrkw', N'4', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (32, N'98375876-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 2, N'NO', N'SI 4', N'DFGDFGDFGDF DFH DHDF HDFH DFH DF HDFH D ', N'NO', N'DHFHDFH DHDFHD DFHDFHD DFHDFHDF DFHDF', CAST(N'2045-07-22' AS Date), N'hdfh dfh dfhdfh fdhfj  j tu tyutyutyu tutyutyut tyutut', N'6', N'yyyyyyyyyy         yyyyyyyyyyyyy yyyyyyyyyyyyyy yyyyyyyyyyyyy', N'6', N'jjjjjjjjjjjjjjjjjjjjjjjjjjjjj yyyyi iiiiiiiiiiiiiiiiiiiiiiiii o ooooooooooooooo', N'5', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (33, N'87654354-0', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 2, N'SI RTYRTYRTYRTYRTYRY RB', N'NO 4', N'RYRUNTYIYIRB ITITYIYI PIP FHF T FTTUUTY YTRRTH', N'', N'', CAST(N'2085-06-07' AS Date), N'456bppppppp ppppppppppppppppppppppp ppppppppppppppppppppppp ', N'7', N'aaaaaaaaaaaaaaaaaassssssssssssssssss ddddddddddddddddddddddddddddddd', N'4', N'ttrrrrrrrrrrrrrrrrrrrrrrrrr rryyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy', N'5', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (34, N'42355676-5', 15, 16, 17, 14, 14, 17, 18, 16, 16, 5, 6, N'NO', N'SI 4', N'FGHFGH FHGFHHHHHHHHHHHHHHHHHHH H HHHHHHH', N'NO', N'HHHHHHHHHHHHHHHHHHHHHHHHHHH', CAST(N'2008-11-13' AS Date), N'yyyyyyyyyyyyyyyyyyyyy yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy', N'4', N'pppppppppppppp ppppppppppppppp ppppppppppppppp', N'8', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'12567876-2', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'FONOAUDIOLOGO', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (35, N'87654354-0', 15, 16, 17, 14, 14, 17, 18, 19, 16, 5, 3, N'NO', N'NO 4', N'HFGJJGH GHKJHKHJ JKHKJH JHL LIILKJLUI TYG HFHGFHDF HDFHFDH HFHF FGHFGH FDHHDFH REYERTER TFHERYREYRE RTYRTYERY RTYERY REY RRTYER RTYRTYY', N'NO', N'RTYRT RTURTUTYURETRTE TRTY ERYERY RTYR RTU UER UR  IU  IIOOPPP 09 P09UPUP 0OIPOIUIPUPUIPIUPUIPPIU UI  ', CAST(N'2077-06-11' AS Date), N'ryrty rty rtyrty r ytrytry try ryrt  yry rty rty tr ', N'5', N'trhtyyyyyyyyyyuuuuuuuuuuuuu uuuuuuuuuuuu', N'5', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'12567876-2', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'FONOAUDIOLOGO', N'X', N'X', N'19837878-2', N'10989000-2', N'12998870-4', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (36, N'19833884-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 2, N'SI EL ALUMNO PRESENTO ALGUNOS SINTOMAS DE ESTA PATOLOGIA EN EL TRANSCURSO DEL AÑO POR LO QUE SE LE EVALUO Y SE DIAGNOSTICO ESTE SINDROME', N'NO 1', N'EL DIAGNOSTICO ES CATEGORICO EL ALUMNO TENDRA QUE SER SOMETIDO A DIFERENTES TRATAMIENTOS PARA SU PRONTA RECUPERAACION', N'NO', N'EL ALUMNO ESTA ESTABLE SIN RIESGO ALGUNO POR EL MOMENTO', CAST(N'1985-06-13' AS Date), N'prueba de desarrollo inttelectual', N'6,7', N'prueba de movilidad motris', N'7', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (37, N'19833884-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 4, 2, N'NO', N'NO 1 año', N'EL DIAGNOSTICO DICE QUE EL ALUMNO DEBERA PRESENTAR UNA SERIE DE EVALUACIONES CON LA QUE SE DETECTARA SI PRESENTA DE VERDAD ESTA PATOLOGIA', N'NO', N'EL ALUMNO ESTA ESTABLE Y SIN RIEGO ALGUNO', CAST(N'2019-05-30' AS Date), N'prueba de desarrollo intelectual', N'4', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (38, N'19833884-2', 15, 16, 14, 14, 14, 17, 18, 16, 16, 4, 2, N'NO', N'NO 1 año', N'EL DIAGNOSTICO DICE QUE EL ALUMNO DEBERA PRESENTAR UNA SERIE DE EVALUACIONES CON LA QUE SE DETECTARA SI PRESENTA DE VERDAD ESTA PATOLOGIA', N'NO', N'EL ALUMNO ESTA ESTABLE Y SIN RIEGO ALGUNO', CAST(N'1944-06-15' AS Date), N'prueba de desarrollo intelectual', N'4', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (39, N'42355676-5', 15, 16, 14, 14, 14, 17, 18, 16, 16, 6, 2, N'NO', N'NO 3', N'DGDFGDFGDFGDFGDF', N'NO', N'DFGDFGDGDFG', CAST(N'2033-02-16' AS Date), N'fdgdfgdfgdf', N'4', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 2, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (40, N'87654354-0', 15, 16, 14, 14, 14, 17, 18, 16, 16, 5, 5, N'SI EL MOTIVO ES PORQUE EL ALUMNO PRESENTO ALGUNOS SINTOMAS Y SE LE REALIZO UNA EVALUACION YSE DIAGNOSTICO ESTE SINDROME', N'NO 1', N'EL DIAGNOSTICO ES PREPARACION TANTO FISICA COMO PSICOLOGICAMENTE PARA SUPERAR ESTE SINDROME', N'NO', N'EL ALUMNO ESTA ESTABLE PERO CON SUPERVICION ESPECIAL Y PROFESIONAL', CAST(N'1994-07-14' AS Date), N'prueba de desarrollo intelectual', N'6', N'prueba de movilidad motris', N'7', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (41, N'87654354-0', 15, 17, 14, 14, 14, 17, 18, 16, 16, 6, 2, N'NO', N'NO 4', N'DFGDFGDFGDFGDFGDFGDFGDFGDFGDFDFGDFDFGDFG GGGGGGGGGGGGGGGGGGGGGGG GGGGGGGGGGGGGGGGGGGGGGGGGGGGG GGGGGGGGGGGGGGGGGGGGGGGGGGG', N'NO', N'GGGGGGGGGGGGGGGG GGGGGGGGGGGGGGGGGGGGGGH         HHHHHHHHHHHHHHHHHHHHHHHHH HHHHHHHHHHHHHHHHHHHHHHHHHHHHH', CAST(N'2044-06-17' AS Date), N'hhhhhhhhhhhhhhhhh hhhhhhhhhhhhhh', N'4', N'yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy', N'5', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'12567876-2', N'x', N'x', N'x', N'PSICOLOGA', N'FONOAUDIOLOGO', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (42, N'87654354-0', 15, 17, 14, 14, 14, 17, 18, 16, 16, 6, 2, N'SI ASDASDAS SDG DFGD GDH H FCJGGFJFJ FJFJFG JFGJFGJ J GFH GF HFGHFFFHG ', N'NO 4', N'FGH FH FGHFGH FH FG HFJ GJ FGJGFJGFJG JHJFGFH FHFGHGFHFGH FGH FGHFGH', N'NO', N'GFHFGHF GHGF HFGHFGHFGHF GFHFGHTRYRE ERERTERTE TERERTETERTWWWTR RT WR HT FG GFDG ', CAST(N'2083-05-13' AS Date), N'4wre rte tertert reytry rtytryrty rtyrtyrtytre gdfgdfgdfgd', N'4', N'dfgdft erqwwwwwwwwwwwww wwwwwwwwwrwe t tet', N'5', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'12567876-2', N'x', N'x', N'x', N'PSICOLOGA', N'FONOAUDIOLOGO', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (43, N'87654354-0', 15, 14, 14, 14, 14, 17, 16, 16, 16, 6, 6, N'NO', N'NO 4', N'CCDFG  DFGDFG DFG DF FDH HFDHDFHFD', N'NO', N'H DFHDFHDFH DFHDH', CAST(N'1999-06-09' AS Date), N'hdfh df hfdh dfh', N'5', N'fhdfhdfh5', N'6', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'VACIO', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'VACIO', N'VACIO', N'VACIO', N'VACIO', 4, N'19845458-2', N'x', N'x', N'x', N'x', N'PSICOLOGA', N'X', N'X', N'X', N'X', N'19837878-2', N'x', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (44, N'87654354-0', 15, 16, 14, 14, 14, 18, 19, 16, 16, 5, 2, N'NO', N'NO 4', N'SDGDDDDDDDDDDDDDDDDDDDDDDDDDDDDFFFFFFFF FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF GGGGGGGGGGGGGGGGGGGGGG HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHFFFFFFFFFFFFFFFFFF', N'NO', N'RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRTTTTTTTTTTTTTTTTTTTTT TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTWWWWWWWWWWWWWWWWWWWWWWWWWWW', CAST(N'1993-07-09' AS Date), N'eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee rrrrrrrrrrrrrrrrr rrrrrrrrrrrrrrrr', N'4', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'ANTONIO JOSE FUENTES CIFUENTES', N'PILAR ESTEFANIA FUENTES JARA', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'PAULINA MARIA PINOCHET SEGIURA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'15673345-0', N'x', N'x', N'x', N'PSICOLOGA', N'PSICOPERATEUTICA', N'X', N'X', N'X', N'10989000-2', N'12998870-4', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (45, N'87654354-0', 15, 17, 14, 14, 14, 17, 18, 16, 16, 4, 2, N'NO', N'NO 4', N'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTPP PP', N'NO', N'TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU PPPPPPPPPP', CAST(N'1944-06-14' AS Date), N'3333333333333333333333333eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee', N'4', N'jjjjjjjjjjjjjjj jjjjjjjjjkkkkkkkkkkkk kkkkkkkkkkkk k', N'5', N'', N'', N'', N'', N'', N'', 1, N'MARIA ANGELICA LEAL LILLO', N'ANTONIO JOSE FUENTES CIFUENTES', N'VACIO', N'VACIO', N'LUISA CECILIA JARA BUSTAMANTE', N'JOSE LUIS RAMIREZ PEÑA', N'VACIO', N'VACIO', N'VACIO', 3, N'19845458-2', N'12567876-2', N'x', N'x', N'x', N'PSICOLOGA', N'FONOAUDIOLOGO', N'X', N'X', N'X', N'19837878-2', N'10989000-2', N'x', N'x')
INSERT [dbo].[ficha_diagnostico] ([id_fichadiagnostico], [rut_alumno], [id_evaluador_1], [id_evaluador_2], [id_evaluador_3], [id_evaluador_4], [id_evaluador_5], [id_apoyo_1], [id_apoyo_2], [id_apoyo_3], [id_apoyo_4], [id_tipoficha], [curso_alumno], [nuevo_ingreso], [continuidad], [diagnostico], [sindrome_asociado_diagnostico], [observaciones_salud], [fecha_emision], [prueba_1], [puntaje_1], [prueba_2], [puntaje_2], [prueba_3], [puntaje_3], [prueba_4], [puntaje_4], [prueba_5], [puntaje_5], [usuario], [nombre_apoyo_1], [nombre_apoyo_2], [nombre_apoyo_3], [nombre_apoyo_4], [nombre_evaluador_1], [nombre_evaluador_2], [nombre_evaluador_3], [nombre_evaluador_4], [nombre_evaluador_5], [numero_estudiante], [rut_evaluador_1], [rut_evaluador_2], [rut_evaluador_3], [rut_evaluador_4], [rut_evaluador_5], [profesion_evaluador_1], [profesion_evaluador_2], [profesion_evaluador_3], [profesion_evaluador_4], [profesion_evaluador_5], [rut_apoyo_1], [rut_apoyo_2], [rut_apoyo_3], [rut_apoyo_4]) VALUES (46, N'87654354-0', 14, 14, 14, 14, 14, 16, 16, 16, 16, 6, 8, N'SI ', N'', N'', N'', N'', CAST(N'2019-05-31' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1, N'VACIO', N'VACIO', N'VACIO', N'VACIO', N'VACIO', N'VACIO', N'VACIO', N'VACIO', N'VACIO', 2, N'x', N'x', N'x', N'x', N'x', N'X', N'X', N'X', N'X', N'X', N'x', N'x', N'x', N'x')
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
/****** Object:  StoredProcedure [dbo].[buscador_ficha_rut]    Script Date: 31-05-2019 13:39:03 ******/
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
USE [master]
GO
ALTER DATABASE [integracion_pie] SET  READ_WRITE 
GO
