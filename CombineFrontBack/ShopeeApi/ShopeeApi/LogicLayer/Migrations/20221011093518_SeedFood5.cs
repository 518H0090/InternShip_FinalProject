using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class SeedFood5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodDescription", "FoodImageUrl", "FoodPrice", "FoodPriceLess", "FoodTitle", "RestaurantId" },
                values: new object[,]
                {
                    { 71, "Trà sữa, trân châu, bánh flan size L", "./ImageForSeedData/Food/Restaurant5/food71.jpeg", 32000, 25600f, "Combo 3", 5 },
                    { 72, "Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L", "./ImageForSeedData/Food/Restaurant5/food72.jpeg", 24000, 19200f, "Trà sữa + 1 topping (trân châu/sương sáo/thạch dẻo) size L", 5 },
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
                    { 90, "", "./ImageForSeedData/Food/Restaurant5/food90.jpeg", 48000, 38400f, "Trà sữa + Trà sữa socola", 5 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 90);

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
    }
}