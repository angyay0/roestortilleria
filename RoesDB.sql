USE [master]
GO
/****** Object:  Database [RoesDB]    Script Date: 12/13/2015 17:45:14 ******/
CREATE DATABASE [RoesDB] ON  PRIMARY 
( NAME = N'RoesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RoesDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RoesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RoesDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RoesDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RoesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RoesDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [RoesDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [RoesDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [RoesDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [RoesDB] SET ARITHABORT OFF
GO
ALTER DATABASE [RoesDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [RoesDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [RoesDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [RoesDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [RoesDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [RoesDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [RoesDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [RoesDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [RoesDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [RoesDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [RoesDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [RoesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [RoesDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [RoesDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [RoesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [RoesDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [RoesDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [RoesDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [RoesDB] SET  READ_WRITE
GO
ALTER DATABASE [RoesDB] SET RECOVERY FULL
GO
ALTER DATABASE [RoesDB] SET  MULTI_USER
GO
ALTER DATABASE [RoesDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [RoesDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'RoesDB', N'ON'
GO
USE [RoesDB]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[idCuota] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[Cantidad] [int] NULL,
	[Normal] [int] NULL,
	[Sabor] [int] NULL,
	[Total] [int] NULL,
	[Fecha] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SysUsuarios]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SysUsuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produccion]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produccion](
	[idProduccion] [int] IDENTITY(1,1) NOT NULL,
	[kHarina] [int] NULL,
	[kMinsa] [int] NULL,
	[kMasaExtra] [int] NULL,
	[kProducidos] [int] NULL,
	[kTsobrantes] [int] NULL,
	[kTsabor] [int] NULL,
	[Fecha] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gastos](
	[idGasto] [int] IDENTITY(1,1) NOT NULL,
	[Concepto] [varchar](50) NULL,
	[Cantidad] [int] NULL,
	[Precio] [int] NULL,
	[Almacen] [varchar](50) NULL,
	[Fecha] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuota]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuota](
	[idCuota] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NULL,
	[Normal] [int] NULL,
	[sabor] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Corte]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corte](
	[idCorte] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[idProduccion] [int] NOT NULL,
	[Monto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Contacto] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Balance]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balance](
	[idBalance] [int] IDENTITY(1,1) NOT NULL,
	[idCorte] [int] NULL,
	[Fecha] [date] NULL,
	[Venta] [int] NULL,
	[Gstos] [int] NULL,
	[Ingreso] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 12/13/2015 17:45:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[SacosMaseca] [int] NULL,
	[SacosMinsa] [int] NULL,
	[LtGas] [int] NULL,
	[LtAgua] [int] NULL,
	[created] [date] NULL,
	[update] [date] NULL
) ON [PRIMARY]
GO
