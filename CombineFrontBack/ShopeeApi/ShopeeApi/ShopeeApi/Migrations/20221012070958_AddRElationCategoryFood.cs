using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class AddRElationCategoryFood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 33,
                column: "FoodTitle",
                value: "Socola kem cheese");

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
                    { 12, 41 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 12, 42 },
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
                    { 25, 81 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 26, 82 },
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
                    { 44, 122 }
                });

            migrationBuilder.InsertData(
                table: "RelationCategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 45, 123 },
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 33, 206, 6, 85, 59, 37, 90, 245, 166, 70, 151, 5, 28, 34, 22, 10, 46, 115, 230, 190, 127, 19, 240, 93, 65, 173, 186, 178, 69, 221, 152, 22, 159, 225, 82, 173, 86, 154, 231, 79, 152, 112, 117, 142, 50, 248, 212, 215, 69, 237, 17, 144, 90, 70, 169, 160, 169, 120, 142, 57, 195, 127, 65 }, new byte[] { 231, 18, 95, 25, 227, 132, 255, 13, 65, 75, 155, 7, 78, 65, 91, 197, 249, 225, 203, 1, 162, 178, 237, 166, 196, 167, 158, 68, 73, 235, 71, 173, 24, 57, 127, 60, 55, 167, 188, 207, 143, 46, 242, 240, 42, 182, 21, 232, 143, 178, 93, 158, 141, 231, 208, 6, 4, 116, 199, 104, 149, 199, 93, 27, 70, 30, 223, 171, 206, 42, 30, 230, 253, 85, 2, 10, 190, 50, 255, 167, 198, 20, 200, 36, 129, 37, 124, 221, 148, 178, 115, 214, 227, 57, 76, 183, 89, 18, 106, 139, 11, 128, 24, 197, 241, 68, 152, 71, 206, 225, 1, 47, 85, 53, 79, 64, 21, 234, 71, 90, 79, 231, 254, 36, 44, 34, 2, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 237, 10, 177, 52, 218, 100, 33, 48, 226, 1, 44, 3, 180, 237, 37, 148, 237, 241, 16, 103, 97, 237, 148, 126, 231, 146, 167, 23, 51, 203, 243, 2, 201, 7, 49, 157, 210, 23, 31, 91, 169, 62, 165, 162, 36, 43, 35, 74, 77, 169, 24, 175, 240, 155, 226, 213, 203, 144, 152, 97, 177, 146, 76, 196 }, new byte[] { 160, 16, 38, 185, 183, 26, 218, 70, 66, 19, 131, 39, 118, 106, 111, 125, 180, 61, 255, 226, 177, 213, 32, 94, 100, 165, 2, 240, 222, 230, 81, 28, 152, 244, 193, 53, 28, 59, 195, 57, 104, 46, 180, 204, 170, 43, 248, 49, 78, 37, 3, 111, 95, 30, 42, 102, 32, 200, 67, 239, 127, 243, 198, 122, 72, 148, 118, 209, 208, 228, 58, 181, 192, 207, 22, 75, 154, 17, 141, 201, 191, 13, 196, 103, 222, 37, 29, 74, 130, 195, 182, 238, 200, 140, 67, 179, 7, 235, 230, 154, 240, 210, 145, 56, 206, 118, 24, 28, 170, 234, 250, 174, 17, 66, 167, 125, 105, 78, 26, 238, 43, 50, 181, 1, 173, 81, 131, 223 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 40, 110, 211, 45, 174, 251, 7, 183, 215, 151, 6, 111, 229, 197, 168, 240, 88, 119, 52, 245, 147, 103, 158, 166, 215, 126, 220, 196, 253, 76, 183, 102, 217, 13, 219, 211, 135, 79, 244, 21, 237, 145, 137, 68, 30, 217, 42, 74, 98, 155, 243, 80, 79, 149, 245, 230, 199, 21, 178, 84, 55, 225, 21, 249 }, new byte[] { 49, 21, 99, 226, 20, 206, 150, 44, 222, 1, 174, 29, 163, 24, 251, 202, 103, 199, 249, 105, 117, 179, 173, 209, 92, 1, 67, 149, 12, 72, 142, 133, 75, 34, 86, 199, 249, 196, 13, 172, 144, 224, 200, 130, 88, 138, 127, 97, 74, 224, 191, 29, 27, 44, 37, 39, 92, 224, 135, 211, 144, 255, 230, 133, 91, 206, 3, 219, 48, 149, 123, 138, 40, 7, 251, 199, 148, 53, 138, 160, 251, 144, 169, 4, 137, 98, 100, 102, 254, 158, 184, 208, 184, 165, 112, 43, 115, 251, 43, 104, 40, 102, 176, 106, 134, 109, 183, 252, 190, 213, 117, 91, 35, 47, 130, 26, 104, 18, 136, 33, 231, 192, 76, 143, 114, 158, 188, 3 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 166, 62, 15, 36, 57, 172, 254, 230, 165, 252, 110, 147, 198, 102, 102, 247, 232, 20, 162, 224, 51, 13, 49, 157, 208, 70, 174, 185, 96, 120, 129, 41, 33, 9, 204, 230, 161, 216, 135, 20, 130, 138, 64, 35, 27, 214, 151, 43, 6, 120, 60, 93, 86, 106, 206, 51, 47, 87, 29, 137, 168, 221, 146, 129 }, new byte[] { 180, 181, 197, 223, 222, 96, 216, 165, 93, 144, 12, 64, 23, 5, 205, 50, 163, 231, 235, 17, 51, 201, 39, 250, 64, 194, 6, 39, 252, 102, 1, 195, 49, 241, 178, 101, 15, 46, 146, 202, 104, 176, 85, 212, 76, 247, 229, 143, 128, 3, 211, 129, 232, 131, 123, 86, 253, 92, 128, 97, 173, 252, 239, 204, 174, 103, 98, 200, 35, 96, 241, 225, 156, 25, 149, 177, 203, 235, 163, 91, 234, 93, 169, 228, 79, 121, 243, 102, 126, 243, 130, 122, 37, 184, 251, 6, 157, 235, 112, 175, 89, 108, 233, 74, 191, 238, 43, 160, 202, 92, 223, 106, 239, 229, 114, 215, 102, 9, 174, 100, 171, 222, 139, 32, 183, 77, 89, 94 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 20 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 21 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 24 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 6, 26 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 7, 27 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 7, 28 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 7, 29 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 8, 30 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 8, 31 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 8, 32 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 9, 33 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 9, 34 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 10, 35 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 10, 36 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 10, 37 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 11, 38 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 11, 39 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 12, 40 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 12, 41 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 12, 42 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 12, 43 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 13, 44 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 13, 45 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 13, 46 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 13, 47 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 13, 48 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 13, 49 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 14, 50 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 14, 51 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 15, 52 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 15, 53 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 15, 54 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 16, 52 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 16, 55 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 16, 56 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 17, 55 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 17, 58 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 17, 59 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 17, 60 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 18, 61 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 18, 62 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 19, 63 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 19, 64 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 20, 56 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 20, 57 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 20, 65 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 21, 67 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 21, 68 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 22, 69 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 22, 70 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 23, 71 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 23, 72 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 23, 73 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 23, 74 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 24, 75 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 24, 76 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 24, 77 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 25, 78 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 25, 79 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 25, 80 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 25, 81 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 26, 82 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 26, 83 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 26, 84 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 27, 85 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 27, 87 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 28, 77 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 28, 85 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 29, 88 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 29, 89 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 30, 90 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 31, 91 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 31, 92 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 31, 93 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 32, 94 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 32, 95 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 32, 96 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 32, 97 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 32, 98 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 33, 99 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 33, 100 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 33, 101 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 33, 102 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 34, 103 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 35, 104 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 36, 105 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 36, 106 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 37, 107 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 37, 108 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 38, 109 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 38, 110 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 38, 111 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 39, 112 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 39, 113 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 39, 114 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 40, 115 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 40, 116 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 40, 117 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 41, 118 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 41, 119 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 42, 120 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 43, 121 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 44, 122 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 45, 123 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 46, 124 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 47, 125 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 48, 126 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 49, 127 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 50, 128 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 51, 129 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 51, 130 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 52, 131 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 52, 132 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 53, 133 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 53, 134 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 54, 135 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 54, 136 });

            migrationBuilder.DeleteData(
                table: "RelationCategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 54, 137 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 33,
                column: "FoodTitle",
                value: "Scola kem cheese");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 10, 37, 245, 155, 135, 54, 95, 56, 89, 10, 216, 18, 18, 195, 182, 131, 90, 242, 178, 11, 86, 13, 19, 112, 231, 212, 88, 70, 183, 100, 61, 194, 224, 155, 111, 88, 66, 219, 139, 93, 37, 24, 19, 65, 16, 21, 111, 155, 62, 188, 202, 148, 167, 141, 219, 201, 240, 76, 38, 14, 253, 234, 13, 231 }, new byte[] { 72, 78, 54, 105, 20, 204, 106, 152, 86, 25, 201, 77, 64, 17, 166, 112, 208, 50, 189, 18, 99, 134, 200, 83, 58, 65, 173, 29, 64, 221, 112, 179, 131, 104, 111, 43, 233, 68, 216, 122, 163, 191, 191, 215, 196, 203, 28, 217, 208, 36, 26, 174, 68, 102, 185, 152, 179, 80, 229, 128, 217, 74, 147, 200, 115, 77, 51, 211, 50, 162, 23, 178, 156, 220, 211, 1, 56, 129, 58, 212, 200, 169, 229, 67, 45, 25, 237, 0, 177, 248, 98, 200, 98, 126, 178, 162, 93, 146, 113, 36, 239, 209, 52, 175, 153, 110, 35, 237, 41, 186, 233, 248, 36, 73, 57, 56, 183, 92, 149, 41, 30, 130, 208, 115, 103, 16, 241, 5 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 170, 124, 251, 67, 134, 234, 138, 243, 98, 206, 184, 180, 22, 4, 218, 117, 164, 20, 244, 108, 107, 167, 227, 196, 87, 74, 71, 79, 15, 217, 211, 60, 217, 39, 210, 129, 66, 234, 49, 180, 54, 239, 228, 77, 102, 26, 110, 68, 114, 231, 2, 248, 145, 232, 60, 44, 237, 74, 172, 97, 227, 105, 219 }, new byte[] { 249, 49, 230, 73, 26, 193, 0, 142, 214, 148, 210, 176, 6, 53, 251, 123, 188, 228, 8, 56, 247, 195, 29, 45, 54, 84, 35, 128, 230, 248, 92, 139, 164, 85, 54, 168, 19, 67, 126, 14, 211, 239, 176, 250, 85, 76, 75, 254, 117, 18, 20, 253, 209, 198, 37, 218, 67, 182, 87, 145, 124, 48, 163, 106, 118, 236, 164, 11, 189, 71, 234, 214, 193, 72, 26, 71, 5, 169, 234, 150, 187, 92, 40, 46, 10, 167, 137, 66, 49, 16, 56, 78, 23, 151, 196, 195, 13, 104, 213, 3, 231, 63, 255, 244, 241, 125, 136, 248, 102, 220, 254, 0, 224, 124, 249, 23, 131, 117, 42, 72, 108, 97, 5, 115, 114, 137, 83, 57 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 30, 18, 173, 17, 187, 209, 177, 102, 110, 187, 21, 219, 88, 153, 52, 78, 117, 29, 231, 95, 59, 173, 157, 71, 20, 14, 78, 153, 127, 189, 45, 73, 197, 189, 76, 189, 68, 238, 198, 187, 190, 100, 248, 68, 120, 199, 187, 13, 247, 146, 107, 70, 78, 233, 200, 112, 160, 80, 99, 25, 167, 57, 59 }, new byte[] { 6, 182, 222, 37, 201, 211, 28, 177, 128, 128, 172, 0, 231, 112, 44, 103, 78, 65, 202, 122, 245, 107, 163, 216, 82, 194, 103, 121, 22, 189, 166, 206, 25, 54, 75, 183, 96, 220, 175, 251, 56, 182, 146, 198, 79, 111, 189, 152, 34, 157, 104, 45, 242, 139, 81, 132, 69, 205, 37, 4, 163, 237, 147, 224, 144, 216, 197, 48, 143, 108, 160, 154, 113, 18, 194, 236, 51, 24, 60, 139, 76, 117, 106, 138, 5, 13, 161, 239, 103, 121, 44, 139, 47, 69, 203, 21, 1, 45, 207, 249, 227, 27, 156, 117, 49, 93, 3, 255, 1, 121, 50, 20, 165, 55, 104, 107, 237, 87, 2, 34, 34, 226, 34, 16, 52, 22, 164, 4 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 127, 8, 163, 209, 118, 180, 77, 79, 200, 30, 66, 237, 32, 80, 29, 53, 67, 127, 73, 173, 33, 46, 190, 248, 3, 187, 76, 99, 116, 3, 187, 0, 70, 106, 74, 65, 165, 149, 157, 69, 175, 225, 90, 44, 176, 35, 66, 153, 47, 75, 156, 151, 235, 143, 148, 194, 247, 124, 82, 27, 7, 228, 238, 78 }, new byte[] { 138, 5, 129, 59, 179, 174, 220, 153, 32, 92, 243, 246, 200, 88, 137, 55, 22, 240, 11, 25, 183, 71, 105, 89, 129, 221, 162, 133, 223, 175, 145, 222, 83, 95, 41, 1, 174, 93, 166, 140, 15, 143, 68, 157, 202, 75, 138, 145, 222, 148, 177, 57, 192, 0, 226, 93, 66, 155, 76, 86, 26, 156, 9, 121, 197, 51, 215, 52, 179, 32, 31, 195, 65, 166, 39, 109, 43, 235, 236, 114, 20, 43, 161, 60, 58, 249, 14, 113, 183, 52, 236, 192, 245, 1, 125, 127, 140, 38, 58, 209, 209, 85, 63, 165, 0, 191, 192, 101, 209, 175, 72, 232, 72, 45, 240, 27, 2, 35, 175, 40, 241, 49, 138, 18, 21, 201, 58, 251 } });
        }
    }
}
