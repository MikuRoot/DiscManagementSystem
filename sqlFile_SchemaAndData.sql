USE [master]
GO
/****** Object:  Database [QuanLyChoThueBangDia]    Script Date: 30/06/2018 12:05:50 ******/
CREATE DATABASE [QuanLyChoThueBangDia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyChoThueBangDia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MIKUROOT\MSSQL\DATA\QuanLyChoThueBangDia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyChoThueBangDia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MIKUROOT\MSSQL\DATA\QuanLyChoThueBangDia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyChoThueBangDia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyChoThueBangDia', N'ON'
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET QUERY_STORE = OFF
GO
USE [QuanLyChoThueBangDia]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLyChoThueBangDia]
GO
/****** Object:  Table [dbo].[Dias]    Script Date: 30/06/2018 12:05:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias](
	[MaDia] [int] NOT NULL,
	[TinhTrangThue] [nvarchar](20) NOT NULL,
	[TinhTrangDia] [nvarchar](20) NOT NULL,
	[IDTuaDe] [varchar](15) NOT NULL,
	[IDLoaiDia] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangDois]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangDois](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaKhacHangs] [varchar](15) NOT NULL,
	[MaTuaDe] [varchar](15) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[SoLuongDat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHangs]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHangs](
	[MaKhachHang] [varchar](15) NOT NULL,
	[TenKhachHang] [nvarchar](max) NOT NULL,
	[SoDienThoai] [char](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDias]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDias](
	[MaLoai] [varchar](15) NOT NULL,
	[TenLoai] [nvarchar](max) NOT NULL,
	[ThoiGianChoPhepThue] [int] NOT NULL,
	[GiaThue] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[UserName] [nvarchar](100) NOT NULL,
	[Pass] [char](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhatKyGhiNo]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKyGhiNo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKhachHang] [varchar](15) NULL,
	[IDDia] [int] NULL,
	[SoTienNo] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhatKyThueDia]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhatKyThueDia](
	[NgayChoThue] [datetime] NOT NULL,
	[MaTua] [varchar](15) NOT NULL,
	[MaDia] [varchar](15) NOT NULL,
	[MaKH] [varchar](15) NOT NULL,
	[SoLuongThue] [int] NOT NULL,
	[TienDatCoc] [money] NOT NULL,
	[PhiTreHen] [money] NULL,
	[NgayTraDia] [datetime] NULL,
	[tinhtrangtradia] [nvarchar](30) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuaDes]    Script Date: 30/06/2018 12:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuaDes](
	[MaTuaDe] [varchar](15) NOT NULL,
	[NoiDungTuaDe] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[SoLuongDia] [int] NULL,
	[MaLoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTuaDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (2, N'Available', N'Not good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (3, N'Available', N'Not good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (4, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (5, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (6, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (7, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (8, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (9, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (10, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (11, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (12, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (13, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (14, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (15, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (16, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (17, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (18, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (19, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (20, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (21, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (22, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (23, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (24, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (25, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (26, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (27, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (28, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (29, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (30, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (31, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (32, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (33, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (34, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (35, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (36, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (37, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (38, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (39, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (40, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (41, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (42, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (43, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (44, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (45, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (46, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (47, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (48, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (49, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (50, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (51, N'Available', N'Good', N'Sh001', N'Type001')
GO
INSERT [dbo].[Dias] ([MaDia], [TinhTrangThue], [TinhTrangDia], [IDTuaDe], [IDLoaiDia]) VALUES (52, N'Not Available', N'Good', N'Te001', N'Type002')
GO
SET IDENTITY_INSERT [dbo].[HangDois] ON 
GO
INSERT [dbo].[HangDois] ([ID], [MaKhacHangs], [MaTuaDe], [ThuTu], [SoLuongDat]) VALUES (33, N'KH004', N'Te001', 2, 0)
GO
INSERT [dbo].[HangDois] ([ID], [MaKhacHangs], [MaTuaDe], [ThuTu], [SoLuongDat]) VALUES (34, N'KH003', N'Te001', 3, 1)
GO
SET IDENTITY_INSERT [dbo].[HangDois] OFF
GO
INSERT [dbo].[KhachHangs] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH003', N'Tran The Vu', N'01269811755')
GO
INSERT [dbo].[KhachHangs] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH004', N'Nguyen Thi Kim Thoa', N'0973244037 ')
GO
INSERT [dbo].[KhachHangs] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH481', N'Tran Ngoc Tho my', N'01265566945')
GO
INSERT [dbo].[KhachHangs] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH671', N'Do Tuan Anh', N'01298856557')
GO
INSERT [dbo].[KhachHangs] ([MaKhachHang], [TenKhachHang], [SoDienThoai]) VALUES (N'KH962', N'Do Tuan Anh', N'01268526544')
GO
INSERT [dbo].[LoaiDias] ([MaLoai], [TenLoai], [ThoiGianChoPhepThue], [GiaThue]) VALUES (N'Type001', N'DVD', 1, 3.0000)
GO
INSERT [dbo].[LoaiDias] ([MaLoai], [TenLoai], [ThoiGianChoPhepThue], [GiaThue]) VALUES (N'Type002', N'Game', 2, 2.5000)
GO
INSERT [dbo].[Logins] ([UserName], [Pass]) VALUES (N'Admin', N'autocomplete                                      ')
GO
SET IDENTITY_INSERT [dbo].[NhatKyThueDia] ON 
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-27T17:34:27.787' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-28T17:34:27.943' AS DateTime), N'Da tra', 1)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-25T22:45:28.990' AS DateTime), N'Sh001', N'3', N'KH003', 2, 6.0000, 0.6000, CAST(N'2018-06-26T22:45:28.990' AS DateTime), N'Da tra', 2)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-27T17:47:10.967' AS DateTime), N'Sh001', N'3', N'KH962', 1, 3.0000, 0.0000, CAST(N'2018-06-28T17:47:11.107' AS DateTime), N'Da tra', 3)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-25T23:17:32.210' AS DateTime), N'Sh001', N'4', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-26T23:17:32.210' AS DateTime), N'Da tra', 4)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-25T23:19:59.143' AS DateTime), N'Sh001', N'5', N'KH004', 1, 3.0000, 0.3000, CAST(N'2018-06-26T23:19:59.143' AS DateTime), N'Da tra', 5)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-25T23:24:41.743' AS DateTime), N'Sh001', N'6', N'KH004', 1, 3.0000, 0.0000, CAST(N'2018-06-26T23:24:41.743' AS DateTime), N'Da tra', 6)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-27T18:09:15.620' AS DateTime), N'Sh001', N'3', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-28T18:09:15.620' AS DateTime), N'Da tra', 7)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T00:54:35.490' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-29T00:54:35.490' AS DateTime), N'Da tra', 8)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T02:11:49.297' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-29T02:11:49.297' AS DateTime), N'Da tra', 9)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T02:27:27.620' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-29T02:27:27.620' AS DateTime), N'Da tra', 12)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T02:29:51.023' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-29T02:29:51.023' AS DateTime), N'Da tra', 13)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T02:40:22.373' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-29T02:40:22.373' AS DateTime), N'Da tra', 14)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T02:40:45.587' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-29T02:40:45.587' AS DateTime), N'Da tra', 15)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T03:00:10.780' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-29T03:00:10.780' AS DateTime), N'Da tra', 16)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-28T17:27:33.897' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-29T17:27:34.473' AS DateTime), N'Da tra', 19)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T11:16:05.900' AS DateTime), N'Sh001', N'3', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T11:16:05.903' AS DateTime), N'Da tra', 20)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T11:19:49.427' AS DateTime), N'Sh001', N'2', N'KH004', 1, 3.0000, 0.0000, CAST(N'2018-06-30T11:19:49.427' AS DateTime), N'Da tra', 21)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T11:23:30.773' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-30T11:23:30.773' AS DateTime), N'Da tra', 22)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:24:58.007' AS DateTime), N'Sh001', N'3', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:24:58.007' AS DateTime), N'Da tra', 23)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:31:30.147' AS DateTime), N'Sh001', N'3', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:31:30.147' AS DateTime), N'Da tra', 24)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:31:44.023' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:31:44.023' AS DateTime), N'Da tra', 25)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:34:08.837' AS DateTime), N'Sh001', N'4', N'KH004', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:34:08.837' AS DateTime), N'Da tra', 26)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:42:15.550' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:42:15.550' AS DateTime), N'Da tra', 27)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:42:21.910' AS DateTime), N'Sh001', N'3', N'KH004', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:42:21.910' AS DateTime), N'Da tra', 28)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:42:35.510' AS DateTime), N'Sh001', N'3', N'KH962', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:42:35.510' AS DateTime), N'Da tra', 29)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:43:07.697' AS DateTime), N'Te001', N'52', N'KH004', 1, 2.5000, 0.0000, CAST(N'2018-06-30T20:43:07.697' AS DateTime), N'Da tra', 30)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:50:22.647' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:50:22.647' AS DateTime), N'Da tra', 31)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:50:29.007' AS DateTime), N'Sh001', N'3', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:50:29.007' AS DateTime), N'Da tra', 32)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:50:37.757' AS DateTime), N'Te001', N'52', N'KH004', 1, 2.5000, 0.0000, CAST(N'2018-06-30T20:50:37.757' AS DateTime), N'Da tra', 33)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:54:35.157' AS DateTime), N'Sh001', N'2', N'KH003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:54:35.157' AS DateTime), N'Da tra', 34)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:54:41.763' AS DateTime), N'Sh001', N'3', N'kh004', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:54:41.763' AS DateTime), N'Da tra', 35)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:54:52.420' AS DateTime), N'Te001', N'52', N'KH004', 1, 2.5000, 0.0000, CAST(N'2018-06-30T20:54:52.420' AS DateTime), N'Da tra', 36)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:57:17.197' AS DateTime), N'Sh001', N'2', N'kh003', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:57:17.197' AS DateTime), N'Da tra', 37)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:57:20.867' AS DateTime), N'Sh001', N'2', N'kh004', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:57:20.867' AS DateTime), N'Da tra', 38)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:57:25.260' AS DateTime), N'Sh001', N'2', N'kh962', 1, 3.0000, 0.0000, CAST(N'2018-06-30T20:57:25.260' AS DateTime), N'Da tra', 39)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T20:57:38.797' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-30T20:57:38.797' AS DateTime), N'Da tra', 40)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T21:01:22.350' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-30T21:01:22.350' AS DateTime), N'Da tra', 41)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T21:05:03.580' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-30T21:05:03.580' AS DateTime), N'Da tra', 42)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T21:07:02.023' AS DateTime), N'Te001', N'52', N'KH004', 1, 2.5000, 0.0000, CAST(N'2018-06-30T21:07:02.023' AS DateTime), N'Da tra', 43)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-29T21:18:45.927' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-06-30T21:18:45.927' AS DateTime), N'Da tra', 44)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-30T11:43:02.900' AS DateTime), N'Sh001', N'2', N'KH004', 1, 3.0000, 0.0000, CAST(N'2018-07-01T11:43:02.900' AS DateTime), N'Da tra', 46)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-30T11:45:02.120' AS DateTime), N'Sh001', N'3', N'KH004', 1, 3.0000, 0.0000, CAST(N'2018-07-01T11:45:02.120' AS DateTime), N'Da tra', 47)
GO
INSERT [dbo].[NhatKyThueDia] ([NgayChoThue], [MaTua], [MaDia], [MaKH], [SoLuongThue], [TienDatCoc], [PhiTreHen], [NgayTraDia], [tinhtrangtradia], [ID]) VALUES (CAST(N'2018-06-30T11:50:57.290' AS DateTime), N'Te001', N'52', N'KH003', 1, 2.5000, 0.0000, CAST(N'2018-07-01T11:50:57.290' AS DateTime), N'Chua tra', 48)
GO
SET IDENTITY_INSERT [dbo].[NhatKyThueDia] OFF
GO
INSERT [dbo].[TuaDes] ([MaTuaDe], [NoiDungTuaDe], [ImageUrl], [SoLuongDia], [MaLoai]) VALUES (N'Sh001', N'Shape of voice', N'D:\Product\CSharpProducts\XayDungPhanMem\Quan_Ly_Cho_Thue_Bang_Dia\UIs\bin\Image\koe-no-katachi.jpg', 50, N'Type001')
GO
INSERT [dbo].[TuaDes] ([MaTuaDe], [NoiDungTuaDe], [ImageUrl], [SoLuongDia], [MaLoai]) VALUES (N'Te001', N'Tenchu:Fatal Shadow', N'D:\Product\CSharpProducts\XayDungPhanMem\Quan_Ly_Cho_Thue_Bang_Dia\UIs\bin\Image\Tenchu_Fatal_Shadow.jpg', 0, N'Type002')
GO
ALTER TABLE [dbo].[Dias]  WITH CHECK ADD  CONSTRAINT [FK_Dias_LoaiDias] FOREIGN KEY([IDLoaiDia])
REFERENCES [dbo].[LoaiDias] ([MaLoai])
GO
ALTER TABLE [dbo].[Dias] CHECK CONSTRAINT [FK_Dias_LoaiDias]
GO
ALTER TABLE [dbo].[Dias]  WITH CHECK ADD  CONSTRAINT [FK_Dias_TuaDes] FOREIGN KEY([IDTuaDe])
REFERENCES [dbo].[TuaDes] ([MaTuaDe])
GO
ALTER TABLE [dbo].[Dias] CHECK CONSTRAINT [FK_Dias_TuaDes]
GO
ALTER TABLE [dbo].[HangDois]  WITH CHECK ADD  CONSTRAINT [FK_HangDois_KhachHangs] FOREIGN KEY([MaKhacHangs])
REFERENCES [dbo].[KhachHangs] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HangDois] CHECK CONSTRAINT [FK_HangDois_KhachHangs]
GO
ALTER TABLE [dbo].[HangDois]  WITH CHECK ADD  CONSTRAINT [FK_HangDois_TuaDes] FOREIGN KEY([MaTuaDe])
REFERENCES [dbo].[TuaDes] ([MaTuaDe])
GO
ALTER TABLE [dbo].[HangDois] CHECK CONSTRAINT [FK_HangDois_TuaDes]
GO
ALTER TABLE [dbo].[NhatKyGhiNo]  WITH CHECK ADD  CONSTRAINT [FK_NhatKyGhiNo_Dias] FOREIGN KEY([IDDia])
REFERENCES [dbo].[Dias] ([MaDia])
GO
ALTER TABLE [dbo].[NhatKyGhiNo] CHECK CONSTRAINT [FK_NhatKyGhiNo_Dias]
GO
ALTER TABLE [dbo].[NhatKyGhiNo]  WITH CHECK ADD  CONSTRAINT [FK_NhatKyGhiNo_KhachHangs] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KhachHangs] ([MaKhachHang])
GO
ALTER TABLE [dbo].[NhatKyGhiNo] CHECK CONSTRAINT [FK_NhatKyGhiNo_KhachHangs]
GO
ALTER TABLE [dbo].[TuaDes]  WITH CHECK ADD  CONSTRAINT [FK_TuaDes_LoaiDias] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiDias] ([MaLoai])
GO
ALTER TABLE [dbo].[TuaDes] CHECK CONSTRAINT [FK_TuaDes_LoaiDias]
GO
USE [master]
GO
ALTER DATABASE [QuanLyChoThueBangDia] SET  READ_WRITE 
GO
