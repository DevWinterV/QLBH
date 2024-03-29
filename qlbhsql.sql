USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 11/26/2023 10:18:00 AM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DONGCHAU\MSSQL\DATA\QLBH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DONGCHAU\MSSQL\DATA\QLBH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH', N'ON'
GO
ALTER DATABASE [QLBH] SET QUERY_STORE = OFF
GO
USE [QLBH]
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MADV_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MADV_TU_TANG] 
 AS [bigint]
 START WITH 100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MAHD_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MAHD_TU_TANG] 
 AS [bigint]
 START WITH 100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MAKH_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MAKH_TU_TANG] 
 AS [bigint]
 START WITH 100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MALSP_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MALSP_TU_TANG] 
 AS [bigint]
 START WITH 10000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MANCC_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MANCC_TU_TANG] 
 AS [bigint]
 START WITH 100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MANV_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MANV_TU_TANG] 
 AS [bigint]
 START WITH 100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MAPHIEUNO_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MAPHIEUNO_TU_TANG] 
 AS [bigint]
 START WITH 10000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MAPN_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MAPN_TU_TANG] 
 AS [bigint]
 START WITH 1000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [QLBH]
GO
/****** Object:  Sequence [dbo].[MASP_TU_TANG]    Script Date: 11/26/2023 10:18:01 AM ******/
CREATE SEQUENCE [dbo].[MASP_TU_TANG] 
 AS [bigint]
 START WITH 10000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[ADMINN]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINN](
	[username] [varchar](25) NOT NULL,
	[pass] [varchar](25) NULL,
	[phanquyen] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETHD]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHD](
	[maHD] [varchar](8) NOT NULL,
	[masp] [varchar](7) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DVT]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVT](
	[maDVT] [varchar](5) NOT NULL,
	[tenDVT] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[ngayGD] [smalldatetime] NULL,
	[maHD] [varchar](8) NOT NULL,
	[maKH] [varchar](5) NULL,
	[manv] [varchar](5) NULL,
	[thanhtien] [money] NULL,
	[chietkhau] [float] NULL,
	[trangthai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[maKH] [varchar](5) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[dchi] [nvarchar](100) NULL,
	[sodt] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISPDGD]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISPDGD](
	[maloai] [nvarchar](8) NOT NULL,
	[tenloai] [nvarchar](100) NOT NULL,
	[tinhtrang] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[mancc] [nvarchar](5) NOT NULL,
	[tenncc] [nvarchar](100) NULL,
	[sdt] [varchar](10) NULL,
	[diachi] [nvarchar](100) NULL,
	[tinhtrang] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[manv] [varchar](5) NULL,
	[username] [varchar](25) NOT NULL,
	[pass] [varchar](25) NULL,
	[MA_QUYEN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[manv] [varchar](5) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[sodt] [varchar](20) NULL,
	[ngaysinh] [smalldatetime] NULL,
	[Dchi] [nvarchar](100) NULL,
	[Gioitinh] [nvarchar](3) NULL,
	[tinhtrang] [nvarchar](10) NULL,
	[luong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPKHO]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPKHO](
	[sophieuN] [varchar](8) NOT NULL,
	[mancc] [nvarchar](5) NULL,
	[ngaynhap] [smalldatetime] NULL,
	[manv] [varchar](5) NULL,
	[tongcong] [money] NULL,
	[ghichu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[sophieuN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAPKHO_CT]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPKHO_CT](
	[sophieuN] [varchar](8) NOT NULL,
	[masp] [varchar](7) NOT NULL,
	[SoluongNhap] [float] NULL,
	[Dgianhap] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[sophieuN] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNO]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNO](
	[ngayNO] [smalldatetime] NULL,
	[maPN] [varchar](8) NOT NULL,
	[maHD] [varchar](8) NULL,
	[ghichu] [nvarchar](50) NULL,
	[tienno] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[maPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNO_CT]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNO_CT](
	[stt] [int] IDENTITY(1,1) NOT NULL,
	[maPN] [varchar](8) NOT NULL,
	[TIENTRA] [money] NULL,
	[ngayTRA] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[maPN] ASC,
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[MA_QUYEN] [int] IDENTITY(1,1) NOT NULL,
	[TENQUYEN] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MA_QUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAMDGD]    Script Date: 11/26/2023 10:18:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAMDGD](
	[maloai] [nvarchar](8) NULL,
	[masp] [varchar](7) NOT NULL,
	[tensp] [nvarchar](100) NULL,
	[dongia] [money] NULL,
	[SLuong] [float] NULL,
	[mancc] [nvarchar](5) NULL,
	[tinhtrang] [nvarchar](25) NULL,
	[ngay_update] [smalldatetime] NULL,
	[dongianhap] [money] NULL,
	[maDVT] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ADMINN] ([username], [pass], [phanquyen]) VALUES (N'admin', N'123', N'ADMIN')
