USE [master]

/****** Object:  Database [CYRSA_FC]    Script Date: 29/04/2017 04:04:35 p.m. ******/
CREATE DATABASE [CYRSA_FC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CYRSA_FC', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CYRSA_FC.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CYRSA_FC_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CYRSA_FC_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)






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


insert into CLIENTE_ESCUELA values (@dni,@nombre,@apellido,@fecha_nac,@mail,'ACTIVO',@fecha)

insert into PLAN_CUOTAS_ESCUELA values (@dni, @fecha,@monto,0,'AL DIA')


insert into dbo.USUARIOS
values (@iduser,@dni,@nombre+'.'+@apellido,PWDENCRYPT(@pass)) 

end







/****** Object:  StoredProcedure [dbo].[alta_familias]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

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


/****** Object:  StoredProcedure [dbo].[Alta_GrupoPatentes]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

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
end
set @idpatente=@idpatente+1




insert into GRUPO_PATENTES (DESCRIPCION, ID_PATENTE,NOMBRE_PAT, FORMULARIO )

values (@descgp,@idpatente, @nombrepat, @FORM)


end
end


/****** Object:  StoredProcedure [dbo].[alta_patente]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

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

insert into PATENTE
values (@id_patente,@form,@desc)

end


/****** Object:  StoredProcedure [dbo].[Asignar_familia]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

create procedure [dbo].[Asignar_familia] 

@id_usuario int, @id_familia int

as
begin


update USUARIOS 

set ID_FAMILIA=@id_familia

where @id_usuario=ID_USUARIO

end

/****** Object:  StoredProcedure [dbo].[INSERTAR_PATENTE]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

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




/****** Object:  StoredProcedure [dbo].[Listar_Usuarios]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

create procedure [dbo].[Listar_Usuarios]	

as
begin

select * 

from USUARIOS


end








ALTER DATABASE [CYRSA_FC] SET COMPATIBILITY_LEVEL = 120

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CYRSA_FC].[dbo].[sp_fulltext_database] @action = 'enable'
end

ALTER DATABASE [CYRSA_FC] SET ANSI_NULL_DEFAULT OFF 

ALTER DATABASE [CYRSA_FC] SET ANSI_NULLS OFF 

ALTER DATABASE [CYRSA_FC] SET ANSI_PADDING OFF 

ALTER DATABASE [CYRSA_FC] SET ANSI_WARNINGS OFF 

ALTER DATABASE [CYRSA_FC] SET ARITHABORT OFF 

ALTER DATABASE [CYRSA_FC] SET AUTO_CLOSE OFF 

ALTER DATABASE [CYRSA_FC] SET AUTO_SHRINK OFF 

ALTER DATABASE [CYRSA_FC] SET AUTO_UPDATE_STATISTICS ON 

ALTER DATABASE [CYRSA_FC] SET CURSOR_CLOSE_ON_COMMIT OFF 

ALTER DATABASE [CYRSA_FC] SET CURSOR_DEFAULT  GLOBAL 

ALTER DATABASE [CYRSA_FC] SET CONCAT_NULL_YIELDS_NULL OFF 

ALTER DATABASE [CYRSA_FC] SET NUMERIC_ROUNDABORT OFF 

ALTER DATABASE [CYRSA_FC] SET QUOTED_IDENTIFIER OFF 

ALTER DATABASE [CYRSA_FC] SET RECURSIVE_TRIGGERS OFF 

ALTER DATABASE [CYRSA_FC] SET  DISABLE_BROKER 

ALTER DATABASE [CYRSA_FC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 

ALTER DATABASE [CYRSA_FC] SET DATE_CORRELATION_OPTIMIZATION OFF 

ALTER DATABASE [CYRSA_FC] SET TRUSTWORTHY OFF 

ALTER DATABASE [CYRSA_FC] SET ALLOW_SNAPSHOT_ISOLATION OFF 

ALTER DATABASE [CYRSA_FC] SET PARAMETERIZATION SIMPLE 

ALTER DATABASE [CYRSA_FC] SET READ_COMMITTED_SNAPSHOT OFF 

ALTER DATABASE [CYRSA_FC] SET HONOR_BROKER_PRIORITY OFF 

ALTER DATABASE [CYRSA_FC] SET RECOVERY FULL 

ALTER DATABASE [CYRSA_FC] SET  MULTI_USER 

ALTER DATABASE [CYRSA_FC] SET PAGE_VERIFY CHECKSUM  

ALTER DATABASE [CYRSA_FC] SET DB_CHAINING OFF 

ALTER DATABASE [CYRSA_FC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

ALTER DATABASE [CYRSA_FC] SET TARGET_RECOVERY_TIME = 0 SECONDS 

ALTER DATABASE [CYRSA_FC] SET DELAYED_DURABILITY = DISABLED 

USE [CYRSA_FC]

/****** Object:  Table [dbo].[CLIENTE_ESCUELA]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[CLIENTE_ESCUELA](
	[DNI] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[FECHA_NAC] [date] NOT NULL,
	[MAIL] [varchar](50) NOT NULL,
	[ESTADO] [varchar](50) NOT NULL,
	[FECHA_INSCRIPCION] [date] NOT NULL,
 CONSTRAINT [PK_CLIENTE_ESCUELA] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[FAMILIA]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

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


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[GRUPO_PATENTES]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

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


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[PATENTE]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[PATENTE](
	[ID_PATENTE] [int] NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
	[FORMULARIO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PATENTE] PRIMARY KEY CLUSTERED 
(
	[ID_PATENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[PLAN_CUOTAS_ESCUELA]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[PLAN_CUOTAS_ESCUELA](
	[DNI] [int] NOT NULL,
	[MES_PA] [date] NOT NULL,
	[MONTO_CUOTA] [float] NOT NULL,
	[INTERES] [float] NOT NULL,
	[ESTADO_PA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PLAN_CUOTAS_ESCUELA] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

/****** Object:  Table [dbo].[USUARIOS]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

SET ANSI_PADDING ON

CREATE TABLE [dbo].[USUARIOS](
	[ID_USUARIO] [int] NOT NULL,
	[ID_CLIENTE] [int] NOT NULL,
	[USUARIO] [varchar](50) NOT NULL,
	[CLAVE] [varbinary](100) NOT NULL,
	[ID_FAMILIA] [int] NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET ANSI_PADDING OFF

INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION]) VALUES (54563, N'asa', N'besa', CAST(N'1980-11-07' AS Date), N'acac', N'ACTIVO', CAST(N'2017-04-23' AS Date))
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION]) VALUES (38326493, N'Carlos', N'Maddalena', CAST(N'1994-07-07' AS Date), N'madalena@gmail.com', N'ACTIVO', CAST(N'2017-04-14' AS Date))
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION]) VALUES (38519008, N'Romina', N'Enriquez', CAST(N'1994-09-19' AS Date), N'raenriquezv@gmail.com', N'ACTIVO', CAST(N'2017-04-22' AS Date))
SET IDENTITY_INSERT [dbo].[GRUPO_PATENTES] ON 

INSERT [dbo].[GRUPO_PATENTES] ([ID_GRUPOPATENTES], [DESCRIPCION], [ID_PATENTE], [FORMULARIO], [NOMBRE_PAT]) VALUES (1, N'Patentes CyrsaFC', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[GRUPO_PATENTES] OFF
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (1, N'UsuarioFamiliaPatenteVb.Consulta_estado_cuenta', N'sarlanga')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (2, N'UsuarioFamiliaPatenteVb.Calculo_Ganancias', N'sarlangita')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (3, N'UsuarioFamiliaPatenteVb.Calculo_Ganancias', N's')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (4, N'UsuarioFamiliaPatenteVb.Calculo_Ganancias', N'admin1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (5, N'UsuarioFamiliaPatenteVb.Consulta_estado_cuenta', N'sa1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (6, N'UsuarioFamiliaPatenteVb.FormularioABM', N'sa1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (7, N'UsuarioFamiliaPatenteVb.Consulta_estado_cuenta', N'sa1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (8, N'UsuarioFamiliaPatenteVb.FormularioDialoPatentes', N'a.1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (9, N'UsuarioFamiliaPatenteVb.Calculo_Ganancias', N'a1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (10, N'UsuarioFamiliaPatenteVb.Consulta_estado_cuenta', N'b2')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (11, N'UsuarioFamiliaPatenteVb.FormularioPrincipal', N'a1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (12, N'UsuarioFamiliaPatenteVb.FormularioPrincipal', N'a1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (13, N'UsuarioFamiliaPatenteVb.FormularioDialoElegirUsu', N'b1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (14, N'UsuarioFamiliaPatenteVb.FormularioDialoPatentes', N'c1')
INSERT [dbo].[PATENTE] ([ID_PATENTE], [DESCRIPCION], [FORMULARIO]) VALUES (15, N'UsuarioFamiliaPatenteVb.FormularioPrincipal', N'a1')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PA], [MONTO_CUOTA], [INTERES], [ESTADO_PA]) VALUES (54563, CAST(N'2017-04-23' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PA], [MONTO_CUOTA], [INTERES], [ESTADO_PA]) VALUES (38326493, CAST(N'2017-04-14' AS Date), 500, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PA], [MONTO_CUOTA], [INTERES], [ESTADO_PA]) VALUES (38519008, CAST(N'2017-04-22' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [ID_FAMILIA]) VALUES (1, 38326493, N'CARLOS.MADDALENA', 0x616263313233, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [ID_FAMILIA]) VALUES (2, 38519008, N'Romina.Enriquez', 0x616263313233, NULL)
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [ID_FAMILIA]) VALUES (3, 54563, N'asa.besa', 0x0200314AA4CF6D5CA9027777E5C08CE35650BC5746AB84F817B73A869A06E412A98B94183BADD268BD1DF9F5BBC57171EFE9112A32C8FD51CB4A0C35CD1EDDFB984B37A4FDED, NULL)
/****** Object:  StoredProcedure [dbo].[Alta_cliente]    Script Date: 29/04/2017 04:04:35 p.m. ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON








USE [master]

ALTER DATABASE [CYRSA_FC] SET  READ_WRITE 

