USE [master]
GO
/****** Object:  Database [CYRSA_FC]    Script Date: 12/06/2017 14:47:40 ******/
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
/****** Object:  Table [dbo].[CLIENTE_ESCUELA]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[EQUIPO]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[EQUIPOxTORNEO]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[FAMILIA]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[GRUPO_PATENTES]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[LANG_INTERFACE]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[Lenguaje]    Script Date: 12/06/2017 14:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lenguaje](
	[id_idioma] [int] NOT NULL,
	[nombre_idioma] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Lenguaje] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PARTIDO]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[PATENTE]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[PLAN_CUOTAS_ESCUELA]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[PROFESORES]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[RANKING]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[TORNEO]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 12/06/2017 14:47:41 ******/
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
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (25, N'ADMINISTRADORES', 30, N'Cyrsa_FC.BAJA_MODIFICACION_DOCENTES', N'BAJA_MODIF_EMPLEADO')
INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (26, N'ADMINISTRADORES', 31, N'Cyrsa_FC.Alta_Equipo', N'Gestion_equipos')
SET IDENTITY_INSERT [dbo].[GRUPO_PATENTES] OFF
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_Cliente', N'Button1', N'Registrar Usuario')
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
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'bregistrarprofesor', N'Registrar Profesor')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'gbaltaprofesor', N'Detalle de profesor')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'lapellidoprofesor', N'Apellido')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'ldniprodesor', N'Documento')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'lfechanacprofesor', N'Fecha_Nacimiento')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'lmailprofesor', N'Direccion de Mail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'lnombreprofesor', N'Nombre')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'lpassprofesor', N'Clave')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (1, N'Alta_profesor', N'lsueldoprofesor', N'Sueldo')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Button1', N'Insert User')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'GroupBox1', N'Client Detail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label1', N'Personal Id')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label2', N'Name')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'label3', N'Surname')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label4', N'Email Adress')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label5', N'Birthdate')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label6', N'Payment')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_Cliente', N'Label7', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'btninsertarequipo', N'INSERT_TEAM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'gbequipo', N'TEAM')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'gbjugadores', N'PLAYERS')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_equipo', N'lblnombreequipo', N'NAME:')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'bregistrarprofesor', N'Insert Teacher')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'gbaltaprofesor', N'Teacher Detail')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'lapellidoprofesor', N'Surname')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'ldniprodesor', N'Personal ID')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'lfechanacprofesor', N'Birthdate')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'lmailprofesor', N'Email Adress')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'lnombreprofesor', N'Name')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'lpassprofesor', N'Password')
INSERT [dbo].[LANG_INTERFACE] ([id_idioma], [id_form], [id_control], [texto]) VALUES (2, N'Alta_profesor', N'lsueldoprofesor', N'Payment')
INSERT [dbo].[Lenguaje] ([id_idioma], [nombre_idioma]) VALUES (1, N'ESPAÑOL')
INSERT [dbo].[Lenguaje] ([id_idioma], [nombre_idioma]) VALUES (2, N'ENGLISH')
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
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (45646, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (123456, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (545646, CAST(N'2017-06-02' AS Date), 222, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (1214879, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (1819819, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (5454564, CAST(N'2017-06-03' AS Date), 55, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (9878912, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (9878915, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (9996565, CAST(N'2017-06-04' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (38326493, CAST(N'2017-05-01' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PROFESORES] ([ID_DOCENTE], [NOMBRE], [APELLIDO], [FECHA_CONTRATACION], [SUELDO], [ID_CLASE], [FECHA_NAC], [MAIL]) VALUES (38326493, N'Carlos', N'maddalena', CAST(N'2017-06-04' AS Date), 50000, NULL, CAST(N'1994-07-07' AS Date), N'cm@cyrsa.com.ar')
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (1, 38326493, N'Carlos.Maddalena', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', N'ADMINISTRADORES', NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (2, 9878912, N'sergio.ramos', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (3, 45646, N'KEYLOR.NAVAS', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (4, 1819819, N'VERMALEEN.DYUK', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (5, 9878915, N'tonny.kross', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (6, 9996565, N'tonny.kross', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (7, 123456, N'cristiano.ronaldo', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA], [ID_IDIOMA]) VALUES (8, 1214879, N'luis.suarez', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', NULL, NULL)
/****** Object:  StoredProcedure [dbo].[Alta_cliente]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[alta_docente]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[alta_familias]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[Alta_GrupoPatentes]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[alta_patente]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[Asignar_familia]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[DEVOLVER_FORMS]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[INSERTAR_PATENTE]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[listar_grupos_distintos]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[listar_patentesdegrupo]    Script Date: 12/06/2017 14:47:41 ******/
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
/****** Object:  StoredProcedure [dbo].[Listar_Usuarios]    Script Date: 12/06/2017 14:47:41 ******/
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
USE [master]
GO
ALTER DATABASE [CYRSA_FC] SET  READ_WRITE 
GO
