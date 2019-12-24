USE [master]
GO
/****** Object:  Database [My_Restaurant_DB]    Script Date: 24/12/19 12:12:31 ******/
CREATE DATABASE [My_Restaurant_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'My_Restaurant_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\My_Restaurant_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'My_Restaurant_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\My_Restaurant_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [My_Restaurant_DB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [My_Restaurant_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [My_Restaurant_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [My_Restaurant_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [My_Restaurant_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [My_Restaurant_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [My_Restaurant_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [My_Restaurant_DB] SET  MULTI_USER 
GO
ALTER DATABASE [My_Restaurant_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [My_Restaurant_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [My_Restaurant_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [My_Restaurant_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [My_Restaurant_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'My_Restaurant_DB', N'ON'
GO
ALTER DATABASE [My_Restaurant_DB] SET QUERY_STORE = OFF
GO
USE [My_Restaurant_DB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [My_Restaurant_DB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 24/12/19 12:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nchar](20) NULL,
	[Password] [nchar](20) NULL,
	[Name] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tableList]    Script Date: 24/12/19 12:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tableList](
	[tableName] [nchar](20) NULL,
	[tableID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tableList] PRIMARY KEY CLUSTERED 
(
	[tableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([Username], [Password], [Name], [Position]) VALUES (N'hung                ', N'123                 ', N'Phước Hưng', N'Manager')
INSERT [dbo].[Account] ([Username], [Password], [Name], [Position]) VALUES (N'ngochai1591         ', N'asdasd123           ', N'Phạm Ngọc Hải', N'Server')
INSERT [dbo].[Account] ([Username], [Password], [Name], [Position]) VALUES (N'hung8               ', N'66                  ', N'hung', N'user')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 1             ', N'T01       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 2             ', N'T02       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 3             ', N'T03       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 4             ', N'T04       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 5             ', N'T05       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 6             ', N'T06       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 7             ', N'T07       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 8             ', N'T08       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 9             ', N'T09       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 10            ', N'T10       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 11            ', N'T11       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 12            ', N'T12       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 13            ', N'T13       ')
INSERT [dbo].[tableList] ([tableName], [tableID]) VALUES (N'Table 14            ', N'T14       ')
USE [master]
GO
ALTER DATABASE [My_Restaurant_DB] SET  READ_WRITE 
GO