GO
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD100', N'SP10000', 7, 525000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD101', N'SP10000', 5, 375000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD102', N'SP10000', 10, 750000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD150', N'SP10000', 10, 750000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD150', N'SP10050', 10, 3000000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD251', N'SP10000', 2, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD251', N'SP10050', 1, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD252', N'SP10000', 3, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD252', N'SP10050', 2, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD253', N'SP10000', 1, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD253', N'SP10050', 1, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD254', N'SP10000', 2, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD255', N'SP10000', 2, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD255', N'SP10050', 2, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD256', N'SP10050', 1, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD257', N'SP10000', 2, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD257', N'SP10050', 1, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD258', N'SP10000', 2, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD258', N'SP10050', 1, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD259', N'SP10000', 3, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD259', N'SP10050', 2, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD260', N'SP10000', 2, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD309', N'SP10000', 5, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD309', N'SP10050', 5, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD310', N'SP10000', 5, 75000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD310', N'SP10050', 12, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD359', N'SP10000', 5, 700000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD359', N'SP10050', 2, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD409', N'SP10050', 4, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD459', N'SP10000', 2, 700000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD459', N'SP10050', 2, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD509', N'SP10000', 5, 700000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD559', N'SP10100', 2, 1700000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD560', N'SP10000', 2, 700000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD609', N'SP10050', 4, 300000.0000)
INSERT [dbo].[CHITIETHD] ([maHD], [masp], [soluong], [dongia]) VALUES (N'HD609', N'SP10100', 6, 1700000.0000)
GO
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV100', N'MÉT')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV101', N'CÁI')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV102', N'CHAI')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV103', N'KHỔ')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV104', N'GÓI')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV105', N'THÙNG')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV106', N'LÓC')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV107', N'HỘP')
INSERT [dbo].[DVT] ([maDVT], [tenDVT]) VALUES (N'DV108', N'KG')
GO
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-03-19T12:39:00' AS SmallDateTime), N'HD100', N'KH100', N'ADMIN', 525000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-03-19T12:40:00' AS SmallDateTime), N'HD101', N'KH100', N'ADMIN', 375000.0000, 0, N'ĐÃ THANH TOÁN ĐỦ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-03-21T09:00:00' AS SmallDateTime), N'HD102', N'KH100', N'ADMIN', 750000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-03-25T11:36:00' AS SmallDateTime), N'HD150', N'KH101', N'ADMIN', 3750000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-02T23:36:00' AS SmallDateTime), N'HD251', N'KH100', N'ADMIN', 450000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-07T16:32:00' AS SmallDateTime), N'HD252', N'KH100', N'ADMIN', 825000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-07T16:36:00' AS SmallDateTime), N'HD253', N'KH101', N'ADMIN', 375000.0000, 0, N'ĐÃ THANH TOÁN ĐỦ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-10T12:06:00' AS SmallDateTime), N'HD254', N'KH100', N'ADMIN', 150000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-10T12:47:00' AS SmallDateTime), N'HD255', N'KH100', N'ADMIN', 750000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-10T12:48:00' AS SmallDateTime), N'HD256', N'KH100', N'ADMIN', 300000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-10T12:51:00' AS SmallDateTime), N'HD257', N'KH100', N'ADMIN', 450000.0000, 0, N'ĐÃ THANH TOÁN ĐỦ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-10T13:10:00' AS SmallDateTime), N'HD258', N'KH101', N'ADMIN', 450000.0000, 0, N'đã thanh toán đủ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-20T07:35:00' AS SmallDateTime), N'HD259', N'KH100', N'ADMIN', 825000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-20T07:41:00' AS SmallDateTime), N'HD260', N'KH100', N'ADMIN', 150000.0000, 0, N'đã thanh toán đủ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-23T23:28:00' AS SmallDateTime), N'HD309', N'KH100', N'ADMIN', 1875000.0000, 0, N'ĐÃ THANH TOÁN ĐỦ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-24T01:26:00' AS SmallDateTime), N'HD310', N'KH100', N'ADMIN', 3975000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-04-30T22:11:00' AS SmallDateTime), N'HD359', N'KH100', N'ADMIN', 4100000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-05-11T23:56:00' AS SmallDateTime), N'HD409', N'KH101', N'ADMIN', 1200000.0000, 0, N'Đã thanh toán đủ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-10-06T13:28:00' AS SmallDateTime), N'HD459', N'KH100', N'ADMIN', 2000000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-11-01T21:55:00' AS SmallDateTime), N'HD509', N'KH100', N'ADMIN', 3500000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-11-07T23:24:00' AS SmallDateTime), N'HD559', N'KH100', N'ADMIN', 3400000.0000, 0, N'ĐÃ THANH TOÁN')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-11-07T23:26:00' AS SmallDateTime), N'HD560', N'KH100', N'ADMIN', 1400000.0000, 0, N'thanh toán đủ')
INSERT [dbo].[HOADON] ([ngayGD], [maHD], [maKH], [manv], [thanhtien], [chietkhau], [trangthai]) VALUES (CAST(N'2023-11-26T09:47:00' AS SmallDateTime), N'HD609', N'KH100', N'ADMIN', 11400000.0000, 0, N'ĐÃ THANH TOÁN')
GO
INSERT [dbo].[KHACHHANG] ([maKH], [hoten], [dchi], [sodt]) VALUES (N'KH100', N'Rạng Đông', N'Long Xuyên', N'0766837068')
INSERT [dbo].[KHACHHANG] ([maKH], [hoten], [dchi], [sodt]) VALUES (N'KH101', N'Anh Việt', N'Chợ Mới', N'0123584575')
INSERT [dbo].[KHACHHANG] ([maKH], [hoten], [dchi], [sodt]) VALUES (N'KH150', N'Thúy Vy', N'Phú Tân, An Giang', N'0366901380')
GO
INSERT [dbo].[LOAISPDGD] ([maloai], [tenloai], [tinhtrang]) VALUES (N'LSP10000', N'ỐNG NHỰA', N'CÒN BÁN')
INSERT [dbo].[LOAISPDGD] ([maloai], [tenloai], [tinhtrang]) VALUES (N'LSP10050', N'GAS', N'CÒN BÁN')
INSERT [dbo].[LOAISPDGD] ([maloai], [tenloai], [tinhtrang]) VALUES (N'LSP10100', N'BÌNH GIỮ NHIỆT', N'CÒN BÁN')
GO
INSERT [dbo].[NCC] ([mancc], [tenncc], [sdt], [diachi], [tinhtrang]) VALUES (N'CC100', N'HỒNG HUÂN', N'0366907380', N'LONG XUYÊN', N'1')
INSERT [dbo].[NCC] ([mancc], [tenncc], [sdt], [diachi], [tinhtrang]) VALUES (N'CC150', N'ABC', N'0326858752', N'CHỢ MỚI', N'1')
GO
INSERT [dbo].[NGUOIDUNG] ([manv], [username], [pass], [MA_QUYEN]) VALUES (N'NV100', N'NV100', N'nv100', 3)
INSERT [dbo].[NGUOIDUNG] ([manv], [username], [pass], [MA_QUYEN]) VALUES (N'NV150', N'NV150', N'NV150', 1)
GO
INSERT [dbo].[NHANVIEN] ([manv], [hoten], [sodt], [ngaysinh], [Dchi], [Gioitinh], [tinhtrang], [luong]) VALUES (N'ADMIN', N'ADMIN', N'', CAST(N'1900-01-01T00:00:00' AS SmallDateTime), N'', N'', N'', 0)
INSERT [dbo].[NHANVIEN] ([manv], [hoten], [sodt], [ngaysinh], [Dchi], [Gioitinh], [tinhtrang], [luong]) VALUES (N'NV100', N'Châu Văn Rạng Đông', N'0766837068', CAST(N'2002-03-09T00:00:00' AS SmallDateTime), N'Long Xuyên', N'Nam', N'CÒN LÀM', 5000000)
INSERT [dbo].[NHANVIEN] ([manv], [hoten], [sodt], [ngaysinh], [Dchi], [Gioitinh], [tinhtrang], [luong]) VALUES (N'NV150', N'Đặng Thị Thúy Vy', N'0366901380', CAST(N'2002-04-05T00:00:00' AS SmallDateTime), N'Phú Tân', N'Nữ', N'NGHỈ LÀM', 15000000)
GO
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1000', N'CC100', CAST(N'2023-03-19T12:36:00' AS SmallDateTime), N'ADMIN', 5000000.0000, N'nHẬP HÀNG
')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1050', N'CC150', CAST(N'2023-03-25T11:14:00' AS SmallDateTime), N'ADMIN', 25000000.0000, N'')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1051', N'CC150', CAST(N'2023-03-25T11:14:00' AS SmallDateTime), N'ADMIN', 2500000.0000, N'')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1100', N'CC150', CAST(N'2023-04-07T15:12:00' AS SmallDateTime), N'NV100', 1250000.0000, N'nhập hàng tháng 4')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1101', N'CC100', CAST(N'2023-04-10T12:06:00' AS SmallDateTime), N'ADMIN', 500000.0000, N'NHẬP HÀNG')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1102', N'CC150', CAST(N'2023-05-11T23:50:00' AS SmallDateTime), N'ADMIN', 250000.0000, N'NHẬP HÀNG THÁNG 5/ 2023 NHÀ CUNG CẤP ABC')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1152', N'CC100', CAST(N'2023-09-02T18:54:00' AS SmallDateTime), N'ADMIN', 9500000.0000, N'')
INSERT [dbo].[NHAPKHO] ([sophieuN], [mancc], [ngaynhap], [manv], [tongcong], [ghichu]) VALUES (N'PN1202', N'CC150', CAST(N'2023-11-01T21:49:00' AS SmallDateTime), N'ADMIN', 1800000.0000, N'NHẬP HÀNG THÁNG 1 NĂM 2023')
GO
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1000', N'SP10000', 100, 50000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1050', N'SP10050', 100, 250000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1051', N'SP10050', 10, 250000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1100', N'SP10050', 5, 250000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1101', N'SP10000', 10, 50000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1102', N'SP10050', 1, 250000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1152', N'SP10000', 19, 500000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1202', N'SP10050', 2, 250000.0000)
INSERT [dbo].[NHAPKHO_CT] ([sophieuN], [masp], [SoluongNhap], [Dgianhap]) VALUES (N'PN1202', N'SP10100', 10, 130000.0000)
GO
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-03-19T12:40:00' AS SmallDateTime), N'PNO10000', N'HD101', N'ĐÃ THANH TOÁN ĐỦ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-04-07T16:36:00' AS SmallDateTime), N'PNO10050', N'HD253', N'ĐÃ THANH TOÁN ĐỦ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-04-10T12:47:00' AS SmallDateTime), N'PNO10051', N'HD255', N'ĐÃ THANH TOÁN', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-04-10T12:51:00' AS SmallDateTime), N'PNO10052', N'HD257', N'ĐÃ THANH TOÁN ĐỦ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-04-10T13:10:00' AS SmallDateTime), N'PNO10053', N'HD258', N'đã thanh toán đủ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-04-20T07:41:00' AS SmallDateTime), N'PNO10054', N'HD260', N'đã thanh toán đủ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-04-23T23:28:00' AS SmallDateTime), N'PNO10104', N'HD309', N'ĐÃ THANH TOÁN ĐỦ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-05-11T23:56:00' AS SmallDateTime), N'PNO10154', N'HD409', N'Đã thanh toán đủ', 0.0000)
INSERT [dbo].[PHIEUNO] ([ngayNO], [maPN], [maHD], [ghichu], [tienno]) VALUES (CAST(N'2023-11-07T23:26:00' AS SmallDateTime), N'PNO10204', N'HD560', N'thanh toán đủ', 0.0000)
GO
SET IDENTITY_INSERT [dbo].[PHIEUNO_CT] ON 

INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (1, N'PNO10000', 0.0000, CAST(N'2023-03-19T12:40:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (2, N'PNO10000', 375000.0000, CAST(N'2023-04-02T23:38:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (3, N'PNO10050', 100000.0000, CAST(N'2023-04-07T16:36:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (4, N'PNO10050', 275000.0000, CAST(N'2023-04-10T12:20:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (5, N'PNO10051', 150000.0000, CAST(N'2023-04-10T12:47:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (6, N'PNO10051', 600000.0000, CAST(N'2023-04-10T12:50:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (7, N'PNO10052', 0.0000, CAST(N'2023-04-10T12:51:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (9, N'PNO10052', 450000.0000, CAST(N'2023-04-10T13:12:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (8, N'PNO10053', 0.0000, CAST(N'2023-04-10T13:10:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (10, N'PNO10053', 300000.0000, CAST(N'2023-04-10T13:12:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (1013, N'PNO10053', 150000.0000, CAST(N'2023-04-24T13:04:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (11, N'PNO10054', 100000.0000, CAST(N'2023-04-20T07:41:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (12, N'PNO10054', 50000.0000, CAST(N'2023-04-20T10:27:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (1011, N'PNO10104', 1700000.0000, CAST(N'2023-04-23T23:28:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (1012, N'PNO10104', 175000.0000, CAST(N'2023-04-24T13:03:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (2011, N'PNO10154', 500000.0000, CAST(N'2023-05-11T23:56:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (2012, N'PNO10154', 600000.0000, CAST(N'2023-05-11T23:57:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (3011, N'PNO10154', 100000.0000, CAST(N'2023-09-02T18:53:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (4011, N'PNO10204', 0.0000, CAST(N'2023-11-07T23:26:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (4012, N'PNO10204', 1300000.0000, CAST(N'2023-11-07T23:27:00' AS SmallDateTime))
INSERT [dbo].[PHIEUNO_CT] ([stt], [maPN], [TIENTRA], [ngayTRA]) VALUES (4013, N'PNO10204', 100000.0000, CAST(N'2023-11-07T23:27:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[PHIEUNO_CT] OFF
GO
SET IDENTITY_INSERT [dbo].[QUYEN] ON 

INSERT [dbo].[QUYEN] ([MA_QUYEN], [TENQUYEN]) VALUES (1, N'Nhân Viên Bán Hàng')
INSERT [dbo].[QUYEN] ([MA_QUYEN], [TENQUYEN]) VALUES (2, N'Nhân Viên Quản Lý')
INSERT [dbo].[QUYEN] ([MA_QUYEN], [TENQUYEN]) VALUES (3, N'Nhân Viên Nhập Kho')
INSERT [dbo].[QUYEN] ([MA_QUYEN], [TENQUYEN]) VALUES (1002, N'Admin')
SET IDENTITY_INSERT [dbo].[QUYEN] OFF
GO
INSERT [dbo].[SANPHAMDGD] ([maloai], [masp], [tensp], [dongia], [SLuong], [mancc], [tinhtrang], [ngay_update], [dongianhap], [maDVT]) VALUES (N'LSP10000', N'SP10000', N'ỐNG NHỰA HỒNG HUÂN 15M', 700000.0000, 44, N'CC100', N'CÒN BÁN', CAST(N'2023-09-02T18:54:00' AS SmallDateTime), 500000.0000, N'DV100')
INSERT [dbo].[SANPHAMDGD] ([maloai], [masp], [tensp], [dongia], [SLuong], [mancc], [tinhtrang], [ngay_update], [dongianhap], [maDVT]) VALUES (N'LSP10050', N'SP10050', N'GAS MINI 10KG', 300000.0000, 60, N'CC150', N'CÒN BÁN', CAST(N'2023-11-01T21:52:00' AS SmallDateTime), 250000.0000, N'DV108')
INSERT [dbo].[SANPHAMDGD] ([maloai], [masp], [tensp], [dongia], [SLuong], [mancc], [tinhtrang], [ngay_update], [dongianhap], [maDVT]) VALUES (N'LSP10100', N'SP10100', N'BÌNH GIỮ NHIỆT ABC', 1700000.0000, 2, N'CC150', N'CÒN BÁN', CAST(N'2023-11-01T21:56:00' AS SmallDateTime), 1300000.0000, N'DV101')
GO
ALTER TABLE [dbo].[ADMINN] ADD  DEFAULT ('ADMIN') FOR [phanquyen]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [maHD_Chitiet_HD] FOREIGN KEY([maHD])
REFERENCES [dbo].[HOADON] ([maHD])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [maHD_Chitiet_HD]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [masp_Chitiet_SP] FOREIGN KEY([masp])
REFERENCES [dbo].[SANPHAMDGD] ([masp])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [masp_Chitiet_SP]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [makh_HD_KH] FOREIGN KEY([maKH])
REFERENCES [dbo].[KHACHHANG] ([maKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [makh_HD_KH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [manv_HD_NV] FOREIGN KEY([manv])
REFERENCES [dbo].[NHANVIEN] ([manv])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [manv_HD_NV]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [manv_User_NV] FOREIGN KEY([manv])
REFERENCES [dbo].[NHANVIEN] ([manv])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [manv_User_NV]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [maQUYEN_User_NV] FOREIGN KEY([MA_QUYEN])
REFERENCES [dbo].[QUYEN] ([MA_QUYEN])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [maQUYEN_User_NV]
GO
ALTER TABLE [dbo].[NHAPKHO]  WITH CHECK ADD  CONSTRAINT [phieunhap_NCC] FOREIGN KEY([mancc])
REFERENCES [dbo].[NCC] ([mancc])
GO
ALTER TABLE [dbo].[NHAPKHO] CHECK CONSTRAINT [phieunhap_NCC]
GO
ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [Chitiet_nhapkho] FOREIGN KEY([sophieuN])
REFERENCES [dbo].[NHAPKHO] ([sophieuN])
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [Chitiet_nhapkho]
GO
ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [sp_nhapkho_CT] FOREIGN KEY([masp])
REFERENCES [dbo].[SANPHAMDGD] ([masp])
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [sp_nhapkho_CT]
GO
ALTER TABLE [dbo].[PHIEUNO]  WITH CHECK ADD  CONSTRAINT [maHD_PN_HD] FOREIGN KEY([maHD])
REFERENCES [dbo].[HOADON] ([maHD])
GO
ALTER TABLE [dbo].[PHIEUNO] CHECK CONSTRAINT [maHD_PN_HD]
GO
ALTER TABLE [dbo].[PHIEUNO_CT]  WITH CHECK ADD  CONSTRAINT [maHD_PN_CT_HD] FOREIGN KEY([maPN])
REFERENCES [dbo].[PHIEUNO] ([maPN])
GO
ALTER TABLE [dbo].[PHIEUNO_CT] CHECK CONSTRAINT [maHD_PN_CT_HD]
GO
ALTER TABLE [dbo].[SANPHAMDGD]  WITH CHECK ADD  CONSTRAINT [donvitinh_Sp] FOREIGN KEY([maDVT])
REFERENCES [dbo].[DVT] ([maDVT])
GO
ALTER TABLE [dbo].[SANPHAMDGD] CHECK CONSTRAINT [donvitinh_Sp]
GO
ALTER TABLE [dbo].[SANPHAMDGD]  WITH CHECK ADD  CONSTRAINT [loaihang_Sp] FOREIGN KEY([maloai])
REFERENCES [dbo].[LOAISPDGD] ([maloai])
GO
ALTER TABLE [dbo].[SANPHAMDGD] CHECK CONSTRAINT [loaihang_Sp]
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
