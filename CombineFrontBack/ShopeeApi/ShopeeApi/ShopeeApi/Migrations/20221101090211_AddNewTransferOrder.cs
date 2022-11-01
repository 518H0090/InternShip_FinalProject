﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class AddNewTransferOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransferOrders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberItem = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    OrderDistance = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Promotion = table.Column<int>(type: "int", nullable: false),
                    TotalMoney = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_TransferOrders_Users_UserId",
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
                values: new object[] { new byte[] { 108, 28, 1, 54, 18, 145, 221, 207, 15, 137, 191, 193, 28, 105, 185, 117, 250, 71, 147, 162, 148, 17, 9, 43, 122, 220, 204, 208, 116, 212, 92, 231, 75, 50, 230, 209, 29, 246, 145, 146, 212, 241, 178, 76, 56, 56, 209, 216, 60, 238, 239, 157, 203, 161, 112, 223, 205, 207, 67, 188, 183, 18, 179, 91 }, new byte[] { 78, 166, 55, 21, 165, 126, 122, 207, 94, 248, 47, 8, 234, 137, 101, 92, 51, 93, 64, 43, 44, 237, 46, 96, 119, 32, 237, 251, 254, 39, 4, 6, 158, 143, 181, 17, 99, 202, 119, 13, 106, 153, 249, 143, 70, 173, 203, 128, 170, 49, 250, 112, 218, 182, 10, 128, 195, 17, 115, 182, 71, 212, 88, 140, 195, 177, 19, 132, 83, 194, 44, 108, 83, 140, 105, 93, 245, 29, 162, 144, 152, 111, 216, 197, 73, 220, 58, 182, 173, 207, 180, 206, 219, 156, 0, 128, 127, 83, 231, 179, 235, 235, 69, 207, 92, 74, 128, 145, 243, 0, 49, 27, 40, 145, 130, 15, 125, 95, 50, 193, 178, 206, 5, 93, 187, 121, 228, 236 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 29, 209, 228, 166, 118, 19, 172, 77, 7, 69, 18, 2, 245, 192, 95, 5, 208, 140, 128, 30, 15, 204, 137, 141, 193, 181, 141, 21, 7, 238, 197, 246, 180, 222, 118, 75, 177, 27, 126, 128, 43, 196, 60, 108, 43, 213, 166, 65, 73, 108, 209, 56, 133, 169, 41, 144, 8, 242, 1, 164, 136, 234, 68 }, new byte[] { 98, 194, 249, 153, 54, 171, 87, 7, 137, 222, 169, 160, 29, 209, 219, 249, 8, 177, 1, 167, 83, 147, 43, 197, 31, 222, 88, 7, 27, 153, 36, 8, 190, 239, 161, 130, 60, 250, 169, 51, 0, 4, 92, 56, 105, 162, 158, 149, 108, 251, 199, 126, 10, 252, 44, 148, 191, 23, 58, 113, 58, 46, 188, 223, 159, 201, 145, 12, 203, 118, 199, 129, 159, 111, 255, 135, 237, 108, 42, 88, 62, 83, 28, 224, 191, 104, 73, 157, 181, 1, 228, 1, 39, 80, 32, 90, 34, 225, 104, 16, 125, 71, 139, 62, 164, 244, 235, 104, 149, 223, 248, 73, 233, 17, 70, 23, 141, 235, 216, 36, 207, 216, 210, 111, 163, 79, 212, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 187, 11, 115, 195, 6, 91, 58, 103, 20, 204, 17, 10, 224, 244, 211, 79, 85, 41, 165, 185, 202, 69, 24, 159, 119, 1, 115, 128, 123, 121, 204, 13, 188, 249, 239, 81, 4, 151, 179, 253, 14, 45, 155, 177, 230, 91, 190, 124, 41, 45, 180, 44, 86, 70, 62, 154, 181, 160, 46, 93, 139, 199, 230 }, new byte[] { 124, 5, 117, 168, 74, 64, 160, 247, 64, 21, 20, 107, 97, 165, 92, 105, 161, 55, 158, 219, 62, 16, 162, 9, 56, 19, 30, 39, 169, 224, 72, 54, 67, 211, 250, 72, 28, 93, 172, 74, 189, 115, 244, 22, 206, 29, 149, 79, 25, 255, 163, 113, 244, 220, 44, 233, 125, 57, 225, 173, 110, 219, 221, 165, 26, 94, 121, 193, 237, 160, 141, 223, 168, 101, 65, 108, 55, 65, 124, 105, 151, 169, 189, 25, 126, 92, 205, 90, 71, 111, 171, 125, 170, 160, 192, 35, 199, 194, 237, 7, 73, 112, 33, 167, 76, 180, 10, 41, 36, 117, 155, 49, 229, 236, 122, 209, 7, 121, 173, 99, 147, 189, 34, 184, 255, 198, 235, 41 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 167, 247, 143, 112, 24, 198, 154, 77, 48, 153, 243, 89, 253, 209, 33, 0, 180, 82, 55, 26, 230, 225, 72, 125, 183, 108, 7, 252, 174, 243, 15, 210, 227, 250, 141, 135, 144, 3, 18, 8, 110, 42, 178, 222, 136, 80, 108, 106, 84, 132, 18, 184, 42, 243, 173, 220, 210, 245, 96, 167, 198, 254, 114, 61 }, new byte[] { 102, 59, 191, 18, 237, 128, 172, 118, 52, 65, 244, 12, 139, 200, 191, 170, 6, 137, 102, 119, 47, 94, 172, 81, 198, 158, 185, 218, 1, 225, 40, 101, 249, 80, 215, 247, 240, 196, 222, 170, 249, 222, 249, 210, 0, 54, 113, 26, 119, 17, 65, 206, 54, 169, 232, 229, 233, 175, 4, 178, 196, 106, 96, 157, 16, 240, 211, 93, 9, 246, 8, 112, 169, 41, 139, 99, 145, 25, 224, 134, 251, 23, 31, 93, 182, 64, 93, 193, 242, 209, 243, 150, 87, 141, 138, 173, 173, 195, 24, 160, 161, 227, 3, 105, 113, 79, 226, 247, 25, 216, 227, 158, 124, 193, 192, 234, 9, 9, 30, 148, 183, 31, 137, 112, 150, 248, 156, 153 } });

            migrationBuilder.CreateIndex(
                name: "IX_TransferOrders_UserId",
                table: "TransferOrders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransferOrders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 217, 12, 70, 87, 197, 23, 178, 116, 52, 255, 108, 151, 126, 97, 148, 135, 253, 46, 117, 120, 195, 16, 78, 163, 40, 131, 121, 120, 225, 148, 161, 45, 197, 95, 207, 38, 120, 69, 0, 176, 137, 239, 83, 129, 219, 61, 96, 8, 12, 56, 8, 106, 249, 177, 127, 236, 86, 205, 46, 39, 176, 23, 6, 102 }, new byte[] { 253, 50, 31, 225, 170, 113, 245, 200, 168, 107, 221, 88, 101, 161, 153, 45, 187, 102, 75, 111, 218, 51, 42, 223, 100, 249, 14, 192, 124, 149, 79, 169, 242, 115, 221, 131, 70, 225, 110, 52, 114, 149, 44, 207, 34, 23, 81, 239, 32, 66, 168, 153, 245, 78, 206, 12, 208, 45, 40, 159, 40, 117, 46, 148, 91, 18, 255, 204, 68, 159, 112, 194, 239, 54, 175, 201, 0, 221, 64, 161, 42, 186, 73, 163, 184, 153, 49, 156, 204, 73, 16, 235, 66, 61, 124, 41, 211, 229, 193, 91, 17, 93, 160, 225, 132, 29, 207, 241, 210, 40, 152, 229, 209, 162, 180, 40, 152, 97, 105, 249, 125, 28, 72, 116, 28, 20, 17, 186 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 161, 57, 68, 140, 235, 11, 4, 82, 96, 218, 14, 75, 208, 30, 15, 11, 170, 41, 175, 21, 175, 64, 92, 223, 147, 36, 154, 239, 234, 13, 42, 91, 91, 127, 200, 112, 1, 170, 54, 202, 69, 59, 45, 246, 8, 71, 55, 210, 222, 177, 13, 169, 175, 225, 255, 56, 126, 238, 73, 111, 68, 216, 226, 161 }, new byte[] { 252, 123, 148, 62, 177, 95, 160, 30, 214, 163, 55, 162, 177, 104, 63, 227, 215, 127, 58, 69, 62, 172, 8, 225, 236, 232, 100, 175, 25, 146, 229, 81, 68, 84, 176, 49, 157, 10, 108, 117, 19, 83, 45, 55, 230, 115, 131, 65, 122, 9, 34, 236, 194, 159, 169, 48, 233, 49, 150, 147, 27, 197, 239, 16, 184, 39, 210, 139, 76, 203, 134, 172, 59, 136, 82, 192, 64, 95, 181, 173, 30, 203, 178, 5, 150, 26, 227, 142, 112, 225, 101, 222, 40, 181, 89, 129, 206, 136, 63, 61, 81, 166, 228, 16, 143, 182, 212, 15, 168, 76, 113, 112, 46, 174, 238, 90, 127, 186, 208, 197, 61, 134, 246, 176, 213, 86, 163, 190 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 169, 22, 169, 218, 162, 204, 12, 83, 73, 23, 94, 190, 65, 95, 43, 237, 145, 212, 8, 234, 96, 71, 92, 117, 128, 172, 254, 222, 158, 61, 22, 65, 71, 35, 0, 51, 7, 93, 93, 80, 63, 75, 45, 212, 1, 164, 15, 145, 232, 215, 189, 155, 85, 51, 109, 37, 156, 178, 136, 86, 17, 125, 220, 197 }, new byte[] { 109, 242, 148, 14, 230, 5, 23, 209, 90, 53, 214, 166, 51, 131, 109, 72, 213, 29, 139, 13, 12, 73, 77, 111, 150, 113, 101, 227, 53, 79, 17, 218, 148, 106, 130, 144, 217, 147, 70, 107, 224, 206, 161, 230, 251, 13, 141, 185, 15, 52, 106, 193, 220, 181, 2, 59, 108, 30, 95, 225, 234, 151, 205, 221, 117, 214, 85, 177, 152, 123, 251, 49, 124, 81, 195, 155, 210, 124, 204, 41, 134, 182, 247, 213, 60, 213, 108, 72, 161, 247, 26, 54, 168, 76, 244, 155, 7, 247, 171, 124, 65, 141, 240, 83, 230, 79, 100, 222, 248, 95, 122, 39, 29, 10, 53, 87, 65, 164, 200, 189, 151, 29, 98, 164, 26, 25, 192, 113 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 134, 119, 220, 171, 71, 9, 182, 252, 2, 56, 0, 97, 59, 63, 160, 187, 106, 157, 113, 103, 54, 26, 206, 74, 164, 190, 35, 123, 26, 127, 126, 252, 193, 200, 43, 64, 169, 124, 9, 98, 145, 230, 181, 24, 12, 73, 133, 140, 239, 3, 215, 130, 19, 135, 67, 129, 149, 68, 123, 183, 232, 36, 164, 236 }, new byte[] { 107, 188, 46, 103, 69, 133, 21, 221, 191, 223, 148, 250, 65, 54, 201, 33, 117, 163, 17, 136, 18, 153, 61, 31, 47, 3, 209, 47, 109, 62, 236, 135, 63, 9, 131, 98, 245, 242, 12, 255, 60, 135, 108, 86, 148, 89, 184, 203, 77, 128, 89, 32, 169, 5, 133, 60, 250, 100, 228, 81, 163, 190, 44, 217, 180, 231, 251, 5, 45, 97, 100, 46, 210, 6, 168, 193, 111, 110, 115, 102, 166, 37, 79, 226, 138, 118, 62, 155, 27, 203, 168, 42, 75, 122, 109, 121, 165, 1, 23, 26, 186, 131, 68, 85, 111, 27, 178, 104, 139, 209, 175, 170, 8, 121, 52, 229, 64, 17, 241, 228, 144, 151, 14, 248, 118, 75, 117, 209 } });
        }
    }
}