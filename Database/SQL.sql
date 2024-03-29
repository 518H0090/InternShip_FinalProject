USE [master]
GO
/****** Object:  Database [ShopeeAPI]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE DATABASE [ShopeeAPI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopeeAPI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ShopeeAPI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopeeAPI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ShopeeAPI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
ALTER DATABASE [ShopeeAPI] SET AUTO_CLOSE OFF 
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
ALTER DATABASE [ShopeeAPI] SET RECOVERY FULL 
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
EXEC sys.sp_db_vardecimal_storage_format N'ShopeeAPI', N'ON'
GO
ALTER DATABASE [ShopeeAPI] SET QUERY_STORE = OFF
GO
USE [ShopeeAPI]
GO
/****** Object:  User [TrungHieu]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE USER [TrungHieu] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/13/2022 1:45:23 PM ******/
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
/****** Object:  Table [dbo].[BillOrders]    Script Date: 11/13/2022 1:45:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillOrders](
	[BillId] [uniqueidentifier] NOT NULL,
	[TotalMoney] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[UpdatedBy] [nvarchar](max) NOT NULL,
	[UpdatedOn] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[OrderCode] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BillOrders] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/13/2022 1:45:23 PM ******/
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
/****** Object:  Table [dbo].[Foods]    Script Date: 11/13/2022 1:45:23 PM ******/
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
/****** Object:  Table [dbo].[RelationCategoryFoods]    Script Date: 11/13/2022 1:45:23 PM ******/
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
/****** Object:  Table [dbo].[RestaurantOrders]    Script Date: 11/13/2022 1:45:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RestaurantOrders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[FoodImageUrl] [nvarchar](max) NOT NULL,
	[FoodTitle] [nvarchar](max) NOT NULL,
	[FoodDescription] [nvarchar](max) NOT NULL,
	[FoodPrice] [real] NOT NULL,
	[CountFoodChoice] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[UpdatedBy] [nvarchar](max) NOT NULL,
	[UpdatedOn] [datetime2](7) NOT NULL,
	[RestaurantId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_RestaurantOrders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 11/13/2022 1:45:23 PM ******/
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
	[RsDistance] [int] NOT NULL,
 CONSTRAINT [PK_Restaurants] PRIMARY KEY CLUSTERED 
