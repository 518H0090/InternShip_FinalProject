﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class AddRestaurantOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 213, 100, 173, 203, 0, 132, 226, 55, 118, 129, 255, 108, 245, 11, 232, 13, 157, 242, 69, 187, 138, 129, 124, 250, 82, 133, 177, 120, 135, 4, 254, 182, 158, 57, 61, 179, 116, 169, 13, 103, 7, 240, 149, 92, 66, 128, 36, 119, 102, 255, 244, 60, 178, 181, 0, 29, 200, 131, 179, 231, 112, 120, 165 }, new byte[] { 236, 60, 73, 133, 160, 156, 13, 200, 16, 101, 120, 20, 107, 238, 69, 221, 1, 182, 76, 128, 28, 154, 151, 5, 254, 103, 6, 132, 103, 214, 252, 210, 241, 79, 66, 101, 242, 84, 152, 188, 72, 163, 217, 123, 218, 94, 219, 203, 115, 56, 255, 60, 39, 69, 93, 95, 95, 68, 216, 196, 18, 234, 165, 159, 93, 161, 230, 95, 105, 175, 180, 54, 184, 210, 227, 193, 69, 149, 226, 85, 22, 165, 128, 125, 212, 38, 222, 206, 37, 217, 212, 142, 215, 79, 43, 220, 171, 80, 128, 51, 253, 160, 130, 186, 177, 144, 210, 104, 250, 91, 19, 152, 138, 251, 168, 236, 9, 103, 14, 102, 225, 14, 233, 250, 237, 11, 189, 240 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 164, 210, 126, 132, 223, 99, 15, 116, 40, 226, 6, 140, 228, 224, 139, 105, 121, 34, 126, 205, 141, 253, 83, 168, 107, 112, 123, 66, 101, 97, 211, 119, 4, 239, 72, 150, 134, 84, 118, 50, 161, 209, 93, 190, 222, 206, 251, 196, 227, 59, 71, 6, 7, 223, 180, 153, 189, 211, 140, 110, 100, 27, 139 }, new byte[] { 48, 29, 45, 172, 59, 13, 38, 179, 106, 195, 92, 45, 138, 221, 109, 128, 136, 62, 250, 93, 56, 234, 142, 158, 114, 255, 230, 72, 249, 178, 137, 162, 149, 33, 15, 191, 46, 244, 204, 175, 217, 160, 48, 221, 193, 143, 39, 102, 169, 228, 94, 164, 68, 35, 85, 38, 163, 204, 97, 57, 162, 246, 180, 2, 36, 123, 53, 173, 54, 159, 103, 148, 167, 66, 1, 39, 3, 179, 149, 253, 164, 93, 87, 42, 209, 25, 30, 125, 109, 107, 222, 184, 0, 189, 74, 244, 44, 222, 91, 29, 211, 249, 113, 33, 30, 90, 62, 160, 139, 224, 45, 141, 54, 242, 240, 111, 108, 90, 184, 39, 136, 89, 88, 250, 19, 89, 9, 199 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 138, 204, 197, 40, 234, 141, 196, 40, 129, 32, 97, 170, 151, 66, 224, 232, 77, 151, 255, 183, 135, 51, 151, 148, 206, 253, 1, 10, 69, 6, 34, 174, 3, 253, 58, 212, 225, 193, 174, 22, 105, 252, 157, 27, 176, 182, 122, 234, 40, 142, 202, 25, 72, 198, 175, 21, 12, 204, 193, 247, 139, 243, 204, 171 }, new byte[] { 49, 120, 135, 155, 37, 4, 205, 219, 224, 78, 228, 211, 104, 231, 191, 69, 253, 211, 244, 150, 190, 117, 178, 125, 72, 21, 117, 236, 123, 225, 231, 101, 120, 59, 27, 226, 220, 51, 176, 167, 68, 215, 131, 118, 231, 170, 117, 174, 192, 167, 151, 74, 235, 158, 61, 51, 98, 185, 28, 223, 37, 177, 61, 81, 3, 191, 147, 156, 135, 12, 26, 1, 209, 119, 151, 140, 83, 188, 184, 186, 147, 199, 132, 36, 22, 220, 92, 30, 172, 99, 35, 145, 247, 152, 194, 243, 53, 71, 57, 157, 184, 214, 95, 103, 131, 93, 41, 100, 108, 17, 203, 156, 242, 138, 211, 159, 153, 154, 96, 41, 198, 46, 150, 247, 230, 107, 53, 81 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 244, 108, 207, 62, 54, 157, 21, 159, 43, 183, 86, 244, 8, 250, 147, 196, 194, 92, 59, 231, 34, 211, 27, 43, 40, 213, 38, 210, 186, 151, 141, 199, 149, 230, 82, 25, 38, 108, 18, 219, 8, 189, 30, 115, 178, 249, 124, 33, 227, 152, 71, 145, 201, 31, 130, 221, 77, 64, 176, 148, 198, 13, 146 }, new byte[] { 5, 206, 52, 241, 206, 13, 237, 92, 206, 38, 11, 9, 25, 93, 175, 128, 158, 231, 143, 192, 158, 218, 24, 91, 105, 150, 5, 203, 137, 87, 16, 12, 220, 250, 102, 106, 200, 7, 158, 216, 154, 92, 144, 47, 69, 174, 56, 60, 223, 21, 138, 255, 215, 49, 193, 184, 101, 117, 125, 12, 73, 234, 32, 34, 95, 220, 3, 32, 208, 170, 160, 250, 221, 24, 201, 205, 244, 201, 59, 156, 235, 81, 76, 194, 102, 133, 74, 53, 11, 109, 254, 55, 154, 254, 107, 138, 195, 54, 81, 186, 60, 130, 137, 139, 209, 39, 62, 158, 222, 58, 226, 107, 72, 9, 166, 48, 157, 54, 77, 240, 57, 174, 189, 28, 157, 113, 208, 139 } });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantOrders_RestaurantId",
                table: "RestaurantOrders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantOrders_UserId",
                table: "RestaurantOrders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantOrders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 148, 31, 251, 72, 116, 2, 99, 6, 220, 121, 29, 205, 166, 235, 169, 200, 59, 63, 213, 55, 4, 194, 163, 132, 56, 22, 133, 70, 204, 0, 211, 24, 41, 70, 246, 149, 25, 122, 147, 54, 115, 12, 180, 15, 156, 62, 235, 96, 185, 101, 245, 131, 210, 123, 15, 252, 253, 130, 161, 214, 238, 55, 36 }, new byte[] { 136, 99, 62, 83, 255, 248, 128, 158, 223, 137, 163, 170, 176, 234, 18, 28, 102, 73, 205, 138, 163, 27, 25, 86, 7, 230, 176, 173, 60, 234, 63, 205, 187, 177, 14, 216, 4, 69, 112, 133, 52, 179, 225, 5, 66, 254, 242, 21, 149, 221, 85, 96, 15, 65, 210, 106, 29, 166, 108, 45, 99, 121, 244, 78, 115, 71, 12, 245, 125, 0, 234, 234, 136, 208, 195, 238, 54, 80, 42, 143, 91, 245, 53, 133, 244, 46, 98, 157, 254, 189, 78, 83, 89, 59, 11, 209, 115, 16, 193, 138, 48, 205, 208, 130, 108, 142, 169, 170, 197, 42, 119, 96, 6, 11, 104, 8, 171, 61, 171, 184, 112, 128, 127, 13, 248, 249, 163, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 203, 63, 181, 88, 156, 100, 146, 233, 14, 6, 227, 35, 237, 195, 244, 229, 176, 139, 155, 170, 83, 166, 29, 86, 135, 126, 125, 198, 63, 170, 176, 230, 225, 108, 55, 232, 87, 106, 16, 215, 222, 129, 73, 53, 64, 218, 198, 244, 52, 114, 247, 93, 138, 68, 39, 221, 154, 32, 250, 73, 59, 97, 197 }, new byte[] { 135, 168, 248, 136, 3, 146, 201, 109, 17, 220, 193, 212, 224, 170, 226, 53, 36, 199, 121, 59, 48, 19, 240, 122, 58, 22, 186, 175, 207, 195, 71, 18, 137, 178, 54, 67, 193, 239, 57, 197, 77, 180, 74, 100, 27, 233, 232, 194, 52, 105, 229, 241, 224, 80, 58, 148, 122, 244, 129, 148, 178, 238, 0, 94, 46, 97, 15, 4, 64, 107, 22, 178, 213, 38, 116, 5, 31, 112, 28, 231, 82, 16, 147, 155, 110, 58, 229, 22, 134, 151, 22, 240, 199, 233, 68, 65, 57, 67, 76, 125, 243, 205, 126, 103, 190, 182, 243, 20, 78, 255, 247, 245, 112, 119, 72, 206, 1, 248, 166, 63, 121, 38, 36, 255, 120, 107, 61, 226 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 240, 237, 56, 173, 127, 34, 43, 124, 48, 242, 150, 178, 51, 173, 88, 85, 220, 176, 48, 100, 99, 31, 133, 177, 236, 145, 184, 88, 140, 239, 147, 145, 112, 74, 107, 105, 132, 204, 112, 126, 228, 184, 168, 143, 239, 91, 194, 168, 8, 239, 235, 142, 234, 40, 212, 47, 155, 17, 105, 113, 96, 66, 167, 80 }, new byte[] { 209, 209, 50, 112, 221, 4, 140, 174, 63, 88, 244, 214, 77, 90, 114, 84, 184, 177, 173, 136, 129, 65, 248, 185, 94, 64, 187, 165, 241, 131, 250, 13, 55, 76, 46, 127, 57, 75, 215, 229, 135, 18, 237, 182, 138, 176, 201, 164, 7, 148, 34, 51, 213, 155, 62, 143, 37, 118, 184, 146, 191, 226, 144, 65, 150, 119, 70, 16, 67, 89, 193, 99, 54, 202, 20, 192, 253, 56, 180, 117, 51, 204, 218, 157, 134, 190, 161, 218, 106, 57, 60, 255, 205, 100, 202, 176, 9, 71, 207, 225, 222, 204, 131, 111, 199, 46, 128, 54, 10, 174, 15, 146, 224, 30, 41, 192, 12, 82, 137, 4, 28, 133, 200, 113, 249, 135, 122, 94 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 249, 196, 176, 47, 55, 239, 58, 137, 114, 27, 123, 100, 64, 13, 62, 237, 253, 251, 135, 237, 46, 58, 201, 73, 254, 12, 225, 171, 88, 29, 83, 158, 156, 118, 9, 174, 76, 48, 129, 131, 205, 99, 31, 115, 110, 149, 212, 165, 48, 157, 116, 123, 98, 192, 189, 240, 193, 11, 17, 241, 151, 232, 122, 246 }, new byte[] { 175, 184, 96, 140, 202, 36, 200, 10, 237, 40, 127, 52, 16, 48, 255, 199, 52, 110, 141, 173, 233, 114, 157, 119, 179, 0, 104, 42, 136, 229, 16, 149, 96, 29, 8, 79, 99, 126, 124, 200, 120, 145, 95, 154, 7, 22, 82, 163, 71, 22, 160, 25, 251, 175, 170, 208, 169, 197, 13, 237, 238, 98, 236, 153, 131, 168, 87, 246, 13, 153, 238, 56, 173, 155, 241, 97, 40, 147, 230, 196, 167, 20, 164, 78, 145, 62, 131, 119, 20, 233, 208, 195, 11, 165, 155, 218, 17, 113, 221, 109, 151, 57, 1, 75, 245, 105, 185, 250, 232, 112, 228, 44, 25, 120, 67, 194, 46, 177, 84, 25, 108, 24, 105, 42, 93, 200, 179, 11 } });
        }
    }
}
