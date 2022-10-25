USE [ShopeeAPI]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[Bills]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[Categories]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[Foods]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[RelationCategoryFoods]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[Restaurants]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[SelectFoodRecords]    Script Date: 10/25/2022 5:08:46 PM ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 10/25/2022 5:08:46 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221007072750_InitialValue', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221007073357_AddCategoryFood', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221007084207_AddConstraintForFood', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221008075833_updateNewConstraint', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221010082117_RemoveConstraintPromotion', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221010083045_InitialSeeDData', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221011070434_seedDataForCategory', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221011080054_AddSeedFood12', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221011090237_AddSeedFood34', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221011093518_SeedFood5', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012025934_seedfoodres6', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012032001_seedfoodres7', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012032621_seedfoodres7update', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012033214_seedfoodres8', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012033637_seedfoodres9', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012033952_seedfoodres9update', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221012070958_AddRElationCategoryFood', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221014030522_UpdateImage', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221018081138_AddFoodRecord', N'6.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221020065529_AddBillTable', N'6.0.9')
GO
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'ec189436-0b67-4afd-b32a-02a099596957', 0, N'string', 5)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'7d194f31-e857-4cd3-8b7e-04339c3d25b8', 134400, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'd3c55586-c75f-42b1-b1ed-2f6b8952c660', 50000, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'a87c00ff-0e48-4733-891d-300f70b48cd1', 7484880, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'7d79eb8d-5a9a-43a4-bb14-5d2e05faa6bf', 2220, N'metmoichua', 3)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'4d9ee680-eb3e-4c08-a79d-77854663eec0', 200000, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'311e9ef9-56bb-42c2-b05a-9385fae5245e', 47000, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'42a896c5-9af8-4c53-9b11-ae04e414331a', 2220, N'hoiaita', 4)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'd9b3c973-5953-4eec-a34a-c3b1547bc13d', 775400, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'ac493463-27d0-45e4-92ba-f69c9dc17c0d', 85000, N'nhoxhieuro5@gmail.com', 1)
INSERT [dbo].[Bills] ([BillId], [totalPayment], [UseName], [UserId]) VALUES (N'5ca4e251-6f84-40cf-a91e-f94625fe9db6', 90000, N'nhoxhieuro5@gmail.com', 1)
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

INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (1, N'Bếp Bà Muối - Ăn Vặt Online', N'TP.HCM', N'606/52 Đường 3 Tháng 2, P. 14, Quận 10, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant1.jpg', 5, 1, N'6:00 - 22:00', N'44,000 - 85,000', 0, 0)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (2, N'Royaltea Vietnam By Hongkong - Sơn Kỳ', N'TP.HCM', N'35 Sơn Kỳ, P. Sơn Kỳ, Tân Phú, TP. HCM', N'CAFE/DESSERT', N'./ImageForSeedData/Restaurant/restaurant2.jpg', 4.5, 500, N'8:15 - 22:20', N'45,000 - 60,000', 0, 50000)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (3, N'Anh Thư - Bánh Mì & Bún Thịt Nướng', N'TP.HCM', N'115B Tôn Đản, P. 14, Quận 4, TP. HCM', N'ANVAT/VIAHE', N'./ImageForSeedData/Restaurant/restaurant3.jpg', 4.5, 999, N'6:00 - 20:11', N'15,000 - 30,000', 0, 0)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (4, N'Mì Quảng 3 Anh Em - Phạm Hùng', N'TP.HCM', N'322 Phạm Hùng, P. 4, Quận 8, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant4.jpeg', 4.5, 100, N'7:00 - 21:30', N'30,000 - 50,000', 1, 5000)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (5, N'Kim Milk Tea - Trà Sữa, Nước Ép & Ăn Vặt', N'TP.HCM', N'38 Đường Số 13, P. Bình Thọ, Thủ Đức, TP. HCM', N'CAFE/DESSERT', N'./ImageForSeedData/Restaurant/restaurant5.jpg', 4.5, 999, N'9:00 - 21:00', N'14,000 - 30,000', 0, 10000)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (6, N'Min Kee - Mì Khô & Trà Hong Kong', N'TP.HCM', N'122 Nguyễn Khoái, P. 2, Quận 4, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant6.jpg', 4.5, 999, N'7:20 - 21:45', N'15,000 - 69,000', 0, 10000)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (7, N'Bánh Bò Thốt Nốt COCOCake - Lò Bánh Minh Khai', N'TP.HCM', N'18A/29 Nguyễn Thị Minh Khai, P. Đa Kao, Quận 1, TP. HCM', N'QUANAN', N'./ImageForSeedData/Restaurant/restaurant7.jpg', 4.5, 999, N'8:30 - 20:25', N'95,000 - 150,000', 1, 5000)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (8, N'Việt - Cơm Chay', N'TP.HCM', N'26 Huỳnh Lan Khanh, P. 2, Tân Bình, TP. HCM', N'ANCHAY', N'./ImageForSeedData/Restaurant/restaurant8.jpg', 4.5, 999, N'7:00 - 20:45', N'20,000 - 100,000', 0, 5000)
INSERT [dbo].[Restaurants] ([RsId], [RsTitle], [RsProvince], [RsAddress], [RsType], [RsImageUrl], [RsStar], [RsReviews], [RsOpenTime], [RsPrinceRange], [RsRefeLike], [RsPromotion]) VALUES (9, N'Bánh Quế Hà Lan - Huỳnh Văn Bánh', N'TP.HCM', N'420/11 Huỳnh Văn Bánh, P. 14, Phú Nhuận, TP. HCM', N'TIEMBANH', N'./ImageForSeedData/Restaurant/restaurant9.jpeg', 4.5, 50, N'9:00 - 19:00', N'105,000 - 150,000', 0, 0)
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[SelectFoodRecords] ON 

INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (66, N'./ImageForSeedData/Food/Restaurant1/food2.jpeg', N'Pate sate (400gram)', N'Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên', 85000, 13)
INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (68, N'./ImageForSeedData/Food/Restaurant1/food3.jpeg', N'Muối nguyễn thần thánh', N'1 hủ/ 150gr', 44000, 13)
INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (69, N'./ImageForSeedData/Food/Restaurant1/food2.jpeg', N'Pate sate (400gram)', N'Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên', 85000, 13)
INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (70, N'./ImageForSeedData/Food/Restaurant1/food2.jpeg', N'Pate sate (400gram)', N'Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên', 85000, 13)
INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (71, N'./ImageForSeedData/Food/Restaurant1/food3.jpeg', N'Muối nguyễn thần thánh', N'1 hủ/ 150gr', 44000, 13)
INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (72, N'./ImageForSeedData/Food/Restaurant1/food3.jpeg', N'Muối nguyễn thần thánh', N'1 hủ/ 150gr', 44000, 13)
INSERT [dbo].[SelectFoodRecords] ([RecordId], [FoodImageUrl], [FoodTitle], [FoodDescription], [FoodPrice], [UserId]) VALUES (73, N'./ImageForSeedData/Food/Restaurant1/food2.jpeg', N'Pate sate (400gram)', N'Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên', 85000, 1)
SET IDENTITY_INSERT [dbo].[SelectFoodRecords] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (1, N'nhoxhieuro5@gmail.com', 0x88633E53FFF8809EDF89A3AAB0EA121C6649CD8AA31B195607E6B0AD3CEA3FCDBBB10ED80445708534B3E10542FEF21595DD55600F41D26A1DA66C2D6379F44E73470CF57D00EAEA88D0C3EE36502A8F5BF53585F42E629DFEBD4E53593B0BD17310C18A30CDD0826C8EA9AAC52A7760060B6808AB3DABB870807F0DF8F9A312, 0x62941FFB4874026306DC791DCDA6EBA9C83B3FD53704C2A38438168546CC00D3182946F695197A9336730CB40F9C3EEB60B965F583D27B0FFCFD82A1D6EE3724, 928399)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (2, N'chaymetwa', 0x87A8F8880392C96D11DCC1D4E0AAE23524C7793B3013F07A3A16BAAFCFC3471289B23643C1EF39C54DB44A641BE9E8C23469E5F1E0503A947AF48194B2EE005E2E610F04406B16B2D52674051F701CE75210939B6E3AE516869716F0C7E9444139434C7DF3CD7E67BEB6F3144EFFF7F5707748CE01F8A63F792624FF786B3DE2, 0x77CB3FB5589C6492E90E06E323EDC3F4E5B08B9BAA53A61D56877E7DC63FAAB0E6E16C37E8576A10D7DE81493540DAC6F43472F75D8A4427DD9A20FA493B61C5, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (3, N'metmoichua', 0xD1D13270DD048CAE3F58F4D64D5A7254B8B1AD888141F8B95E40BBA5F183FA0D374C2E7F394BD7E58712EDB68AB0C9A407942233D59B3E8F2576B892BFE29041967746104359C16336CA14C0FD38B47533CCDA9D86BEA1DA6A393CFFCD64CAB00947CFE1DECC836FC72E80360AAE0F92E01E29C00C5289041C85C871F9877A5E, 0xF0ED38AD7F222B7C30F296B233AD5855DCB03064631F85B1EC91B8588CEF9391704A6B6984CC707EE4B8A88FEF5BC2A808EFEB8EEA28D42F9B1169716042A750, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (4, N'hoiaita', 0xAFB8608CCA24C80AED287F341030FFC7346E8DADE9729D77B300682A88E51095601D084F637E7CC878915F9A071652A34716A019FBAFAAD0A9C50DEDEE62EC9983A857F60D99EE38AD9BF1612893E6C4A714A44E913E837714E9D0C30BA59BDA1171DD6D9739014BF569B9FAE870E42C197843C22EB154196C18692A5DC8B30B, 0xF9C4B02F37EF3A89721B7B64400D3EEDFDFB87ED2E3AC949FE0CE1AB581D539E9C7609AE4C308183CD631F736E95D4A5309D747B62C0BDF0C10B11F197E87AF6, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (5, N'string', 0x1D998186619E66A2C251DD73C87F5052BADD22A429B18D1B36AF15C8D66C3B35F065C835935ECCCE97DC162D832D124332FF1A36EE164520C49921F80CB9687FA2ACFB41F890169AE2A3C985E0A514E9FA743D2D88EB37EC52CA4D85A9B2173E8A553630257427766BF51119659AE3AF10A453C58EBB4580466D4CAFF8B0F325, 0x9BD2E2014637B5C764AB8D9204980372B58BC430BBD4C1D0AD1ECBF8667114767A6A9687A20B7D5C97064B59C9FEEE2CDA6881892FFDAEA8939589A9715D476C, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (6, N'heheh', 0xD03804082649B7D8C2C52F12AE87BFFFC1DBE1D9119F5E216AB9888897C4EFC3F3F805D4F14553BD70DB8B09F2C6F719E2001A4420A0D5DB9DB39BCFB437F58E74C7FA91BB96D32C15E75F3EB7B1517C942289505B6E96AF32B8BB433FBC7EB060CFA1523287B07D262A474A9E4B3AE2BB32F960261AB34044CA4038FDEBD938, 0xA02D6A9F3CDF75E1127146703623CD08B4847F99D9A7C1BCDE80DEA4F01975FFF80E260011CB49B964406F9C4943B3D32EFE3B412536A293B748B05F140A0D2B, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (7, N'fafa', 0xC35282C985FAC2BD41B3B8F2D1D50518DE7A33342C45AE0E9A9C35F6876FF1D34D8EEF5B817C1D51C0AFB8E52F6F6F4A7FFAE4412106C8DD6A62A820D6A2C24B9460F0DE060D7A108209CD3B980190CEFA723D4DCFC40D973C2D744382B04BB52761400FB5BD146BE01B4DBD4F497D6B27F3AACA57381E1C3B2AB09DC71F87EE, 0x0361C2BB6F9548749231160F0AF9200B2D6CBFAE37F381B6D497207BD5D16F1A0744A2CFA234A1CF24240965852735F257EF3064CAEDD3E755EC271A727FC243, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (8, N'sf', 0x760C40B72A341BA0D49BEA1C885A5C37F945943719F020626EDF1D2F071C082B8C92CFC28CCD4C88FB541CDF5FA2C53AF98355B8CE40492DEA551F9A4851B4D479B46EF60F123563F45CB613646BAC0B8113ED029849D71D2EA35D83CE9D62BA22B4E1AE4CE5827007B3402F891602FDB47D3132B448DCCD9D8465BC6E34F0CD, 0xE3085BDC02CDD6F14DE60026B969A385B0B44F3F88010B74B2B9D7E2651BD2ACBAB38D7211BD786B795EEF8E17E643B99F710F244A37BF92519090366816834F, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (9, N'fff', 0xEC7A79E1D1C4080323330EA1E30C6AC6BAA8F104D526D122F8F5C77E81D5AF95811F2E32760E2A23AA2797B009F28A16F1D14DDE92B46FCD7FA60717B530A8D9194A94017198A9490BE33FF2DA6318297A8D0E122541439A70DA070F10689D7B5A67A64A70FAA58DEED25BBDE1B148EDCCF2D5A740C7222BCA6E5094E93133C3, 0x0865B2171CA2581DB2A8B82454629674AD06F68CB3100C7757C15BA4E2E0BBD5C8DC1FB44A2136EAC4E58707E872AE574214B1D71D577D81178474637476DCF7, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (10, N'ss', 0x2F33E65353660CB17AD1A6FCBDB2C452426D7F64415F5F0B342FD2B9857E01653D0BDFA6D78319B85E1CAB38CBFCB116A9525E8115FBAB75969324D0DB0CEE4907A79B4C1E5EC42D739C40C22848AA2F807D999C7946B10B9F5E7A395C0AC1B30EFAC4C05CBDD1936296B2CD9FDAF1590449D7D1F683D4D2FB8A46EAA4769113, 0x5D4C84604596DD446F6EDA180F3BA6B75C3F2F8C1722900E26604250DA3DAB2F1F98255293DAE17D2273C91E66397E151BCDD6629CFFCD725AEE0E8A14A062CC, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (11, N'fafaf', 0xB6E7A6E8D91985EE49C6BD1A868F2BF699300CF7AC17C61F9F1B237EACDB7531D5597A243DAF6CC83351522C704A9192DE230A7D1113F113D211D7AC4AAE229EEBA4B6FC7C1038FE45174D91186C137F56B2F206A5D90C4E58C0DAC09C454CAA14DB67EF601E1DF835A45D1108828FE1F8B45A28FEE4D061BF9BE995474F9884, 0x624BB00C76ADFF52B3CDB86E2BE608CAE7BE504387045B9508CDB62EB381DFB1C4A4102A8BC7DEBBBA2AE185FD6116EEA585FF69B4930856B3F5BEE6A6689237, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (12, N'hahah', 0xA25236E1EEBB0982A95AFA0DDD064F775191D77D93F9D22E81C79F1CEF32B13F04D87CAEBE04CC1A5FF6AA131695158505E23F9E226C4E4A456160181E414FAE853167C666D069BA3FEE868C79BF79C45CA9768F0950343A5BBEFCAFB3A14019C085E7CF9324B6C12B7AD89F6A52798A4F76711A2ACB4FB0D69D17316B1C4E24, 0xF0D90A4A2F3DC6208CFC397E0D005320F2A895F52D06C64A643D7DE5B6B486448D0824FE499AAD9DFA4F46E6641A975A518C16C53ED682A7F88C0F818079AF68, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (13, N'metmoiquanha', 0x0B64A16B06F9EF03C64B646515EEDADBB4CC0366D5CE468AEBFB1C7B23FD3C59F7DB407BA53FD8A00985B92696C2E26EA2C194B82BAD1946F3A76926727F3F76EE1BB2BBEF98CB39036F53103A3989011771F64B0D5D993A409799B92A3B27DB85A65A84366E67E17780ED550A208E3B21D98198EED72FCCDC65E5D6F4B93A75, 0xAEA2BA9E2E31908373B2B275A1D10F353AFB3122D2E0B00777BAB486E24CD98199083DFC2C72DF4DD6777E8E3322447B0D8E16B8E1B23EC7B8FDE4B37EB5CEA0, 468255)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordSalt], [PasswordHash], [Role]) VALUES (14, N'nhoxhieuro7@gmail.com', 0x9FDC692AF8C8D9C7B74C80234F68DF507959EA5BDB062F08C61DDDD054C921CB132A8A28ACFC91C34D82A58F9C3FC93FE0DA3C5456F5CC7FF799628360E1467D417EC3B7C6D7264849630064685F370915FB4841A9507B700C4EEF8E7DBE808EC22834E8FD1F6C5B14CDE7B37B97F4D724CD9880E466C7B16DE012DB35A49C48, 0x505309CC42FF2C5183B12115ACCADCC9805902BE2577325ABCDB5ECACB1B85D38E0BAB07D9C0B5429B4C24161E60EEBC582F7F1A48FE1959BB83B1FA252D2B55, 468255)
SET IDENTITY_INSERT [dbo].[Users] OFF
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
