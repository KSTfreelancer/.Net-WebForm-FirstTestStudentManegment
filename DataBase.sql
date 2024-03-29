USE [master]
GO
/****** Object:  Database [Student_manegment]    Script Date: 12/14/2022 7:06:08 PM ******/
CREATE DATABASE [Student_manegment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student_manegment', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Student_manegment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student_manegment_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Student_manegment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Student_manegment] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student_manegment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student_manegment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student_manegment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student_manegment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student_manegment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student_manegment] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student_manegment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student_manegment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student_manegment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student_manegment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student_manegment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student_manegment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student_manegment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student_manegment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student_manegment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student_manegment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Student_manegment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student_manegment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student_manegment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student_manegment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student_manegment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student_manegment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student_manegment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student_manegment] SET RECOVERY FULL 
GO
ALTER DATABASE [Student_manegment] SET  MULTI_USER 
GO
ALTER DATABASE [Student_manegment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student_manegment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student_manegment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student_manegment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Student_manegment] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Student_manegment] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Student_manegment', N'ON'
GO
ALTER DATABASE [Student_manegment] SET QUERY_STORE = OFF
GO
USE [Student_manegment]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 12/14/2022 7:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] NULL,
	[CourseName] [nvarchar](20) NULL,
	[Duration] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 12/14/2022 7:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] NULL,
	[Name] [nvarchar](20) NULL,
	[HeadOfDepartment] [nvarchar](20) NULL,
	[Phone] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marks_sit]    Script Date: 12/14/2022 7:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks_sit](
	[Student_Roll] [nvarchar](20) NOT NULL,
	[Course_Name] [nvarchar](25) NOT NULL,
	[Marks] [nvarchar](15) NOT NULL,
	[OutOfMarks] [nvarchar](15) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stLogin]    Script Date: 12/14/2022 7:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stLogin](
	[userName] [nvarchar](25) NOT NULL,
	[userPassword] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/14/2022 7:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] NULL,
	[Name] [nvarchar](20) NULL,
	[Address] [nvarchar](40) NULL,
	[Age] [int] NULL,
	[Roll] [int] NULL,
	[Phone] [nvarchar](20) NULL,
	[RegNo] [int] NULL,
	[Session] [int] NULL,
	[Department] [nvarchar](15) NULL,
	[Course] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 12/14/2022 7:06:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Id] [int] NULL,
	[Name] [nvarchar](20) NULL,
	[Subject] [nvarchar](20) NULL,
	[Department] [nvarchar](20) NULL,
	[Address] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[DateOfJoin] [date] NULL,
	[Phone] [nvarchar](20) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (1, N'Graphic', N'6-Month')
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (2, N'C++', N'6-Month')
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (3, N'C#', N'6-Month')
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (4, N'Fiber Cable', N'1-Year')
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (5, N'machine', N'6-Month')
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (6, N'Architect', N'6-Month')
INSERT [dbo].[Course] ([Id], [CourseName], [Duration]) VALUES (7, N'Construction', N'1-Year')
GO
INSERT [dbo].[Department] ([Id], [Name], [HeadOfDepartment], [Phone]) VALUES (1, N'CMT', N'Md.Tohidul Islam', N'85944305843')
INSERT [dbo].[Department] ([Id], [Name], [HeadOfDepartment], [Phone]) VALUES (2, N'EEE', N'Md.Munna Islam', N'85944305843')
INSERT [dbo].[Department] ([Id], [Name], [HeadOfDepartment], [Phone]) VALUES (3, N'Civil', N'Md.Motaleb Hossin', N'85944305843')
GO
INSERT [dbo].[Marks_sit] ([Student_Roll], [Course_Name], [Marks], [OutOfMarks]) VALUES (N'328301', N'Graphic', N'85', N'100')
INSERT [dbo].[Marks_sit] ([Student_Roll], [Course_Name], [Marks], [OutOfMarks]) VALUES (N'328302', N'Graphic', N'74', N'100')
GO
INSERT [dbo].[stLogin] ([userName], [userPassword]) VALUES (N'Student', N'student12345')
INSERT [dbo].[stLogin] ([userName], [userPassword]) VALUES (N'student', N'12345')
GO
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (1, N'Md.Roton Islam', N'Mirpur-2-329/02', 16, 328301, N'74659453245', 272001, 2016, N'CMT', N'Graphic')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (2, N'Md.Tonmoy Islam', N'Mirpur-10-329/02', 16, 328302, N'74659437395', 272002, 2016, N'CMT', N'Graphic')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (3, N'Md.Rabby Islam', N'Mirpur-1-234/05', 14, 328303, N'23543245646', 272003, 2016, N'CMT', N'Graphic')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (4, N'Md.Tusher Islam', N'Mirpur-1-53/11', 16, 328304, N'74659436395', 272004, 2016, N'EEE', N'Fiber Cable')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (5, N'Md.Shanto Islam', N'Mirpur-2-06/23', 14, 328305, N'74659423395', 272005, 2016, N'EEE', N'Fiber Cable')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (6, N'Md.Sakin Islam', N'Mirpur-2-13/08', 16, 328306, N'74659437395', 272006, 2016, N'EEE', N'machine')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (7, N'Md.Sabbir Islam', N'Mirpur-10-130/06', 15, 328307, N'74634437395', 272007, 2016, N'Civil', N'Architect')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (8, N'Md.Emon Islam', N'Mirpur-14-234/21', 16, 328308, N'74659887395', 272008, 2016, N'Civil', N'Architect')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (9, N'Md.Forad Islam', N'Mirpur-14-123/45', 15, 328309, N'74634437395', 272009, 2016, N'Civil', N'Architect')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (10, N'Md.Ikram Islam', N'Mirpur-14-43/32', 16, 328310, N'74665437395', 272010, 2016, N'Civil', N'Construction')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (11, N'Md.Mahafuz Islam', N'Mirpur-11-233/23', 16, 328312, N'74659787395', 272011, 2016, N'Civil', N'Construction')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (12, N'Md.Sanvi Islam', N'Mirpur-11-323/23', 14, 328312, N'74659347395', 272012, 2016, N'EEE', N'machine')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (13, N'Md.Moon Islam', N'Mirpur-11-343/12', 16, 328313, N'74659467395', 272013, 2016, N'CMT', N'C#')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (14, N'Md.Ashik Islam', N'Mirpur-11-454/34', 16, 328314, N'74659977395', 272014, 2016, N'CMT', N'C#')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (15, N'Md.Joty Islam', N'Mirpur-2-357/12', 16, 328315, N'74659406395', 272015, 2016, N'CMT', N'C#')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (16, N'Md.Noyon Islam', N'Mirpur-1-396/34', 15, 328316, N'74659097395', 272016, 2016, N'CMT', N'C++')
INSERT [dbo].[Students] ([Id], [Name], [Address], [Age], [Roll], [Phone], [RegNo], [Session], [Department], [Course]) VALUES (17, N'Md.Rasel Islam', N'Mirpur-1-598/30', 16, 328317, N'74659400395', 272017, 2016, N'CMT', N'C++')
GO
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (1, N'Md.Harun Islam', N'C++', N'CMT', N'Jhenaidah', 42, CAST(N'2005-05-16' AS Date), N'98432573953')
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (2, N'Md.Shadot Hosin', N'C#', N'CMT', N'Khulna', 37, CAST(N'2010-05-16' AS Date), N'84325573953')
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (3, N'Md.Torikul Islam', N'Graphic', N'CMT', N'Kushtia', 30, CAST(N'2013-03-18' AS Date), N'854342573953')
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (4, N'Md.Soriful Islam', N'Fiber Cable', N'EEE', N'Dhaka', 38, CAST(N'2007-05-16' AS Date), N'8843345463953')
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (5, N'Md.Razak Islam', N'machine', N'EEE', N'Kushtia', 40, CAST(N'2009-05-16' AS Date), N'884325643953')
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (6, N'Md.Saidul Islam', N'Architect', N'Civil', N'Kushtia', 45, CAST(N'2003-05-16' AS Date), N'84765673953')
INSERT [dbo].[Teacher] ([Id], [Name], [Subject], [Department], [Address], [Age], [DateOfJoin], [Phone]) VALUES (7, N'Md.Jafor Islam', N'Construction', N'Civil', N'Borishal', 36, CAST(N'2009-05-16' AS Date), N'8423673953')
GO
USE [master]
GO
ALTER DATABASE [Student_manegment] SET  READ_WRITE 
GO
