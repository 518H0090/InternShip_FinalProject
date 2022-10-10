using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class InitialSeeDData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[,]
                {
                    { 1, "606/52 Đường 3 Tháng 2, P. 14, Quận 10, TP. HCM", "./ImageForSeedData/Restaurant/restaurant1.jpg", "6:00 - 22:00", "44,000 - 85,000", 0, "TP.HCM", 1, 5f, "Bếp Bà Muối - Ăn Vặt Online", "QUANAN" },
                    { 2, "35 Sơn Kỳ, P. Sơn Kỳ, Tân Phú, TP. HCM", "./ImageForSeedData/Restaurant/restaurant2.jpg", "8:15 - 22:20", "45,000 - 60,000", 50, "TP.HCM", 500, 4.5f, "Royaltea Vietnam By Hongkong - Sơn Kỳ", "CAFE/DESSERT" },
                    { 3, "115B Tôn Đản, P. 14, Quận 4, TP. HCM", "./ImageForSeedData/Restaurant/restaurant3.jpg", "6:00 - 20:11", "15,000 - 30,000", 0, "TP.HCM", 999, 4.5f, "Anh Thư - Bánh Mì & Bún Thịt Nướng", "ANVAT/VIAHE" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsRefeLike", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[] { 4, "322 Phạm Hùng, P. 4, Quận 8, TP. HCM", "./ImageForSeedData/Restaurant/restaurant4.jpeg", "7:00 - 21:30", "30,000 - 50,000", 5, "TP.HCM", true, 100, 4.5f, "Mì Quảng 3 Anh Em - Phạm Hùng", "QUANAN" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[,]
                {
                    { 5, "38 Đường Số 13, P. Bình Thọ, Thủ Đức, TP. HCM", "./ImageForSeedData/Restaurant/restaurant5.jpg", "9:00 - 21:00", "14,000 - 30,000", 10, "TP.HCM", 999, 4.5f, "Kim Milk Tea - Trà Sữa, Nước Ép & Ăn Vặt", "CAFE/DESSERT" },
                    { 6, "122 Nguyễn Khoái, P. 2, Quận 4, TP. HCM", "./ImageForSeedData/Restaurant/restaurant6.jpg", "7:20 - 21:45", "15,000 - 69,000", 10, "TP.HCM", 999, 4.5f, "Min Kee - Mì Khô & Trà Hong Kong", "QUANAN" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsRefeLike", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[] { 7, "18A/29 Nguyễn Thị Minh Khai, P. Đa Kao, Quận 1, TP. HCM", "./ImageForSeedData/Restaurant/restaurant7.jpg", "8:30 - 20:25", "95,000 - 150,000", 5, "TP.HCM", true, 999, 4.5f, "Bánh Bò Thốt Nốt COCOCake - Lò Bánh Minh Khai", "QUANAN" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RsId", "RsAddress", "RsImageUrl", "RsOpenTime", "RsPrinceRange", "RsPromotion", "RsProvince", "RsReviews", "RsStar", "RsTitle", "RsType" },
                values: new object[,]
                {
                    { 8, "26 Huỳnh Lan Khanh, P. 2, Tân Bình, TP. HCM", "./ImageForSeedData/Restaurant/restaurant8.jpg", "7:00 - 20:45", "20,000 - 100,000", 5, "TP.HCM", 999, 4.5f, "Việt - Cơm Chay", "ANCHAY" },
                    { 9, "420/11 Huỳnh Văn Bánh, P. 14, Phú Nhuận, TP. HCM", "./ImageForSeedData/Restaurant/restaurant9.jpeg", "9:00 - 19:00", "105,000 - 150,000", 0, "TP.HCM", 50, 4.5f, "Bánh Quế Hà Lan - Huỳnh Văn Bánh", "TIEMBANH" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, new byte[] { 184, 125, 84, 195, 138, 13, 25, 17, 237, 190, 195, 173, 106, 183, 251, 191, 148, 250, 223, 187, 38, 234, 212, 157, 51, 147, 145, 18, 45, 26, 32, 249, 128, 6, 113, 28, 97, 104, 106, 192, 57, 13, 181, 173, 32, 69, 146, 41, 109, 51, 83, 10, 203, 112, 102, 204, 81, 218, 201, 55, 222, 138, 149, 130 }, new byte[] { 101, 201, 12, 242, 118, 29, 218, 122, 158, 165, 6, 237, 24, 61, 31, 179, 234, 90, 81, 165, 89, 168, 173, 166, 186, 4, 169, 201, 254, 223, 1, 196, 46, 45, 132, 196, 150, 44, 100, 11, 16, 7, 4, 31, 244, 103, 204, 255, 51, 173, 11, 180, 195, 3, 76, 86, 116, 166, 219, 36, 20, 146, 83, 219, 24, 231, 70, 91, 173, 238, 92, 194, 68, 58, 126, 50, 195, 170, 233, 39, 146, 106, 143, 219, 130, 56, 254, 135, 161, 214, 101, 91, 95, 191, 88, 208, 175, 100, 226, 167, 132, 64, 21, 44, 40, 180, 79, 108, 240, 250, 157, 172, 93, 234, 218, 214, 51, 4, 66, 14, 34, 128, 58, 0, 170, 65, 8, 101 }, 928399, "nhoxhieuro5@gmail.com" },
                    { 2, new byte[] { 3, 65, 207, 176, 40, 51, 255, 37, 220, 121, 153, 157, 50, 187, 95, 118, 58, 51, 133, 206, 253, 188, 15, 247, 12, 27, 200, 253, 129, 70, 3, 89, 84, 191, 90, 117, 254, 127, 128, 221, 221, 88, 116, 200, 35, 208, 180, 56, 166, 49, 133, 222, 39, 207, 204, 128, 119, 79, 93, 30, 250, 157, 30, 239 }, new byte[] { 167, 107, 18, 116, 45, 105, 253, 73, 34, 127, 34, 94, 209, 251, 252, 251, 165, 167, 137, 235, 158, 190, 59, 7, 109, 27, 7, 73, 134, 172, 134, 117, 42, 22, 16, 141, 236, 40, 130, 188, 29, 62, 201, 191, 131, 41, 161, 245, 72, 215, 193, 128, 5, 202, 231, 118, 139, 55, 107, 247, 108, 192, 11, 39, 111, 131, 198, 48, 249, 75, 142, 53, 155, 65, 54, 150, 109, 155, 252, 54, 233, 87, 210, 238, 160, 124, 25, 41, 178, 237, 86, 98, 234, 240, 230, 225, 148, 141, 183, 18, 179, 207, 160, 147, 205, 136, 187, 87, 15, 60, 25, 90, 111, 98, 11, 49, 68, 134, 218, 14, 167, 161, 218, 58, 26, 131, 231, 116 }, 468255, "chaymetwa" },
                    { 3, new byte[] { 77, 50, 139, 135, 157, 48, 4, 157, 182, 94, 67, 10, 24, 78, 25, 43, 87, 162, 226, 143, 217, 194, 2, 2, 141, 111, 176, 26, 236, 74, 54, 125, 252, 196, 183, 142, 97, 51, 75, 216, 123, 245, 14, 200, 250, 80, 12, 10, 100, 43, 254, 133, 176, 29, 67, 40, 13, 131, 229, 184, 185, 43, 215, 162 }, new byte[] { 7, 24, 244, 172, 215, 3, 247, 241, 34, 110, 126, 84, 158, 80, 223, 134, 150, 68, 222, 181, 83, 174, 234, 4, 100, 22, 26, 246, 120, 216, 203, 71, 174, 218, 19, 221, 38, 17, 211, 54, 213, 130, 232, 199, 188, 67, 54, 21, 121, 232, 230, 18, 133, 58, 110, 250, 221, 28, 42, 180, 228, 252, 200, 228, 123, 201, 108, 31, 31, 7, 154, 225, 55, 135, 26, 165, 98, 113, 135, 7, 38, 222, 136, 125, 24, 219, 86, 88, 125, 152, 93, 225, 170, 84, 165, 177, 223, 47, 125, 64, 192, 42, 193, 119, 222, 24, 155, 71, 78, 70, 157, 55, 6, 46, 232, 107, 144, 202, 249, 221, 13, 235, 73, 171, 92, 240, 123, 137 }, 468255, "metmoichua" },
                    { 4, new byte[] { 157, 63, 223, 192, 157, 208, 47, 135, 197, 100, 171, 39, 108, 197, 167, 98, 182, 60, 177, 183, 37, 219, 113, 135, 40, 111, 28, 230, 162, 34, 145, 224, 116, 1, 60, 172, 178, 135, 93, 218, 225, 155, 228, 154, 232, 74, 36, 237, 224, 130, 43, 153, 215, 122, 248, 222, 228, 27, 7, 133, 91, 7, 108, 80 }, new byte[] { 84, 75, 142, 132, 18, 227, 192, 138, 225, 186, 206, 73, 189, 241, 106, 15, 234, 159, 106, 178, 238, 247, 191, 150, 247, 72, 206, 214, 223, 173, 228, 147, 133, 203, 181, 82, 212, 255, 92, 190, 240, 72, 79, 32, 252, 139, 241, 198, 179, 48, 18, 150, 13, 196, 68, 214, 83, 106, 34, 216, 86, 216, 74, 179, 229, 150, 70, 16, 93, 246, 3, 138, 255, 206, 70, 59, 118, 202, 121, 3, 244, 109, 98, 122, 211, 193, 162, 167, 17, 176, 243, 184, 163, 239, 217, 26, 162, 198, 24, 12, 25, 66, 90, 108, 235, 119, 89, 59, 240, 207, 87, 249, 82, 219, 169, 239, 144, 175, 22, 176, 118, 171, 87, 117, 225, 113, 13, 197 }, 468255, "hoiaita" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
