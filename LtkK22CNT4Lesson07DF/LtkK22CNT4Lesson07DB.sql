USE [LtkK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[LtkKhoa]    Script Date: 12/06/2024 2:38:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LtkKhoa](
	[LtkMaKH] [nchar](10) NULL,
	[LtkTenKh] [nvarchar](50) NULL,
	[LtkTrangThai] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LtkSinhVien]    Script Date: 12/06/2024 2:38:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LtkSinhVien](
	[LtkMaSV] [nchar](10) NULL,
	[LtkHoSV] [nvarchar](50) NULL,
	[LtkTenSV] [nvarchar](50) NOT NULL,
	[LtkPhai] [bit] NULL,
	[LtkEmail] [nvarchar](50) NULL,
	[LtkPhone] [nvarchar](50) NULL,
	[LtkMaKH] [nchar](10) NULL,
	[LtkTrangThai] [bit] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[LtkKhoa] ([LtkMaKH], [LtkTenKh], [LtkTrangThai]) VALUES (N'CNT       ', N'Công Nghệ thông tin', 1)
INSERT [dbo].[LtkKhoa] ([LtkMaKH], [LtkTenKh], [LtkTrangThai]) VALUES (N'NNN       ', N'Ngôn Ngữ Nhật', 0)
GO
INSERT [dbo].[LtkSinhVien] ([LtkMaSV], [LtkHoSV], [LtkTenSV], [LtkPhai], [LtkEmail], [LtkPhone], [LtkMaKH], [LtkTrangThai]) VALUES (N'221090034 ', N'Lê Trung', N'Kiên', 1, N'kienlee14@gmail.com', N'0913088169', N'CNT       ', 1)
GO
