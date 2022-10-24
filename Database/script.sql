USE [master]
GO
/****** Object:  Database [ShopeeAPI]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE DATABASE [ShopeeAPI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopeeAPI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ShopeeAPI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopeeAPI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ShopeeAPI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ShopeeAPI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopeeAPI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopeeAPI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopeeAPI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopeeAPI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopeeAPI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopeeAPI] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopeeAPI] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShopeeAPI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopeeAPI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopeeAPI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopeeAPI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopeeAPI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopeeAPI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopeeAPI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopeeAPI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopeeAPI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ShopeeAPI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopeeAPI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopeeAPI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopeeAPI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopeeAPI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopeeAPI] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ShopeeAPI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopeeAPI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopeeAPI] SET  MULTI_USER 
GO
ALTER DATABASE [ShopeeAPI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopeeAPI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopeeAPI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopeeAPI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopeeAPI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShopeeAPI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ShopeeAPI] SET QUERY_STORE = OFF
GO
USE [ShopeeAPI]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/24/2022 2:20:33 PM ******/
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
/****** Object:  Table [dbo].[Bills]    Script Date: 10/24/2022 2:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[BillId] [uniqueidentifier] NOT NULL,
	[totalPayment] [real] NOT NULL,
	[UseName] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/24/2022 2:20:33 PM ******/
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
/****** Object:  Table [dbo].[Foods]    Script Date: 10/24/2022 2:20:33 PM ******/
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
/****** Object:  Table [dbo].[RelationCategoryFoods]    Script Date: 10/24/2022 2:20:33 PM ******/
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
/****** Object:  Table [dbo].[Restaurants]    Script Date: 10/24/2022 2:20:33 PM ******/
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
/****** Object:  Table [dbo].[SelectFoodRecords]    Script Date: 10/24/2022 2:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SelectFoodRecords](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[FoodImageUrl] [nvarchar](max) NOT NULL,
	[FoodTitle] [nvarchar](max) NOT NULL,
	[FoodDescription] [nvarchar](max) NOT NULL,
	[FoodPrice] [real] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_SelectFoodRecords] PRIMARY KEY CLUSTERED 
(
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/24/2022 2:20:33 PM ******/
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
/****** Object:  Index [IX_Bills_BillId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Bills_BillId] ON [dbo].[Bills]
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bills_UserId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Bills_UserId] ON [dbo].[Bills]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Categories_CategoryTag_RestaurantId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Categories_CategoryTag_RestaurantId] ON [dbo].[Categories]
(
	[CategoryTag] ASC,
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categories_RestaurantId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Categories_RestaurantId] ON [dbo].[Categories]
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Foods_FoodTitle_RestaurantId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Foods_FoodTitle_RestaurantId] ON [dbo].[Foods]
(
	[FoodTitle] ASC,
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Foods_RestaurantId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Foods_RestaurantId] ON [dbo].[Foods]
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RelationCategoryFoods_FoodId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_RelationCategoryFoods_FoodId] ON [dbo].[RelationCategoryFoods]
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Restaurants_RsTitle]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Restaurants_RsTitle] ON [dbo].[Restaurants]
(
	[RsTitle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SelectFoodRecords_UserId]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_SelectFoodRecords_UserId] ON [dbo].[SelectFoodRecords]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_UserName]    Script Date: 10/24/2022 2:20:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_UserName] ON [dbo].[Users]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bills] ADD  DEFAULT (CONVERT([real],(0))) FOR [totalPayment]
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
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Users_UserId]
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
ALTER TABLE [dbo].[SelectFoodRecords]  WITH CHECK ADD  CONSTRAINT [FK_SelectFoodRecords_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SelectFoodRecords] CHECK CONSTRAINT [FK_SelectFoodRecords_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [ShopeeAPI] SET  READ_WRITE 
GO
