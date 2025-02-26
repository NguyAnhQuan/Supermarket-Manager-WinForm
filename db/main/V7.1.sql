USE [master]
GO
/****** Object:  Database [QuanLySieuThi]    Script Date: 26/07/2024 10:32:27 CH ******/
CREATE DATABASE [QuanLySieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySieuThi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ANHQUANHAV\MSSQL\DATA\QuanLySieuThi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySieuThi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ANHQUANHAV\MSSQL\DATA\QuanLySieuThi_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLySieuThi] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLySieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySieuThi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLySieuThi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySieuThi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLySieuThi', N'ON'
GO
ALTER DATABASE [QuanLySieuThi] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLySieuThi] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLySieuThi]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Mdn] [nvarchar](255) NOT NULL,
	[Mnv] [nvarchar](255) NOT NULL,
	[GioVao] [datetime] NOT NULL,
	[GioRa] [datetime] NOT NULL,
	[MatKhau] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Mhd] [nvarchar](255) NOT NULL,
	[NgayXuat] [datetime] NOT NULL,
	[Msp] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[Mkh] [nvarchar](255) NOT NULL,
	[Mnv] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mhd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Mkh] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[Sdt] [nvarchar](255) NOT NULL,
	[HangKhach] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mkh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoNX]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoNX](
	[Mnx] [nvarchar](255) NOT NULL,
	[Msp] [nvarchar](255) NOT NULL,
	[Mncc] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongGia] [float] NOT NULL,
	[ThoiGian] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mnx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganSach]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganSach](
	[Mns] [nvarchar](255) NOT NULL,
	[Ten] [nvarchar](255) NOT NULL,
	[Tien] [float] NOT NULL,
	[Mhd] [nvarchar](255) NULL,
	[Msp] [nvarchar](255) NULL,
	[TienNS] [float] NOT NULL,
	[Mnx] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Mns] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[Mncc] [nvarchar](255) NOT NULL,
	[Ten] [nvarchar](255) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[Sdt] [nvarchar](255) NOT NULL,
	[HopTac] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Mnv] [nvarchar](255) NOT NULL,
	[Sdt] [nvarchar](255) NOT NULL,
	[SinhNhat] [date] NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](255) NOT NULL,
	[ChucVu] [nvarchar](255) NOT NULL,
	[Luong] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mnv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[Msp] [nvarchar](255) NOT NULL,
	[Mncc] [nvarchar](255) NOT NULL,
	[TenSp] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [float] NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[HetHan] [date] NOT NULL,
	[HetHang] [bit] NOT NULL,
	[PhanLoai] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Msp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UuDai]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UuDai](
	[Mud] [nvarchar](255) NOT NULL,
	[Mkh] [nvarchar](255) NOT NULL,
	[Ten] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'admin', N'Admin', CAST(N'2024-06-20T00:00:00.000' AS DateTime), CAST(N'1900-01-01T23:59:59.000' AS DateTime), N'admin')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN001', N'NV001', CAST(N'1900-01-01T08:00:00.000' AS DateTime), CAST(N'1900-01-01T17:00:00.000' AS DateTime), N'Nv1')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN002', N'NV002', CAST(N'1900-01-01T08:30:00.000' AS DateTime), CAST(N'1900-01-01T18:00:00.000' AS DateTime), N'Nv2')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN003', N'NV003', CAST(N'1900-01-01T09:00:00.000' AS DateTime), CAST(N'1900-01-01T18:30:00.000' AS DateTime), N'abc')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN004', N'NV004', CAST(N'1900-01-01T09:30:00.000' AS DateTime), CAST(N'1900-01-01T19:00:00.000' AS DateTime), N'xyz')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN005', N'NV005', CAST(N'1900-01-01T10:00:00.000' AS DateTime), CAST(N'1900-01-01T19:30:00.000' AS DateTime), N'123@')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN006', N'NV006', CAST(N'1900-01-01T08:00:00.000' AS DateTime), CAST(N'1900-01-01T17:00:00.000' AS DateTime), N'NvKho')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN007', N'NV007', CAST(N'1900-01-01T08:00:00.000' AS DateTime), CAST(N'1900-01-01T17:00:00.000' AS DateTime), N'NvQuay')
