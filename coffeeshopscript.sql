USE [coffeeshop]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 9/28/2019 11:00:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Address] [varchar](30) NULL,
	[Contact] [varchar](11) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 9/28/2019 11:00:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [varchar](30) NULL,
	[FoodPrice] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 9/28/2019 11:00:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [varchar](30) NULL,
	[FoodPrice] [varchar](30) NULL,
	[Quantity] [varchar](3) NULL,
	[TotalBill] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Name], [Address], [Contact]) VALUES (4, N'sohel', N'khilkhet', N'0112jhk')
INSERT [dbo].[Customers] ([ID], [Name], [Address], [Contact]) VALUES (3, N'shishir', N'tongi', N'01123')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [FoodName], [FoodPrice]) VALUES (1, N'cold', N'150')
INSERT [dbo].[Items] ([ID], [FoodName], [FoodPrice]) VALUES (2, N'hot', N'200')
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [FoodName], [FoodPrice], [Quantity], [TotalBill]) VALUES (1, N'hot', N'200', N'3', 600)
INSERT [dbo].[Orders] ([ID], [FoodName], [FoodPrice], [Quantity], [TotalBill]) VALUES (2, N'cold', N'150', N'2', 300)
SET IDENTITY_INSERT [dbo].[Orders] OFF
