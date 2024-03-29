USE [master]
GO
/****** Object:  Database [PractikaZachot]    Script Date: 02.03.2024 14:54:51 ******/
CREATE DATABASE [PractikaZachot]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PractikaZachot', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PractikaZachot.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'PractikaZachot_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PractikaZachot_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PractikaZachot] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PractikaZachot].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PractikaZachot] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PractikaZachot] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PractikaZachot] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PractikaZachot] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PractikaZachot] SET ARITHABORT OFF 
GO
ALTER DATABASE [PractikaZachot] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PractikaZachot] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PractikaZachot] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PractikaZachot] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PractikaZachot] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PractikaZachot] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PractikaZachot] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PractikaZachot] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PractikaZachot] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PractikaZachot] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PractikaZachot] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PractikaZachot] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PractikaZachot] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PractikaZachot] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PractikaZachot] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PractikaZachot] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PractikaZachot] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PractikaZachot] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PractikaZachot] SET  MULTI_USER 
GO
ALTER DATABASE [PractikaZachot] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PractikaZachot] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PractikaZachot] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PractikaZachot] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PractikaZachot] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PractikaZachot] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PractikaZachot] SET QUERY_STORE = OFF
GO
USE [PractikaZachot]
GO
/****** Object:  Table [dbo].[Cloth]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cloth](
	[Article of cloth] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Colour] [nvarchar](50) NULL,
	[Picture] [nvarchar](50) NULL,
	[Image] [nvarchar](50) NULL,
	[Composition] [nvarchar](50) NULL,
	[Width] [int] NULL,
	[Length] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Cloth] PRIMARY KEY CLUSTERED 
(
	[Article of cloth] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cloth of products]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cloth of products](
	[Id cloth of products] [int] IDENTITY(1,1) NOT NULL,
	[Article of cloth] [int] NULL,
	[ID_Product] [int] NULL,
 CONSTRAINT [PK_Cloth of products] PRIMARY KEY CLUSTERED 
(
	[Id cloth of products] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fabric warehouse]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabric warehouse](
	[id_fabric] [int] IDENTITY(1,1) NOT NULL,
	[Article of cloth] [int] NULL,
	[Roll] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Width] [int] NULL,
	[Length] [int] NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_Fabric warehouse_1] PRIMARY KEY CLUSTERED 
(
	[id_fabric] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[Article of furniture] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Hight] [int] NULL,
	[Length] [int] NULL,
	[Weight] [int] NULL,
	[Image] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Furniture] PRIMARY KEY CLUSTERED 
(
	[Article of furniture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture of product]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture of product](
	[id FoP] [int] IDENTITY(1,1) NOT NULL,
	[Article of furniture] [int] NULL,
	[ID_Product] [int] NULL,
	[Width] [int] NULL,
	[Hight] [int] NULL,
	[Fabric] [nvarchar](50) NULL,
	[Edging] [nvarchar](50) NULL,
	[Hardware] [nvarchar](50) NULL,
	[Placements] [nvarchar](50) NULL,
	[HardwareSizes] [nvarchar](50) NULL,
 CONSTRAINT [PK_Furniture of product] PRIMARY KEY CLUSTERED 
(
	[id FoP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Order number] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[The stage of execution] [nvarchar](50) NULL,
	[Customer] [nvarchar](50) NULL,
	[Manager] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Order number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordered products]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordered products](
	[Order number] [int] IDENTITY(1,1) NOT NULL,
	[ID_Product] [int] NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_Ordered products] PRIMARY KEY CLUSTERED 
(
	[Order number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[The product]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[The product](
	[ID_Product] [int] IDENTITY(1,1) NOT NULL,
	[Article of product] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Width] [int] NULL,
	[Length] [int] NULL,
	[Image] [nvarchar](50) NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_The product] PRIMARY KEY CLUSTERED 
(
	[ID_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse of furniture]    Script Date: 02.03.2024 14:54:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse of furniture](
	[Batch] [int] IDENTITY(1,1) NOT NULL,
	[Article of furniture] [int] NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_Warehouse of furniture] PRIMARY KEY CLUSTERED 
(
	[Batch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cloth of products]  WITH CHECK ADD  CONSTRAINT [FK_Cloth of products_Cloth] FOREIGN KEY([Article of cloth])
REFERENCES [dbo].[Cloth] ([Article of cloth])
GO
ALTER TABLE [dbo].[Cloth of products] CHECK CONSTRAINT [FK_Cloth of products_Cloth]
GO
ALTER TABLE [dbo].[Cloth of products]  WITH CHECK ADD  CONSTRAINT [FK_Cloth of products_The product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[The product] ([ID_Product])
GO
ALTER TABLE [dbo].[Cloth of products] CHECK CONSTRAINT [FK_Cloth of products_The product]
GO
ALTER TABLE [dbo].[Fabric warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Fabric warehouse_Cloth] FOREIGN KEY([Article of cloth])
REFERENCES [dbo].[Cloth] ([Article of cloth])
GO
ALTER TABLE [dbo].[Fabric warehouse] CHECK CONSTRAINT [FK_Fabric warehouse_Cloth]
GO
ALTER TABLE [dbo].[Furniture of product]  WITH CHECK ADD  CONSTRAINT [FK_Furniture of product_Furniture] FOREIGN KEY([Article of furniture])
REFERENCES [dbo].[Furniture] ([Article of furniture])
GO
ALTER TABLE [dbo].[Furniture of product] CHECK CONSTRAINT [FK_Furniture of product_Furniture]
GO
ALTER TABLE [dbo].[Furniture of product]  WITH CHECK ADD  CONSTRAINT [FK_Furniture of product_The product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[The product] ([ID_Product])
GO
ALTER TABLE [dbo].[Furniture of product] CHECK CONSTRAINT [FK_Furniture of product_The product]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Ordered products] FOREIGN KEY([Order number])
REFERENCES [dbo].[Ordered products] ([Order number])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Ordered products]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([Customer])
REFERENCES [dbo].[User] ([Login])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User1] FOREIGN KEY([Manager])
REFERENCES [dbo].[User] ([Login])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User1]
GO
ALTER TABLE [dbo].[Ordered products]  WITH CHECK ADD  CONSTRAINT [FK_Ordered products_The product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[The product] ([ID_Product])
GO
ALTER TABLE [dbo].[Ordered products] CHECK CONSTRAINT [FK_Ordered products_The product]
GO
ALTER TABLE [dbo].[Warehouse of furniture]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse of furniture_Furniture] FOREIGN KEY([Article of furniture])
REFERENCES [dbo].[Furniture] ([Article of furniture])
GO
ALTER TABLE [dbo].[Warehouse of furniture] CHECK CONSTRAINT [FK_Warehouse of furniture_Furniture]
GO
USE [master]
GO
ALTER DATABASE [PractikaZachot] SET  READ_WRITE 
GO
