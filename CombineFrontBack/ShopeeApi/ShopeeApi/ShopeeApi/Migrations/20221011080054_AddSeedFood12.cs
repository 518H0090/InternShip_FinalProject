using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class AddSeedFood12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 4, "", "./ImageForSeedData/Food/Restaurant2/food4.jpeg", 50000, 30000f, "Trà sữa trân châu hoàng kim", 2 },
                    { 5, "", "./ImageForSeedData/Food/Restaurant2/food5.jpeg", 45000, 27000f, "Trà sữa Hongkong Royal", 2 },
                    { 6, "", "./ImageForSeedData/Food/Restaurant2/food6.jpeg", 45000, 27000f, "Trà sữa lúa mạch", 2 },
                    { 7, "", "./ImageForSeedData/Food/Restaurant2/food7.jpeg", 45000, 27000f, "Hồng trà sữa", 2 },
                    { 8, "", "./ImageForSeedData/Food/Restaurant2/food7.jpeg", 45000, 27000f, "Trà sữa hoa nhài", 2 },
                    { 9, "", "./ImageForSeedData/Food/Restaurant2/food7.jpeg", 45000, 27000f, "Trà sữa olong kim phượng", 2 },
                    { 10, "", "./ImageForSeedData/Food/Restaurant2/food7.jpeg", 45000, 27000f, "Trà sữa olong bạch đào", 2 },
                    { 11, "không chọn được mức đá", "./ImageForSeedData/Food/Restaurant2/food11.png", 50000, 30000f, "Sữa tươi trân châu hoàng kim", 2 },
                    { 12, "", "./ImageForSeedData/Food/Restaurant2/food11.png", 50000, 30000f, "Đường Đen Sầu Riêng", 2 },
                    { 13, "không thể để đá riêng", "./ImageForSeedData/Food/Restaurant2/food13.jpeg", 50000, 30000f, "Sữa tươi trân châu đường đen", 2 },
                    { 14, "", "./ImageForSeedData/Food/Restaurant2/food14.jpeg", 50000, 30000f, "Trà sữa trân châu đường đen", 2 },
                    { 15, "Size M", "./ImageForSeedData/Food/Restaurant2/food15.jpeg", 57000, 34200f, "Matcha đường đen", 2 },
                    { 16, "Thơm ngon", "./ImageForSeedData/Food/Restaurant2/food16.jpeg", 65000, 39000f, "Trà táo xanh kiwi", 2 },
                    { 17, "SizeM", "./ImageForSeedData/Food/Restaurant2/food17.jpeg", 69000, 41400f, "Matcha đường đen kem cheese", 2 },
                    { 18, "", "./ImageForSeedData/Food/Restaurant2/food11.png", 55000, 33000f, "Trà sữa khoai môn đường đen", 2 },
                    { 19, "", "./ImageForSeedData/Food/Restaurant2/food19.jpeg", 54000, 32400f, "Trà lúa mạch kem cheese", 2 },
                    { 20, "", "./ImageForSeedData/Food/Restaurant2/food20.jpeg", 54000, 32400f, "Hồng trà Royal kem cheese", 2 },
                    { 21, "", "./ImageForSeedData/Food/Restaurant2/food21.jpeg", 57000, 34200f, "Trà sương mù London kem cheese", 2 },
                    { 22, "", "./ImageForSeedData/Food/Restaurant2/food22.jpeg", 54000, 34200f, "Trà xanh Golden kem cheese", 2 },
                    { 23, "", "./ImageForSeedData/Food/Restaurant2/food23.jpeg", 54000, 32400f, "Trà ô long bạch đào kem cheese", 2 },
                    { 24, "", "./ImageForSeedData/Food/Restaurant2/food24.jpeg", 54000, 32400f, "Trà bách hoa kem cheese", 2 },
                    { 25, "", "./ImageForSeedData/Food/Restaurant2/food25.jpeg", 54000, 32400f, "Trà ô long mộc hoa kem cheese", 2 },
                    { 26, "", "./ImageForSeedData/Food/Restaurant2/food25.jpeg", 54000, 32400f, "Trà oolong Kim Phượng kem cheese", 2 },
                    { 27, "", "./ImageForSeedData/Food/Restaurant2/food27.jpeg", 59000, 35400f, "Trà sữa oreo cake cream", 2 },
                    { 28, "", "./ImageForSeedData/Food/Restaurant2/food28.jpeg", 55000, 33000f, "Trà sữa trân châu ngọc trai trắng", 2 },
                    { 29, "", "./ImageForSeedData/Food/Restaurant2/food29.jpeg", 55000, 33000f, "Trà sữa trân châu ngọc trai đen", 2 },
                    { 30, "", "./ImageForSeedData/Food/Restaurant2/food30.jpeg", 68000, 40800f, "Trà hoa quả Royaltea đặc biệt", 2 },
                    { 31, "", "./ImageForSeedData/Food/Restaurant2/food31.jpeg", 65000, 39000f, "Trà xanh cam bưởi dâu tây", 2 },
                    { 32, "", "./ImageForSeedData/Food/Restaurant2/food32.jpeg", 65000, 39000f, "Trà xanh cam bưởi nhiệt đới", 2 },
                    { 33, "", "./ImageForSeedData/Food/Restaurant2/food33.jpeg", 58000, 34800f, "Scola kem cheese", 2 },
                    { 34, "", "./ImageForSeedData/Food/Restaurant2/food34.jpeg", 55000, 33000f, "Scola cake cream", 2 },
                    { 35, "", "./ImageForSeedData/Food/Restaurant2/food35.jpeg", 67000, 40200f, "Smoothie xoài kem cheese", 2 },
                    { 36, "", "./ImageForSeedData/Food/Restaurant2/food36.jpeg", 67000, 40200f, "Smoothie dưa hấu kem cheese", 2 },
                    { 37, "", "./ImageForSeedData/Food/Restaurant2/food37.jpeg", 67000, 40200f, "Smoothie ruby", 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 37);

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
    }
}
