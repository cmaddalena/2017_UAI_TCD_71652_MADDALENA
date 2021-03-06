USE [master]
GO
/****** Object:  Database [CYRSA_FC]    Script Date: 03/09/2017 21:17:38 ******/
CREATE DATABASE [CYRSA_FC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CYRSA_FC', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.CYRSA_SA\MSSQL\DATA\CYRSA_FC.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CYRSA_FC_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.CYRSA_SA\MSSQL\DATA\CYRSA_FC_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CYRSA_FC] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CYRSA_FC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CYRSA_FC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CYRSA_FC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CYRSA_FC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CYRSA_FC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CYRSA_FC] SET ARITHABORT OFF 
GO
ALTER DATABASE [CYRSA_FC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CYRSA_FC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CYRSA_FC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CYRSA_FC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CYRSA_FC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CYRSA_FC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CYRSA_FC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CYRSA_FC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CYRSA_FC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CYRSA_FC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CYRSA_FC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CYRSA_FC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CYRSA_FC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CYRSA_FC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CYRSA_FC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CYRSA_FC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CYRSA_FC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CYRSA_FC] SET RECOVERY FULL 
GO
ALTER DATABASE [CYRSA_FC] SET  MULTI_USER 
GO
ALTER DATABASE [CYRSA_FC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CYRSA_FC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CYRSA_FC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CYRSA_FC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CYRSA_FC] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CYRSA_FC', N'ON'
GO
USE [CYRSA_FC]
GO
/****** Object:  Table [dbo].[CLIENTE_ESCUELA]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTE_ESCUELA](
	[DNI] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[FECHA_NAC] [date] NOT NULL,
	[MAIL] [varchar](50) NOT NULL,
	[ESTADO] [varchar](50) NOT NULL,
	[FECHA_INSCRIPCION] [date] NOT NULL,
	[ID_EQUIPO] [int] NULL,
	[FECHA_EXPULSION] [date] NULL,
	[FECHA_AMONESTACION] [date] NULL,
 CONSTRAINT [PK_CLIENTE_ESCUELA] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EQUIPO]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EQUIPO](
	[ID_EQUIPO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_EQUIPO] [varchar](50) NOT NULL,
	[CANTGF] [int] NULL,
	[CANTGC] [int] NULL,
	[CANTAMONESTADOS] [int] NULL,
	[CANTEXPULSADOS] [int] NULL,
 CONSTRAINT [PK_EQUIPO] PRIMARY KEY CLUSTERED 
(
	[ID_EQUIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EQUIPOxTORNEO]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EQUIPOxTORNEO](
	[ID_EQUIPO] [int] NOT NULL,
	[ID_TORNEO] [int] NOT NULL,
 CONSTRAINT [PK_EQUIPOxTORNEO] PRIMARY KEY CLUSTERED 
(
	[ID_EQUIPO] ASC,
	[ID_TORNEO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FAMILIA]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FAMILIA](
	[ID_FAMILIA] [int] NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
	[ID_PATENTE] [int] NULL,
	[ID_GRUPOPATENTE] [int] NULL,
 CONSTRAINT [PK_FAMILIA] PRIMARY KEY CLUSTERED 
(
	[ID_FAMILIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GRUPO_PATENTES]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GRUPO_PATENTES](
	[ID_GRUPOPATENTES] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
	[ID_PATENTE] [int] NULL,
	[FORMULARIO] [varchar](50) NULL,
	[NOMBRE_PAT] [varchar](50) NULL,
 CONSTRAINT [PK_GRUPO_PATENTES] PRIMARY KEY CLUSTERED 
(
	[ID_GRUPOPATENTES] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LANG_INTERFACE]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LANG_INTERFACE](
	[id_idioma] [int] NOT NULL,
	[id_form] [varchar](50) NOT NULL,
	[id_control] [varchar](50) NOT NULL,
	[texto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LANG_INTERFACE] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC,
	[id_form] ASC,
	[id_control] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LANG_MENSAJES]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LANG_MENSAJES](
	[ID_IDIOMA] [int] NOT NULL,
	[ID_MENSAJE] [int] NOT NULL,
	[ID_TRADUCCION] [int] IDENTITY(1,1) NOT NULL,
	[TEXTO] [varchar](150) NOT NULL,
 CONSTRAINT [PK_LANG_MENSAJES] PRIMARY KEY CLUSTERED 
(
	[ID_IDIOMA] ASC,
	[ID_MENSAJE] ASC,
	[ID_TRADUCCION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lenguaje]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lenguaje](
	[id_idioma] [int] IDENTITY(1,1) NOT NULL,
	[nombre_idioma] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Lenguaje] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOGS]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOGS](
	[ID_LOG] [int] IDENTITY(1,1) NOT NULL,
	[FECHA] [date] NOT NULL,
	[DESCRIPCION] [varchar](300) NOT NULL,
	[TIPO] [int] NOT NULL,
 CONSTRAINT [PK_LOGS] PRIMARY KEY CLUSTERED 
(
	[ID_LOG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PARTIDO]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARTIDO](
	[ID_PARTIDO] [int] NOT NULL,
	[IDEQUIPO1] [int] NOT NULL,
	[IDEQUIPO2] [int] NOT NULL,
	[GOLESE1] [int] NULL,
	[GOLESE2] [int] NULL,
	[FECHA] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PATENTE]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PATENTE](
	[ID_PATENTE] [int] NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
	[FORMULARIO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PATENTE] PRIMARY KEY CLUSTERED 
(
	[ID_PATENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PLAN_CUOTAS_ESCUELA]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PLAN_CUOTAS_ESCUELA](
	[DNI] [int] NOT NULL,
	[MES_PAGO] [date] NOT NULL,
	[MONTO_CUOTA] [float] NOT NULL,
	[INTERES] [float] NOT NULL,
	[ESTADO_PAGO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PLAN_CUOTAS_ESCUELA] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROFESORES]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROFESORES](
	[ID_DOCENTE] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[FECHA_CONTRATACION] [date] NOT NULL,
	[SUELDO] [float] NOT NULL,
	[ID_CLASE] [int] NULL,
	[FECHA_NAC] [date] NOT NULL,
	[MAIL] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RANKING]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RANKING](
	[ID_RANKING] [int] NOT NULL,
	[ID_EQUIPO] [int] NOT NULL,
	[PUNTAJE] [int] NOT NULL,
 CONSTRAINT [PK_RANKING] PRIMARY KEY CLUSTERED 
(
	[ID_RANKING] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIPO_LOG]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPO_LOG](
	[ID_TIPO] [int] NOT NULL,
	[DESCRIPCION] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TIPO_LOG] PRIMARY KEY CLUSTERED 
(
	[ID_TIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TORNEO]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TORNEO](
	[ID_TORNEO] [int] NOT NULL,
	[NOMBRE_TORNEO] [varchar](50) NOT NULL,
	[ID_RANKING] [int] NOT NULL,
 CONSTRAINT [PK_TORNEO] PRIMARY KEY CLUSTERED 
(
	[ID_TORNEO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[ID_USUARIO] [int] NOT NULL,
	[ID_CLIENTE] [int] NOT NULL,
	[USUARIO] [varchar](50) NOT NULL,
	[CLAVE] [nvarchar](50) NOT NULL,
	[FAMILIA] [varchar](50) NULL,
	[ID_IDIOMA] [int] NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (45646, N'KEYLOR', N'NAVAS', CAST(N'2017-06-04' AS Date), N'KV@gmail.com', N'ACTIVO', CAST(N'2017-06-04' AS Date), 4, NULL, NULL)
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (123456, N'cristiano', N'ronaldo', CAST(N'2017-06-04' AS Date), N'cr@gmail.com', N'ACTIVO', CAST(N'2017-06-04' AS Date), 4, NULL, NULL)
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (1214879, N'luis', N'suarez', CAST(N'2017-06-04' AS Date), N'ls@gmail.com', N'ACTIVO', CAST(N'2017-06-04' AS Date), 4, NULL, NULL)
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (1819819, N'VERMALEEN', N'DYUK', CAST(N'2017-06-04' AS Date), N'VD@gmail.com', N'ACTIVO', CAST(N'2017-06-04' AS Date), 4, NULL, NULL)
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (9878912, N'sergio', N'ramos', CAST(N'2017-06-04' AS Date), N'sr@gmail.com', N'ACTIVO', CAST(N'2017-06-04' AS Date), 4, NULL, NULL)
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (9878915, N'tonny', N'kross', CAST(N'2017-06-04' AS Date), N'tk@gmail.com', N'ACTIVO', CAST(N'2017-06-04' AS Date), NULL, NULL, NULL)
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION], [ID_EQUIPO], [FECHA_EXPULSION], [FECHA_AMONESTACION]) VALUES (36568965, N'Yamil', N'Ribada', CAST(N'1989-09-03' AS Date), N'yr@hotmail.com', N'ACTIVO', CAST(N'2017-09-03' AS Date), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[EQUIPO] ON 

INSERT [dbo].[EQUIPO] ([ID_EQUIPO], [NOMBRE_EQUIPO], [CANTGF], [CANTGC], [CANTAMONESTADOS], [CANTEXPULSADOS]) VALUES (3, N'rm', NULL, NULL, NULL, NULL)
INSERT [dbo].[EQUIPO] ([ID_EQUIPO], [NOMBRE_EQUIPO], [CANTGF], [CANTGC], [CANTAMONESTADOS], [CANTEXPULSADOS]) VALUES (4, N'REAL MADRID', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[EQUIPO] OFF
SET IDENTITY_INSERT [dbo].[GRUPO_PATENTES] ON 

INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (4, N'Admin', 1, N'Cyrsa_FC.Alta_Cliente', N'A')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (5, N'Contables', 2, N'Cyrsa_FC.CyrsaFC_Menu', N'conti')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (6, N'a', 3, N'Cyrsa_FC.Calculo_Ganancias', N'a2')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (7, N's', 4, N'Cyrsa_FC.Calculo_Ganancias', N's1')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (8, N's', 5, N'Cyrsa_FC.Alta_Cliente', N's2')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (9, N'Admins', 6, N'Cyrsa_FC.Consulta_estado_cuenta', N'A')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (10, N'Admins', 7, N'Cyrsa_FC.Consulta_estado_cuenta', N'J')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (11, N'Admins', 8, N'Cyrsa_FC.Calculo_Ganancias', N'H')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (12, N'ADMINISTRADORES', 9, N'Cyrsa_FC.FormularioPrincipal', N'ABM_PERFILES')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (14, N'ADMINISTRADORES', 11, N'Cyrsa_FC.ALTA_PROFESOR', N'Alta_docente')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (19, N'a', 16, N'Cyrsa_FC.Calculo_Ganancias', N'a2')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (20, N'a', 17, N'Cyrsa_FC.Calculo_Ganancias', N'a3')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (23, N'ADMINISTRADORES', 28, N'Cyrsa_FC.BAJA_MODIFICACION_ALUMNOS', N'Baja_Modificacion_Cliente')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (24, N'ADMINISTRADORES', 29, N'Cyrsa_FC.Alta_Cliente', N'Alta_clientes')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (25, N'ADMINISTRADORES', 30, N'Cyrsa_FC.BAJA_MODIFICACION_PERSONAL', N'BAJA_MODIF_EMPLEADO')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (26, N'ADMINISTRADORES', 31, N'Cyrsa_FC.Alta_Equipo', N'Gestion_equipos')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (27, N'Patentes CyrsaFC', 32, N'Cyrsa_FC.ABMLenguaje', N'Multidioma')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (28, N'ADMINISTRADORES', 32, N'Cyrsa_FC.ABMLenguaje', N'Multidioma')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (29, N'ADMINISTRADORES', 33, N'Cyrsa_FC.TORNEOS', N'Tournaments')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (35, N'ADMINISTRADORES', 39, N'Cyrsa_FC.Calculo_Ganancias', N'ganancias1')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (1027, N'Patentes CyrsaFC', 43, N'Cyrsa_FC.Bitacora', N'Bitacora')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (1028, N'ADMINISTRADORES', 43, N'Cyrsa_FC.Bitacora', N'BITACORA')
SET IDENTITY_INSERT [dbo].[GRUPO_PATENTES] OFF
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Button1', N'Registrar Usuario')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Button2', N'Volver a Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'GroupBox1', N'Detalle de cliente')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Label1', N'DNI')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Label2', N'Nombre')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Label3', N'Apellido')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Label4', N'Direccion de Mail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'label5', N'Fecha_Nacimiento')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Label6', N'Cuota')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Label7', N'Clave')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_equipo', N'btninsertarequipo', N'ALTA_EQUIPO')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_equipo', N'gbequipo', N'EQUIPO')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_equipo', N'gbjugadores', N'JUGADORES')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_equipo', N'lblnombreequipo', N'NOMBRE:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'bregistrarprofesor', N'Registrar_Personal')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'Button2', N'VOLVER A MENU')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'gbaltaprofesor', N'Detalle Docente')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'lapellidoprofesor', N'Apellido')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'ldniprofesor', N'Documento')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'lfechanacprofesor', N'Fecha_Nacimiento')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'lmailprofesor', N'Direccion de Mail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'lnombreprofesor', N'Nombre')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'lpassprofesor', N'Clave')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ALTA_PROFESOR', N'lsueldoprofesor', N'Sueldo')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'Button1', N'MODIFICAR')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'Button2', N'ELIMINAR')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'Button3', N'VOLVER A MENU PRINCIPAL')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'GroupBox1', N'Detalle_Alumno')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosapellido', N'Apellido')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosfechanac', N'Fecha_nac')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosmail', N'Correo')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosnombre', N'Nombre')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnospassword', N'Clave')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_ALUMNOS', N'lblbalumnosdni', N'Dni')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Button1', N'MODIFICAR')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Button2', N'ELIMINAR')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Button3', N'VOLVER A MENU PRINCIPAL')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'GroupBox1', N'Detalle_Alumno')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label1', N'Dni')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label2', N'Nombre')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label3', N'Apellido')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label4', N'Correo')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label5', N'Fecha_nac')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label6', N'Sueldo')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'BAJA_MODIFICACION_PERSONAL', N'Label7', N'Clave')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button1', N'Finanzas')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button2', N'Jugadores')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button3', N'Torneos')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button4', N'Equipos')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button5', N'Clases')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button6', N'Docentes')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button7', N'Arbitros')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button8', N'Promociones')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'ESTADISTICAS_TORNEOS', N'Button9', N'VOLVER A MENU PRINCIPAL')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Form_Confirmacion', N'Button1', N'Aceptar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Form_Confirmacion', N'Label1', N'Esta es la ultima patente?')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioDialogoPatentes', N'Button1', N'Aceptar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioDialogoPatentes', N'lnombreformulario', N'Nombre Formulario')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioDialogoPatentes', N'lnombrepatente', N'Nombre Patente')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioFamilia', N'btnCancelar', N'Cancelar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioFamilia', N'btnvolvermenu', N'Volver Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioFamilia', N'Familia', N'Datos de la Familia')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioFamilia', N'lblNombreFamilia', N'Nombre Familia:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioFamilia', N'lblTituloPatentes', N'Patentes:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioFamilia', N'NombrePerfil', N'Aceptar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPatentes', N'btncancelar', N'Cancelar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPatentes', N'btnvolvermenu', N'Volver Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPatentes', N'Familia', N'Patentes-CyrsaFC')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPatentes', N'NombrePerfil', N'Aceptar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPrincipal', N'btnDefinirPatentes', N'Definir Patentes')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPrincipal', N'btnDefinirUsuarios', N'Asignar Familia ')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPrincipal', N'btnIniciarSesionComoUsuario', N'Aceptar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPrincipal', N'btnvolvermenu', N'Volver Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioPrincipal', N'GroupBox1', N'Panel Administrador')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioUsuarios', N'btnCancelar', N'Cancelar')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioUsuarios', N'btnvolvermenu', N'Volver Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioUsuarios', N'lblNombreFamilia', N'Nombre:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioUsuarios', N'lblTituloPatentes', N'Familia:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'FormularioUsuarios', N'NombrePerfil', N'Asignar Familia ')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Loguin', N'Button1', N'Loguear')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Loguin', N'LPassword', N'Clave')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Loguin', N'LUsuario', N'Usuario')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Button1', N'Insert User')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Button2', N'Back to Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'GroupBox1', N'Client Detail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label1', N'Personal Id')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label2', N'Name')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label3', N'Surname')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label4', N'Email Adress')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label5', N'Birthdate')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label6', N'Payment')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label7', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'btninsertarequipo', N'INSERT_TEAM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'gbequipo', N'TEAM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'gbjugadores', N'PLAYERS')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'lblnombreequipo', N'NAME:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'bregistrarprofesor', N'Insert Teacher')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'Button2', N'BACK TO MENU')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'gbaltaprofesor', N'Teacher Detail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'lapellidoprofesor', N'Surname')
GO
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'ldniprofesor', N'Personal ID')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'lfechanacprofesor', N'Birthdate')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'lmailprofesor', N'Email Adress')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'lnombreprofesor', N'Name')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'lpassprofesor', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ALTA_PROFESOR', N'lsueldoprofesor', N'Payment')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'Button1', N'MODIFY')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'Button2', N'DELETE')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'Button3', N'BACK TO MAIN FORM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'GroupBox1', N'Student_Detail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosapellido', N'Surname')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosfechanac', N'Birthday')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosmail', N'Email')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnosnombre', N'Name')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'lblalumnospassword', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_ALUMNOS', N'lblbalumnosdni', N'Personal ID')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Button1', N'MODIFY')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Button2', N'DELETE')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Button3', N'BACK TO MAIN FORM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'GroupBox1', N'Employee_Detail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label1', N'Personal_ID')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label2', N'Name')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label3', N'Surname')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label4', N'Email')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label5', N'Birthday')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label6', N'Salary')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'BAJA_MODIFICACION_PERSONAL', N'Label7', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button1', N'Finance')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button2', N'Players')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button3', N'Championship')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button4', N'Teams')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button5', N'Classes')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button6', N'Teachers')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button7', N'Referee')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button8', N'Offers')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'ESTADISTICAS_TORNEOS', N'Button9', N'BACK TO MAIN FORM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Form_Confirmacion', N'Button1', N'Accept')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Form_Confirmacion', N'Label1', N'This is the last patent?')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioDialogoPatentes', N'Button1', N'Accept')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioDialogoPatentes', N'lnombreformulario', N'Name of Form')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioDialogoPatentes', N'lnombrepatente', N'Name of Patent')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioFamilia', N'btnCancelar', N'Cancel')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioFamilia', N'btnvolvermenu', N'Back to Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioFamilia', N'Familia', N'Family Information')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioFamilia', N'lblNombreFamilia', N'Name of Family:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioFamilia', N'lblTituloPatentes', N'Patents:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioFamilia', N'NombrePerfil', N'Accept')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPatentes', N'Familia', N'Patents - Cyrsa FC')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPatentes', N'lblNombreFamilia', N'Accept')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPatentes', N'lblTituloPatentes', N'Cancel')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPatentes', N'NombrePerfil', N'Back to Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPrincipal', N'btnDefinirPatentes', N'Assign Patents')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPrincipal', N'btnDefinirUsuarios', N'Asign Family ')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPrincipal', N'btnIniciarSesionComoUsuario', N'Accept')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPrincipal', N'btnvolvermenu', N'Back to Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioPrincipal', N'GroupBox1', N'Administration Panel')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioUsuarios', N'btnCancelar', N'Cancel')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioUsuarios', N'btnvolvermenu', N'Back to Menu')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioUsuarios', N'lblNombreFamilia', N'Name:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioUsuarios', N'lblTituloPatentes', N'Family:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'FormularioUsuarios', N'NombrePerfil', N'Assign Family ')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Loguin', N'Button1', N'Loguin')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Loguin', N'LPassword', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Loguin', N'LUsuario', N'User')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (3, N'Alta_Cliente', N'Label3', N'Apellidinho')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (3, N'Cyrsa_FC.Alta_Cliente', N'CLAVE', N'SENHA')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (3, N'Cyrsa_FC.Alta_Cliente', N'Label7', N'Senha')
SET IDENTITY_INSERT [dbo].[LANG_MENSAJES] ON 

INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 1, 1, N'Bienvenido')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 3, 4, N'Usted no posee acceso ó perfil para ingresar al sistema - Comuniquese con su adiministrador')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 4, 6, N'Ingrese valores correctos en ambos campos')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 5, 8, N'Revise por favor los datos cargados')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 6, 10, N'Configuracion Exitosa')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 7, 12, N'Configuracion Fallida')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 8, 14, N'seleccione una instancia y el script de base de datos')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (1, 9, 16, N'A Partir de ahora su lenguaje en CyrsaFC será:')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 1, 2, N'Welcome')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 2, 3, N'Can you colaborate with $50 for this club?')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 3, 5, N'You dont have access or profile to login here - Please contact your IT department for solve it')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 4, 7, N'Please complete the blank spaces with properly information')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 5, 9, N'Please review the information content')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 6, 11, N'Successfull Configuration')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 7, 13, N'Failed Configuration')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 8, 15, N'Please select the instance and bbdd script')
INSERT [dbo].[LANG_MENSAJES] ([ID_IDIOMA], [ID_MENSAJE], [ID_TRADUCCION], [TEXTO]) VALUES (2, 9, 17, N'Since now your languaje on CyrsaFC will be: ')
SET IDENTITY_INSERT [dbo].[LANG_MENSAJES] OFF
SET IDENTITY_INSERT [dbo].[Lenguaje] ON 

INSERT [dbo].[Lenguaje] ([id_idioma], [nombre_idioma]) VALUES (1, N'ESPAÑOL')
INSERT [dbo].[Lenguaje] ([id_idioma], [nombre_idioma]) VALUES (2, N'ENGLISH')
INSERT [dbo].[Lenguaje] ([id_idioma], [nombre_idioma]) VALUES (3, N'PORTUGUES')
SET IDENTITY_INSERT [dbo].[Lenguaje] OFF
SET IDENTITY_INSERT [dbo].[LOGS] ON 

INSERT [dbo].[LOGS] ([ID_LOG], [FECHA], [DESCRIPCION], [TIPO]) VALUES (1, CAST(N'2017-09-03' AS Date), N'Se ha logueado el usuario carlos.maddalena', 2)
INSERT [dbo].[LOGS] ([ID_LOG], [FECHA], [DESCRIPCION], [TIPO]) VALUES (2, CAST(N'2017-09-03' AS Date), N'Se ha logueado el usuario Carlos.maddalena', 2)
INSERT [dbo].[LOGS] ([ID_LOG], [FECHA], [DESCRIPCION], [TIPO]) VALUES (3, CAST(N'2017-09-03' AS Date), N'Se ha logueado el usuario carlos.maddalena', 2)
INSERT [dbo].[LOGS] ([ID_LOG], [FECHA], [DESCRIPCION], [TIPO]) VALUES (4, CAST(N'2017-09-03' AS Date), N'Se ha logueado el usuario carlos.maddalena', 2)
INSERT [dbo].[LOGS] ([ID_LOG], [FECHA], [DESCRIPCION], [TIPO]) VALUES (5, CAST(N'2017-09-03' AS Date), N'Se ha logueado el usuario carlos.maddalena', 2)
INSERT [dbo].[LOGS] ([ID_LOG], [FECHA], [DESCRIPCION], [TIPO]) VALUES (6, CAST(N'2017-09-03' AS Date), N'Se ha dado de alta el cliente Yamil', 2)
SET IDENTITY_INSERT [dbo].[LOGS] OFF
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (1, N'Cyrsa_FC.Alta_Cliente', N'A')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (2, N'Cyrsa_FC.Form1', N'B')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (3, N'Cyrsa_FC.CyrsaFC_Menu', N'conti')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (4, N'Cyrsa_FC.CyrsaFC_Menu', N'conta')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (5, N'Cyrsa_FC.Calculo_Ganancias', N'a1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (6, N'Cyrsa_FC.Calculo_Ganancias', N'a2')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (7, N'Cyrsa_FC.CyrsaFC_Menu', N'b1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (8, N'Cyrsa_FC.CyrsaFC_Menu', N'b2')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (9, N'Cyrsa_FC.CyrsaFC_Menu', N'z1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (10, N'Cyrsa_FC.Alta_Cliente', N'z2')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (11, N'Cyrsa_FC.Calculo_Ganancias', N's1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (12, N'Cyrsa_FC.Alta_Cliente', N's2')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (13, N'Cyrsa_FC.Consulta_estado_cuenta', N'A')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (14, N'Cyrsa_FC.Consulta_estado_cuenta', N'J')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (15, N'Cyrsa_FC.Calculo_Ganancias', N'H')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (16, N'Cyrsa_FC.FormularioPrincipal', N'ABM_PERFILES')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (17, N'Cyrsa_FC.ALTA_PROFESOR', N'Alta_docente')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (18, N'Cyrsa_FC.BAJA_MODIFICACION_ALUMNOS', N'BAJA_MOD_CLIENTE')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (19, N'Cyrsa_FC.Calculo_Ganancias', N'a3')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (20, N'Baja_Modificacion_Clientes', N'Cyrsa_FC.BAJA_MODIFICACION_ALUMNOS')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (21, N'Alta_Baja_Clientes', N'Cyrsa_FC.BAJA_MODIFICACION_ALUMNOS')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (22, N'aaa5', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (23, N'aaaa', N'Cyrsa_FC.ALTA_PROFESOR')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (24, N'aaa', N'Cyrsa_FC.FormularioPrincipal')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (25, N'aaasa', N'Cyrsa_FC.BAJA_MODIFICACION_DOCENTES')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (26, N'Alta_baja_Patentes', N'Cyrsa_FC.Consulta_estado_cuenta')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (27, N'Baja_Modif_cliente', N'Cyrsa_FC.BAJA_MODIFICACION_ALUMNOS')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (28, N'Baja_Modificacion_Cliente', N'Cyrsa_FC.BAJA_MODIFICACION_ALUMNOS')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (29, N'Alta_clientes', N'Cyrsa_FC.Alta_Cliente')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (30, N'BAJA_MODIF_EMPLEADO', N'Cyrsa_FC.BAJA_MODIFICACION_DOCENTES')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (31, N'Gestion_equipos', N'Cyrsa_FC.Alta_Equipo')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (32, N'Multidioma', N'Cyrsa_FC.ABMLenguaje')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (33, N'Tournaments', N'Cyrsa_FC.TORNEOS')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (34, N'Promociones', N'Cyrsa_FC.PROMOCIONES')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (35, N'Ganancias2', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (36, N'Ganancias3', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (37, N'Ganancias4', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (38, N'Ganancias5', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (39, N'ganancias1', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (40, N'Gananciasxxx', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (41, N'ganaciaszzzz', N'Cyrsa_FC.Calculo_Ganancias')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (42, N'sarlanga', N'Cyrsa_FC.ALTA_PROFESOR')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (43, N'Bitacora', N'Cyrsa_FC.Bitacora')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (45646, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (123456, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (545646, CAST(N'2017-06-02' AS Date), 222, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (1214879, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (1819819, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (5454564, CAST(N'2017-06-03' AS Date), 55, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (9878912, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (9878915, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (9996565, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (36568965, CAST(N'2017-09-03' AS Date), 500, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (38326493, CAST(N'2017-05-01' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PROFESORES] ([ID_DOCENTE], [NOMBRE], [APELLIDO], [FECHA_CONTRATACION], [SUELDO], [ID_CLASE], [FECHA_NAC], [MAIL]) VALUES (38326493, N'Carlos', N'maddalena', CAST(N'2017-06-04' AS Date), 50000, NULL, CAST(N'1994-07-07' AS Date), N'cm@cyrsa.com.ar')
INSERT [dbo].[TIPO_LOG] ([ID_TIPO], [DESCRIPCION]) VALUES (1, N'Error')
INSERT [dbo].[TIPO_LOG] ([ID_TIPO], [DESCRIPCION]) VALUES (2, N'Informacion')
INSERT [dbo].[TIPO_LOG] ([ID_TIPO], [DESCRIPCION]) VALUES (3, N'Advertencia')
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (1, 38326493, N'Carlos.Maddalena', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', N'ADMINISTRADORES', 3)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (2, 9878912, N'sergio.ramos', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (3, 45646, N'KEYLOR.NAVAS', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (4, 1819819, N'VERMALEEN.DYUK', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', N'Contables', NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (5, 9878915, N'tonny.kross', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (6, 9996565, N'tonny.kross', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (7, 123456, N'cristiano.ronaldo', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (8, 1214879, N'luis.suarez', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (9, 36568965, N'Yamil.Ribada', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
/****** Object:  StoredProcedure [dbo].[Alta_cliente]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alta_cliente]
@dni int, @nombre varchar(50), @apellido varchar(50), @fecha_nac date, @mail varchar(50), @fecha date, @monto float, @pass VARCHAR(50)

as
begin

declare @iduser int
set @iduser=(select count (*) from USUARIOS)
if @iduser>0
begin
set @iduser =(select max (ID_USUARIO) from USUARIOS)
end
set @iduser=@iduser+1

if @dni not in (select DNI from CLIENTE_ESCUELA)
begin
insert into CLIENTE_ESCUELA values (@dni,@nombre,@apellido,@fecha_nac,@mail,'ACTIVO',@fecha, NULL,NULL,NULL)


insert into PLAN_CUOTAS_ESCUELA values (@dni, @fecha,@monto,0,'AL DIA')

select * from CLIENTE_ESCUELA
insert into dbo.USUARIOS (ID_USUARIO,ID_CLIENTE,USUARIO,CLAVE)
values (@iduser,@dni,@nombre+'.'+@apellido,@pass) 
end
end


GO
/****** Object:  StoredProcedure [dbo].[alta_docente]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[alta_docente]
@dni int, @nombre varchar(50), @apellido varchar(50), @fecha_contratacion date, @sueldo varchar(50),
@id_clase int =null,  @fecha_nac date, @pass nvarchar (50),@mail varchar(50)

as
begin

declare @iduser int
set @iduser=(select count (*) from USUARIOS)
if @iduser>0
begin
set @iduser =(select max (ID_USUARIO) from USUARIOS)
end
set @iduser=@iduser+1


if @dni not in (select ID_DOCENTE from PROFESORES)
begin
insert into profesores
values (@dni,@nombre,@apellido,@fecha_contratacion,@sueldo,@id_clase,@fecha_nac,@mail)

insert into dbo.USUARIOS (ID_USUARIO,ID_CLIENTE,USUARIO,CLAVE)
values (@iduser,@dni,@nombre+'.'+@apellido,@pass) 

end
end

GO
/****** Object:  StoredProcedure [dbo].[alta_familias]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[alta_familias]

@desc varchar (50), @idpatente int, @idgpa int


as
begin

declare @idfamilia int
set @idfamilia=(select count (*) from FAMILIA)
if @idfamilia>0
begin
set @idfamilia =(select max (ID_FAMILIA) from FAMILIA)
end
set @idfamilia=@idfamilia+1

insert into FAMILIA
values (@idfamilia,@desc, @idpatente,@idgpa)

end




GO
/****** Object:  StoredProcedure [dbo].[Alta_GrupoPatentes]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Alta_GrupoPatentes]

@descgp varchar (50), @nombrepat varchar(50), @FORM VARCHAR (50)

as
begin


declare @idpatente int

set @idpatente = (select ID_PATENTE from PATENTE where @nombrepat=PATENTE.DESCRIPCION)

if @idpatente is null
begin
set @idpatente=(select count (ID_PATENTE) from GRUPO_PATENTES)

if @idpatente>0
begin
set @idpatente =(select max (ID_PATENTE) from GRUPO_PATENTES)

set @idpatente=@idpatente+1
end
end

if  @nombrepat not in (select NOMBRE_PAT from GRUPO_PATENTES where DESCRIPCION=@descgp)
begin	
insert into GRUPO_PATENTES (DESCRIPCION, ID_PATENTE,NOMBRE_PAT, FORMULARIO )
values (@descgp,@idpatente, @nombrepat, @FORM)


end
end


GO
/****** Object:  StoredProcedure [dbo].[alta_patente]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[alta_patente]

@form varchar(50), @desc varchar(50)

as
begin

declare @id_patente int
set @id_patente=(select count (*) from PATENTE)
if @id_patente>0
begin
set @id_patente =(select max (ID_PATENTE) from PATENTE)
end
set @id_patente=@id_patente+1

if @desc not in (select DESCRIPCION from PATENTE)
begin
insert into PATENTE (ID_PATENTE, FORMULARIO, DESCRIPCION)
values (@id_patente,@form,@desc)

end
end




GO
/****** Object:  StoredProcedure [dbo].[Asignar_familia]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Asignar_familia] 

@id_usuario int, @familia varchar(50)

as
begin


update USUARIOS 

set FAMILIA=@familia
where ID_CLIENTE=@id_usuario

end



GO
/****** Object:  StoredProcedure [dbo].[DEVOLVER_FORMS]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEVOLVER_FORMS]
@USUARIO varchar(50), @CLAVE VARCHAR(50)

AS
BEGIN

SELECT NOMBRE_PAT,FORMULARIO FROM GRUPO_PATENTES

INNER JOIN USUARIOS
ON (USUARIOS.FAMILIA=GRUPO_PATENTES.DESCRIPCION)

WHERE USUARIO=@USUARIO AND CLAVE=@CLAVE

END

select * from USUARIOS



GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_PATENTE]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[INSERTAR_PATENTE]
@descripcion varchar(50), @formulario varchar (50), @grupopatente varchar(50)

as
begin



declare @idpatente int
set @idpatente=(select count (*) from PATENTE)
if @idpatente>0
begin
set @idpatente =(select max (ID_PATENTE) from PATENTE)
end
set @idpatente=@idpatente+1


declare @idgrupo int
set @idgrupo= (select ID_GRUPOPATENTES from GRUPO_PATENTES where DESCRIPCION=@grupopatente)



insert into PATENTE
values (@idpatente,@descripcion,@formulario)


insert into dbo.GRUPOxPATENTE
values (@idpatente, @idgrupo)

end






GO
/****** Object:  StoredProcedure [dbo].[listar_grupos_distintos]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar_grupos_distintos]

as
begin

select distinct DESCRIPCION from CYRSA_FC.dbo.GRUPO_PATENTES

end


GO
/****** Object:  StoredProcedure [dbo].[listar_patentesdegrupo]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar_patentesdegrupo]
@nombre_grupo varchar (50)

as
begin

select NOMBRE_PAT,FORMULARIO from GRUPO_PATENTES

where DESCRIPCION=@nombre_grupo

end



GO
/****** Object:  StoredProcedure [dbo].[Listar_Usuarios]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Listar_Usuarios]	

as
begin

select * 

from USUARIOS


end








GO
/****** Object:  StoredProcedure [dbo].[traduccion_forms]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[traduccion_forms]

as
begin
select * from LANG_INTERFACE

end


GO
/****** Object:  StoredProcedure [dbo].[traer_idiomas]    Script Date: 03/09/2017 21:17:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[traer_idiomas]

as
begin
select * from Lenguaje

end


GO
USE [master]
GO
ALTER DATABASE [CYRSA_FC] SET  READ_WRITE 
GO
