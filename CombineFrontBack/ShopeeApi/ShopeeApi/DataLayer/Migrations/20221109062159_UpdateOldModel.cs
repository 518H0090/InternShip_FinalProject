﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class UpdateOldModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "TransferOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RsDistance",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "RestaurantOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 1,
                column: "RsDistance",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 2,
                column: "RsDistance",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 3,
                column: "RsDistance",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 4,
                column: "RsDistance",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 5,
                column: "RsDistance",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 6,
                column: "RsDistance",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 7,
                column: "RsDistance",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 8,
                column: "RsDistance",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 9,
                column: "RsDistance",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 115, 36, 165, 231, 197, 154, 70, 98, 43, 48, 159, 149, 231, 14, 52, 181, 203, 35, 206, 226, 96, 26, 139, 203, 233, 168, 156, 181, 162, 202, 151, 255, 202, 194, 7, 188, 173, 87, 214, 66, 237, 117, 158, 99, 15, 111, 92, 6, 5, 120, 108, 49, 129, 65, 127, 56, 128, 147, 138, 116, 171, 160, 166 }, new byte[] { 107, 150, 184, 41, 142, 216, 84, 220, 226, 161, 46, 6, 184, 48, 235, 239, 152, 70, 104, 34, 142, 129, 255, 232, 167, 68, 218, 106, 0, 31, 158, 91, 63, 59, 163, 199, 99, 59, 73, 253, 109, 210, 140, 240, 197, 37, 195, 38, 54, 82, 136, 180, 66, 240, 127, 39, 96, 70, 84, 64, 36, 180, 18, 8, 9, 175, 107, 109, 116, 148, 12, 179, 2, 44, 81, 230, 65, 135, 75, 190, 199, 58, 250, 107, 4, 116, 122, 35, 247, 210, 100, 34, 139, 238, 163, 194, 81, 126, 86, 86, 85, 141, 127, 126, 228, 11, 187, 142, 205, 92, 219, 84, 123, 70, 149, 212, 243, 87, 77, 87, 37, 213, 25, 128, 72, 89, 159, 181 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 114, 176, 226, 43, 197, 125, 86, 188, 191, 84, 99, 144, 30, 125, 209, 56, 246, 70, 230, 233, 100, 23, 164, 238, 195, 71, 194, 123, 35, 202, 149, 134, 33, 66, 201, 110, 243, 160, 162, 230, 94, 107, 199, 226, 144, 49, 197, 46, 25, 40, 92, 191, 180, 106, 146, 243, 103, 52, 254, 1, 0, 4, 152, 106 }, new byte[] { 175, 48, 61, 172, 207, 199, 27, 179, 122, 135, 223, 53, 7, 18, 177, 29, 180, 238, 218, 133, 158, 142, 99, 95, 168, 230, 191, 110, 140, 193, 34, 155, 93, 200, 158, 26, 3, 112, 9, 178, 61, 181, 29, 95, 184, 18, 17, 231, 37, 11, 69, 178, 186, 17, 241, 93, 136, 181, 255, 173, 72, 174, 24, 8, 93, 127, 72, 68, 89, 126, 97, 252, 195, 87, 241, 85, 68, 143, 111, 197, 13, 108, 39, 75, 248, 182, 232, 68, 31, 93, 99, 7, 159, 133, 157, 119, 180, 125, 135, 204, 161, 238, 85, 34, 58, 120, 251, 157, 19, 104, 211, 65, 93, 7, 98, 34, 46, 153, 104, 229, 44, 34, 254, 154, 71, 77, 129, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 162, 141, 208, 145, 244, 241, 208, 237, 191, 138, 164, 216, 110, 129, 63, 6, 82, 141, 205, 149, 174, 163, 173, 132, 113, 93, 181, 79, 49, 136, 190, 158, 238, 110, 218, 251, 150, 162, 68, 71, 131, 72, 103, 44, 224, 96, 14, 187, 204, 232, 172, 77, 42, 182, 251, 195, 153, 145, 202, 7, 155, 90, 149 }, new byte[] { 182, 149, 185, 65, 154, 212, 73, 138, 98, 5, 82, 121, 181, 24, 93, 78, 112, 32, 5, 168, 213, 246, 159, 1, 17, 253, 109, 39, 73, 99, 135, 8, 53, 40, 184, 32, 77, 93, 74, 19, 39, 74, 78, 167, 248, 2, 34, 252, 238, 236, 199, 3, 93, 192, 90, 180, 5, 59, 5, 227, 253, 119, 210, 18, 206, 81, 69, 233, 83, 8, 30, 68, 213, 216, 180, 79, 114, 237, 54, 168, 209, 143, 5, 61, 129, 170, 106, 101, 46, 190, 249, 37, 51, 183, 13, 202, 93, 58, 6, 120, 107, 156, 188, 235, 172, 111, 147, 163, 76, 192, 236, 197, 48, 25, 171, 95, 74, 138, 50, 237, 55, 128, 95, 146, 147, 47, 155, 160 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 51, 47, 31, 0, 108, 68, 237, 220, 239, 88, 234, 85, 203, 47, 49, 193, 71, 208, 17, 118, 43, 205, 125, 209, 50, 125, 37, 134, 24, 116, 197, 43, 167, 222, 216, 140, 250, 82, 7, 146, 107, 217, 208, 91, 185, 42, 105, 61, 68, 200, 71, 247, 206, 59, 199, 188, 150, 81, 37, 199, 143, 168, 70, 31 }, new byte[] { 151, 209, 94, 248, 207, 32, 157, 83, 92, 77, 96, 237, 194, 78, 211, 180, 154, 169, 219, 205, 164, 97, 246, 115, 149, 235, 49, 117, 184, 37, 14, 185, 3, 180, 117, 241, 59, 171, 157, 190, 174, 121, 64, 89, 59, 99, 44, 182, 174, 58, 197, 136, 37, 59, 103, 142, 5, 147, 132, 2, 119, 23, 53, 69, 91, 241, 111, 88, 101, 156, 72, 126, 120, 92, 139, 9, 231, 29, 11, 96, 224, 197, 255, 244, 255, 105, 115, 46, 30, 200, 217, 161, 57, 239, 205, 212, 52, 227, 64, 26, 123, 9, 113, 129, 70, 84, 152, 51, 52, 74, 199, 30, 76, 248, 95, 66, 172, 105, 219, 137, 214, 205, 64, 85, 93, 214, 236, 181 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "TransferOrders");

            migrationBuilder.DropColumn(
                name: "RsDistance",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "RestaurantOrders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 19, 253, 253, 142, 26, 132, 214, 159, 82, 36, 200, 237, 51, 57, 167, 160, 149, 231, 232, 234, 125, 176, 12, 26, 172, 70, 11, 172, 63, 146, 164, 95, 142, 51, 23, 219, 71, 142, 232, 65, 207, 157, 232, 200, 148, 140, 216, 106, 218, 147, 57, 115, 11, 16, 180, 235, 199, 112, 56, 53, 111, 29, 253 }, new byte[] { 135, 51, 223, 179, 216, 180, 122, 73, 183, 36, 210, 82, 19, 212, 117, 133, 61, 151, 163, 242, 51, 162, 252, 208, 161, 73, 225, 158, 130, 134, 193, 177, 214, 210, 58, 174, 69, 195, 48, 137, 74, 195, 132, 111, 127, 39, 113, 73, 219, 16, 179, 129, 57, 50, 174, 89, 139, 229, 228, 193, 136, 123, 92, 9, 44, 218, 177, 253, 40, 100, 245, 145, 217, 15, 34, 51, 142, 16, 42, 2, 92, 65, 253, 192, 235, 27, 44, 221, 229, 102, 88, 21, 101, 221, 120, 250, 53, 3, 87, 81, 66, 74, 23, 99, 253, 51, 183, 254, 147, 199, 3, 156, 65, 10, 250, 103, 45, 168, 25, 29, 16, 45, 210, 22, 235, 226, 232, 171 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 41, 101, 95, 36, 63, 189, 48, 148, 36, 48, 161, 73, 110, 56, 227, 102, 143, 254, 198, 116, 243, 182, 147, 228, 78, 139, 190, 208, 45, 5, 118, 177, 190, 27, 33, 236, 234, 231, 125, 159, 217, 60, 125, 59, 151, 223, 163, 195, 19, 53, 184, 75, 5, 41, 31, 26, 234, 85, 41, 161, 78, 211, 208, 250 }, new byte[] { 147, 172, 32, 167, 24, 44, 179, 137, 190, 77, 20, 203, 252, 94, 161, 91, 73, 74, 67, 228, 11, 110, 136, 140, 137, 46, 82, 213, 127, 201, 14, 16, 15, 115, 60, 203, 188, 204, 109, 101, 227, 169, 76, 205, 119, 209, 107, 145, 204, 171, 66, 192, 177, 0, 117, 196, 189, 56, 25, 57, 253, 240, 147, 207, 177, 221, 116, 230, 178, 206, 222, 31, 146, 99, 84, 240, 20, 98, 94, 40, 224, 180, 209, 64, 36, 219, 175, 101, 130, 191, 58, 224, 39, 35, 122, 150, 113, 198, 29, 100, 228, 121, 147, 220, 99, 96, 192, 195, 62, 212, 127, 189, 45, 129, 17, 9, 226, 198, 155, 185, 62, 88, 73, 28, 73, 22, 77, 1 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 77, 121, 127, 88, 227, 89, 12, 83, 81, 49, 28, 147, 45, 37, 119, 93, 16, 236, 154, 68, 15, 76, 153, 51, 1, 49, 152, 211, 186, 128, 103, 147, 82, 174, 152, 240, 29, 100, 254, 253, 31, 69, 106, 140, 225, 244, 194, 98, 190, 56, 198, 203, 109, 124, 18, 64, 139, 100, 5, 182, 136, 185, 145 }, new byte[] { 154, 127, 113, 242, 26, 223, 249, 38, 75, 248, 148, 99, 250, 160, 4, 101, 112, 167, 151, 99, 127, 160, 252, 100, 222, 253, 162, 128, 20, 61, 104, 199, 232, 142, 92, 65, 126, 86, 12, 92, 75, 235, 179, 163, 161, 224, 65, 86, 205, 103, 207, 13, 34, 224, 105, 193, 41, 122, 21, 215, 249, 98, 247, 48, 55, 6, 197, 214, 60, 227, 6, 103, 56, 104, 181, 124, 236, 42, 11, 80, 82, 214, 160, 22, 95, 198, 202, 238, 90, 60, 108, 188, 230, 187, 198, 194, 74, 216, 184, 3, 192, 27, 56, 1, 215, 144, 32, 236, 224, 165, 204, 76, 235, 123, 51, 0, 85, 207, 126, 235, 246, 22, 235, 2, 66, 62, 141, 21 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 0, 159, 96, 153, 137, 0, 164, 107, 68, 104, 128, 72, 224, 210, 140, 38, 192, 84, 248, 45, 36, 210, 90, 230, 154, 95, 100, 22, 12, 89, 187, 203, 105, 33, 67, 13, 253, 109, 227, 213, 16, 1, 134, 19, 66, 199, 17, 217, 228, 154, 243, 71, 86, 204, 42, 205, 26, 36, 108, 49, 56, 121, 197 }, new byte[] { 202, 250, 168, 155, 43, 253, 105, 231, 96, 126, 32, 148, 88, 152, 104, 160, 63, 13, 138, 142, 243, 29, 52, 225, 231, 176, 169, 65, 207, 137, 81, 88, 146, 66, 172, 214, 76, 182, 233, 222, 151, 215, 137, 226, 243, 251, 40, 21, 83, 131, 68, 92, 128, 24, 72, 77, 231, 250, 61, 185, 67, 162, 255, 87, 153, 11, 116, 52, 198, 14, 198, 238, 193, 63, 131, 67, 227, 17, 5, 167, 253, 20, 34, 185, 50, 247, 40, 37, 58, 85, 178, 60, 11, 86, 187, 149, 185, 4, 81, 249, 200, 96, 211, 64, 24, 129, 27, 158, 251, 83, 30, 189, 70, 29, 18, 174, 55, 179, 46, 120, 162, 170, 246, 181, 207, 90, 28, 32 } });
        }
    }
}
