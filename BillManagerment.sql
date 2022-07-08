CREATE DATABASE BillManagerment
GO

USE [BillManagerment]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/8/2022 9:32:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
	[QuocTich] [nvarchar](50) NULL,
	[DinhMuc] [int] NULL,
	[LoaiKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [DonGia], [SoLuong], [ThanhTien], [QuocTich], [DinhMuc], [LoaiKH], [DiaChi]) VALUES (1, N'Dona Nguyen', 2000, 120, 240000, N'Viet Nam', 125, N'Sinh hoạt', N'Tam Ky, Quang Nam')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [DonGia], [SoLuong], [ThanhTien], [QuocTich], [DinhMuc], [LoaiKH], [DiaChi]) VALUES (2, N'Duy Nguyen', 2200, 1200, 3630000, N'Viet Nam', 900, N'Sản xuất', N'SaiGon')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [DonGia], [SoLuong], [ThanhTien], [QuocTich], [DinhMuc], [LoaiKH], [DiaChi]) VALUES (14, N'Tommy Le', 2000, 120, 240000, N'USA', NULL, NULL, N'Florida')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [DonGia], [SoLuong], [ThanhTien], [QuocTich], [DinhMuc], [LoaiKH], [DiaChi]) VALUES (3, N'MT-P Ent', 2000, 3000, 11400000, N'Viet Nam', 1200, N'Sản xuất', N'Q1, SaiGon')
GO
