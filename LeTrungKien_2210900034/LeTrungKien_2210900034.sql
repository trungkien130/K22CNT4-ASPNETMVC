USE [LeTrungKien_2210900034]
GO
/****** Object:  Table [dbo].[Ltk_Sach]    Script Date: 12/07/2024 9:58:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ltk_Sach](
	[Ltk_MaSach] [char](10) NOT NULL,
	[Ltk_TenSach] [nvarchar](50) NULL,
	[Ltk_SoTrang] [int] NULL,
	[Ltk_NamXB] [int] NULL,
	[Ltk_MaTG] [nvarchar](50) NULL,
	[Ltk_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Ltk_Sach] PRIMARY KEY CLUSTERED 
(
	[Ltk_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ltk_TacGia]    Script Date: 12/07/2024 9:58:17 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ltk_TacGia](
	[Ltk_MaTG] [nvarchar](50) NOT NULL,
	[Ltk_TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ltk_TacGia] PRIMARY KEY CLUSTERED 
(
	[Ltk_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ltk_Sach]  WITH CHECK ADD  CONSTRAINT [FK_Ltk_Sach_Ltk_TacGia] FOREIGN KEY([Ltk_MaTG])
REFERENCES [dbo].[Ltk_TacGia] ([Ltk_MaTG])
GO
ALTER TABLE [dbo].[Ltk_Sach] CHECK CONSTRAINT [FK_Ltk_Sach_Ltk_TacGia]
GO
