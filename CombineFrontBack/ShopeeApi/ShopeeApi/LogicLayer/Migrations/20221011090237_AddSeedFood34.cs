using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class AddSeedFood34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 70, "1 hủ", "./ImageForSeedData/Food/Restaurant4/food70.jpeg", 90000, 81000f, "Tương ớt hội an", 4 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 3, 150, 211, 217, 204, 215, 5, 126, 27, 226, 237, 164, 180, 146, 232, 75, 36, 82, 205, 205, 114, 40, 226, 63, 80, 96, 127, 73, 148, 19, 32, 82, 86, 99, 23, 167, 15, 220, 134, 121, 231, 246, 242, 187, 202, 29, 13, 14, 29, 39, 156, 153, 164, 4, 216, 198, 40, 196, 239, 116, 76, 176, 212, 75 }, new byte[] { 76, 177, 179, 204, 76, 78, 75, 200, 168, 61, 98, 98, 9, 209, 203, 186, 127, 135, 16, 13, 220, 220, 32, 14, 143, 232, 248, 139, 38, 67, 239, 39, 148, 98, 156, 169, 104, 148, 229, 211, 116, 53, 92, 154, 38, 166, 7, 97, 116, 216, 46, 178, 80, 110, 130, 95, 223, 50, 146, 100, 207, 51, 87, 101, 51, 78, 225, 74, 167, 119, 43, 97, 194, 44, 190, 227, 208, 153, 27, 241, 100, 235, 221, 11, 161, 153, 179, 47, 78, 77, 238, 189, 186, 234, 34, 83, 138, 46, 146, 236, 84, 90, 90, 187, 3, 228, 199, 203, 154, 208, 56, 68, 11, 91, 99, 101, 173, 23, 38, 152, 65, 180, 173, 147, 126, 138, 14, 244 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 169, 186, 67, 85, 90, 224, 85, 249, 125, 162, 60, 230, 166, 59, 132, 111, 89, 45, 28, 157, 205, 89, 22, 199, 30, 148, 129, 134, 105, 198, 15, 111, 49, 206, 187, 179, 67, 85, 194, 4, 126, 54, 223, 113, 201, 55, 186, 254, 254, 125, 41, 228, 252, 135, 125, 90, 149, 199, 221, 98, 131, 242, 137 }, new byte[] { 44, 184, 88, 218, 39, 121, 224, 204, 168, 29, 24, 112, 172, 100, 5, 174, 12, 251, 103, 151, 143, 150, 70, 52, 195, 239, 176, 127, 226, 237, 83, 204, 143, 32, 97, 142, 209, 244, 36, 97, 199, 189, 143, 145, 11, 66, 160, 30, 35, 195, 208, 167, 206, 216, 66, 245, 113, 239, 234, 17, 42, 69, 198, 206, 144, 122, 247, 126, 134, 206, 28, 198, 29, 45, 155, 123, 141, 112, 209, 20, 189, 165, 160, 37, 9, 21, 237, 96, 60, 101, 242, 251, 193, 144, 65, 198, 33, 101, 244, 136, 76, 89, 140, 142, 43, 27, 44, 252, 50, 229, 134, 154, 10, 16, 208, 250, 29, 209, 97, 70, 47, 181, 168, 61, 98, 64, 194, 71 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 39, 35, 110, 204, 172, 184, 206, 233, 37, 28, 253, 47, 201, 188, 197, 187, 31, 240, 38, 145, 10, 253, 38, 214, 169, 62, 149, 220, 6, 81, 83, 210, 219, 104, 201, 6, 156, 91, 69, 251, 102, 149, 171, 144, 235, 204, 81, 67, 75, 126, 44, 97, 207, 100, 210, 241, 102, 158, 253, 223, 10, 62, 28 }, new byte[] { 127, 11, 56, 187, 25, 5, 130, 210, 152, 222, 144, 54, 26, 15, 231, 231, 172, 27, 38, 35, 49, 101, 90, 240, 70, 19, 194, 223, 185, 49, 45, 73, 20, 3, 86, 126, 195, 96, 192, 104, 247, 155, 7, 62, 28, 211, 238, 2, 37, 94, 250, 173, 232, 46, 231, 118, 135, 235, 240, 148, 149, 218, 100, 136, 58, 170, 173, 52, 153, 210, 221, 129, 214, 189, 153, 142, 2, 229, 96, 183, 193, 217, 120, 134, 190, 198, 234, 170, 59, 117, 243, 109, 102, 14, 112, 218, 221, 188, 206, 193, 46, 90, 98, 113, 213, 99, 250, 40, 147, 45, 216, 150, 245, 136, 229, 80, 252, 66, 214, 51, 176, 244, 60, 48, 173, 77, 201, 238 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 249, 154, 224, 4, 71, 166, 150, 46, 129, 85, 177, 118, 117, 58, 14, 153, 100, 113, 198, 52, 96, 248, 101, 6, 34, 2, 253, 4, 143, 175, 41, 216, 177, 116, 154, 159, 214, 214, 23, 122, 32, 100, 37, 126, 48, 138, 11, 34, 111, 231, 25, 85, 99, 213, 222, 169, 155, 30, 151, 202, 137, 51, 102 }, new byte[] { 214, 61, 151, 247, 67, 71, 210, 100, 45, 212, 149, 207, 252, 8, 214, 95, 191, 11, 118, 22, 188, 162, 111, 246, 152, 154, 133, 83, 90, 92, 235, 221, 202, 240, 250, 193, 0, 69, 30, 112, 36, 31, 112, 57, 70, 39, 148, 146, 230, 107, 168, 230, 100, 204, 99, 43, 102, 61, 15, 37, 110, 120, 56, 1, 163, 65, 197, 162, 110, 179, 101, 181, 160, 101, 255, 4, 23, 37, 250, 225, 183, 182, 113, 231, 50, 116, 191, 158, 252, 247, 204, 230, 253, 58, 52, 10, 5, 220, 58, 123, 252, 76, 95, 49, 160, 170, 171, 198, 151, 25, 138, 151, 114, 225, 232, 44, 40, 60, 172, 172, 35, 108, 124, 230, 175, 47, 190, 22 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 70);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 120, 86, 104, 9, 108, 249, 146, 54, 159, 86, 56, 115, 199, 181, 98, 213, 15, 88, 71, 98, 164, 60, 255, 173, 35, 252, 210, 102, 202, 188, 227, 92, 150, 73, 102, 143, 49, 97, 174, 183, 190, 165, 140, 164, 100, 84, 112, 109, 166, 121, 77, 110, 213, 18, 103, 17, 59, 83, 136, 45, 114, 17, 77, 181 }, new byte[] { 190, 134, 222, 235, 131, 75, 50, 109, 214, 219, 34, 30, 73, 95, 197, 44, 9, 149, 145, 106, 233, 104, 16, 216, 133, 31, 68, 219, 7, 82, 62, 87, 156, 255, 179, 209, 168, 141, 170, 81, 100, 222, 205, 178, 195, 166, 19, 254, 50, 31, 51, 247, 32, 24, 98, 131, 94, 19, 214, 185, 133, 63, 188, 43, 184, 122, 235, 58, 29, 63, 238, 197, 91, 25, 127, 58, 88, 129, 233, 178, 191, 200, 206, 220, 182, 165, 46, 180, 232, 14, 254, 211, 179, 185, 206, 116, 233, 147, 37, 222, 53, 132, 230, 236, 120, 247, 215, 167, 95, 25, 219, 237, 209, 116, 121, 179, 219, 2, 250, 231, 108, 160, 84, 5, 122, 208, 220, 91 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 182, 4, 130, 68, 255, 109, 209, 204, 187, 252, 109, 141, 49, 201, 166, 140, 48, 11, 115, 162, 212, 127, 162, 196, 194, 243, 116, 24, 155, 158, 247, 114, 62, 191, 214, 238, 235, 230, 43, 115, 237, 183, 188, 44, 231, 102, 163, 84, 244, 161, 43, 105, 44, 90, 120, 84, 129, 103, 122, 167, 178, 176, 233, 242 }, new byte[] { 172, 159, 243, 123, 67, 104, 85, 234, 235, 146, 13, 32, 148, 229, 25, 4, 155, 207, 130, 171, 3, 211, 85, 99, 172, 147, 110, 188, 60, 8, 127, 144, 85, 162, 132, 101, 253, 104, 106, 141, 12, 231, 156, 196, 60, 197, 173, 89, 36, 133, 68, 118, 38, 7, 55, 196, 95, 173, 43, 20, 4, 14, 27, 82, 1, 92, 201, 131, 96, 209, 158, 227, 116, 51, 182, 186, 169, 180, 23, 40, 235, 247, 235, 23, 31, 33, 51, 2, 58, 63, 187, 65, 68, 102, 88, 200, 236, 106, 146, 81, 73, 29, 86, 217, 181, 28, 3, 109, 31, 77, 174, 216, 233, 223, 85, 90, 251, 65, 124, 255, 144, 157, 188, 141, 93, 60, 69, 35 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 59, 185, 154, 193, 87, 126, 32, 202, 183, 255, 253, 154, 191, 53, 238, 46, 135, 103, 82, 237, 155, 6, 63, 255, 114, 234, 57, 240, 144, 172, 73, 169, 54, 199, 37, 34, 253, 205, 254, 86, 190, 231, 159, 66, 213, 245, 41, 84, 73, 177, 15, 148, 64, 178, 44, 160, 152, 109, 40, 36, 196, 39, 248 }, new byte[] { 18, 106, 176, 168, 91, 250, 7, 134, 237, 210, 108, 51, 191, 74, 87, 5, 193, 64, 167, 37, 91, 255, 67, 103, 86, 54, 36, 62, 114, 67, 168, 214, 64, 248, 89, 237, 192, 120, 38, 117, 235, 91, 144, 28, 226, 175, 38, 5, 193, 6, 105, 140, 192, 98, 55, 26, 134, 127, 193, 253, 20, 86, 192, 32, 82, 44, 106, 83, 84, 116, 213, 108, 137, 67, 63, 123, 242, 244, 90, 125, 130, 209, 234, 197, 203, 56, 98, 150, 72, 143, 181, 162, 3, 57, 138, 215, 39, 12, 125, 125, 119, 173, 100, 176, 113, 170, 76, 194, 22, 155, 5, 41, 209, 44, 212, 152, 62, 215, 4, 146, 48, 55, 20, 208, 116, 207, 67, 97 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 2, 104, 223, 13, 253, 116, 155, 122, 133, 168, 90, 83, 109, 79, 194, 230, 161, 47, 240, 56, 36, 69, 124, 168, 232, 42, 93, 179, 31, 62, 219, 74, 111, 188, 223, 69, 24, 115, 212, 172, 80, 166, 184, 177, 154, 153, 110, 113, 17, 83, 37, 166, 135, 202, 211, 184, 189, 181, 28, 159, 180, 111, 111, 218 }, new byte[] { 212, 156, 69, 0, 149, 220, 169, 239, 45, 103, 114, 101, 99, 25, 102, 217, 240, 250, 16, 111, 207, 72, 104, 11, 118, 31, 146, 68, 173, 251, 137, 67, 129, 100, 150, 195, 209, 197, 0, 138, 87, 250, 237, 232, 214, 131, 16, 105, 78, 210, 42, 156, 244, 92, 135, 63, 209, 35, 104, 20, 165, 110, 219, 175, 118, 164, 86, 52, 217, 56, 105, 247, 224, 167, 177, 123, 197, 25, 33, 202, 113, 27, 33, 195, 214, 123, 158, 246, 222, 247, 233, 60, 116, 207, 110, 87, 167, 145, 60, 155, 57, 162, 106, 230, 46, 121, 109, 101, 218, 212, 44, 24, 79, 99, 186, 13, 248, 73, 240, 182, 193, 89, 51, 178, 152, 41, 139, 80 } });
        }
    }
}