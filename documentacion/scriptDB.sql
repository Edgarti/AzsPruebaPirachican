USE [master]
GO
/****** Object:  Database [azs_pirachican]    Script Date: 27/01/2024 2:54:55 a. m. ******/
CREATE DATABASE [azs_pirachican]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'azs_pirachican', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVE\MSSQL\DATA\azs_pirachican.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'azs_pirachican_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVE\MSSQL\DATA\azs_pirachican_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [azs_pirachican] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [azs_pirachican].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [azs_pirachican] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [azs_pirachican] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [azs_pirachican] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [azs_pirachican] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [azs_pirachican] SET ARITHABORT OFF 
GO
ALTER DATABASE [azs_pirachican] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [azs_pirachican] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [azs_pirachican] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [azs_pirachican] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [azs_pirachican] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [azs_pirachican] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [azs_pirachican] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [azs_pirachican] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [azs_pirachican] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [azs_pirachican] SET  ENABLE_BROKER 
GO
ALTER DATABASE [azs_pirachican] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [azs_pirachican] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [azs_pirachican] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [azs_pirachican] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [azs_pirachican] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [azs_pirachican] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [azs_pirachican] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [azs_pirachican] SET RECOVERY FULL 
GO
ALTER DATABASE [azs_pirachican] SET  MULTI_USER 
GO
ALTER DATABASE [azs_pirachican] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [azs_pirachican] SET DB_CHAINING OFF 
GO
ALTER DATABASE [azs_pirachican] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [azs_pirachican] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [azs_pirachican] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'azs_pirachican', N'ON'
GO
USE [azs_pirachican]
GO
/****** Object:  Table [dbo].[autores]    Script Date: 27/01/2024 2:54:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[autores](
	[autorID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[fecCreacion] [datetime] NULL DEFAULT (getdate()),
	[estado] [int] NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[autorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[libros]    Script Date: 27/01/2024 2:54:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[libros](
	[libroID] [int] IDENTITY(1,1) NOT NULL,
	[autorID] [int] NULL,
	[titulo] [varchar](50) NULL,
	[fecCreacion] [datetime] NULL DEFAULT (getdate()),
	[estado] [int] NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[libroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_autores] FOREIGN KEY([autorID])
REFERENCES [dbo].[autores] ([autorID])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_autores]
GO
USE [master]
GO
ALTER DATABASE [azs_pirachican] SET  READ_WRITE 
GO
