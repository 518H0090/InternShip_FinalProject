using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class seedDataForCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 113, 160, 2, 222, 64, 106, 87, 23, 132, 236, 143, 180, 22, 164, 165, 156, 211, 135, 164, 57, 15, 171, 34, 161, 72, 174, 91, 37, 84, 52, 186, 224, 174, 181, 62, 14, 9, 110, 171, 246, 193, 25, 100, 188, 37, 45, 141, 126, 62, 101, 107, 40, 145, 6, 146, 9, 130, 69, 10, 73, 31, 20, 226 }, new byte[] { 223, 125, 191, 19, 230, 240, 12, 163, 246, 218, 83, 142, 227, 116, 203, 91, 138, 147, 225, 8, 252, 90, 192, 65, 237, 156, 70, 180, 245, 221, 118, 10, 26, 0, 129, 243, 217, 143, 116, 174, 223, 42, 177, 90, 250, 132, 0, 240, 72, 202, 194, 72, 19, 171, 152, 161, 126, 254, 13, 85, 148, 54, 18, 154, 54, 104, 204, 211, 117, 243, 81, 214, 85, 159, 145, 110, 110, 95, 83, 52, 189, 228, 201, 176, 246, 194, 222, 15, 92, 48, 26, 255, 183, 250, 142, 103, 51, 89, 77, 174, 250, 224, 182, 69, 192, 150, 243, 35, 117, 140, 240, 113, 70, 84, 223, 39, 27, 146, 51, 83, 63, 91, 247, 9, 76, 249, 90, 112 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 16, 119, 67, 81, 207, 11, 171, 221, 9, 241, 160, 57, 152, 51, 192, 60, 112, 148, 18, 199, 175, 69, 116, 66, 25, 252, 99, 13, 238, 114, 5, 74, 43, 106, 63, 138, 101, 111, 43, 8, 105, 78, 83, 170, 217, 166, 118, 235, 11, 48, 170, 3, 21, 28, 169, 28, 15, 120, 137, 224, 162, 19, 241 }, new byte[] { 85, 98, 213, 123, 191, 245, 214, 84, 190, 155, 206, 2, 172, 75, 147, 43, 82, 201, 228, 227, 108, 18, 106, 96, 215, 47, 203, 226, 117, 128, 210, 125, 121, 13, 237, 109, 17, 119, 133, 73, 51, 127, 46, 212, 250, 237, 25, 175, 30, 53, 206, 143, 231, 18, 235, 179, 177, 144, 50, 134, 154, 244, 161, 39, 49, 14, 190, 227, 6, 201, 216, 253, 175, 76, 104, 195, 131, 23, 154, 106, 255, 180, 239, 128, 193, 223, 244, 32, 172, 150, 98, 76, 164, 132, 120, 221, 75, 211, 241, 112, 53, 16, 84, 78, 153, 191, 48, 3, 16, 89, 176, 186, 99, 244, 61, 33, 1, 199, 67, 51, 191, 85, 140, 62, 2, 237, 244, 176 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 101, 168, 148, 1, 217, 169, 159, 2, 226, 143, 41, 248, 164, 58, 12, 81, 17, 227, 180, 85, 40, 217, 201, 202, 201, 205, 245, 228, 156, 193, 45, 164, 45, 248, 247, 241, 43, 220, 98, 236, 120, 94, 21, 25, 36, 14, 233, 171, 125, 173, 69, 31, 151, 151, 147, 239, 202, 206, 132, 131, 187, 208, 70, 208 }, new byte[] { 43, 218, 55, 234, 81, 18, 136, 15, 33, 4, 1, 75, 142, 64, 95, 79, 119, 167, 161, 156, 93, 195, 88, 73, 56, 180, 140, 42, 239, 196, 230, 248, 238, 147, 40, 73, 1, 111, 88, 229, 138, 129, 59, 99, 217, 121, 14, 237, 217, 99, 131, 24, 44, 138, 39, 192, 232, 129, 177, 37, 213, 99, 243, 24, 33, 141, 166, 13, 57, 246, 54, 106, 40, 41, 42, 135, 155, 59, 166, 182, 85, 164, 233, 125, 9, 112, 155, 156, 61, 123, 94, 242, 124, 192, 192, 84, 231, 174, 120, 233, 49, 76, 30, 43, 24, 129, 213, 71, 74, 5, 16, 233, 188, 93, 205, 159, 47, 142, 8, 111, 113, 12, 145, 7, 226, 143, 174, 152 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 134, 166, 46, 40, 6, 215, 248, 20, 69, 185, 180, 60, 8, 26, 186, 197, 149, 103, 136, 137, 157, 159, 74, 158, 99, 174, 226, 172, 131, 140, 135, 246, 46, 51, 170, 124, 81, 228, 92, 151, 45, 82, 5, 153, 234, 188, 211, 19, 49, 176, 21, 127, 125, 221, 237, 174, 225, 93, 60, 202, 135, 233, 53 }, new byte[] { 11, 3, 5, 65, 102, 67, 243, 54, 76, 197, 94, 15, 51, 196, 50, 211, 254, 85, 68, 61, 210, 52, 234, 235, 182, 172, 148, 4, 219, 212, 3, 91, 16, 108, 224, 60, 20, 215, 166, 208, 158, 63, 49, 228, 156, 103, 98, 79, 142, 99, 224, 112, 47, 175, 57, 248, 203, 77, 177, 238, 22, 49, 151, 154, 134, 237, 71, 19, 95, 252, 88, 231, 205, 77, 229, 28, 119, 14, 203, 119, 116, 133, 31, 188, 111, 131, 17, 180, 104, 146, 74, 24, 138, 239, 62, 28, 135, 79, 6, 29, 72, 208, 227, 234, 250, 6, 127, 225, 18, 164, 150, 255, 144, 124, 15, 152, 154, 158, 199, 100, 10, 84, 167, 31, 133, 144, 187, 231 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 54);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 125, 84, 195, 138, 13, 25, 17, 237, 190, 195, 173, 106, 183, 251, 191, 148, 250, 223, 187, 38, 234, 212, 157, 51, 147, 145, 18, 45, 26, 32, 249, 128, 6, 113, 28, 97, 104, 106, 192, 57, 13, 181, 173, 32, 69, 146, 41, 109, 51, 83, 10, 203, 112, 102, 204, 81, 218, 201, 55, 222, 138, 149, 130 }, new byte[] { 101, 201, 12, 242, 118, 29, 218, 122, 158, 165, 6, 237, 24, 61, 31, 179, 234, 90, 81, 165, 89, 168, 173, 166, 186, 4, 169, 201, 254, 223, 1, 196, 46, 45, 132, 196, 150, 44, 100, 11, 16, 7, 4, 31, 244, 103, 204, 255, 51, 173, 11, 180, 195, 3, 76, 86, 116, 166, 219, 36, 20, 146, 83, 219, 24, 231, 70, 91, 173, 238, 92, 194, 68, 58, 126, 50, 195, 170, 233, 39, 146, 106, 143, 219, 130, 56, 254, 135, 161, 214, 101, 91, 95, 191, 88, 208, 175, 100, 226, 167, 132, 64, 21, 44, 40, 180, 79, 108, 240, 250, 157, 172, 93, 234, 218, 214, 51, 4, 66, 14, 34, 128, 58, 0, 170, 65, 8, 101 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 3, 65, 207, 176, 40, 51, 255, 37, 220, 121, 153, 157, 50, 187, 95, 118, 58, 51, 133, 206, 253, 188, 15, 247, 12, 27, 200, 253, 129, 70, 3, 89, 84, 191, 90, 117, 254, 127, 128, 221, 221, 88, 116, 200, 35, 208, 180, 56, 166, 49, 133, 222, 39, 207, 204, 128, 119, 79, 93, 30, 250, 157, 30, 239 }, new byte[] { 167, 107, 18, 116, 45, 105, 253, 73, 34, 127, 34, 94, 209, 251, 252, 251, 165, 167, 137, 235, 158, 190, 59, 7, 109, 27, 7, 73, 134, 172, 134, 117, 42, 22, 16, 141, 236, 40, 130, 188, 29, 62, 201, 191, 131, 41, 161, 245, 72, 215, 193, 128, 5, 202, 231, 118, 139, 55, 107, 247, 108, 192, 11, 39, 111, 131, 198, 48, 249, 75, 142, 53, 155, 65, 54, 150, 109, 155, 252, 54, 233, 87, 210, 238, 160, 124, 25, 41, 178, 237, 86, 98, 234, 240, 230, 225, 148, 141, 183, 18, 179, 207, 160, 147, 205, 136, 187, 87, 15, 60, 25, 90, 111, 98, 11, 49, 68, 134, 218, 14, 167, 161, 218, 58, 26, 131, 231, 116 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 50, 139, 135, 157, 48, 4, 157, 182, 94, 67, 10, 24, 78, 25, 43, 87, 162, 226, 143, 217, 194, 2, 2, 141, 111, 176, 26, 236, 74, 54, 125, 252, 196, 183, 142, 97, 51, 75, 216, 123, 245, 14, 200, 250, 80, 12, 10, 100, 43, 254, 133, 176, 29, 67, 40, 13, 131, 229, 184, 185, 43, 215, 162 }, new byte[] { 7, 24, 244, 172, 215, 3, 247, 241, 34, 110, 126, 84, 158, 80, 223, 134, 150, 68, 222, 181, 83, 174, 234, 4, 100, 22, 26, 246, 120, 216, 203, 71, 174, 218, 19, 221, 38, 17, 211, 54, 213, 130, 232, 199, 188, 67, 54, 21, 121, 232, 230, 18, 133, 58, 110, 250, 221, 28, 42, 180, 228, 252, 200, 228, 123, 201, 108, 31, 31, 7, 154, 225, 55, 135, 26, 165, 98, 113, 135, 7, 38, 222, 136, 125, 24, 219, 86, 88, 125, 152, 93, 225, 170, 84, 165, 177, 223, 47, 125, 64, 192, 42, 193, 119, 222, 24, 155, 71, 78, 70, 157, 55, 6, 46, 232, 107, 144, 202, 249, 221, 13, 235, 73, 171, 92, 240, 123, 137 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 63, 223, 192, 157, 208, 47, 135, 197, 100, 171, 39, 108, 197, 167, 98, 182, 60, 177, 183, 37, 219, 113, 135, 40, 111, 28, 230, 162, 34, 145, 224, 116, 1, 60, 172, 178, 135, 93, 218, 225, 155, 228, 154, 232, 74, 36, 237, 224, 130, 43, 153, 215, 122, 248, 222, 228, 27, 7, 133, 91, 7, 108, 80 }, new byte[] { 84, 75, 142, 132, 18, 227, 192, 138, 225, 186, 206, 73, 189, 241, 106, 15, 234, 159, 106, 178, 238, 247, 191, 150, 247, 72, 206, 214, 223, 173, 228, 147, 133, 203, 181, 82, 212, 255, 92, 190, 240, 72, 79, 32, 252, 139, 241, 198, 179, 48, 18, 150, 13, 196, 68, 214, 83, 106, 34, 216, 86, 216, 74, 179, 229, 150, 70, 16, 93, 246, 3, 138, 255, 206, 70, 59, 118, 202, 121, 3, 244, 109, 98, 122, 211, 193, 162, 167, 17, 176, 243, 184, 163, 239, 217, 26, 162, 198, 24, 12, 25, 66, 90, 108, 235, 119, 89, 59, 240, 207, 87, 249, 82, 219, 169, 239, 144, 175, 22, 176, 118, 171, 87, 117, 225, 113, 13, 197 } });
        }
    }
}