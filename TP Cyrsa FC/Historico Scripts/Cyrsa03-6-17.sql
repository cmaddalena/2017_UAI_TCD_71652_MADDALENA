USE [master]
GO
/****** Object:  Database [CYRSA_FC]    Script Date: 03/06/2017 02:53:56 p.m. ******/
CREATE DATABASE [CYRSA_FC]
 
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
USE [CYRSA_FC]
GO
/****** Object:  Table [dbo].[CLIENTE_ESCUELA]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
 CONSTRAINT [PK_CLIENTE_ESCUELA] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FAMILIA]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  Table [dbo].[GRUPO_PATENTES]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  Table [dbo].[PATENTE]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  Table [dbo].[PLAN_CUOTAS_ESCUELA]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  Table [dbo].[PROFESORES]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
	[PASSWORD] [nvarchar](50) NOT NULL,
	[MAIL] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CLIENTE_ESCUELA] ([DNI], [NOMBRE], [APELLIDO], [FECHA_NAC], [MAIL], [ESTADO], [FECHA_INSCRIPCION]) VALUES (38326493, N'Carlos', N'Maddalena', CAST(N'1994-07-07' AS Date), N'cmaddalena@gmail.com', N'', CAST(N'2017-05-01' AS Date))
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
SET IDENTITY_INSERT [dbo].[GRUPO_PATENTES] OFF
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
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (545646, CAST(N'2017-06-02' AS Date), 222, 0, N'AL DIA')
INSERT [dbo].[PLAN_CUOTAS_ESCUELA] ([DNI], [MES_PAGO], [MONTO_CUOTA], [INTERES], [ESTADO_PAGO]) VALUES (38326493, CAST(N'2017-05-01' AS Date), 200, 0, N'AL DIA')
INSERT [dbo].[PROFESORES] ([ID_DOCENTE], [NOMBRE], [APELLIDO], [FECHA_CONTRATACION], [SUELDO], [ID_CLASE], [FECHA_NAC], [PASSWORD], [MAIL]) VALUES (5456456, N'fernando', N'urribarri', CAST(N'2017-05-28' AS Date), 2000, NULL, CAST(N'2017-05-28' AS Date), N'200000', N'asa@gmail.com')
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA]) VALUES (1, 38326493, N'Carlos.Maddalena', N'JEfO3UDNILfgFyN887ITTM0BIQoOM+Aw+jXbH9N0A88=', N'ADMINISTRADORES')
INSERT [dbo].[USUARIOS] ([ID_USUARIO], [ID_CLIENTE], [USUARIO], [CLAVE], [FAMILIA]) VALUES (2, 5456456, N'fernando.urribarri', N'200000', NULL)
/****** Object:  StoredProcedure [dbo].[Alta_cliente]    Script Date: 03/06/2017 02:53:57 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[Alta_cliente]
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


insert into dbo.USUARIOS (ID_USUARIO,ID_CLIENTE,USUARIO,CLAVE)
values (@iduser,@dni,@nombre+'.'+@apellido,@pass) 

end

GO
/****** Object:  StoredProcedure [dbo].[alta_docente]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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



insert into profesores
values (@dni,@nombre,@apellido,@fecha_contratacion,@sueldo,@id_clase,@fecha_nac,@pass,@mail)

insert into dbo.USUARIOS (ID_USUARIO,ID_CLIENTE,USUARIO,CLAVE)
values (@iduser,@dni,@nombre+'.'+@apellido,@pass) 

end

select * from PROFESORES

GO
/****** Object:  StoredProcedure [dbo].[alta_familias]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Alta_GrupoPatentes]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[alta_patente]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Asignar_familia]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[DEVOLVER_FORMS]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[INSERTAR_PATENTE]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[listar_grupos_distintos]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[listar_patentesdegrupo]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
/****** Object:  StoredProcedure [dbo].[Listar_Usuarios]    Script Date: 03/06/2017 02:53:57 p.m. ******/
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
