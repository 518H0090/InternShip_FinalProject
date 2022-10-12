using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class seedfoodres6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
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
                    { 108, "", "./ImageForSeedData/Food/Restaurant6/food105.jpeg", 29000, 26100f, "Hồng trà chanh", 6 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 108);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 244, 89, 241, 167, 49, 22, 112, 45, 140, 144, 70, 224, 119, 115, 117, 228, 6, 103, 65, 22, 16, 89, 139, 16, 29, 15, 73, 165, 6, 183, 204, 11, 246, 18, 215, 8, 99, 220, 79, 203, 33, 124, 231, 64, 203, 89, 83, 129, 189, 96, 83, 186, 239, 12, 83, 138, 78, 198, 85, 63, 185, 52, 25 }, new byte[] { 100, 118, 196, 1, 229, 239, 108, 140, 136, 46, 101, 135, 208, 31, 197, 186, 91, 241, 255, 144, 234, 182, 243, 131, 128, 214, 161, 116, 194, 104, 20, 232, 162, 205, 133, 206, 185, 32, 235, 215, 25, 120, 100, 68, 168, 248, 199, 105, 52, 41, 179, 72, 86, 85, 217, 43, 239, 209, 130, 174, 16, 91, 236, 100, 209, 190, 126, 246, 93, 238, 158, 142, 255, 134, 92, 124, 178, 194, 221, 20, 73, 245, 84, 50, 182, 218, 30, 60, 36, 18, 98, 89, 99, 55, 19, 58, 50, 44, 66, 146, 177, 254, 144, 177, 77, 102, 231, 161, 248, 37, 231, 250, 169, 123, 56, 168, 213, 69, 153, 204, 177, 145, 139, 25, 23, 103, 56, 239 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 90, 241, 87, 42, 238, 127, 22, 81, 237, 234, 29, 36, 7, 86, 157, 147, 198, 147, 101, 2, 218, 175, 231, 60, 4, 156, 27, 224, 99, 136, 138, 96, 202, 61, 19, 30, 36, 83, 216, 157, 228, 125, 68, 114, 106, 189, 17, 146, 32, 33, 202, 116, 223, 79, 30, 72, 24, 59, 38, 25, 172, 227, 217 }, new byte[] { 44, 31, 86, 28, 169, 178, 250, 60, 195, 110, 47, 237, 190, 246, 14, 227, 159, 190, 216, 229, 180, 31, 161, 31, 16, 60, 197, 111, 120, 77, 149, 61, 229, 111, 92, 178, 166, 63, 37, 127, 94, 154, 134, 205, 149, 152, 182, 233, 154, 63, 218, 85, 100, 147, 6, 121, 184, 58, 215, 207, 3, 168, 165, 50, 94, 202, 54, 212, 121, 111, 75, 131, 229, 208, 227, 48, 65, 184, 250, 80, 164, 26, 188, 203, 102, 98, 211, 228, 161, 255, 170, 32, 215, 113, 90, 6, 238, 141, 134, 203, 106, 38, 200, 217, 79, 193, 143, 76, 57, 167, 110, 52, 72, 207, 14, 139, 155, 252, 100, 232, 147, 245, 128, 196, 114, 215, 214, 168 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 150, 97, 228, 219, 236, 235, 35, 206, 172, 66, 38, 203, 140, 36, 16, 139, 235, 214, 85, 89, 184, 235, 246, 186, 42, 72, 106, 224, 188, 178, 120, 238, 120, 107, 123, 49, 176, 223, 138, 70, 121, 141, 178, 164, 44, 50, 108, 242, 234, 174, 176, 128, 119, 155, 83, 158, 184, 104, 200, 248, 195, 187, 66, 56 }, new byte[] { 213, 202, 38, 236, 129, 170, 134, 134, 100, 166, 148, 152, 32, 11, 79, 48, 16, 201, 253, 232, 85, 187, 167, 185, 153, 204, 18, 120, 178, 231, 246, 180, 38, 217, 141, 1, 147, 52, 215, 85, 255, 199, 171, 171, 137, 207, 117, 252, 143, 163, 58, 80, 147, 200, 235, 104, 108, 186, 75, 36, 129, 19, 194, 146, 223, 69, 172, 43, 77, 93, 141, 209, 68, 138, 252, 182, 162, 17, 25, 239, 76, 90, 187, 9, 211, 155, 121, 201, 206, 102, 99, 193, 14, 5, 103, 61, 31, 45, 210, 20, 78, 220, 243, 242, 252, 206, 98, 116, 127, 53, 104, 52, 239, 210, 128, 92, 16, 185, 246, 236, 14, 45, 179, 206, 194, 219, 124, 205 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 27, 205, 236, 49, 110, 82, 148, 83, 86, 251, 86, 45, 232, 182, 44, 169, 185, 168, 237, 85, 179, 118, 79, 177, 81, 176, 33, 173, 209, 116, 183, 97, 76, 18, 142, 47, 188, 79, 47, 78, 76, 205, 14, 0, 110, 29, 81, 70, 145, 38, 87, 238, 118, 127, 214, 27, 154, 81, 44, 14, 249, 64, 219 }, new byte[] { 107, 163, 89, 33, 206, 203, 57, 245, 190, 221, 74, 174, 80, 180, 80, 233, 22, 15, 172, 164, 29, 239, 214, 149, 234, 118, 152, 56, 248, 135, 172, 248, 98, 3, 96, 7, 171, 174, 41, 129, 47, 145, 92, 185, 80, 250, 139, 133, 83, 118, 211, 145, 190, 132, 197, 123, 129, 221, 38, 81, 12, 22, 33, 102, 45, 16, 84, 137, 186, 243, 99, 216, 106, 50, 48, 133, 168, 165, 104, 120, 206, 133, 241, 49, 118, 102, 65, 158, 97, 218, 238, 55, 113, 233, 231, 97, 27, 32, 41, 177, 90, 196, 186, 53, 101, 56, 71, 101, 15, 41, 162, 49, 140, 34, 224, 103, 244, 143, 177, 254, 18, 15, 39, 38, 202, 221, 150, 100 } });
        }
    }
}
