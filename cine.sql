USE [master]
GO
/****** Object:  Database [Cine]    Script Date: 09/15/2020 11:24:27 ******/
CREATE DATABASE [Cine] ON  PRIMARY 
( NAME = N'Cine', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Cine.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Cine_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Cine_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Cine] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cine] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Cine] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Cine] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Cine] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Cine] SET ARITHABORT OFF
GO
ALTER DATABASE [Cine] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Cine] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Cine] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Cine] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Cine] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Cine] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Cine] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Cine] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Cine] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Cine] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Cine] SET  ENABLE_BROKER
GO
ALTER DATABASE [Cine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Cine] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Cine] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Cine] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Cine] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Cine] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Cine] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Cine] SET  READ_WRITE
GO
ALTER DATABASE [Cine] SET RECOVERY FULL
GO
ALTER DATABASE [Cine] SET  MULTI_USER
GO
ALTER DATABASE [Cine] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Cine] SET DB_CHAINING OFF
GO
USE [Cine]
GO
/****** Object:  User [pablo]    Script Date: 09/15/2020 11:24:27 ******/
CREATE USER [pablo] FOR LOGIN [pablo] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Comentarios]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comentarios](
	[idComentario] [int] IDENTITY(1,1) NOT NULL,
	[idPelicula] [int] NULL,
	[comentario] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idComentario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Combos]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Combos](
	[CodigoCo] [int] IDENTITY(1,1) NOT NULL,
	[NombreCo] [varchar](100) NULL,
	[PrecioCo] [money] NULL,
	[ContenidoCo] [varchar](200) NULL,
	[Ventas] [int] NULL,
	[ImagenCo] [varchar](100) NULL,
	[Estado] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoCo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[NameUse] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NULL,
	[Nombres] [varchar](100) NULL,
	[Apellidos] [varchar](100) NULL,
	[Correo] [varchar](100) NULL,
	[fechanacimiento] [date] NULL,
	[TipoUsuario] [varchar](50) NULL,
	[Compras] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NameUse] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Peliculas](
	[CodigoPe] [int] IDENTITY(1,1) NOT NULL,
	[NombrePe] [varchar](50) NULL,
	[WebPe] [varchar](100) NULL,
	[DirectoresPe] [varchar](100) NULL,
	[ActoresPe] [varchar](100) NULL,
	[DescripcionPe] [varchar](500) NULL,
	[ImagenPe] [varchar](100) NULL,
	[CategoriaPe] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoPe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios](
	[CodigoHo] [int] NOT NULL,
	[HoraHo] [time](7) NULL,
 CONSTRAINT [PK_Horarios] PRIMARY KEY CLUSTERED 
(
	[CodigoHo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcion]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funcion](
	[CodigoFu] [int] NOT NULL,
	[SalaFu] [varchar](50) NULL,
	[CodigoPe] [int] NULL,
	[CodigoHo] [int] NULL,
	[CodigoAs] [int] NULL,
	[CodigoVe] [int] NULL,
 CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED 
(
	[CodigoFu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asientos]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asientos](
	[CodigoAs] [int] NOT NULL,
	[CodigoFu] [int] NULL,
	[Libre] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Asientos] PRIMARY KEY CLUSTERED 
(
	[CodigoAs] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 09/15/2020 11:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compras](
	[CodigoVe] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionVe] [text] NULL,
	[FechaVe] [date] NULL,
	[MontoVe] [money] NULL,
	[NameUse] [varchar](50) NULL,
	[FunciOCombo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoVe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__Combos__Estado__1BFD2C07]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Combos] ADD  DEFAULT ('E') FOR [Estado]
GO
/****** Object:  Default [DF__Asientos__Libre__1CF15040]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Asientos] ADD  DEFAULT ('S') FOR [Libre]
GO
/****** Object:  ForeignKey [FK_Funcion_Horarios]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Horarios] FOREIGN KEY([CodigoHo])
REFERENCES [dbo].[Horarios] ([CodigoHo])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Horarios]
GO
/****** Object:  ForeignKey [FK_Funcion_Peliculas]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Peliculas] FOREIGN KEY([CodigoPe])
REFERENCES [dbo].[Peliculas] ([CodigoPe])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Peliculas]
GO
/****** Object:  ForeignKey [FK_Asientos_Funcion]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Asientos]  WITH CHECK ADD  CONSTRAINT [FK_Asientos_Funcion] FOREIGN KEY([CodigoFu])
REFERENCES [dbo].[Funcion] ([CodigoFu])
GO
ALTER TABLE [dbo].[Asientos] CHECK CONSTRAINT [FK_Asientos_Funcion]
GO
/****** Object:  ForeignKey [FK_Compras_Combos]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Combos] FOREIGN KEY([FunciOCombo])
REFERENCES [dbo].[Combos] ([CodigoCo])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Combos]
GO
/****** Object:  ForeignKey [FK_Compras_Funcion]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Funcion] FOREIGN KEY([FunciOCombo])
REFERENCES [dbo].[Funcion] ([CodigoFu])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Funcion]
GO
/****** Object:  ForeignKey [FK_Compras_Usuarios]    Script Date: 09/15/2020 11:24:30 ******/
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Usuarios] FOREIGN KEY([NameUse])
REFERENCES [dbo].[Usuarios] ([NameUse])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Usuarios]
GO
