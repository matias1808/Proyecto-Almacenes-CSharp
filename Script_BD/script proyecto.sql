USE [master]
GO
/****** Object:  Database [db_proyecto_3]    Script Date: 8/06/2025 20:21:40 ******/
CREATE DATABASE [db_proyecto_3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_proyecto_3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_proyecto_3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_proyecto_3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_proyecto_3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_proyecto_3] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_proyecto_3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_proyecto_3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_proyecto_3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_proyecto_3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_proyecto_3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_proyecto_3] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_proyecto_3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_proyecto_3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_proyecto_3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_proyecto_3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_proyecto_3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_proyecto_3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_proyecto_3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_proyecto_3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_proyecto_3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_proyecto_3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_proyecto_3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_proyecto_3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_proyecto_3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_proyecto_3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_proyecto_3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_proyecto_3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_proyecto_3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_proyecto_3] SET RECOVERY FULL 
GO
ALTER DATABASE [db_proyecto_3] SET  MULTI_USER 
GO
ALTER DATABASE [db_proyecto_3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_proyecto_3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_proyecto_3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_proyecto_3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_proyecto_3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_proyecto_3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_proyecto_3', N'ON'
GO
ALTER DATABASE [db_proyecto_3] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_proyecto_3] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_proyecto_3]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 8/06/2025 20:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[Id_Almacen] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Tipo_Almacen] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Id_AlmacenGeneral] [int] NOT NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[Id_Almacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Almacen_General]    Script Date: 8/06/2025 20:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen_General](
	[Id_AlmacenGeneral] [int] IDENTITY(1,1) NOT NULL,
	[Area_Recepcion] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Area_Despacho] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Almacen_General] PRIMARY KEY CLUSTERED 
(
	[Id_AlmacenGeneral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area_Operativa_Produccion]    Script Date: 8/06/2025 20:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area_Operativa_Produccion](
	[Id_Area] [int] IDENTITY(1,1) NOT NULL,
	[Seccion] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Area_Operativa_Produccion] PRIMARY KEY CLUSTERED 
(
	[Id_Area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area_Producto]    Script Date: 8/06/2025 20:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area_Producto](
	[Numero_Documento] [int] IDENTITY(1,1) NOT NULL,
	[Id_Area] [int] NOT NULL,
	[Codigo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Area_Producto] PRIMARY KEY CLUSTERED 
(
	[Numero_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 8/06/2025 20:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Costo] [decimal](5, 2) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Unidad_Medida] [varchar](50) NOT NULL,
	[Tipo_Producto] [varchar](50) NOT NULL,
	[Stock] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Id_Almacen] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 8/06/2025 20:21:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[Id_Trabajador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Id_Almacen] [int] NOT NULL,
 CONSTRAINT [PK_Trabajador] PRIMARY KEY CLUSTERED 
(
	[Id_Trabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Almacen]  WITH CHECK ADD  CONSTRAINT [FK_Almacen_Almacen_General] FOREIGN KEY([Id_AlmacenGeneral])
REFERENCES [dbo].[Almacen_General] ([Id_AlmacenGeneral])
GO
ALTER TABLE [dbo].[Almacen] CHECK CONSTRAINT [FK_Almacen_Almacen_General]
GO
ALTER TABLE [dbo].[Area_Producto]  WITH CHECK ADD  CONSTRAINT [FK_Area_Producto_Area_Operativa_Produccion] FOREIGN KEY([Id_Area])
REFERENCES [dbo].[Area_Operativa_Produccion] ([Id_Area])
GO
ALTER TABLE [dbo].[Area_Producto] CHECK CONSTRAINT [FK_Area_Producto_Area_Operativa_Produccion]
GO
ALTER TABLE [dbo].[Area_Producto]  WITH CHECK ADD  CONSTRAINT [FK_Area_Producto_Producto] FOREIGN KEY([Codigo])
REFERENCES [dbo].[Producto] ([Codigo])
GO
ALTER TABLE [dbo].[Area_Producto] CHECK CONSTRAINT [FK_Area_Producto_Producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Almacen] FOREIGN KEY([Id_Almacen])
REFERENCES [dbo].[Almacen] ([Id_Almacen])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Almacen]
GO
ALTER TABLE [dbo].[Trabajador]  WITH CHECK ADD  CONSTRAINT [FK_Trabajador_Almacen] FOREIGN KEY([Id_Almacen])
REFERENCES [dbo].[Almacen] ([Id_Almacen])
GO
ALTER TABLE [dbo].[Trabajador] CHECK CONSTRAINT [FK_Trabajador_Almacen]
GO
USE [master]
GO
ALTER DATABASE [db_proyecto_3] SET  READ_WRITE 
GO
