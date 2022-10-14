USE [ShopeeAPI]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/14/2022 5:26:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/14/2022 5:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](200) NOT NULL,
	[CategoryTag] [nvarchar](50) NOT NULL,
	[RestaurantId] [int] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foods]    Script Date: 10/14/2022 5:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[FoodId] [int] IDENTITY(1,1) NOT NULL,
	[FoodImageUrl] [nvarchar](500) NOT NULL,
	[FoodTitle] [nvarchar](500) NOT NULL,
	[FoodDescription] [nvarchar](max) NOT NULL,
	[FoodPrice] [int] NOT NULL,
	[FoodPriceLess] [real] NOT NULL,
	[RestaurantId] [int] NOT NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationCategoryFoods]    Script Date: 10/14/2022 5:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationCategoryFoods](
	[CategoryId] [int] NOT NULL,
	[FoodId] [int] NOT NULL,
 CONSTRAINT [PK_RelationCategoryFoods] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC,
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 10/14/2022 5:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurants](
	[RsId] [int] IDENTITY(1,1) NOT NULL,
	[RsTitle] [nvarchar](100) NOT NULL,
	[RsProvince] [nvarchar](200) NOT NULL,
	[RsAddress] [nvarchar](200) NOT NULL,
	[RsType] [nvarchar](30) NOT NULL,
	[RsImageUrl] [nvarchar](600) NOT NULL,
	[RsStar] [real] NOT NULL,
	[RsReviews] [int] NOT NULL,
	[RsOpenTime] [nvarchar](100) NOT NULL,
	[RsPrinceRange] [nvarchar](800) NOT NULL,
	[RsRefeLike] [bit] NOT NULL,
	[RsPromotion] [int] NOT NULL,
 CONSTRAINT [PK_Restaurants] PRIMARY KEY CLUSTERED 
(
	[RsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/14/2022 5:26:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[PasswordHash] [varbinary](max) NOT NULL,
	[Role] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Foods] ADD  DEFAULT ((0)) FOR [FoodPrice]
GO
ALTER TABLE [dbo].[Foods] ADD  DEFAULT (CONVERT([real],(0))) FOR [FoodPriceLess]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT (CONVERT([real],(1))) FOR [RsStar]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT ((0)) FOR [RsReviews]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT (CONVERT([bit],(0))) FOR [RsRefeLike]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([RsId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[Foods]  WITH CHECK ADD  CONSTRAINT [FK_Foods_Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([RsId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Foods] CHECK CONSTRAINT [FK_Foods_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[RelationCategoryFoods]  WITH CHECK ADD  CONSTRAINT [FK_RelationCategoryFoods_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[RelationCategoryFoods] CHECK CONSTRAINT [FK_RelationCategoryFoods_Categories_CategoryId]
GO
ALTER TABLE [dbo].[RelationCategoryFoods]  WITH CHECK ADD  CONSTRAINT [FK_RelationCategoryFoods_Foods_FoodId] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Foods] ([FoodId])
GO
ALTER TABLE [dbo].[RelationCategoryFoods] CHECK CONSTRAINT [FK_RelationCategoryFoods_Foods_FoodId]
GO