INSERT [dbo].[DangNhap] ([Mdn], [Mnv], [GioVao], [GioRa], [MatKhau]) VALUES (N'DN008', N'NV005', CAST(N'2020-06-20T10:00:00.000' AS DateTime), CAST(N'2024-06-20T19:30:00.000' AS DateTime), N'123@')
GO
INSERT [dbo].[HoaDon] ([Mhd], [NgayXuat], [Msp], [SoLuong], [DonGia], [ThanhTien], [Mkh], [Mnv]) VALUES (N'HD001', CAST(N'2024-05-31T08:00:00.000' AS DateTime), N'SP001', 2, 50000, 100000, N'KH001', N'NV001')
INSERT [dbo].[HoaDon] ([Mhd], [NgayXuat], [Msp], [SoLuong], [DonGia], [ThanhTien], [Mkh], [Mnv]) VALUES (N'HD002', CAST(N'2024-05-31T08:30:00.000' AS DateTime), N'SP002', 3, 75000, 225000, N'KH002', N'NV002')
INSERT [dbo].[HoaDon] ([Mhd], [NgayXuat], [Msp], [SoLuong], [DonGia], [ThanhTien], [Mkh], [Mnv]) VALUES (N'HD003', CAST(N'2024-05-31T09:00:00.000' AS DateTime), N'SP003', 4, 100000, 400000, N'KH003', N'NV003')
INSERT [dbo].[HoaDon] ([Mhd], [NgayXuat], [Msp], [SoLuong], [DonGia], [ThanhTien], [Mkh], [Mnv]) VALUES (N'HD005', CAST(N'2024-05-31T10:00:00.000' AS DateTime), N'SP005', 5, 90000, 450000, N'KH005', N'NV005')
INSERT [dbo].[HoaDon] ([Mhd], [NgayXuat], [Msp], [SoLuong], [DonGia], [ThanhTien], [Mkh], [Mnv]) VALUES (N'HD7', CAST(N'2024-06-20T20:54:08.103' AS DateTime), N'SP005', 2, 180000, 180000, N'KH001', N'NV004')
GO
INSERT [dbo].[KhachHang] ([Mkh], [HoTen], [DiaChi], [Sdt], [HangKhach]) VALUES (N'KH001', N'Nguyễn Văn A', N'10 Đường PQR, Qu?n Long Biên, TP.Hà N?i', N'909876541', 0)
INSERT [dbo].[KhachHang] ([Mkh], [HoTen], [DiaChi], [Sdt], [HangKhach]) VALUES (N'KH002', N'Tr?n Th? B', N'20 Đư?ng STU, Qu?n C?u Gi?y, TP.Hà N?i', N'0909876542', 0)
INSERT [dbo].[KhachHang] ([Mkh], [HoTen], [DiaChi], [Sdt], [HangKhach]) VALUES (N'KH003', N'Lê Văn C', N'30 Đư?ng WXY, Qu?n Nam T? liêm, TP.Hà N?i', N'0909876543', 0)
INSERT [dbo].[KhachHang] ([Mkh], [HoTen], [DiaChi], [Sdt], [HangKhach]) VALUES (N'KH005', N'Hoàng Văn E', N'50 Đư?ng JKL, Qu?n C?u Gi?y, TP.Hà N?i', N'0909876545', 0)
INSERT [dbo].[KhachHang] ([Mkh], [HoTen], [DiaChi], [Sdt], [HangKhach]) VALUES (N'KH006', N'Nguyễn Văn C', N'10 Đư?ng PQR, Qu?n Long Biên, TP.Hà N?i', N'909876541', 0)
GO
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'24CA3F25-D676-4EF6-9EC8-6E299CAB34F0', N'SP0011', N'NCC001', 20, 200000, CAST(N'2023-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'9D3B78A0-4D8D-4B02-B82A-2ED3788B1527', N'SP0010', N'NCC001', 20, 200000, CAST(N'2023-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'A64FAA1F-057B-49AB-A413-3D8A06830923', N'SP0010', N'NCC001', 20, 200000, CAST(N'2023-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'E1E72D15-4888-47E8-912D-9861A098F453', N'SP0011', N'NCC001', 20, 200000, CAST(N'2023-05-08T00:00:00.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN001', N'SP004', N'NCC004', 120, 9600000, CAST(N'2024-06-13T10:56:15.100' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN002', N'SP004', N'NCC004', 120, 9600000, CAST(N'2024-06-13T10:56:15.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN006', N'SP003', N'NCC003', 200, 20000000, CAST(N'2024-06-12T20:07:13.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN008', N'SP002', N'NCC004', 120, 9600000, CAST(N'2024-06-19T00:55:28.000' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN009', N'SP002', N'NCC004', 120, 9600000, CAST(N'2024-06-19T01:20:34.367' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN3', N'SP0011', N'NCC001', 10, 1000, CAST(N'2024-06-20T21:29:41.877' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KN4', N'SP0011', N'NCC001', 10, 1000, CAST(N'2024-07-14T10:35:27.437' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KX001', N'SP001', N'NCC001', 100, 5000000, NULL)
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KX002', N'SP002', N'NCC002', 150, 11250000, NULL)
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KX003', N'SP001', N'NCC001', 100, 5000000, CAST(N'2024-06-12T20:09:43.737' AS DateTime))
INSERT [dbo].[KhoNX] ([Mnx], [Msp], [Mncc], [SoLuong], [TongGia], [ThoiGian]) VALUES (N'KX005', N'SP005', N'NCC005', 180, 16200000, NULL)
GO
INSERT [dbo].[NganSach] ([Mns], [Ten], [Tien], [Mhd], [Msp], [TienNS], [Mnx]) VALUES (N'NS001', N'Bán', 100000000, NULL, NULL, 50000000, N'KX001')
INSERT [dbo].[NganSach] ([Mns], [Ten], [Tien], [Mhd], [Msp], [TienNS], [Mnx]) VALUES (N'NS002', N'Bán', 150000000, NULL, NULL, 75000000, N'KX002')
INSERT [dbo].[NganSach] ([Mns], [Ten], [Tien], [Mhd], [Msp], [TienNS], [Mnx]) VALUES (N'NS005', N'Bán', 180000000, NULL, NULL, 90000000, N'KX005')
GO
INSERT [dbo].[NhaCungCap] ([Mncc], [Ten], [DiaChi], [Sdt], [HopTac]) VALUES (N'NCC001', N'Công ty TNHH A', N'123 Đư?ng ABC, Qu?n C?u Gi?y, TP.Hà N?i', N'0901234561', 1)
INSERT [dbo].[NhaCungCap] ([Mncc], [Ten], [DiaChi], [Sdt], [HopTac]) VALUES (N'NCC002', N'Công ty TNHH B', N'456 Đư?ng XYZ, Qu?n Nam T? liêm, TP.Hà N?i', N'0901234562', 1)
INSERT [dbo].[NhaCungCap] ([Mncc], [Ten], [DiaChi], [Sdt], [HopTac]) VALUES (N'NCC003', N'Công ty TNHH C', N'789 Đư?ng LMN, Qu?n C?u Gi?y, TP.Hà N?i', N'0901234563', 1)
INSERT [dbo].[NhaCungCap] ([Mncc], [Ten], [DiaChi], [Sdt], [HopTac]) VALUES (N'NCC004', N'Công ty TNHH D', N'321 Đư?ng DEF, Qu?n B?c T? liêm, TP.Hà N?i', N'0901234564', 1)
INSERT [dbo].[NhaCungCap] ([Mncc], [Ten], [DiaChi], [Sdt], [HopTac]) VALUES (N'NCC005', N'Công ty TNHH E', N'654 Đư?ng UVW, Qu?n Thanh Xuân, TP.Hà N?i', N'0901234565', 1)
GO
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'Admin', N'0987254324', CAST(N'2024-06-19' AS Date), N'3 Đường EXY, Quận Tây Hồ, TP.Hà Nội', N'Nguyễn Anh QUân', N'Nam', N'Admin Quản lý', 20000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV001', N'0987654321', CAST(N'1990-01-01' AS Date), N'5 Đư?ng MNZ, Qu?n C?u Gi?y, TP.Hà N?i', N'Nguyễn Thị A', N'Nữ', N'KhachHang Nhân viên bán hàng', 8000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV002', N'0987654322', CAST(N'1995-05-05' AS Date), N'15 Đư?ng OPQ, Qu?n C?u Gi?y, TP.Hà N?i', N'Tr?n Văn B', N'Nam', N'Kho NvQl Kho', 9000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV003', N'0987654323', CAST(N'1988-12-10' AS Date), N'25 Đư?ng RST, Qu?n B?c T? Liêm, TP.Hà N?i', N'Lê Th? C', N'N?', N'NhaCungCap Ql nhà cung cấp', 12000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV004', N'0987654324', CAST(N'1986-07-20' AS Date), N'35 Đư?ng WXY, Qu?n Tây H?, TP.Hà N?i', N'Ph?m Văn D', N'Nam', N'NhanVien Ql nhân viên', 8000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV005', N'0987654325', CAST(N'1993-03-15' AS Date), N'45 Đư?ng UVW, Qu?n Long Biên, TP.Hà N?i', N'Hoàng Th? E', N'Nữ', N'SanPham QL sản phẩm', 10000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV006', N'0987645211', CAST(N'1999-12-20' AS Date), N'237 Đường Yên Phụ, TP.Hà Nội', N'Trần Thị Yến', N'Nữ', N'ThuNgan Thu ngân sảnh', 5000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV007', N'0521928763', CAST(N'1999-12-20' AS Date), N'762 Quan Hoa, Quận Cầu Giấy, TP.Hà Nội', N'Nguyễn Ngọc Linh', N'Nữ', N'KeToan Thống kê', 4000000)
INSERT [dbo].[NhanVien] ([Mnv], [Sdt], [SinhNhat], [DiaChi], [HoTen], [GioiTinh], [ChucVu], [Luong]) VALUES (N'NV008', N'0987654323', CAST(N'1988-12-10' AS Date), N'25 Đư?ng RST, Qu?n B?c T? Liêm, TP.Hà N?i', N'Lê Th? C', N'N?', N'NhaCungCap Ql nhà cung cấp', 12000000)
GO
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP001', N'NCC001', N'Sữa óc chó', 100, 50000, CAST(N'2024-05-01' AS Date), CAST(N'2025-05-01' AS Date), 0, N'Sữa')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP0010', N'NCC004', N'Nư?c m?m ông tây', 120, 80000, CAST(N'2024-05-04' AS Date), CAST(N'2025-05-04' AS Date), 0, N'Gia V?')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP0011', N'NCC001', N'Sua bo', 50, 10000, CAST(N'2023-05-08' AS Date), CAST(N'2024-05-06' AS Date), 0, N'Sữa')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP0012', N'NCC002', N'Omo matic', 155, 75000, CAST(N'2024-05-02' AS Date), CAST(N'2025-05-02' AS Date), 0, N'Nư?c Gi?t')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP002', N'NCC002', N'Omo matic', 150, 75000, CAST(N'2024-05-02' AS Date), CAST(N'2025-05-02' AS Date), 0, N'Nư?c Gi?t')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP003', N'NCC003', N'333', 394, 100000, CAST(N'2024-05-03' AS Date), CAST(N'2025-05-03' AS Date), 0, N'Bia')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP004', N'NCC004', N'Nưoc m?m ông tây', 120, 80000, CAST(N'2024-05-04' AS Date), CAST(N'2025-05-04' AS Date), 0, N'Gia V?')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP005', N'NCC005', N'Habeco', 178, 90000, CAST(N'2024-05-05' AS Date), CAST(N'2025-05-05' AS Date), 0, N'Bia')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP006', N'NCC001', N'Sua bo', 20, 10000, CAST(N'2023-05-08' AS Date), CAST(N'2024-05-06' AS Date), 0, N'Sữa')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP008', N'NCC001', N'Sua bo', 20, 10000, CAST(N'2023-05-08' AS Date), CAST(N'2024-05-06' AS Date), 0, N'Sữa')
INSERT [dbo].[SanPham] ([Msp], [Mncc], [TenSp], [SoLuong], [Gia], [NgayNhap], [HetHan], [HetHang], [PhanLoai]) VALUES (N'SP009', N'NCC004', N'Nư?c m?m ông tây', 120, 80000, CAST(N'2024-05-04' AS Date), CAST(N'2025-05-04' AS Date), 0, N'Gia V?')
GO
INSERT [dbo].[UuDai] ([Mud], [Mkh], [Ten]) VALUES (N'UD001', N'KH001', N'5%')
INSERT [dbo].[UuDai] ([Mud], [Mkh], [Ten]) VALUES (N'UD002', N'KH002', N'10%')
INSERT [dbo].[UuDai] ([Mud], [Mkh], [Ten]) VALUES (N'UD003', N'KH003', N'Ch? nh?t gi?m 20%')
INSERT [dbo].[UuDai] ([Mud], [Mkh], [Ten]) VALUES (N'UD005', N'KH005', N'Habeco gi?m 08%')
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ((0)) FOR [HangKhach]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT ((1)) FOR [HopTac]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ('Nam') FOR [GioiTinh]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((7000000)) FOR [Luong]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [HetHang]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_DangNhap_NhanVien] FOREIGN KEY([Mnv])
REFERENCES [dbo].[NhanVien] ([Mnv])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_DangNhap_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([Mkh])
REFERENCES [dbo].[KhachHang] ([Mkh])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([Mnv])
REFERENCES [dbo].[NhanVien] ([Mnv])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_SanPham] FOREIGN KEY([Msp])
REFERENCES [dbo].[SanPham] ([Msp])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_SanPham]
GO
ALTER TABLE [dbo].[KhoNX]  WITH CHECK ADD  CONSTRAINT [FK_KhoNX_NhaCungCap] FOREIGN KEY([Mncc])
REFERENCES [dbo].[NhaCungCap] ([Mncc])
GO
ALTER TABLE [dbo].[KhoNX] CHECK CONSTRAINT [FK_KhoNX_NhaCungCap]
GO
ALTER TABLE [dbo].[KhoNX]  WITH CHECK ADD  CONSTRAINT [FK_KhoNX_SanPham] FOREIGN KEY([Msp])
REFERENCES [dbo].[SanPham] ([Msp])
GO
ALTER TABLE [dbo].[KhoNX] CHECK CONSTRAINT [FK_KhoNX_SanPham]
GO
ALTER TABLE [dbo].[NganSach]  WITH CHECK ADD  CONSTRAINT [FK_NganSach_HoaDon] FOREIGN KEY([Mhd])
REFERENCES [dbo].[HoaDon] ([Mhd])
GO
ALTER TABLE [dbo].[NganSach] CHECK CONSTRAINT [FK_NganSach_HoaDon]
GO
ALTER TABLE [dbo].[NganSach]  WITH CHECK ADD  CONSTRAINT [FK_NganSach_KhoNX] FOREIGN KEY([Mnx])
REFERENCES [dbo].[KhoNX] ([Mnx])
GO
ALTER TABLE [dbo].[NganSach] CHECK CONSTRAINT [FK_NganSach_KhoNX]
GO
ALTER TABLE [dbo].[NganSach]  WITH CHECK ADD  CONSTRAINT [FK_NganSach_SanPham] FOREIGN KEY([Msp])
REFERENCES [dbo].[SanPham] ([Msp])
GO
ALTER TABLE [dbo].[NganSach] CHECK CONSTRAINT [FK_NganSach_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaCungCap] FOREIGN KEY([Mncc])
REFERENCES [dbo].[NhaCungCap] ([Mncc])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[UuDai]  WITH CHECK ADD  CONSTRAINT [FK_UuDai_KhachHang] FOREIGN KEY([Mkh])
REFERENCES [dbo].[KhachHang] ([Mkh])
GO
ALTER TABLE [dbo].[UuDai] CHECK CONSTRAINT [FK_UuDai_KhachHang]
GO
/****** Object:  StoredProcedure [dbo].[GetSanPham]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSanPham]
AS
BEGIN
    SELECT *
    FROM QuanLySieuThi.dbo.SanPham;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_JoinNhaCungCapSanPham]    Script Date: 26/07/2024 10:32:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_JoinNhaCungCapSanPham]
AS
BEGIN
    SELECT *
    FROM NhaCungCap NCC
    JOIN SanPham SP
    ON NCC.Mncc = SP.Mncc;
END;
GO
USE [master]
GO
ALTER DATABASE [QuanLySieuThi] SET  READ_WRITE 
GO
