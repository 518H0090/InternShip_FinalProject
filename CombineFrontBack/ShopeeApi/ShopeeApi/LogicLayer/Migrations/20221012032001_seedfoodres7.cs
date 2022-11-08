using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class seedfoodres7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 109, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food109.jpeg", 22000, 11000f, "Bánh bò nướng (hộp 1 lát lớn)", 6 },
                    { 110, "Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa", "./ImageForSeedData/Food/Restaurant7/food110.jpeg", 45000, 40500f, "Rau câu sơn thủy hộp nhỏ (350g)", 6 },
                    { 111, "Gồm: nước cốt dừa tươi, đường thốt nốt, trứng gà tươi, bột", "./ImageForSeedData/Food/Restaurant7/food111.jpeg", 35000, 31500f, "Hộp 2 lát bánh bò nhỏ", 6 },
                    { 112, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food112.jpeg", 110000, 99000f, "Bánh bò nhỏ (550g)", 6 },
                    { 113, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food113.jpeg", 170000, 153000f, "Bánh bò lớn (900g)", 6 },
                    { 114, "Bánh bò nướng đường thốt nốt", "./ImageForSeedData/Food/Restaurant7/food114.jpeg", 60000, 54000f, "Hộp 4 lát bánh bò nhỏ", 6 },
                    { 115, "Bánh da lợn có thành phần chính từ lá cẩm khoai môn", "./ImageForSeedData/Food/Restaurant7/food115.jpeg", 60000, 54000f, "Da lợn cuộn 2 vị hộp 6 khoanh", 6 },
                    { 116, "Bánh da lợn có thành phần chính từ lá cẩm khoai môn", "./ImageForSeedData/Food/Restaurant7/food116.jpeg", 75000, 67500f, "Da lợn cuộn 2 vị hộp 8 khoanh", 6 },
                    { 117, "Bánh da lợn có thành phần chính từ lá dứa, đậu xanh", "./ImageForSeedData/Food/Restaurant7/food117.jpeg", 60000, 54000f, "Da lợn cuộn Đậu xanh lá dứa hộp 6 khoanh", 6 },
                    { 118, "Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp", "./ImageForSeedData/Food/Restaurant7/food118.jpeg", 95000, 85500f, "Flan cheese Cà phê hộp nhỏ (600g)", 6 },
                    { 119, "Rau câu dẻo, lớp rau câu cà phê và flan phô mai xen kẽ nhau tạo thành từng lớp", "./ImageForSeedData/Food/Restaurant7/food119.jpeg", 140000, 126000f, "Flan cheese Cà phê hộp lớn (900g)", 6 },
                    { 120, "Rau câu sơn thủy, bao gồm nhiều vị trong cùng một miếng rau câu: cốt dừa, cà phê, rau câu, lá dứa", "./ImageForSeedData/Food/Restaurant7/food120.jpeg", 75000, 67500f, "Rau câu sơn thủy hộp lớn (600g)", 6 },
                    { 121, "Rau câu dẻo được làm từ nước cốt và nước dừa tươi", "./ImageForSeedData/Food/Restaurant7/food121.jpeg", 85000, 76500f, "Rau câu dừa hộp nhỏ (600g)", 6 },
                    { 122, "", "./ImageForSeedData/Food/Restaurant7/food122.jpeg", 95000, 85500f, "Hộp kem Nhãn nhỏ 250g", 6 },
                    { 123, "Hình ảnh mang tính chất minh họa", "./ImageForSeedData/Food/Restaurant7/food123.jpeg", 195000, 175500f, "Combo B: 1 Bánh bò nhỏ (550g) + Hộp kem dừa 250gr", 6 },
                    { 124, "", "./ImageForSeedData/Food/Restaurant7/food124.jpeg", 22000, 19800f, "Yoghurt", 6 },
                    { 125, "", "./ImageForSeedData/Food/Restaurant7/food125.jpeg", 22000, 19800f, "Bánh Flan Vị Truyền Thống", 6 },
                    { 126, "Chè bưởi kèm cốt dừa chan", "./ImageForSeedData/Food/Restaurant7/food126.jpeg", 35000, 31500f, "Chè Bưởi (Đường Thốt Nốt) 200g☘", 6 },
                    { 127, "50ml cốt dừa (lạnh)", "./ImageForSeedData/Food/Restaurant7/food127.jpeg", 6000, 5400f, "Cốt dừa chén nhỏ 50ml (lạnh)", 6 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 24, 186, 213, 132, 104, 130, 122, 85, 107, 84, 241, 18, 41, 236, 240, 15, 71, 8, 45, 129, 191, 6, 32, 66, 53, 141, 231, 126, 119, 210, 119, 191, 63, 13, 195, 240, 182, 151, 201, 107, 161, 149, 81, 101, 206, 156, 206, 23, 122, 93, 172, 246, 194, 176, 188, 246, 51, 255, 197, 181, 209, 214, 97 }, new byte[] { 145, 16, 121, 93, 242, 42, 191, 207, 225, 65, 214, 92, 29, 166, 149, 6, 164, 243, 120, 175, 40, 13, 123, 175, 159, 103, 12, 45, 47, 55, 209, 239, 246, 171, 165, 246, 33, 157, 133, 177, 191, 157, 95, 240, 185, 104, 246, 167, 167, 210, 20, 143, 134, 144, 218, 128, 60, 154, 183, 28, 5, 244, 91, 94, 94, 153, 90, 85, 122, 3, 204, 48, 213, 178, 147, 21, 117, 247, 149, 23, 221, 51, 120, 161, 230, 245, 219, 36, 29, 226, 47, 36, 85, 42, 182, 13, 216, 14, 134, 120, 14, 152, 243, 131, 89, 199, 132, 75, 179, 237, 59, 213, 119, 127, 46, 106, 11, 246, 95, 219, 41, 221, 196, 29, 18, 84, 6, 184 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 211, 101, 143, 207, 242, 212, 248, 49, 6, 148, 134, 75, 249, 117, 162, 96, 3, 96, 81, 235, 108, 97, 35, 93, 81, 12, 94, 202, 121, 0, 242, 246, 144, 14, 189, 11, 26, 42, 203, 227, 89, 90, 195, 55, 38, 226, 25, 112, 174, 231, 120, 190, 215, 106, 164, 242, 115, 156, 166, 62, 255, 183, 29 }, new byte[] { 147, 172, 58, 109, 136, 176, 55, 31, 236, 234, 62, 147, 238, 17, 111, 57, 161, 118, 154, 108, 14, 91, 43, 71, 241, 1, 192, 121, 237, 107, 128, 133, 100, 41, 93, 152, 145, 107, 125, 141, 219, 20, 170, 5, 105, 105, 207, 200, 171, 49, 168, 93, 3, 119, 39, 250, 45, 122, 174, 231, 246, 60, 182, 228, 195, 136, 218, 171, 0, 68, 3, 216, 164, 161, 9, 183, 189, 112, 197, 176, 154, 54, 148, 114, 174, 165, 178, 119, 233, 94, 34, 168, 205, 108, 167, 170, 116, 99, 45, 18, 131, 30, 80, 181, 217, 112, 31, 5, 191, 167, 67, 78, 253, 167, 243, 112, 120, 144, 203, 168, 50, 86, 42, 64, 158, 86, 117, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 218, 201, 88, 93, 59, 224, 62, 162, 64, 117, 59, 182, 88, 57, 74, 146, 198, 22, 228, 218, 223, 39, 253, 250, 188, 99, 28, 125, 215, 14, 114, 251, 169, 84, 127, 211, 67, 128, 52, 49, 96, 229, 129, 203, 3, 178, 49, 195, 141, 59, 179, 146, 152, 72, 204, 221, 232, 37, 229, 31, 147, 55, 156 }, new byte[] { 12, 86, 181, 75, 161, 3, 95, 121, 206, 149, 210, 181, 56, 99, 173, 107, 30, 228, 164, 14, 64, 208, 66, 249, 183, 107, 110, 39, 81, 184, 8, 213, 145, 84, 231, 226, 225, 205, 171, 156, 200, 88, 109, 99, 189, 252, 225, 62, 21, 16, 29, 206, 201, 218, 106, 56, 21, 125, 137, 101, 172, 186, 197, 196, 73, 196, 2, 218, 15, 232, 147, 219, 221, 191, 171, 237, 54, 165, 191, 227, 38, 111, 107, 131, 43, 48, 143, 213, 126, 56, 147, 60, 239, 213, 44, 11, 180, 134, 88, 209, 219, 27, 223, 196, 169, 224, 8, 185, 141, 176, 200, 246, 214, 131, 107, 6, 187, 212, 142, 233, 210, 83, 134, 191, 148, 233, 175, 240 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 82, 96, 43, 221, 214, 100, 215, 214, 63, 170, 228, 144, 202, 220, 20, 187, 72, 228, 117, 77, 9, 21, 204, 57, 90, 237, 45, 133, 97, 162, 157, 211, 152, 40, 80, 4, 235, 240, 195, 231, 129, 62, 60, 253, 35, 172, 138, 79, 17, 225, 8, 230, 177, 126, 201, 74, 204, 9, 60, 155, 176, 46, 97, 116 }, new byte[] { 195, 30, 199, 26, 109, 187, 78, 158, 44, 75, 95, 205, 3, 167, 23, 186, 227, 145, 117, 197, 240, 177, 247, 0, 138, 216, 173, 21, 223, 139, 236, 208, 243, 137, 224, 66, 137, 54, 252, 141, 159, 140, 151, 151, 112, 68, 3, 63, 88, 136, 201, 1, 217, 73, 183, 50, 21, 71, 62, 120, 251, 139, 187, 76, 250, 46, 45, 234, 242, 210, 74, 144, 232, 135, 73, 6, 147, 10, 236, 239, 136, 138, 212, 93, 63, 120, 73, 168, 114, 38, 84, 234, 48, 21, 181, 185, 43, 4, 210, 194, 247, 84, 156, 74, 254, 246, 37, 110, 109, 253, 46, 148, 111, 89, 172, 226, 251, 201, 57, 111, 13, 4, 11, 167, 151, 114, 97, 75 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 127);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 72, 148, 7, 15, 239, 165, 6, 84, 179, 194, 213, 112, 80, 235, 194, 197, 201, 231, 115, 133, 125, 103, 55, 57, 141, 11, 10, 238, 201, 206, 251, 188, 196, 46, 198, 176, 25, 78, 114, 159, 193, 135, 39, 93, 62, 59, 28, 59, 153, 90, 213, 44, 146, 209, 199, 166, 9, 93, 82, 241, 251, 161, 65 }, new byte[] { 249, 122, 100, 217, 92, 44, 45, 113, 189, 107, 88, 253, 156, 0, 77, 61, 37, 106, 253, 168, 103, 42, 67, 130, 115, 111, 139, 207, 243, 91, 52, 247, 54, 252, 174, 38, 112, 128, 32, 171, 135, 171, 113, 84, 57, 205, 144, 99, 167, 179, 156, 57, 171, 168, 69, 226, 12, 26, 219, 250, 207, 224, 146, 25, 164, 26, 200, 67, 41, 218, 41, 64, 95, 110, 241, 194, 69, 60, 19, 19, 113, 227, 99, 239, 202, 36, 140, 15, 6, 76, 196, 150, 31, 186, 172, 125, 19, 179, 145, 79, 136, 108, 79, 96, 217, 132, 237, 47, 49, 5, 140, 211, 82, 60, 140, 197, 254, 35, 72, 255, 26, 192, 54, 178, 46, 56, 150, 89 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 46, 169, 102, 59, 15, 235, 214, 134, 236, 222, 13, 17, 223, 129, 183, 83, 123, 226, 158, 162, 25, 179, 85, 45, 60, 98, 176, 170, 24, 228, 252, 43, 138, 57, 151, 223, 22, 10, 127, 224, 240, 95, 57, 173, 133, 202, 211, 176, 215, 67, 154, 208, 48, 156, 206, 82, 134, 99, 246, 195, 18, 215, 176 }, new byte[] { 34, 48, 39, 162, 34, 140, 13, 197, 70, 127, 108, 8, 15, 153, 205, 210, 129, 185, 199, 105, 216, 237, 67, 213, 200, 183, 129, 46, 40, 64, 211, 10, 55, 60, 111, 44, 49, 103, 137, 109, 233, 117, 90, 136, 127, 214, 216, 57, 119, 90, 56, 161, 216, 97, 116, 205, 107, 202, 65, 102, 253, 245, 212, 138, 171, 83, 30, 197, 59, 10, 162, 55, 3, 76, 75, 2, 214, 162, 192, 26, 226, 209, 159, 109, 221, 117, 118, 171, 245, 149, 172, 55, 254, 162, 150, 254, 205, 191, 3, 248, 183, 244, 15, 116, 0, 143, 24, 27, 141, 233, 81, 17, 114, 205, 144, 42, 49, 168, 10, 174, 164, 79, 49, 134, 158, 183, 235, 112 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 70, 5, 174, 232, 111, 78, 188, 187, 139, 78, 100, 72, 26, 171, 151, 13, 199, 31, 137, 112, 72, 173, 103, 22, 57, 132, 244, 131, 79, 197, 220, 50, 33, 198, 115, 159, 245, 59, 94, 16, 30, 93, 17, 245, 241, 156, 128, 190, 30, 160, 245, 10, 166, 216, 1, 118, 51, 14, 158, 95, 78, 75, 136, 128 }, new byte[] { 133, 242, 243, 26, 19, 176, 172, 33, 219, 213, 238, 226, 103, 132, 228, 71, 165, 104, 65, 142, 204, 65, 89, 12, 5, 178, 171, 209, 166, 250, 245, 43, 127, 38, 231, 9, 35, 248, 253, 87, 186, 243, 138, 8, 92, 100, 32, 184, 102, 85, 230, 100, 188, 110, 60, 52, 119, 74, 153, 224, 86, 52, 162, 251, 39, 128, 208, 55, 17, 235, 32, 12, 97, 124, 75, 24, 51, 228, 184, 208, 148, 236, 192, 246, 200, 117, 218, 202, 19, 55, 64, 239, 147, 69, 117, 125, 58, 80, 19, 45, 246, 132, 24, 144, 243, 196, 105, 91, 40, 12, 237, 156, 204, 67, 152, 116, 215, 42, 34, 44, 113, 226, 107, 129, 60, 223, 73, 174 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 34, 199, 77, 182, 89, 226, 244, 65, 223, 150, 143, 202, 205, 120, 198, 81, 225, 44, 188, 38, 128, 155, 98, 223, 48, 135, 237, 168, 44, 18, 39, 55, 171, 106, 116, 247, 48, 13, 111, 24, 222, 41, 105, 119, 101, 225, 67, 21, 16, 147, 226, 37, 20, 212, 251, 210, 249, 41, 181, 147, 136, 206, 85 }, new byte[] { 81, 155, 80, 97, 196, 32, 147, 140, 246, 164, 226, 2, 18, 9, 202, 176, 34, 243, 150, 196, 13, 107, 247, 5, 204, 99, 151, 223, 69, 188, 84, 150, 247, 21, 19, 115, 224, 60, 34, 154, 24, 255, 117, 176, 165, 10, 129, 69, 182, 71, 148, 70, 154, 19, 105, 31, 181, 53, 220, 158, 52, 160, 231, 187, 86, 119, 134, 192, 14, 175, 100, 233, 98, 137, 12, 53, 149, 69, 60, 31, 33, 18, 94, 221, 93, 60, 134, 100, 76, 45, 204, 20, 29, 152, 12, 88, 136, 45, 236, 15, 213, 85, 117, 70, 218, 200, 68, 134, 193, 218, 59, 86, 43, 156, 210, 195, 63, 94, 0, 111, 125, 41, 82, 177, 23, 219, 71, 228 } });
        }
    }
}