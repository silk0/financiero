USE [master]
GO
/****** Object:  Database [financiero]    Script Date: 16/9/2020 12:27:15 am ******/
CREATE DATABASE [financiero]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'financiero', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\financiero.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'financiero_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\financiero_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [financiero] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [financiero].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [financiero] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [financiero] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [financiero] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [financiero] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [financiero] SET ARITHABORT OFF 
GO
ALTER DATABASE [financiero] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [financiero] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [financiero] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [financiero] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [financiero] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [financiero] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [financiero] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [financiero] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [financiero] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [financiero] SET  ENABLE_BROKER 
GO
ALTER DATABASE [financiero] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [financiero] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [financiero] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [financiero] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [financiero] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [financiero] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [financiero] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [financiero] SET RECOVERY FULL 
GO
ALTER DATABASE [financiero] SET  MULTI_USER 
GO
ALTER DATABASE [financiero] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [financiero] SET DB_CHAINING OFF 
GO
ALTER DATABASE [financiero] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [financiero] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [financiero] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'financiero', N'ON'
GO
ALTER DATABASE [financiero] SET QUERY_STORE = OFF
GO
USE [financiero]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[tipo_descripcion] [nvarchar](5) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_civils]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_civils](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[generos]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[generos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nivel_acceso]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nivel_acceso](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](5) NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nivel_acceso_usuarios]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nivel_acceso_usuarios](
	[id_nivel_acceso] [int] NOT NULL,
	[id_usuarios] [int] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nivel_acceso] ASC,
	[id_usuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](45) NOT NULL,
	[apellidos] [varchar](45) NOT NULL,
	[telefono] [varchar](10) NOT NULL,
	[nit] [varchar](17) NOT NULL,
	[dui] [varchar](10) NOT NULL,
	[id_genero] [int] NOT NULL,
	[id_estados_civil] [int] NOT NULL,
	[hijos] [int] NOT NULL,
	[estado] [int] NOT NULL,
	[tipo] [int] NOT NULL,
	[fecha_nacimiento] [datetime] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 16/9/2020 12:27:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](45) NOT NULL,
	[contrasena] [varchar](45) NOT NULL,
	[correo] [varchar](45) NOT NULL,
	[id_persona] [int] NULL,
	[estado] [int] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_actualizacion] [datetime] NOT NULL,
	[token] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_2] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [fk_usuarios_2]
GO
ALTER TABLE [dbo].[nivel_acceso_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_nivel_acceso_1] FOREIGN KEY([id_nivel_acceso])
REFERENCES [dbo].[nivel_acceso] ([id])
GO
ALTER TABLE [dbo].[nivel_acceso_usuarios] CHECK CONSTRAINT [fk_nivel_acceso_1]
GO
ALTER TABLE [dbo].[nivel_acceso_usuarios]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_1] FOREIGN KEY([id_usuarios])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[nivel_acceso_usuarios] CHECK CONSTRAINT [fk_usuarios_1]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [fk_estado_civils_1] FOREIGN KEY([id_estados_civil])
REFERENCES [dbo].[estado_civils] ([id])
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [fk_estado_civils_1]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [fk_genero_1] FOREIGN KEY([id_genero])
REFERENCES [dbo].[generos] ([id])
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [fk_genero_1]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [fk_persona_1] FOREIGN KEY([id_persona])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [fk_persona_1]
GO
USE [master]
GO
ALTER DATABASE [financiero] SET  READ_WRITE 
GO
