using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class InitialValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RsTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    RsProvince = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    RsAddress = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    RsType = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    RsImageUrl = table.Column<string>(type: "nvarchar(600)", nullable: false),
                    RsStar = table.Column<float>(type: "real", nullable: false, defaultValue: 1f),
                    RsReviews = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RsOpenTime = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    RsPrinceRange = table.Column<string>(type: "nvarchar(800)", nullable: false),
                    RsRefeLike = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RsPromotion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RsId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    CategoryTag = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodImageUrl = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    FoodTitle = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPrice = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FoodPriceLess = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillOrders",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalMoney = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillOrders", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_BillOrders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPrice = table.Column<float>(type: "real", nullable: false),
                    CountFoodChoice = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_RestaurantOrders_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantOrders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelationCategoryFoods",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationCategoryFoods", x => new { x.CategoryId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_RelationCategoryFoods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelationCategoryFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransferOrders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberItem = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    OrderDistance = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Promotion = table.Column<int>(type: "int", nullable: false),
                    TempMoney = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TotalMoney = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ORDERSTATUS = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BillOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_TransferOrders_BillOrders_BillOrderId",
                        column: x => x.BillOrderId,
                        principalTable: "BillOrders",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransferOrders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[,]
                {
                    { 1, "606/52 Đường 3 Tháng 2, P. 14, Quận 10, TP. HCM", "./ImageForSeedData/Restaurant/restaurant1.jpg", "6:00 - 22:00", "44,000 - 85,000", 0, "TP.HCM", 1, 5f, "Bếp Bà Muối - Ăn Vặt Online", "QUANAN" },
                    { 2, "35 Sơn Kỳ, P. Sơn Kỳ, Tân Phú, TP. HCM", "./ImageForSeedData/Restaurant/restaurant2.jpg", "8:15 - 22:20", "45,000 - 60,000", 50000, "TP.HCM", 500, 4.5f, "Royaltea Vietnam By Hongkong - Sơn Kỳ", "CAFE/DESSERT" },
                    { 3, "115B Tôn Đản, P. 14, Quận 4, TP. HCM", "./ImageForSeedData/Restaurant/restaurant3.jpg", "6:00 - 20:11", "15,000 - 30,000", 0, "TP.HCM", 999, 4.5f, "Anh Thư - Bánh Mì & Bún Thịt Nướng", "ANVAT/VIAHE" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsRefeLike", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[] { 4, "322 Phạm Hùng, P. 4, Quận 8, TP. HCM", "./ImageForSeedData/Restaurant/restaurant4.jpeg", "7:00 - 21:30", "30,000 - 50,000", 5000, "TP.HCM", true, 100, 4.5f, "Mì Quảng 3 Anh Em - Phạm Hùng", "QUANAN" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[,]
                {
                    { 5, "38 Đường Số 13, P. Bình Thọ, Thủ Đức, TP. HCM", "./ImageForSeedData/Restaurant/restaurant5.jpg", "9:00 - 21:00", "14,000 - 30,000", 10000, "TP.HCM", 999, 4.5f, "Kim Milk Tea - Trà Sữa, Nước Ép & Ăn Vặt", "CAFE/DESSERT" },
                    { 6, "122 Nguyễn Khoái, P. 2, Quận 4, TP. HCM", "./ImageForSeedData/Restaurant/restaurant6.jpg", "7:20 - 21:45", "15,000 - 69,000", 10000, "TP.HCM", 999, 4.5f, "Min Kee - Mì Khô & Trà Hong Kong", "QUANAN" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsRefeLike", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[] { 7, "18A/29 Nguyễn Thị Minh Khai, P. Đa Kao, Quận 1, TP. HCM", "./ImageForSeedData/Restaurant/restaurant7.jpg", "8:30 - 20:25", "95,000 - 150,000", 5000, "TP.HCM", true, 999, 4.5f, "Bánh Bò Thốt Nốt COCOCake - Lò Bánh Minh Khai", "QUANAN" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[,]
                {
                    { 8, "26 Huỳnh Lan Khanh, P. 2, Tân Bình, TP. HCM", "./ImageForSeedData/Restaurant/restaurant8.jpg", "7:00 - 20:45", "20,000 - 100,000", 5000, "TP.HCM", 999, 4.5f, "Việt - Cơm Chay", "ANCHAY" },
                    { 9, "420/11 Huỳnh Văn Bánh, P. 14, Phú Nhuận, TP. HCM", "./ImageForSeedData/Restaurant/restaurant9.jpeg", "9:00 - 19:00", "105,000 - 150,000", 0, "TP.HCM", 50, 4.5f, "Bánh Quế Hà Lan - Huỳnh Văn Bánh", "TIEMBANH" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new byte[] { 5, 19, 253, 253, 142, 26, 132, 214, 159, 82, 36, 200, 237, 51, 57, 167, 160, 149, 231, 232, 234, 125, 176, 12, 26, 172, 70, 11, 172, 63, 146, 164, 95, 142, 51, 23, 219, 71, 142, 232, 65, 207, 157, 232, 200, 148, 140, 216, 106, 218, 147, 57, 115, 11, 16, 180, 235, 199, 112, 56, 53, 111, 29, 253 }, new byte[] { 135, 51, 223, 179, 216, 180, 122, 73, 183, 36, 210, 82, 19, 212, 117, 133, 61, 151, 163, 242, 51, 162, 252, 208, 161, 73, 225, 158, 130, 134, 193, 177, 214, 210, 58, 174, 69, 195, 48, 137, 74, 195, 132, 111, 127, 39, 113, 73, 219, 16, 179, 129, 57, 50, 174, 89, 139, 229, 228, 193, 136, 123, 92, 9, 44, 218, 177, 253, 40, 100, 245, 145, 217, 15, 34, 51, 142, 16, 42, 2, 92, 65, 253, 192, 235, 27, 44, 221, 229, 102, 88, 21, 101, 221, 120, 250, 53, 3, 87, 81, 66, 74, 23, 99, 253, 51, 183, 254, 147, 199, 3, 156, 65, 10, 250, 103, 45, 168, 25, 29, 16, 45, 210, 22, 235, 226, 232, 171 }, 928399, "nhoxhieuro5@gmail.com" },
                    { 2, new byte[] { 41, 101, 95, 36, 63, 189, 48, 148, 36, 48, 161, 73, 110, 56, 227, 102, 143, 254, 198, 116, 243, 182, 147, 228, 78, 139, 190, 208, 45, 5, 118, 177, 190, 27, 33, 236, 234, 231, 125, 159, 217, 60, 125, 59, 151, 223, 163, 195, 19, 53, 184, 75, 5, 41, 31, 26, 234, 85, 41, 161, 78, 211, 208, 250 }, new byte[] { 147, 172, 32, 167, 24, 44, 179, 137, 190, 77, 20, 203, 252, 94, 161, 91, 73, 74, 67, 228, 11, 110, 136, 140, 137, 46, 82, 213, 127, 201, 14, 16, 15, 115, 60, 203, 188, 204, 109, 101, 227, 169, 76, 205, 119, 209, 107, 145, 204, 171, 66, 192, 177, 0, 117, 196, 189, 56, 25, 57, 253, 240, 147, 207, 177, 221, 116, 230, 178, 206, 222, 31, 146, 99, 84, 240, 20, 98, 94, 40, 224, 180, 209, 64, 36, 219, 175, 101, 130, 191, 58, 224, 39, 35, 122, 150, 113, 198, 29, 100, 228, 121, 147, 220, 99, 96, 192, 195, 62, 212, 127, 189, 45, 129, 17, 9, 226, 198, 155, 185, 62, 88, 73, 28, 73, 22, 77, 1 }, 468255, "chaymetwa" },
                    { 3, new byte[] { 157, 77, 121, 127, 88, 227, 89, 12, 83, 81, 49, 28, 147, 45, 37, 119, 93, 16, 236, 154, 68, 15, 76, 153, 51, 1, 49, 152, 211, 186, 128, 103, 147, 82, 174, 152, 240, 29, 100, 254, 253, 31, 69, 106, 140, 225, 244, 194, 98, 190, 56, 198, 203, 109, 124, 18, 64, 139, 100, 5, 182, 136, 185, 145 }, new byte[] { 154, 127, 113, 242, 26, 223, 249, 38, 75, 248, 148, 99, 250, 160, 4, 101, 112, 167, 151, 99, 127, 160, 252, 100, 222, 253, 162, 128, 20, 61, 104, 199, 232, 142, 92, 65, 126, 86, 12, 92, 75, 235, 179, 163, 161, 224, 65, 86, 205, 103, 207, 13, 34, 224, 105, 193, 41, 122, 21, 215, 249, 98, 247, 48, 55, 6, 197, 214, 60, 227, 6, 103, 56, 104, 181, 124, 236, 42, 11, 80, 82, 214, 160, 22, 95, 198, 202, 238, 90, 60, 108, 188, 230, 187, 198, 194, 74, 216, 184, 3, 192, 27, 56, 1, 215, 144, 32, 236, 224, 165, 204, 76, 235, 123, 51, 0, 85, 207, 126, 235, 246, 22, 235, 2, 66, 62, 141, 21 }, 468255, "metmoichua" },
                    { 4, new byte[] { 99, 0, 159, 96, 153, 137, 0, 164, 107, 68, 104, 128, 72, 224, 210, 140, 38, 192, 84, 248, 45, 36, 210, 90, 230, 154, 95, 100, 22, 12, 89, 187, 203, 105, 33, 67, 13, 253, 109, 227, 213, 16, 1, 134, 19, 66, 199, 17, 217, 228, 154, 243, 71, 86, 204, 42, 205, 26, 36, 108, 49, 56, 121, 197 }, new byte[] { 202, 250, 168, 155, 43, 253, 105, 231, 96, 126, 32, 148, 88, 152, 104, 160, 63, 13, 138, 142, 243, 29, 52, 225, 231, 176, 169, 65, 207, 137, 81, 88, 146, 66, 172, 214, 76, 182, 233, 222, 151, 215, 137, 226, 243, 251, 40, 21, 83, 131, 68, 92, 128, 24, 72, 77, 231, 250, 61, 185, 67, 162, 255, 87, 153, 11, 116, 52, 198, 14, 198, 238, 193, 63, 131, 67, 227, 17, 5, 167, 253, 20, 34, 185, 50, 247, 40, 37, 58, 85, 178, 60, 11, 86, 187, 149, 185, 4, 81, 249, 200, 96, 211, 64, 24, 129, 27, 158, 251, 83, 30, 189, 70, 29, 18, 174, 55, 179, 46, 120, 162, 170, 246, 181, 207, 90, 28, 32 }, 468255, "hoiaita" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryTag", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "MENU", "menu", 1 },
                    { 2, "FREESHIP XTRA SIÊU ƯU ĐÃI - GIẢM 50%", "freeship50%", 2 },
                    { 3, "NOWFOOD DAY", "nowfoodday", 2 },
                    { 4, "NEW", "new", 2 },
                    { 5, "ROYAL BLACK TIGER", "royalblacktiger", 2 },
                    { 6, "ROYAL CHEESE TEA", "royalcheesetea", 2 },
                    { 7, "MILK TEA", "milktea", 2 },
                    { 8, "FRESH FRUIT TEA", "freshfruittea", 2 },
                    { 9, "MATCHA & CHOCOLATE", "matchachocolate", 2 },
                    { 10, "SMOOTHIE CHEESE", "smoothiecheese", 2 },
                    { 11, "BÁNH MÌ", "banhmi", 3 },
                    { 12, "BÚN", "bun", 3 },
                    { 13, "MÓN THÊM", "monthem", 3 },
                    { 14, "THỨC UỐNG", "thucuong", 3 },
                    { 15, "KHUYẾN MÃI HOT", "khuyenmaihot", 4 },
                    { 16, "COMBO HOT NƯỚC NGỌT", "combohotnuocngot", 4 },
                    { 17, "MÌ QUẢNG", "miquang", 4 },
                    { 18, "COMBO SIÊU TIẾT KIỆM 1 NGƯỜI", "combosieutietkiem1nguoi", 4 },
                    { 19, "COMBO 3 TÔ", "combo3to", 4 },
                    { 20, "MÓN THÊM", "monthem", 4 },
                    { 21, "NƯỚC UỐNG", "nuocuong", 4 },
                    { 22, "ĐẶC SẢN MIỀN TRUNG", "dacsanmientrung", 4 },
                    { 23, "NOWFOOD DAY", "nowfoodday", 5 },
                    { 24, "COMBO TRÀ SỮA", "combotrasua", 5 },
                    { 25, "TRÀ TRÁI CÂY NHIỆT ĐỚI", "tratraicaynhietdoi", 5 },
                    { 26, "SỮA TƯƠI ĐƯỜNG ĐEN", "suatuoiduongden", 5 },
                    { 27, "TRÀ SỮA", "trasua", 5 },
                    { 28, "LỤC TRÀ", "luctra", 5 },
                    { 29, "NƯỚC ÉP TRÁI CÂY TƯƠI", "nuoceptraicaytuoi", 5 },
                    { 30, "COMBO COUPLE", "combocouple", 5 },
                    { 31, "MÌ CỰC PHẨM", "micucpham", 6 },
                    { 32, "SỦI CẢO / HOÀNH THÁNH", "suicaohoanhthanh", 6 },
                    { 33, "MÌ KHÔ", "mikho", 6 },
                    { 34, "MÌ NƯỚC", "minuoc", 6 },
                    { 35, "HỦ TIẾU KHÔ", "hutieukho", 6 },
                    { 36, "MÓN ĂN THÊM", "monanthem", 6 },
                    { 37, "TRÀ THANH NHIỆT", "trathanhnhiet", 6 },
                    { 38, "SIÊU SALE MÙA LỄ HỘI", "sieusalemualehoi", 7 },
                    { 39, "BÁNH BÒ", "banhbo", 7 },
                    { 40, "BÁNH DA LỢN", "banhdalon", 7 },
                    { 41, "RAU CÂU FLAN CHEESE", "raucauflancheese", 7 },
                    { 42, "RAU CÂU SƠN THỦY", "raucausonthuy", 7 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryTag", "RestaurantId" },
                values: new object[,]
                {
                    { 43, "RAU CÂU DỪA", "raucaudua", 7 },
                    { 44, "KEM", "kem", 7 },
                    { 45, "COMBO", "combo", 7 },
                    { 46, "YOGHURT", "yoghurt", 7 },
                    { 47, "BÁNH FLAN", "banhflan", 7 },
                    { 48, "CHÈ", "che", 7 },
                    { 49, "CỐT DỪA", "cotdua", 7 },
                    { 50, "COMBO", "combo", 8 },
                    { 51, "MÓN CƠM", "moncom", 8 },
                    { 52, "MÓN SỢI", "monsoi", 8 },
                    { 53, "MÓN LẨU", "monlau", 8 },
                    { 54, "BANH1 BISCOTTI", "banhbiscotti", 9 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Hộp đã được nâng cấp lên từ 300->400 gram vẫn nguyên giá cux", "./ImageForSeedData/Food/Restaurant1/food1.jpeg", 85000, "Pate bơ béo (400gram)", 1 },
                    { 2, "Hộp đã được nâng cấp từ 300->400 gram với giá giữ nguyên", "./ImageForSeedData/Food/Restaurant1/food2.jpeg", 85000, "Pate sate (400gram)", 1 },
                    { 3, "1 hủ/ 150gr", "./ImageForSeedData/Food/Restaurant1/food3.jpeg", 44000, "Muối nguyễn thần thánh", 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 4, "", "./ImageForSeedData/Food/Restaurant2/food4.jpg", 50000, 30000f, "Trà sữa trân châu hoàng kim", 2 },
                    { 5, "", "./ImageForSeedData/Food/Restaurant2/food5.jpg", 45000, 27000f, "Trà sữa Hongkong Royal", 2 },
                    { 6, "", "./ImageForSeedData/Food/Restaurant2/food6.jpg", 45000, 27000f, "Trà sữa lúa mạch", 2 },
                    { 7, "", "./ImageForSeedData/Food/Restaurant2/food7.jpg", 45000, 27000f, "Hồng trà sữa", 2 },
                    { 8, "", "./ImageForSeedData/Food/Restaurant2/food7.jpg", 45000, 27000f, "Trà sữa hoa nhài", 2 },
                    { 9, "", "./ImageForSeedData/Food/Restaurant2/food7.jpg", 45000, 27000f, "Trà sữa olong kim phượng", 2 },
                    { 10, "", "./ImageForSeedData/Food/Restaurant2/food7.jpg", 45000, 27000f, "Trà sữa olong bạch đào", 2 },
                    { 11, "không chọn được mức đá", "./ImageForSeedData/Food/Restaurant2/food11.png", 50000, 30000f, "Sữa tươi trân châu hoàng kim", 2 },
                    { 12, "", "./ImageForSeedData/Food/Restaurant2/food11.png", 50000, 30000f, "Đường Đen Sầu Riêng", 2 },
                    { 13, "không thể để đá riêng", "./ImageForSeedData/Food/Restaurant2/food13.jpg", 50000, 30000f, "Sữa tươi trân châu đường đen", 2 },
                    { 14, "", "./ImageForSeedData/Food/Restaurant2/food14.jpg", 50000, 30000f, "Trà sữa trân châu đường đen", 2 },
                    { 15, "Size M", "./ImageForSeedData/Food/Restaurant2/food15.jpg", 57000, 34200f, "Matcha đường đen", 2 },
                    { 16, "Thơm ngon", "./ImageForSeedData/Food/Restaurant2/food16.jpg", 65000, 39000f, "Trà táo xanh kiwi", 2 },
                    { 17, "SizeM", "./ImageForSeedData/Food/Restaurant2/food17.jpg", 69000, 41400f, "Matcha đường đen kem cheese", 2 },
                    { 18, "", "./ImageForSeedData/Food/Restaurant2/food11.png", 55000, 33000f, "Trà sữa khoai môn đường đen", 2 },
                    { 19, "", "./ImageForSeedData/Food/Restaurant2/food19.jpg", 54000, 32400f, "Trà lúa mạch kem cheese", 2 },
                    { 20, "", "./ImageForSeedData/Food/Restaurant2/food20.jpg", 54000, 32400f, "Hồng trà Royal kem cheese", 2 },
                    { 21, "", "./ImageForSeedData/Food/Restaurant2/food21.jpg", 57000, 34200f, "Trà sương mù London kem cheese", 2 },
                    { 22, "", "./ImageForSeedData/Food/Restaurant2/food22.jpg", 54000, 34200f, "Trà xanh Golden kem cheese", 2 },
                    { 23, "", "./ImageForSeedData/Food/Restaurant2/food23.jpg", 54000, 32400f, "Trà ô long bạch đào kem cheese", 2 },
                    { 24, "", "./ImageForSeedData/Food/Restaurant2/food24.jpg", 54000, 32400f, "Trà bách hoa kem cheese", 2 },
                    { 25, "", "./ImageForSeedData/Food/Restaurant2/food25.jpg", 54000, 32400f, "Trà ô long mộc hoa kem cheese", 2 },
                    { 26, "", "./ImageForSeedData/Food/Restaurant2/food25.jpg", 54000, 32400f, "Trà oolong Kim Phượng kem cheese", 2 },
                    { 27, "", "./ImageForSeedData/Food/Restaurant2/food27.jpg", 59000, 35400f, "Trà sữa oreo cake cream", 2 },
                    { 28, "", "./ImageForSeedData/Food/Restaurant2/food28.jpg", 55000, 33000f, "Trà sữa trân châu ngọc trai trắng", 2 },
                    { 29, "", "./ImageForSeedData/Food/Restaurant2/food29.jpg", 55000, 33000f, "Trà sữa trân châu ngọc trai đen", 2 },
                    { 30, "", "./ImageForSeedData/Food/Restaurant2/food30.jpg", 68000, 40800f, "Trà hoa quả Royaltea đặc biệt", 2 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 31, "", "./ImageForSeedData/Food/Restaurant2/food31.jpg", 65000, 39000f, "Trà xanh cam bưởi dâu tây", 2 },
                    { 32, "", "./ImageForSeedData/Food/Restaurant2/food32.jpg", 65000, 39000f, "Trà xanh cam bưởi nhiệt đới", 2 },
                    { 33, "", "./ImageForSeedData/Food/Restaurant2/food33.jpg", 58000, 34800f, "Socola kem cheese", 2 },
                    { 34, "", "./ImageForSeedData/Food/Restaurant2/food34.jpg", 55000, 33000f, "Scola cake cream", 2 },
                    { 35, "", "./ImageForSeedData/Food/Restaurant2/food35.jpg", 67000, 40200f, "Smoothie xoài kem cheese", 2 },
                    { 36, "", "./ImageForSeedData/Food/Restaurant2/food36.jpg", 67000, 40200f, "Smoothie dưa hấu kem cheese", 2 },
                    { 37, "", "./ImageForSeedData/Food/Restaurant2/food37.jpg", 67000, 40200f, "Smoothie ruby", 2 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 38, "", "./ImageForSeedData/Food/Restaurant3/food38.jpeg", 26000, "Bánh mì thịt nướng", 3 },
                    { 39, "", "./ImageForSeedData/Food/Restaurant3/food39.jpeg", 32000, "Bánh mì thịt nướng đặc biệt", 3 },
                    { 40, "", "./ImageForSeedData/Food/Restaurant3/food40.jpeg", 47000, "Bún thịt nướng đặc biệt", 3 },
                    { 41, "", "./ImageForSeedData/Food/Restaurant3/food41.jpeg", 33000, "Bún thịt nướng", 3 },
                    { 42, "", "./ImageForSeedData/Food/Restaurant3/food42.jpeg", 33000, "Bún nem nướng", 3 },
                    { 43, "", "./ImageForSeedData/Food/Restaurant3/food43.jpeg", 30000, "Bún Chả giò", 3 },
                    { 44, "Cái", "./ImageForSeedData/Food/Restaurant3/food44.jpeg", 6000, "Chả giò", 3 },
                    { 45, "Xiên", "./ImageForSeedData/Food/Restaurant3/food45.jpeg", 18000, "Thịt xiên", 3 },
                    { 46, "Viên", "./ImageForSeedData/Food/Restaurant3/food46.jpeg", 6000, "Thịt viên", 3 },
                    { 47, "", "./ImageForSeedData/Food/Restaurant3/food47.jpeg", 12000, "Nem nướng", 3 },
                    { 48, "", "./ImageForSeedData/Food/Restaurant3/food48.jpeg", 3000, "Bún thêm", 3 },
                    { 49, "", "./ImageForSeedData/Food/Restaurant3/food49.jpeg", 3000, "Rau thêm", 3 },
                    { 50, "Thành phần: bí đao, hạt chia, thục địa, la hán quả, bông cóc ... Đường phèn", "./ImageForSeedData/Food/Restaurant3/food50.jpeg", 15000, "Sâm Bí Đao Hạt Chia", 3 },
                    { 51, "Thành phần: BÍ ĐAOM THỤC ĐỊA, LA HÁN QUẢ, BÔNG CÚC ... ĐƯỜNG PHÈN", "./ImageForSeedData/Food/Restaurant3/food51.jpeg", 12000, "Sâm Bí Đao Đường Phền", 3 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 52, "Gọi 0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food52.jpeg", 55000, 49500f, "Mì Quảng thịt, trứng cút", 4 },
                    { 53, "", "./ImageForSeedData/Food/Restaurant4/food53.jpeg", 50000, 45000f, "Mì Quảng Chả Nhỏ", 4 },
                    { 54, "Gọi 0906743795 Hỗ trợ nha", "./ImageForSeedData/Food/Restaurant4/food54.jpeg", 55000, 49500f, "Mì Quảng Chả cua", 4 },
                    { 55, "", "./ImageForSeedData/Food/Restaurant4/food55.jpeg", 60000, 54000f, "Mì Quảng bắp bò + chả", 4 },
                    { 56, "", "./ImageForSeedData/Food/Restaurant4/food56.jpeg", 60000, 54000f, "Mì Quảng sườn non + chả", 4 },
                    { 57, "", "./ImageForSeedData/Food/Restaurant4/food57.jpeg", 50000, 45000f, "Chén tôm thêm", 4 },
                    { 58, "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food58.jpeg", 70000, 63000f, "Mì Quảng Đặt biệt", 4 },
                    { 59, "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food59.jpeg", 60000, 54000f, "Mì Quảng gà chọi rút xương", 4 },
                    { 60, "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food60.jpeg", 55000, 49500f, "Mì Quảng tôm thịt", 4 },
                    { 61, "TẶNG KÈM TƯƠNG ỚT HỘI AN SIÊU NGON", "./ImageForSeedData/Food/Restaurant4/food61.jpg", 65000, 58500f, "Combo 1 tô mì quảng chọn món + 1 pepsi/nước suối", 4 },
                    { 62, "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food62.jpeg", 215000, 193500f, "Combo 3 tô mì quảng đặc biệt 3 anh em", 4 },
                    { 63, "Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food63.jpeg", 180000, 162000f, "Combo 3 tô mì Quảng gà chọi rút xương", 4 },
                    { 64, "0906743795 Hổ trợ nhanh nhất nhé cảm ơn ạ ^^", "./ImageForSeedData/Food/Restaurant4/food64.jpeg", 165000, 148500f, "Combo 3 tô mì Quảng Thit trứng cút", 4 },
                    { 65, "", "./ImageForSeedData/Food/Restaurant4/food65.jpg", 10000, 9000f, "Bánh tráng thêm", 4 },
                    { 66, "", "./ImageForSeedData/Food/Restaurant4/food66.jpg", 10000, 9000f, "Rau thêm", 4 },
                    { 67, "", "./ImageForSeedData/Food/Restaurant4/food67.jpg", 20000, 18000f, "Pepsi", 4 },
                    { 68, "", "./ImageForSeedData/Food/Restaurant4/food68.jpg", 20000, 18000f, "7up", 4 },
                    { 69, "", "./ImageForSeedData/Food/Restaurant4/food69.jpeg", 55000, 49500f, "Bánh tráng gạo 300gram", 4 },
                    { 70, "1 hủ", "./ImageForSeedData/Food/Restaurant4/food70.jpeg", 90000, 81000f, "Tương ớt hội an", 4 },
                    { 71, "Trà sữa, trân châu, bánh flan size L", "./ImageForSeedData/Food/Restaurant5/food71.jpeg", 32000, 25600f, "Combo 3", 5 },
                    { 72, "Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L", "./ImageForSeedData/Food/Restaurant5/food72.jpeg", 24000, 19200f, "Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L", 5 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 73, "", "./ImageForSeedData/Food/Restaurant5/food73.jpeg", 34000, 27200f, "Dưa hấu ép", 5 },
                    { 74, "4 ly Trà sữa full topping size XL", "./ImageForSeedData/Food/Restaurant5/food74.jpeg", 168000, 134400f, "Combo 4 ly Combo 5", 5 },
                    { 75, "Trà sữa full topping size XL", "./ImageForSeedData/Food/Restaurant5/food75.jpeg", 42000, 33600f, "Combo 5", 5 },
                    { 76, "Trà sữa, thạch dẻo, thạch phô mai, bánh flan size L", "./ImageForSeedData/Food/Restaurant5/food76.jpeg", 37000, 29600f, "Combo 4", 5 },
                    { 77, "Trà sữa, thạch dẻo, thạch phô mai size L", "./ImageForSeedData/Food/Restaurant5/food77.jpeg", 32000, 25600f, "Combo 2", 5 },
                    { 78, "", "./ImageForSeedData/Food/Restaurant5/food78.jpeg", 35000, 28000f, "Trà đào cam sả", 5 },
                    { 79, "", "./ImageForSeedData/Food/Restaurant5/food79.jpeg", 22000, 17600f, "Trà đào dầm", 5 },
                    { 80, "", "./ImageForSeedData/Food/Restaurant5/food80.jpeg", 21000, 16800f, "Lục trà bạc hà", 5 },
                    { 81, "", "./ImageForSeedData/Food/Restaurant5/food81.jpeg", 34000, 27200f, "Trà Cam Nhài", 5 },
                    { 82, "", "./ImageForSeedData/Food/Restaurant5/food82.jpeg", 25000, 20000f, "Sữa tươi trân châu đường đen", 5 },
                    { 83, "", "./ImageForSeedData/Food/Restaurant5/food83.jpeg", 30000, 24000f, "Sữa tươi matcha trân châu đường đen", 5 },
                    { 84, "", "./ImageForSeedData/Food/Restaurant5/food84.jpeg", 25000, 20000f, "Sữa tươi đường đen sương sáo", 5 },
                    { 85, "", "./ImageForSeedData/Food/Restaurant5/food85.jpeg", 21000, 16800f, "Trà sữa", 5 },
                    { 86, "", "./ImageForSeedData/Food/Restaurant5/food86.jpeg", 27000, 21600f, "Trà sữa socola", 5 },
                    { 87, "", "./ImageForSeedData/Food/Restaurant5/food87.jpeg", 22000, 17600f, "Trà sữa hoa đậu biếc", 5 },
                    { 88, "", "./ImageForSeedData/Food/Restaurant5/food88.jpeg", 32000, 25600f, "Thơm ép", 5 },
                    { 89, "", "./ImageForSeedData/Food/Restaurant5/food89.jpeg", 32000, 25600f, "Ổi ép", 5 },
                    { 90, "", "./ImageForSeedData/Food/Restaurant5/food90.jpeg", 48000, 38400f, "Trà sữa + Trà sữa socola", 5 },
                    { 91, "2 vắt mì + đùi gà góc tư mắm tỏi + cải Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food91.jpeg", 87000, 78300f, "Mì khô gà chiên giòn mắm tỏi", 6 },
                    { 92, "2 vắt mì + tôm + xá xíu + gà xé + 2 cá viên hấp + trứng bắc thảo + sate tôm X.O Tặng kèm 1 ly Trà La Hán Quar", "./ImageForSeedData/Food/Restaurant6/food92.jpeg", 97000, 87300f, "Mì khô thập cẩm Hong Kong", 6 },
                    { 93, "2 vắt mì + 4 hoành thánh chiên + 1 đùi gà góc tư mắm tỏi + cải Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food93.jpeg", 97000, 87300f, "Mì hoành thánh khô gà góc tư mắm giòn", 6 },
                    { 94, "8 viên hoành thánh luộc + Sốt giấm đen + Sate tôm X.O + cải", "./ImageForSeedData/Food/Restaurant6/food94.jpg", 69000, 62100f, "Hoành thánh giấm đen", 6 },
                    { 95, "6 viên sủi cảo + sốt tương sate tôm X.O + cải Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food95.jpeg", 69000, 62100f, "Sủi cảo khô sốt X.O", 6 },
                    { 96, "3 Sủi cảo + 5 Hoành thánh + Sốt tương sate X.O + cải Tặng kèm 1 ly Trà La Hán Quar", "./ImageForSeedData/Food/Restaurant6/food96.jpeg", 69000, 62100f, "Hoành sủi khô", 6 },
                    { 97, "6 hoành thánh chiên + 6 cá viên mắm tỏi + bắc thảo + trứng gà Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food97.jpeg", 69000, 62100f, "Combo thập cẩm chiên lớn", 6 },
                    { 98, "8 viên hoành thánh nước + xá xíu + cải", "./ImageForSeedData/Food/Restaurant6/food98.jpeg", 59000, 53100f, "Hoành thánh nước xá xíu", 6 },
                    { 99, "2 vắt mì + xá xíu + cải Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food99.jpeg", 59000, 53100f, "Mì khô xá xíu", 6 },
                    { 100, "2 vắt mì + 2 hoành thánh chiên + 6 viên cá chiên mắm + cải Tặng kèm 1 Ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food100.jpeg", 59000, 53100f, "Mì khô cá hoành chiên mắm", 6 },
                    { 101, "2 vắt mì trộn khô + 4 viên hoành thánh chiên + Cải Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food101.jpeg", 59000, 53100f, "Mì khô hoành thánh chiên (Ko kèm chén súp)", 6 },
                    { 102, "2 vắt mì + gà luộc xé + cải Tặng kèm 1 Ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food102.jpeg", 59000, 53100f, "Mì khô gà xé", 6 },
                    { 103, "2 vắt mì + 5 hoành thánh luộc + cải + Súp", "./ImageForSeedData/Food/Restaurant6/food103.jpeg", 59000, 53100f, "Mì hoành thánh nước", 6 },
                    { 104, "Hủ tíu khô + xá xíu + cải Tặng kèm 1 ly Trà La Hán Quả", "./ImageForSeedData/Food/Restaurant6/food104.jpeg", 59000, 53100f, "Hủ tiếu khô xá xíu", 6 },
                    { 105, "Đùi gà góc tư chiên giòn sốt mắm tỏi", "./ImageForSeedData/Food/Restaurant6/food105.jpeg", 59000, 53100f, "Đùi gà góc tư chiên mắm", 6 },
                    { 106, "4 viên", "./ImageForSeedData/Food/Restaurant6/food105.jpeg", 39000, 35100f, "Hoàn thánh chiên", 6 },
                    { 107, "", "./ImageForSeedData/Food/Restaurant6/food107.jpg", 39000, 35100f, "Hồng trà long nhãn", 6 },
                    { 108, "", "./ImageForSeedData/Food/Restaurant6/food105.jpeg", 29000, 26100f, "Hồng trà chanh", 6 },
                    { 109, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food109.jpeg", 22000, 11000f, "Bánh bò nướng (hộp 1 lát lớn)", 7 },
                    { 110, "Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa", "./ImageForSeedData/Food/Restaurant7/food110.jpeg", 45000, 40500f, "Rau câu sơn thủy hộp nhỏ (350g)", 7 },
                    { 111, "Gồm: nước cốt dừa tươi, đường thốt nốt, trứng gà tươi, bột", "./ImageForSeedData/Food/Restaurant7/food111.jpeg", 35000, 31500f, "Hộp 2 lát bánh bò nhỏ", 7 },
                    { 112, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food112.jpeg", 110000, 99000f, "Bánh bò nhỏ (550g)", 7 },
                    { 113, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food113.jpeg", 170000, 153000f, "Bánh bò lớn (900g)", 7 },
                    { 114, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food114.jpeg", 60000, 54000f, "Hộp 4 lát bánh bò nhỏ", 7 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 115, "Bánh da lợn có thành phần chính từ lá cẩm khoai môn", "./ImageForSeedData/Food/Restaurant7/food115.jpeg", 60000, 54000f, "Da lợn cuộn 2 vị hộp 6 khoanh", 7 },
                    { 116, "Bánh da lợn có thành phần chính từ lá cẩm khoai môn", "./ImageForSeedData/Food/Restaurant7/food116.jpeg", 75000, 67500f, "Da lợn cuộn 2 vị hộp 8 khoanh", 7 },
                    { 117, "Bánh da lợn có thành phần chính từ lá dứa, đậu xanh", "./ImageForSeedData/Food/Restaurant7/food117.jpeg", 60000, 54000f, "Da lợn cuộn Đậu xanh lá dứa hộp 6 khoanh", 7 },
                    { 118, "Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp", "./ImageForSeedData/Food/Restaurant7/food118.jpeg", 95000, 85500f, "Flan cheese Cà phê hộp nhỏ (600g)", 7 },
                    { 119, "Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp", "./ImageForSeedData/Food/Restaurant7/food119.jpeg", 140000, 126000f, "Flan cheese Cà phê hộp lớn (900g)", 7 },
                    { 120, "Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa", "./ImageForSeedData/Food/Restaurant7/food120.jpeg", 75000, 67500f, "Rau câu sơn thủy hộp lớn (600g)", 7 },
                    { 121, "Rau câu dẻo được làm từ nước cốt và nước dừa tươi", "./ImageForSeedData/Food/Restaurant7/food121.jpeg", 85000, 76500f, "Rau câu dừa hộp nhỏ (600g)", 7 },
                    { 122, "", "./ImageForSeedData/Food/Restaurant7/food122.jpeg", 95000, 85500f, "Hộp kem Nhãn nhỏ 250g", 7 },
                    { 123, "Hình ảnh mang tính chất minh họa", "./ImageForSeedData/Food/Restaurant7/food123.jpeg", 195000, 175500f, "Combo B: 1 Bánh bò nhỏ (550g) + Hộp kem dừa 250gr", 7 },
                    { 124, "", "./ImageForSeedData/Food/Restaurant7/food124.jpeg", 22000, 19800f, "Yoghurt", 7 },
                    { 125, "", "./ImageForSeedData/Food/Restaurant7/food125.jpeg", 22000, 19800f, "Bánh Flan Vị Truyền Thống", 7 },
                    { 126, "Chè bưởi kèm cốt dừa chan", "./ImageForSeedData/Food/Restaurant7/food126.jpeg", 35000, 31500f, "Chè Bưởi (Đường Thốt Nốt) 200g☘", 7 },
                    { 127, "50ml cốt dừa (lạnh)", "./ImageForSeedData/Food/Restaurant7/food127.jpeg", 6000, 5400f, "Cốt dừa chén nhỏ 50ml (lạnh)", 7 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 128, "", "./ImageForSeedData/Food/Restaurant8/food128.jpeg", 54000, "Combo 2 Cơm thập cẩm chay", 8 },
                    { 129, "", "./ImageForSeedData/Food/Restaurant8/food129.jpeg", 29000, "Cơm thập cẩm chay", 8 },
                    { 130, "", "./ImageForSeedData/Food/Restaurant8/food130.jpeg", 44000, "Cơm chiên Dương Châu chay", 8 },
                    { 131, "", "./ImageForSeedData/Food/Restaurant8/food131.jpeg", 29000, "Bún Huế chay", 8 },
                    { 132, "", "./ImageForSeedData/Food/Restaurant8/food132.jpeg", 29000, "Hủ tiếu Sa Đéc chay", 8 },
                    { 133, "", "./ImageForSeedData/Food/Restaurant8/food133.jpeg", 160000, "Lẩu Thái chay", 8 },
                    { 134, "", "./ImageForSeedData/Food/Restaurant8/food134.jpeg", 160000, "Lẩu nấm chay", 8 },
                    { 135, "Bánh Biscotti hạnh nhân & socola nguyên chất, dành cho những người sành ăn tạo ra một sự kết hợp ngon miệng.", "./ImageForSeedData/Food/Restaurant9/food135.jpeg", 99000, "Bánh Biscotti Dark Chocolate - Hộp 195gr", 9 },
                    { 136, "Hương vị truyền thống kết hợp hạt hạnh nhân & óc chó với một chút hương vị hạt tiểu hồi.", "./ImageForSeedData/Food/Restaurant9/food136.jpeg", 99000, "Bánh Biscotti Truyền Thống - Hộp 195gr", 9 },
                    { 137, "Nam Việt Quất kết hợp với Hạnh Nhân và được nướng hai lần mang đến cho bạn cảm giác dai giòn ngon tuyệt đỉnh.", "./ImageForSeedData/Food/Restaurant9/food137.jpeg", 120000, "Biscotti Nam Việt Quất - Hộp 195gr", 9 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 6, 19 },
                    { 6, 20 },
                    { 6, 21 },
                    { 6, 22 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 6, 26 },
                    { 7, 27 },
                    { 7, 28 },
                    { 7, 29 },
                    { 8, 30 },
                    { 8, 31 },
                    { 8, 32 },
                    { 9, 33 },
                    { 9, 34 },
                    { 10, 35 },
                    { 10, 36 },
                    { 10, 37 },
                    { 11, 38 },
                    { 11, 39 },
                    { 12, 40 },
                    { 12, 41 },
                    { 12, 42 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 12, 43 },
                    { 13, 44 },
                    { 13, 45 },
                    { 13, 46 },
                    { 13, 47 },
                    { 13, 48 },
                    { 13, 49 },
                    { 14, 50 },
                    { 14, 51 },
                    { 15, 52 },
                    { 15, 53 },
                    { 15, 54 },
                    { 16, 52 },
                    { 16, 55 },
                    { 16, 56 },
                    { 17, 55 },
                    { 17, 58 },
                    { 17, 59 },
                    { 17, 60 },
                    { 18, 61 },
                    { 18, 62 },
                    { 19, 63 },
                    { 19, 64 },
                    { 20, 56 },
                    { 20, 57 },
                    { 20, 65 },
                    { 21, 67 },
                    { 21, 68 },
                    { 22, 69 },
                    { 22, 70 },
                    { 23, 71 },
                    { 23, 72 },
                    { 23, 73 },
                    { 23, 74 },
                    { 24, 75 },
                    { 24, 76 },
                    { 24, 77 },
                    { 25, 78 },
                    { 25, 79 },
                    { 25, 80 },
                    { 25, 81 },
                    { 26, 82 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 26, 83 },
                    { 26, 84 },
                    { 27, 85 },
                    { 27, 87 },
                    { 28, 77 },
                    { 28, 85 },
                    { 29, 88 },
                    { 29, 89 },
                    { 30, 90 },
                    { 31, 91 },
                    { 31, 92 },
                    { 31, 93 },
                    { 32, 94 },
                    { 32, 95 },
                    { 32, 96 },
                    { 32, 97 },
                    { 32, 98 },
                    { 33, 99 },
                    { 33, 100 },
                    { 33, 101 },
                    { 33, 102 },
                    { 34, 103 },
                    { 35, 104 },
                    { 36, 105 },
                    { 36, 106 },
                    { 37, 107 },
                    { 37, 108 },
                    { 38, 109 },
                    { 38, 110 },
                    { 38, 111 },
                    { 39, 112 },
                    { 39, 113 },
                    { 39, 114 },
                    { 40, 115 },
                    { 40, 116 },
                    { 40, 117 },
                    { 41, 118 },
                    { 41, 119 },
                    { 42, 120 },
                    { 43, 121 },
                    { 44, 122 },
                    { 45, 123 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 46, 124 },
                    { 47, 125 },
                    { 48, 126 },
                    { 49, 127 },
                    { 50, 128 },
                    { 51, 129 },
                    { 51, 130 },
                    { 52, 131 },
                    { 52, 132 },
                    { 53, 133 },
                    { 53, 134 },
                    { 54, 135 },
                    { 54, 136 },
                    { 54, 137 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillOrders_UserId",
                table: "BillOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryTag_RestaurantId",
                table: "Categories",
                columns: new[] { "CategoryTag", "RestaurantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_RestaurantId",
                table: "Categories",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodTitle_RestaurantId",
                table: "Foods",
                columns: new[] { "FoodTitle", "RestaurantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_RestaurantId",
                table: "Foods",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationCategoryFoods_FoodId",
                table: "RelationCategoryFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantOrders_RestaurantId",
                table: "RestaurantOrders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantOrders_UserId",
                table: "RestaurantOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RsTitle",
                table: "Restaurants",
                column: "RsTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrders_BillOrderId",
                table: "TransferOrders",
                column: "BillOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrders_UserId",
                table: "TransferOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelationCategoryFoods");

            migrationBuilder.DropTable(
                name: "RestaurantOrders");

            migrationBuilder.DropTable(
                name: "TransferOrders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "BillOrders");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
