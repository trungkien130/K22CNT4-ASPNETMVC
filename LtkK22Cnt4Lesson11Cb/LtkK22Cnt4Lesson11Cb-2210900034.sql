USE [LtkK22Cnt4Lesson11Cb]
GO
/****** Object:  Table [dbo].[LtkCatagory]    Script Date: 04/07/2024 10:11:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LtkCatagory](
	[LtkID] [int] IDENTITY(1,1) NOT NULL,
	[LtkCateName] [nvarchar](50) NULL,
	[LtkStatus] [bit] NULL,
 CONSTRAINT [PK_LtkCatagory] PRIMARY KEY CLUSTERED 
(
	[LtkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LtkProduct]    Script Date: 04/07/2024 10:11:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LtkProduct](
	[LtkID2210900034] [nvarchar](50) NOT NULL,
	[LtkProName] [nvarchar](50) NULL,
	[LtkQty] [int] NULL,
	[LtkPrice] [float] NULL,
	[LtkCateId] [int] NULL,
	[LtkActive] [bit] NULL,
 CONSTRAINT [PK_LtkProduct] PRIMARY KEY CLUSTERED 
(
	[LtkID2210900034] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LtkCatagory] ON 

INSERT [dbo].[LtkCatagory] ([LtkID], [LtkCateName], [LtkStatus]) VALUES (1, N'2210900034', 1)
INSERT [dbo].[LtkCatagory] ([LtkID], [LtkCateName], [LtkStatus]) VALUES (2, N'iphone', 0)
SET IDENTITY_INSERT [dbo].[LtkCatagory] OFF
GO
INSERT [dbo].[LtkProduct] ([LtkID2210900034], [LtkProName], [LtkQty], [LtkPrice], [LtkCateId], [LtkActive]) VALUES (N'2210900034', N'Lê Trung Kiên', 10, 1000, 1, 1)
INSERT [dbo].[LtkProduct] ([LtkID2210900034], [LtkProName], [LtkQty], [LtkPrice], [LtkCateId], [LtkActive]) VALUES (N'P001', N'Iphone 15pro ', 1, 2000, 1, 1)
GO