(
	[RsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransferOrders]    Script Date: 11/13/2022 1:45:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransferOrders](
	[OrderId] [uniqueidentifier] NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[NumberItem] [int] NOT NULL,
	[OrderDistance] [int] NOT NULL,
	[Promotion] [int] NOT NULL,
	[TempMoney] [int] NOT NULL,
	[TotalMoney] [int] NOT NULL,
	[ORDERSTATUS] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[UpdatedBy] [nvarchar](max) NOT NULL,
	[UpdatedOn] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[BillOrderId] [uniqueidentifier] NULL,
	[OrderCode] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TransferOrders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/13/2022 1:45:23 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221109062016_InitialValue', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221109062159_UpdateOldModel', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221109062556_UpdateOldModel2', N'6.0.9')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (1, N'MENU', N'menu', 1)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (2, N'FREESHIP XTRA SIÊU ƯU ĐÃI - GIẢM 50%', N'freeship50%', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (3, N'NOWFOOD DAY', N'nowfoodday', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (4, N'NEW', N'new', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (5, N'ROYAL BLACK TIGER', N'royalblacktiger', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (6, N'ROYAL CHEESE TEA', N'royalcheesetea', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (7, N'MILK TEA', N'milktea', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (8, N'FRESH FRUIT TEA', N'freshfruittea', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (9, N'MATCHA & CHOCOLATE', N'matchachocolate', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (10, N'SMOOTHIE CHEESE', N'smoothiecheese', 2)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (11, N'BÁNH MÌ', N'banhmi', 3)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (12, N'BÚN', N'bun', 3)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (13, N'MÓN THÊM', N'monthem', 3)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (14, N'THỨC UỐNG', N'thucuong', 3)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (15, N'KHUYẾN MÃI HOT', N'khuyenmaihot', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (16, N'COMBO HOT NƯỚC NGỌT', N'combohotnuocngot', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (17, N'MÌ QUẢNG', N'miquang', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (18, N'COMBO SIÊU TIẾT KIỆM 1 NGƯỜI', N'combosieutietkiem1nguoi', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (19, N'COMBO 3 TÔ', N'combo3to', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (20, N'MÓN THÊM', N'monthem', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (21, N'NƯỚC UỐNG', N'nuocuong', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (22, N'ĐẶC SẢN MIỀN TRUNG', N'dacsanmientrung', 4)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (23, N'NOWFOOD DAY', N'nowfoodday', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (24, N'COMBO TRÀ SỮA', N'combotrasua', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (25, N'TRÀ TRÁI CÂY NHIỆT ĐỚI', N'tratraicaynhietdoi', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (26, N'SỮA TƯƠI ĐƯỜNG ĐEN', N'suatuoiduongden', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (27, N'TRÀ SỮA', N'trasua', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (28, N'LỤC TRÀ', N'luctra', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (29, N'NƯỚC ÉP TRÁI CÂY TƯƠI', N'nuoceptraicaytuoi', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (30, N'COMBO COUPLE', N'combocouple', 5)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (31, N'MÌ CỰC PHẨM', N'micucpham', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (32, N'SỦI CẢO / HOÀNH THÁNH', N'suicaohoanhthanh', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (33, N'MÌ KHÔ', N'mikho', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (34, N'MÌ NƯỚC', N'minuoc', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (35, N'HỦ TIẾU KHÔ', N'hutieukho', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (36, N'MÓN ĂN THÊM', N'monanthem', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (37, N'TRÀ THANH NHIỆT', N'trathanhnhiet', 6)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (38, N'SIÊU SALE MÙA LỄ HỘI', N'sieusalemualehoi', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (39, N'BÁNH BÒ', N'banhbo', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (40, N'BÁNH DA LỢN', N'banhdalon', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (41, N'RAU CÂU FLAN CHEESE', N'raucauflancheese', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (42, N'RAU CÂU SƠN THỦY', N'raucausonthuy', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (43, N'RAU CÂU DỪA', N'raucaudua', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (44, N'KEM', N'kem', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (45, N'COMBO', N'combo', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (46, N'YOGHURT', N'yoghurt', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (47, N'BÁNH FLAN', N'banhflan', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (48, N'CHÈ', N'che', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (49, N'CỐT DỪA', N'cotdua', 7)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (50, N'COMBO', N'combo', 8)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (51, N'MÓN CƠM', N'moncom', 8)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (52, N'MÓN SỢI', N'monsoi', 8)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (53, N'MÓN LẨU', N'monlau', 8)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [CategoryTag], [RestaurantId]) VALUES (54, N'BANH1 BISCOTTI', N'banhbiscotti', 9)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Foods] ON 

INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (1, N'./ImageForSeedData/Food/Restaurant1/food1.jpeg', N'Pate bơ béo (400gram)', N'Hộp đã được nâng cấp lên từ 300->400 gram vẫn nguyên giá cux', 85000, 0, 1)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (2, N'./ImageForSeedData/Food/Restaurant1/food2.jpeg', N'Pate sate (400gram)', N'Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên', 85000, 0, 1)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (3, N'./ImageForSeedData/Food/Restaurant1/food3.jpeg', N'Muối nguyễn thần thánh', N'1 hủ/ 150gr', 44000, 0, 1)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (4, N'./ImageForSeedData/Food/Restaurant2/food4.jpg', N'Trà sữa trân châu hoàng kim', N'', 50000, 30000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (5, N'./ImageForSeedData/Food/Restaurant2/food5.jpg', N'Trà sữa Hongkong Royal', N'', 45000, 27000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (6, N'./ImageForSeedData/Food/Restaurant2/food6.jpg', N'Trà sữa lúa mạch', N'', 45000, 27000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (7, N'./ImageForSeedData/Food/Restaurant2/food7.jpg', N'Hồng trà sữa', N'', 45000, 27000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (8, N'./ImageForSeedData/Food/Restaurant2/food7.jpg', N'Trà sữa hoa nhài', N'', 45000, 27000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (9, N'./ImageForSeedData/Food/Restaurant2/food7.jpg', N'Trà sữa olong kim phượng', N'', 45000, 27000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (10, N'./ImageForSeedData/Food/Restaurant2/food7.jpg', N'Trà sữa olong bạch đào', N'', 45000, 27000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (11, N'./ImageForSeedData/Food/Restaurant2/food11.png', N'Sữa tươi trân châu hoàng kim', N'không chọn được mức đá', 50000, 30000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (12, N'./ImageForSeedData/Food/Restaurant2/food11.png', N'Đường Đen Sầu Riêng', N'', 50000, 30000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (13, N'./ImageForSeedData/Food/Restaurant2/food13.jpg', N'Sữa tươi trân châu đường đen', N'không thể để đá riêng', 50000, 30000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (14, N'./ImageForSeedData/Food/Restaurant2/food14.jpg', N'Trà sữa trân châu đường đen', N'', 50000, 30000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (15, N'./ImageForSeedData/Food/Restaurant2/food15.jpg', N'Matcha đường đen', N'Size M', 57000, 34200, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (16, N'./ImageForSeedData/Food/Restaurant2/food16.jpg', N'Trà táo xanh kiwi', N'Thơm ngon', 65000, 39000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (17, N'./ImageForSeedData/Food/Restaurant2/food17.jpg', N'Matcha đường đen kem cheese', N'SizeM', 69000, 41400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (18, N'./ImageForSeedData/Food/Restaurant2/food11.png', N'Trà sữa khoai môn đường đen', N'', 55000, 33000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (19, N'./ImageForSeedData/Food/Restaurant2/food19.jpg', N'Trà lúa mạch kem cheese', N'', 54000, 32400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (20, N'./ImageForSeedData/Food/Restaurant2/food20.jpg', N'Hồng trà Royal kem cheese', N'', 54000, 32400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (21, N'./ImageForSeedData/Food/Restaurant2/food21.jpg', N'Trà sương mù London kem cheese', N'', 57000, 34200, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (22, N'./ImageForSeedData/Food/Restaurant2/food22.jpg', N'Trà xanh Golden kem cheese', N'', 54000, 34200, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (23, N'./ImageForSeedData/Food/Restaurant2/food23.jpg', N'Trà ô long bạch đào kem cheese', N'', 54000, 32400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (24, N'./ImageForSeedData/Food/Restaurant2/food24.jpg', N'Trà bách hoa kem cheese', N'', 54000, 32400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (25, N'./ImageForSeedData/Food/Restaurant2/food25.jpg', N'Trà ô long mộc hoa kem cheese', N'', 54000, 32400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (26, N'./ImageForSeedData/Food/Restaurant2/food25.jpg', N'Trà oolong Kim Phượng kem cheese', N'', 54000, 32400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (27, N'./ImageForSeedData/Food/Restaurant2/food27.jpg', N'Trà sữa oreo cake cream', N'', 59000, 35400, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (28, N'./ImageForSeedData/Food/Restaurant2/food28.jpg', N'Trà sữa trân châu ngọc trai trắng', N'', 55000, 33000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (29, N'./ImageForSeedData/Food/Restaurant2/food29.jpg', N'Trà sữa trân châu ngọc trai đen', N'', 55000, 33000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (30, N'./ImageForSeedData/Food/Restaurant2/food30.jpg', N'Trà hoa quả Royaltea đặc biệt', N'', 68000, 40800, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (31, N'./ImageForSeedData/Food/Restaurant2/food31.jpg', N'Trà xanh cam bưởi dâu tây', N'', 65000, 39000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (32, N'./ImageForSeedData/Food/Restaurant2/food32.jpg', N'Trà xanh cam bưởi nhiệt đới', N'', 65000, 39000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (33, N'./ImageForSeedData/Food/Restaurant2/food33.jpg', N'Socola kem cheese', N'', 58000, 34800, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (34, N'./ImageForSeedData/Food/Restaurant2/food34.jpg', N'Scola cake cream', N'', 55000, 33000, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (35, N'./ImageForSeedData/Food/Restaurant2/food35.jpg', N'Smoothie xoài kem cheese', N'', 67000, 40200, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (36, N'./ImageForSeedData/Food/Restaurant2/food36.jpg', N'Smoothie dưa hấu kem cheese', N'', 67000, 40200, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (37, N'./ImageForSeedData/Food/Restaurant2/food37.jpg', N'Smoothie ruby', N'', 67000, 40200, 2)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (38, N'./ImageForSeedData/Food/Restaurant3/food38.jpeg', N'Bánh mì thịt nướng', N'', 26000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (39, N'./ImageForSeedData/Food/Restaurant3/food39.jpeg', N'Bánh mì thịt nướng đặc biệt', N'', 32000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (40, N'./ImageForSeedData/Food/Restaurant3/food40.jpeg', N'Bún thịt nướng đặc biệt', N'', 47000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (41, N'./ImageForSeedData/Food/Restaurant3/food41.jpeg', N'Bún thịt nướng', N'', 33000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (42, N'./ImageForSeedData/Food/Restaurant3/food42.jpeg', N'Bún nem nướng', N'', 33000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (43, N'./ImageForSeedData/Food/Restaurant3/food43.jpeg', N'Bún Chả giò', N'', 30000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (44, N'./ImageForSeedData/Food/Restaurant3/food44.jpeg', N'Chả giò', N'Cái', 6000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (45, N'./ImageForSeedData/Food/Restaurant3/food45.jpeg', N'Thịt xiên', N'Xiên', 18000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (46, N'./ImageForSeedData/Food/Restaurant3/food46.jpeg', N'Thịt viên', N'Viên', 6000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (47, N'./ImageForSeedData/Food/Restaurant3/food47.jpeg', N'Nem nướng', N'', 12000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (48, N'./ImageForSeedData/Food/Restaurant3/food48.jpeg', N'Bún thêm', N'', 3000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (49, N'./ImageForSeedData/Food/Restaurant3/food49.jpeg', N'Rau thêm', N'', 3000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (50, N'./ImageForSeedData/Food/Restaurant3/food50.jpeg', N'Sâm Bí Đao Hạt Chia', N'Thành phần: bí đao, hạt chia, thục địa, la hán quả, bông cóc ... Đường phèn', 15000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (51, N'./ImageForSeedData/Food/Restaurant3/food51.jpeg', N'Sâm Bí Đao Đường Phền', N'Thành phần: BÍ ĐAOM THỤC ĐỊA, LA HÁN QUẢ, BÔNG CÚC ... ĐƯỜNG PHÈN', 12000, 0, 3)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (52, N'./ImageForSeedData/Food/Restaurant4/food52.jpeg', N'Mì Quảng thịt, trứng cút', N'Gọi 0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 55000, 49500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (53, N'./ImageForSeedData/Food/Restaurant4/food53.jpeg', N'Mì Quảng Chả Nhỏ', N'', 50000, 45000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (54, N'./ImageForSeedData/Food/Restaurant4/food54.jpeg', N'Mì Quảng Chả cua', N'Gọi 0906743795 Hỗ trợ nha', 55000, 49500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (55, N'./ImageForSeedData/Food/Restaurant4/food55.jpeg', N'Mì Quảng bắp bò + chả', N'', 60000, 54000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (56, N'./ImageForSeedData/Food/Restaurant4/food56.jpeg', N'Mì Quảng sườn non + chả', N'', 60000, 54000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (57, N'./ImageForSeedData/Food/Restaurant4/food57.jpeg', N'Chén tôm thêm', N'', 50000, 45000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (58, N'./ImageForSeedData/Food/Restaurant4/food58.jpeg', N'Mì Quảng Đặt biệt', N'0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 70000, 63000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (59, N'./ImageForSeedData/Food/Restaurant4/food59.jpeg', N'Mì Quảng gà chọi rút xương', N'0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 60000, 54000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (60, N'./ImageForSeedData/Food/Restaurant4/food60.jpeg', N'Mì Quảng tôm thịt', N'0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 55000, 49500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (61, N'./ImageForSeedData/Food/Restaurant4/food61.jpg', N'Combo 1 tô mì quảng chọn món + 1 pepsi/nước suối', N'TẶNG KÈM TƯƠNG ỚT HỘI AN SIÊU NGON', 65000, 58500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (62, N'./ImageForSeedData/Food/Restaurant4/food62.jpeg', N'Combo 3 tô mì quảng đặc biệt 3 anh em', N'0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 215000, 193500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (63, N'./ImageForSeedData/Food/Restaurant4/food63.jpeg', N'Combo 3 tô mì Quảng gà chọi rút xương', N'Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 180000, 162000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (64, N'./ImageForSeedData/Food/Restaurant4/food64.jpeg', N'Combo 3 tô mì Quảng Thit trứng cút', N'0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^', 165000, 148500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (65, N'./ImageForSeedData/Food/Restaurant4/food65.jpg', N'Bánh tráng thêm', N'', 10000, 9000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (66, N'./ImageForSeedData/Food/Restaurant4/food66.jpg', N'Rau thêm', N'', 10000, 9000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (67, N'./ImageForSeedData/Food/Restaurant4/food67.jpg', N'Pepsi', N'', 20000, 18000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (68, N'./ImageForSeedData/Food/Restaurant4/food68.jpg', N'7up', N'', 20000, 18000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (69, N'./ImageForSeedData/Food/Restaurant4/food69.jpeg', N'Bánh tráng gạo 300gram', N'', 55000, 49500, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (70, N'./ImageForSeedData/Food/Restaurant4/food70.jpeg', N'Tương ớt hội an', N'1 hủ', 90000, 81000, 4)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (71, N'./ImageForSeedData/Food/Restaurant5/food71.jpeg', N'Combo 3', N'Trà sữa, trân châu, bánh flan size L', 32000, 25600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (72, N'./ImageForSeedData/Food/Restaurant5/food72.jpeg', N'Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L', N'Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L', 24000, 19200, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (73, N'./ImageForSeedData/Food/Restaurant5/food73.jpeg', N'Dưa hấu ép', N'', 34000, 27200, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (74, N'./ImageForSeedData/Food/Restaurant5/food74.jpeg', N'Combo 4 ly Combo 5', N'4 ly Trà sữa full topping size XL', 168000, 134400, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (75, N'./ImageForSeedData/Food/Restaurant5/food75.jpeg', N'Combo 5', N'Trà sữa full topping size XL', 42000, 33600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (76, N'./ImageForSeedData/Food/Restaurant5/food76.jpeg', N'Combo 4', N'Trà sữa, thạch dẻo, thạch phô mai, bánh flan size L', 37000, 29600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (77, N'./ImageForSeedData/Food/Restaurant5/food77.jpeg', N'Combo 2', N'Trà sữa, thạch dẻo, thạch phô mai size L', 32000, 25600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (78, N'./ImageForSeedData/Food/Restaurant5/food78.jpeg', N'Trà đào cam sả', N'', 35000, 28000, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (79, N'./ImageForSeedData/Food/Restaurant5/food79.jpeg', N'Trà đào dầm', N'', 22000, 17600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (80, N'./ImageForSeedData/Food/Restaurant5/food80.jpeg', N'Lục trà bạc hà', N'', 21000, 16800, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (81, N'./ImageForSeedData/Food/Restaurant5/food81.jpeg', N'Trà Cam Nhài', N'', 34000, 27200, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (82, N'./ImageForSeedData/Food/Restaurant5/food82.jpeg', N'Sữa tươi trân châu đường đen', N'', 25000, 20000, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (83, N'./ImageForSeedData/Food/Restaurant5/food83.jpeg', N'Sữa tươi matcha trân châu đường đen', N'', 30000, 24000, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (84, N'./ImageForSeedData/Food/Restaurant5/food84.jpeg', N'Sữa tươi đường đen sương sáo', N'', 25000, 20000, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (85, N'./ImageForSeedData/Food/Restaurant5/food85.jpeg', N'Trà sữa', N'', 21000, 16800, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (86, N'./ImageForSeedData/Food/Restaurant5/food86.jpeg', N'Trà sữa socola', N'', 27000, 21600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (87, N'./ImageForSeedData/Food/Restaurant5/food87.jpeg', N'Trà sữa hoa đậu biếc', N'', 22000, 17600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (88, N'./ImageForSeedData/Food/Restaurant5/food88.jpeg', N'Thơm ép', N'', 32000, 25600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (89, N'./ImageForSeedData/Food/Restaurant5/food89.jpeg', N'Ổi ép', N'', 32000, 25600, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (90, N'./ImageForSeedData/Food/Restaurant5/food90.jpeg', N'Trà sữa + Trà sữa socola', N'', 48000, 38400, 5)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (91, N'./ImageForSeedData/Food/Restaurant6/food91.jpeg', N'Mì khô gà chiên giòn mắm tỏi', N'2 vắt mì + đùi gà góc tư mắm tỏi + cải Tặng kèm 1 ly Trà La Hán Quả', 87000, 78300, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (92, N'./ImageForSeedData/Food/Restaurant6/food92.jpeg', N'Mì khô thập cẩm Hong Kong', N'2 vắt mì + tôm + xá xíu + gà xé + 2 cá viên hấp + trứng bắc thảo + sate tôm X.O Tặng kèm 1 ly Trà La Hán Quar', 97000, 87300, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (93, N'./ImageForSeedData/Food/Restaurant6/food93.jpeg', N'Mì hoành thánh khô gà góc tư mắm giòn', N'2 vắt mì + 4 hoành thánh chiên + 1 đùi gà góc tư mắm tỏi + cải Tặng kèm 1 ly Trà La Hán Quả', 97000, 87300, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (94, N'./ImageForSeedData/Food/Restaurant6/food94.jpg', N'Hoành thánh giấm đen', N'8 viên hoành thánh luộc + Sốt giấm đen + Sate tôm X.O + cải', 69000, 62100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (95, N'./ImageForSeedData/Food/Restaurant6/food95.jpeg', N'Sủi cảo khô sốt X.O', N'6 viên sủi cảo + sốt tương sate tôm X.O + cải Tặng kèm 1 ly Trà La Hán Quả', 69000, 62100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (96, N'./ImageForSeedData/Food/Restaurant6/food96.jpeg', N'Hoành sủi khô', N'3 Sủi cảo + 5 Hoành thánh + Sốt tương sate X.O + cải Tặng kèm 1 ly Trà La Hán Quar', 69000, 62100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (97, N'./ImageForSeedData/Food/Restaurant6/food97.jpeg', N'Combo thập cẩm chiên lớn', N'6 hoành thánh chiên + 6 cá viên mắm tỏi + bắc thảo + trứng gà Tặng kèm 1 ly Trà La Hán Quả', 69000, 62100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (98, N'./ImageForSeedData/Food/Restaurant6/food98.jpeg', N'Hoành thánh nước xá xíu', N'8 viên hoành thánh nước + xá xíu + cải', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (99, N'./ImageForSeedData/Food/Restaurant6/food99.jpeg', N'Mì khô xá xíu', N'2 vắt mì + xá xíu + cải Tặng kèm 1 ly Trà La Hán Quả', 59000, 53100, 6)
GO
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (100, N'./ImageForSeedData/Food/Restaurant6/food100.jpeg', N'Mì khô cá hoành chiên mắm', N'2 vắt mì + 2 hoành thánh chiên + 6 viên cá chiên mắm + cải Tặng kèm 1 Ly Trà La Hán Quả', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (101, N'./ImageForSeedData/Food/Restaurant6/food101.jpeg', N'Mì khô hoành thánh chiên (Ko kèm chén súp)', N'2 vắt mì trộn khô + 4 viên hoành thánh chiên + Cải Tặng kèm 1 ly Trà La Hán Quả', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (102, N'./ImageForSeedData/Food/Restaurant6/food102.jpeg', N'Mì khô gà xé', N'2 vắt mì + gà luộc xé + cải Tặng kèm 1 Ly Trà La Hán Quả', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (103, N'./ImageForSeedData/Food/Restaurant6/food103.jpeg', N'Mì hoành thánh nước', N'2 vắt mì + 5 hoành thánh luộc + cải + Súp', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (104, N'./ImageForSeedData/Food/Restaurant6/food104.jpeg', N'Hủ tiếu khô xá xíu', N'Hủ tíu khô + xá xíu + cải Tặng kèm 1 ly Trà La Hán Quả', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (105, N'./ImageForSeedData/Food/Restaurant6/food105.jpeg', N'Đùi gà góc tư chiên mắm', N'Đùi gà góc tư chiên giòn sốt mắm tỏi', 59000, 53100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (106, N'./ImageForSeedData/Food/Restaurant6/food105.jpeg', N'Hoàn thánh chiên', N'4 viên', 39000, 35100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (107, N'./ImageForSeedData/Food/Restaurant6/food107.jpg', N'Hồng trà long nhãn', N'', 39000, 35100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (108, N'./ImageForSeedData/Food/Restaurant6/food105.jpeg', N'Hồng trà chanh', N'', 29000, 26100, 6)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (109, N'./ImageForSeedData/Food/Restaurant7/food109.jpeg', N'Bánh bò nướng (hộp 1 lát lớn)', N'Bánh bò nướng đường thốt nốt', 22000, 11000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (110, N'./ImageForSeedData/Food/Restaurant7/food110.jpeg', N'Rau câu sơn thủy hộp nhỏ (350g)', N'Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa', 45000, 40500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (111, N'./ImageForSeedData/Food/Restaurant7/food111.jpeg', N'Hộp 2 lát bánh bò nhỏ', N'Gồm: nước cốt dừa tươi, đường thốt nốt, trứng gà tươi, bột', 35000, 31500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (112, N'./ImageForSeedData/Food/Restaurant7/food112.jpeg', N'Bánh bò nhỏ (550g)', N'Bánh bò nướng đường thốt nốt', 110000, 99000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (113, N'./ImageForSeedData/Food/Restaurant7/food113.jpeg', N'Bánh bò lớn (900g)', N'Bánh bò nướng đường thốt nốt', 170000, 153000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (114, N'./ImageForSeedData/Food/Restaurant7/food114.jpeg', N'Hộp 4 lát bánh bò nhỏ', N'Bánh bò nướng đường thốt nốt', 60000, 54000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (115, N'./ImageForSeedData/Food/Restaurant7/food115.jpeg', N'Da lợn cuộn 2 vị hộp 6 khoanh', N'Bánh da lợn có thành phần chính từ lá cẩm khoai môn', 60000, 54000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (116, N'./ImageForSeedData/Food/Restaurant7/food116.jpeg', N'Da lợn cuộn 2 vị hộp 8 khoanh', N'Bánh da lợn có thành phần chính từ lá cẩm khoai môn', 75000, 67500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (117, N'./ImageForSeedData/Food/Restaurant7/food117.jpeg', N'Da lợn cuộn Đậu xanh lá dứa hộp 6 khoanh', N'Bánh da lợn có thành phần chính từ lá dứa, đậu xanh', 60000, 54000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (118, N'./ImageForSeedData/Food/Restaurant7/food118.jpeg', N'Flan cheese Cà phê hộp nhỏ (600g)', N'Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp', 95000, 85500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (119, N'./ImageForSeedData/Food/Restaurant7/food119.jpeg', N'Flan cheese Cà phê hộp lớn (900g)', N'Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp', 140000, 126000, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (120, N'./ImageForSeedData/Food/Restaurant7/food120.jpeg', N'Rau câu sơn thủy hộp lớn (600g)', N'Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa', 75000, 67500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (121, N'./ImageForSeedData/Food/Restaurant7/food121.jpeg', N'Rau câu dừa hộp nhỏ (600g)', N'Rau câu dẻo được làm từ nước cốt và nước dừa tươi', 85000, 76500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (122, N'./ImageForSeedData/Food/Restaurant7/food122.jpeg', N'Hộp kem Nhãn nhỏ 250g', N'', 95000, 85500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (123, N'./ImageForSeedData/Food/Restaurant7/food123.jpeg', N'Combo B: 1 Bánh bò nhỏ (550g) + Hộp kem dừa 250gr', N'Hình ảnh mang tính chất minh họa', 195000, 175500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (124, N'./ImageForSeedData/Food/Restaurant7/food124.jpeg', N'Yoghurt', N'', 22000, 19800, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (125, N'./ImageForSeedData/Food/Restaurant7/food125.jpeg', N'Bánh Flan Vị Truyền Thống', N'', 22000, 19800, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (126, N'./ImageForSeedData/Food/Restaurant7/food126.jpeg', N'Chè Bưởi (Đường Thốt Nốt) 200g☘', N'Chè bưởi kèm cốt dừa chan', 35000, 31500, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (127, N'./ImageForSeedData/Food/Restaurant7/food127.jpeg', N'Cốt dừa chén nhỏ 50ml (lạnh)', N'50ml cốt dừa (lạnh)', 6000, 5400, 7)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (128, N'./ImageForSeedData/Food/Restaurant8/food128.jpeg', N'Combo 2 Cơm thập cẩm chay', N'', 54000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (129, N'./ImageForSeedData/Food/Restaurant8/food129.jpeg', N'Cơm thập cẩm chay', N'', 29000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (130, N'./ImageForSeedData/Food/Restaurant8/food130.jpeg', N'Cơm chiên Dương Châu chay', N'', 44000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (131, N'./ImageForSeedData/Food/Restaurant8/food131.jpeg', N'Bún Huế chay', N'', 29000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (132, N'./ImageForSeedData/Food/Restaurant8/food132.jpeg', N'Hủ tiếu Sa Đéc chay', N'', 29000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (133, N'./ImageForSeedData/Food/Restaurant8/food133.jpeg', N'Lẩu Thái chay', N'', 160000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (134, N'./ImageForSeedData/Food/Restaurant8/food134.jpeg', N'Lẩu nấm chay', N'', 160000, 0, 8)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (135, N'./ImageForSeedData/Food/Restaurant9/food135.jpeg', N'Bánh Biscotti Dark Chocolate - Hộp 195gr', N'Bánh Biscotti hạnh nhân & socola nguyên chất, dành cho những người sành ăn tạo ra một sự kết hợp ngon miệng.', 99000, 0, 9)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (136, N'./ImageForSeedData/Food/Restaurant9/food136.jpeg', N'Bánh Biscotti Truyền Thống - Hộp 195gr', N'Hương vị truyền thống kết hợp hạt hạnh nhân & óc chó với một chút hương vị hạt tiểu hồi.', 99000, 0, 9)
INSERT [dbo].[Foods] ([FoodId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [FoodPriceLess], [RestaurantId]) VALUES (137, N'./ImageForSeedData/Food/Restaurant9/food137.jpeg', N'Biscotti Nam Việt Quất - Hộp 195gr', N'Nam Việt Quất kết hợp với Hạnh Nhân và được nướng hai lần mang đến cho bạn cảm giác dai giòn ngon tuyệt đỉnh.', 120000, 0, 9)
SET IDENTITY_INSERT [dbo].[Foods] OFF
GO
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (1, 1)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (1, 2)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (1, 3)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (2, 4)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (3, 5)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (3, 6)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (3, 7)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (3, 8)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (3, 9)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (3, 10)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (4, 11)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (4, 12)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (5, 13)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (5, 14)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (5, 15)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (5, 16)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (5, 17)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (5, 18)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 19)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 20)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 21)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 22)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 23)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 24)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 25)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (6, 26)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (7, 27)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (7, 28)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (7, 29)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (8, 30)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (8, 31)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (8, 32)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (9, 33)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (9, 34)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (10, 35)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (10, 36)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (10, 37)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (11, 38)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (11, 39)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (12, 40)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (12, 41)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (12, 42)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (12, 43)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (13, 44)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (13, 45)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (13, 46)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (13, 47)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (13, 48)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (13, 49)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (14, 50)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (14, 51)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (15, 52)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (16, 52)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (15, 53)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (15, 54)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (16, 55)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (17, 55)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (16, 56)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (20, 56)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (20, 57)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (17, 58)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (17, 59)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (17, 60)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (18, 61)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (18, 62)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (19, 63)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (19, 64)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (20, 65)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (21, 67)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (21, 68)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (22, 69)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (22, 70)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (23, 71)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (23, 72)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (23, 73)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (23, 74)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (24, 75)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (24, 76)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (24, 77)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (28, 77)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (25, 78)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (25, 79)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (25, 80)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (25, 81)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (26, 82)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (26, 83)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (26, 84)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (27, 85)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (28, 85)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (27, 87)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (29, 88)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (29, 89)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (30, 90)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (31, 91)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (31, 92)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (31, 93)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (32, 94)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (32, 95)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (32, 96)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (32, 97)
GO
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (32, 98)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (33, 99)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (33, 100)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (33, 101)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (33, 102)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (34, 103)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (35, 104)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (36, 105)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (36, 106)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (37, 107)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (37, 108)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (38, 109)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (38, 110)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (38, 111)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (39, 112)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (39, 113)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (39, 114)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (40, 115)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (40, 116)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (40, 117)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (41, 118)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (41, 119)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (42, 120)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (43, 121)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (44, 122)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (45, 123)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (46, 124)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (47, 125)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (48, 126)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (49, 127)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (50, 128)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (51, 129)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (51, 130)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (52, 131)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (52, 132)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (53, 133)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (53, 134)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (54, 135)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (54, 136)
INSERT [dbo].[RelationCategoryFoods] ([CategoryId], [FoodId]) VALUES (54, 137)
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (1, N'Bếp Bà Muối - Ăn Vặt Online', N'TP.HCM', N'606/52 Đường 3 Tháng 2, P. 14, Quận 10, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant1.jpg', 5, 1, N'6:00 - 22:00', N'44,000 - 85,000', 0, 0, 29)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (2, N'Royaltea Vietnam By Hongkong - Sơn Kỳ', N'TP.HCM', N'35 Sơn Kỳ, P. Sơn Kỳ, Tân Phú, TP. HCM', N'CAFE/DESSERT', N'./ImageForSeedData/Restaurant/restaurant2.jpg', 4.5, 500, N'8:15 - 22:20', N'45,000 - 60,000', 0, 50000, 7)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (3, N'Anh Thư - Bánh Mì & Bún Thịt Nướng', N'TP.HCM', N'115B Tôn Đản, P. 14, Quận 4, TP. HCM', N'ANVAT/VIAHE', N'./ImageForSeedData/Restaurant/restaurant3.jpg', 4.5, 999, N'6:00 - 20:11', N'15,000 - 30,000', 0, 0, 23)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (4, N'Mì Quảng 3 Anh Em - Phạm Hùng', N'TP.HCM', N'322 Phạm Hùng, P. 4, Quận 8, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant4.jpeg', 4.5, 100, N'7:00 - 21:30', N'30,000 - 50,000', 1, 5000, 15)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (5, N'Kim Milk Tea - Trà Sữa, Nước Ép & Ăn Vặt', N'TP.HCM', N'38 Đường Số 13, P. Bình Thọ, Thủ Đức, TP. HCM', N'CAFE/DESSERT', N'./ImageForSeedData/Restaurant/restaurant5.jpg', 4.5, 999, N'9:00 - 21:00', N'14,000 - 30,000', 0, 10000, 26)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (6, N'Min Kee - Mì Khô & Trà Hong Kong', N'TP.HCM', N'122 Nguyễn Khoái, P. 2, Quận 4, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant6.jpg', 4.5, 999, N'7:20 - 21:45', N'15,000 - 69,000', 0, 10000, 4)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (7, N'Bánh Bò Thốt Nốt COCOCake - Lò Bánh Minh Khai', N'TP.HCM', N'18A/29 Nguyễn Thị Minh Khai, P. Đa Kao, Quận 1, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant7.jpg', 4.5, 999, N'8:30 - 20:25', N'95,000 - 150,000', 1, 5000, 18)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (8, N'Việt - Cơm Chay', N'TP.HCM', N'26 Huỳnh Lan Khanh, P. 2, Tân Bình, TP. HCM', N'ANCHAY', N'./ImageForSeedData/Restaurant/restaurant8.jpg', 4.5, 999, N'7:00 - 20:45', N'20,000 - 100,000', 0, 5000, 13)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion], [RsDistance]) VALUES (9, N'Bánh Quế Hà Lan - Huỳnh Văn Bánh', N'TP.HCM', N'420/11 Huỳnh Văn Bánh, P. 14, Phú Nhuận, TP. HCM', N'TIEMBANH', N'./ImageForSeedData/Restaurant/restaurant9.jpeg', 4.5, 50, N'9:00 - 19:00', N'105,000 - 150,000', 0, 0, 29)
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (1, N'nhoxhieuro5@gmail.com', 0x9A29761B1475B4018351C7EFE00184E9CA28A22E803831EBE936EFC5331EF245A05952AF447DEAEE3B4C86D00EE5D4B290CD4FE550A314F847205BBC279DA566B9849E257DBC18399F16C0E0A5363FDEB4A4282B99103B419936202C6AEFC45BAD6828966FD63C141D4C60D27E68DEC29BD963B25D4580CE8A933A48E48ECFAD, 0x059264479D34764C533EB0AC83E6CB94184EFDAEDE68AC6DF2D39B70D6E7783FE8F04B6EA2F4810722F00E9DC16A8AF18278AB2FE8B5DCAF4C76101EB83375B8, 928399)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (2, N'chaymetwa', 0xC660C74652BF33AF8CC700F51EDB5A7512DBF9CA691F3DDFF311AD841F9442FC598A020DC6EC4CE5A0901BC82C45AD8834F4B44FFCAB01F9279FFA173FE725AC39BF14A0FBA59F396B473C21C5F98D661EA43B0BD50E5DB1DA1B683017765DBFF05BD71210F92CCA2189BF377163C0997C99FA1CFEE6BDECDA2D1B0036ABE1B8, 0x61D6DCE25972B03D9F53183A2BCF346F8C8DC2CF5B5725DF1E5CBC6AF591A34FC8D3DEF9A95AE8449F41B9C6BBFF6B2DC4740CABC992FEC3F67537582A80FB14, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (3, N'metmoichua', 0xB51D354DBF725945558B2BD6BC4B7B31AC749DBC2973EC9F7E0238A761ED4A9E76FB80C90A56BEA86EFF05EE598D028D956C6910361BAAD383824864698C3F00F0259FA6E0B76F87579C5134121C6EBC04DE8EB8128AD0323226488E11EDF2F6EC4637EA4122656D3FF727131E023B7EB33CA3A71067AB2D762ED2F510D1DA41, 0x74986AB33FBEB5772278972C0E6A9C824AABB6105B470DDBAB37F8D544480AC22FD8693F7801F3BFC5FF9CC92AA9E859D83C3AA867E36999AF7B64CA83CA9DCB, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (4, N'hoiaita', 0x22226958CF95593FDB7B1EEF2D2FE350028D4179A713249E1227D5E3B620FBCAD031ADDE518509CA4BB7FA3981CC50AFD641D1F456FDF6880249BF90C85553CECDFE3BB24F5F44E66241B61AAFD45B3631C8DE0EB2EEB913F482455513AC4104989305F53AB858EEB8CBAE6937D513516408629A222CACE7A539C5773578B8F2, 0x0C5E904643838B7756FBD71E99EA53D478208501BA573F805AF3B630E9455A6C06BA961D17E082EB038A70F3A1A07A6E4EB12FC7433EDC6DC2A84BC06DAB5E3F, 468255)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_BillOrders_UserId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_BillOrders_UserId] ON [dbo].[BillOrders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Categories_CategoryTag_RestaurantId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Categories_CategoryTag_RestaurantId] ON [dbo].[Categories]
(
	[CategoryTag] ASC,
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categories_RestaurantId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_Categories_RestaurantId] ON [dbo].[Categories]
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Foods_FoodTitle_RestaurantId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Foods_FoodTitle_RestaurantId] ON [dbo].[Foods]
(
	[FoodTitle] ASC,
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Foods_RestaurantId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_Foods_RestaurantId] ON [dbo].[Foods]
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RelationCategoryFoods_FoodId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_RelationCategoryFoods_FoodId] ON [dbo].[RelationCategoryFoods]
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RestaurantOrders_RestaurantId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_RestaurantOrders_RestaurantId] ON [dbo].[RestaurantOrders]
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RestaurantOrders_UserId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_RestaurantOrders_UserId] ON [dbo].[RestaurantOrders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Restaurants_RsTitle]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Restaurants_RsTitle] ON [dbo].[Restaurants]
(
	[RsTitle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TransferOrders_BillOrderId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_TransferOrders_BillOrderId] ON [dbo].[TransferOrders]
(
	[BillOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TransferOrders_UserId]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE NONCLUSTERED INDEX [IX_TransferOrders_UserId] ON [dbo].[TransferOrders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_UserName]    Script Date: 11/13/2022 1:45:23 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_UserName] ON [dbo].[Users]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillOrders] ADD  DEFAULT ((0)) FOR [TotalMoney]
GO
ALTER TABLE [dbo].[BillOrders] ADD  DEFAULT (N'') FOR [OrderCode]
GO
ALTER TABLE [dbo].[Foods] ADD  DEFAULT ((0)) FOR [FoodPrice]
GO
ALTER TABLE [dbo].[Foods] ADD  DEFAULT (CONVERT([real],(0))) FOR [FoodPriceLess]
GO
ALTER TABLE [dbo].[RestaurantOrders] ADD  DEFAULT ((1)) FOR [CountFoodChoice]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT (CONVERT([real],(1))) FOR [RsStar]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT ((0)) FOR [RsReviews]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT (CONVERT([bit],(0))) FOR [RsRefeLike]
GO
ALTER TABLE [dbo].[Restaurants] ADD  DEFAULT ((0)) FOR [RsDistance]
GO
ALTER TABLE [dbo].[TransferOrders] ADD  DEFAULT ((0)) FOR [NumberItem]
GO
ALTER TABLE [dbo].[TransferOrders] ADD  DEFAULT ((0)) FOR [OrderDistance]
GO
ALTER TABLE [dbo].[TransferOrders] ADD  DEFAULT ((0)) FOR [TempMoney]
GO
ALTER TABLE [dbo].[TransferOrders] ADD  DEFAULT ((0)) FOR [TotalMoney]
GO
ALTER TABLE [dbo].[TransferOrders] ADD  DEFAULT (N'') FOR [OrderCode]
GO
ALTER TABLE [dbo].[BillOrders]  WITH CHECK ADD  CONSTRAINT [FK_BillOrders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillOrders] CHECK CONSTRAINT [FK_BillOrders_Users_UserId]
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
ALTER TABLE [dbo].[RestaurantOrders]  WITH CHECK ADD  CONSTRAINT [FK_RestaurantOrders_Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([RsId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RestaurantOrders] CHECK CONSTRAINT [FK_RestaurantOrders_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[RestaurantOrders]  WITH CHECK ADD  CONSTRAINT [FK_RestaurantOrders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RestaurantOrders] CHECK CONSTRAINT [FK_RestaurantOrders_Users_UserId]
GO
ALTER TABLE [dbo].[TransferOrders]  WITH CHECK ADD  CONSTRAINT [FK_TransferOrders_BillOrders_BillOrderId] FOREIGN KEY([BillOrderId])
REFERENCES [dbo].[BillOrders] ([BillId])
GO
ALTER TABLE [dbo].[TransferOrders] CHECK CONSTRAINT [FK_TransferOrders_BillOrders_BillOrderId]
GO
ALTER TABLE [dbo].[TransferOrders]  WITH CHECK ADD  CONSTRAINT [FK_TransferOrders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TransferOrders] CHECK CONSTRAINT [FK_TransferOrders_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [ShopeeAPI] SET  READ_WRITE 
GO
