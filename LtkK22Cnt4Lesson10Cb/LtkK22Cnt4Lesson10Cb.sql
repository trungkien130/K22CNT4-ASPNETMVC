USE [LtkK22Cnt4Lesson10Cb]
GO
/****** Object:  Table [dbo].[LtkAccount]    Script Date: 03/07/2024 2:08:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LtkAccount](
	[LtkID] [int] NOT NULL,
	[LtkUserName] [nvarchar](50) NULL,
	[LtkPassword] [nvarchar](50) NULL,
	[LtkFullName] [nvarchar](50) NULL,
	[LtkEmail] [nvarchar](50) NULL,
	[LtkPhone] [nvarchar](50) NULL,
	[LtkActive] [bit] NULL,
 CONSTRAINT [PK_LtkAccount] PRIMARY KEY CLUSTERED 
(
	[LtkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LtkAccount] ([LtkID], [LtkUserName], [LtkPassword], [LtkFullName], [LtkEmail], [LtkPhone], [LtkActive]) VALUES (1, N'TrungKien', N'123456', N'Lê Trung Kiên', N'kienlee14@gmail.com', N'0913088169', 1)
GO
