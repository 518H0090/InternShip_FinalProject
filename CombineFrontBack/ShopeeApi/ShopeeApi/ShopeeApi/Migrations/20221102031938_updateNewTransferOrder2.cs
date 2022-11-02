﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class updateNewTransferOrder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TempMoney",
                table: "TransferOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 61, 24, 31, 23, 101, 112, 101, 249, 221, 135, 99, 71, 26, 33, 247, 82, 88, 231, 166, 114, 240, 93, 161, 183, 35, 139, 187, 140, 226, 82, 134, 169, 86, 175, 218, 94, 31, 10, 22, 231, 228, 216, 248, 247, 90, 153, 96, 99, 140, 100, 240, 187, 220, 45, 235, 20, 183, 108, 36, 221, 248, 144, 164 }, new byte[] { 227, 88, 145, 128, 177, 186, 225, 49, 81, 109, 201, 238, 59, 175, 30, 81, 175, 79, 186, 180, 103, 67, 37, 124, 4, 42, 179, 51, 171, 76, 191, 86, 164, 134, 30, 35, 54, 214, 31, 140, 205, 117, 158, 71, 22, 246, 162, 26, 63, 124, 44, 96, 120, 66, 156, 134, 62, 88, 116, 226, 237, 201, 188, 87, 68, 78, 123, 36, 245, 134, 244, 118, 153, 68, 181, 170, 41, 216, 69, 228, 231, 16, 221, 235, 186, 28, 243, 145, 153, 9, 247, 229, 214, 92, 129, 246, 139, 90, 157, 20, 11, 217, 113, 1, 158, 31, 40, 20, 175, 134, 23, 170, 138, 245, 224, 124, 248, 210, 211, 44, 245, 180, 116, 173, 0, 38, 31, 223 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 216, 131, 97, 194, 9, 187, 169, 93, 142, 75, 69, 174, 195, 178, 195, 82, 33, 201, 247, 155, 228, 130, 19, 110, 170, 237, 2, 73, 220, 86, 2, 55, 195, 123, 109, 206, 109, 36, 9, 236, 146, 226, 214, 52, 112, 183, 88, 206, 246, 143, 226, 130, 177, 238, 232, 213, 139, 161, 105, 134, 120, 232, 222 }, new byte[] { 165, 66, 233, 50, 180, 68, 129, 201, 13, 203, 144, 112, 119, 23, 156, 219, 28, 3, 231, 43, 253, 47, 193, 217, 181, 27, 161, 154, 245, 177, 252, 89, 147, 123, 52, 98, 9, 2, 47, 47, 254, 78, 93, 109, 145, 78, 219, 70, 168, 2, 174, 52, 58, 180, 102, 44, 70, 150, 125, 224, 43, 90, 173, 16, 198, 34, 229, 205, 161, 154, 204, 10, 190, 55, 65, 51, 216, 210, 4, 66, 232, 167, 153, 240, 112, 99, 14, 221, 93, 220, 75, 188, 177, 195, 255, 255, 245, 74, 23, 166, 101, 14, 38, 255, 131, 126, 78, 22, 231, 68, 52, 145, 34, 50, 244, 123, 192, 133, 17, 125, 40, 94, 234, 24, 206, 43, 2, 233 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 180, 101, 141, 56, 101, 137, 24, 77, 128, 104, 109, 121, 30, 220, 59, 157, 108, 203, 55, 154, 97, 137, 124, 170, 80, 51, 231, 133, 179, 114, 13, 19, 69, 121, 11, 237, 30, 230, 22, 77, 53, 109, 60, 100, 204, 94, 194, 74, 193, 19, 252, 142, 185, 252, 167, 44, 176, 125, 78, 220, 192, 103, 97, 56 }, new byte[] { 240, 233, 176, 145, 104, 76, 244, 16, 195, 79, 229, 55, 106, 67, 145, 138, 144, 53, 68, 187, 78, 249, 174, 164, 18, 222, 197, 3, 231, 197, 139, 94, 48, 55, 179, 31, 87, 196, 104, 117, 169, 127, 41, 245, 160, 126, 85, 253, 46, 106, 176, 33, 31, 9, 83, 229, 93, 137, 210, 215, 57, 149, 12, 21, 131, 227, 172, 231, 138, 165, 96, 101, 58, 124, 213, 48, 132, 61, 164, 37, 188, 218, 243, 234, 143, 231, 162, 48, 149, 66, 215, 242, 179, 75, 77, 70, 69, 166, 20, 62, 196, 135, 73, 0, 198, 199, 200, 15, 51, 145, 122, 193, 38, 170, 7, 210, 129, 80, 0, 123, 50, 239, 64, 86, 131, 1, 178, 165 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 84, 94, 210, 70, 114, 68, 119, 125, 140, 203, 1, 99, 41, 68, 25, 233, 150, 45, 108, 203, 104, 199, 167, 54, 105, 210, 90, 236, 136, 118, 76, 141, 187, 240, 140, 105, 90, 8, 57, 188, 27, 1, 110, 120, 203, 234, 184, 78, 215, 229, 185, 206, 234, 102, 55, 85, 139, 197, 212, 165, 17, 228, 200, 225 }, new byte[] { 72, 78, 38, 0, 208, 215, 57, 62, 82, 77, 41, 30, 190, 63, 160, 141, 196, 47, 76, 40, 107, 64, 55, 246, 162, 153, 84, 203, 0, 29, 37, 48, 178, 219, 79, 160, 180, 148, 72, 27, 198, 150, 114, 226, 92, 119, 184, 121, 33, 45, 52, 69, 83, 104, 153, 243, 222, 15, 193, 153, 30, 103, 28, 56, 44, 213, 236, 249, 84, 111, 239, 94, 58, 117, 108, 166, 119, 20, 112, 209, 67, 134, 198, 156, 14, 86, 63, 250, 139, 244, 75, 102, 218, 78, 129, 173, 138, 6, 83, 239, 171, 179, 112, 3, 106, 46, 231, 37, 253, 205, 168, 101, 75, 184, 246, 24, 43, 255, 57, 56, 15, 93, 101, 138, 77, 155, 5, 36 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempMoney",
                table: "TransferOrders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 181, 14, 43, 143, 71, 113, 243, 59, 243, 25, 115, 15, 129, 229, 35, 25, 65, 13, 254, 173, 219, 98, 124, 25, 68, 143, 110, 124, 183, 214, 96, 209, 134, 28, 17, 230, 74, 102, 86, 217, 143, 248, 42, 170, 187, 224, 214, 103, 58, 209, 136, 243, 59, 135, 211, 33, 243, 249, 187, 201, 2, 246, 40, 124 }, new byte[] { 15, 147, 246, 48, 129, 238, 198, 69, 60, 186, 9, 244, 69, 165, 145, 243, 74, 140, 132, 225, 229, 74, 150, 105, 143, 195, 9, 36, 17, 229, 168, 29, 218, 41, 196, 190, 232, 168, 194, 135, 245, 221, 223, 19, 240, 225, 13, 78, 204, 130, 35, 37, 1, 114, 68, 32, 141, 227, 239, 28, 175, 54, 29, 41, 248, 60, 59, 7, 31, 222, 13, 225, 46, 79, 5, 26, 193, 211, 171, 161, 72, 190, 67, 109, 136, 155, 127, 101, 2, 147, 74, 134, 50, 92, 147, 222, 49, 169, 165, 108, 205, 51, 108, 139, 0, 165, 62, 25, 181, 39, 245, 50, 167, 147, 178, 228, 203, 197, 39, 2, 76, 3, 1, 42, 126, 168, 13, 172 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 171, 77, 129, 142, 202, 229, 33, 175, 254, 26, 105, 232, 53, 43, 138, 219, 4, 227, 234, 157, 82, 134, 232, 124, 136, 82, 91, 61, 140, 38, 197, 172, 95, 196, 241, 233, 237, 56, 94, 169, 151, 228, 210, 186, 157, 183, 202, 197, 77, 52, 86, 92, 219, 118, 98, 183, 135, 135, 64, 134, 173, 156, 7, 166 }, new byte[] { 216, 139, 194, 165, 69, 106, 78, 50, 14, 118, 79, 198, 193, 11, 114, 93, 119, 119, 189, 127, 72, 169, 6, 83, 1, 210, 30, 244, 5, 173, 67, 211, 177, 109, 214, 0, 86, 59, 215, 187, 189, 247, 90, 148, 238, 82, 34, 59, 103, 246, 246, 141, 34, 132, 53, 39, 155, 157, 63, 11, 233, 216, 4, 56, 146, 227, 118, 165, 226, 169, 163, 28, 95, 165, 197, 165, 79, 251, 213, 179, 70, 3, 20, 185, 58, 42, 229, 112, 199, 185, 50, 56, 96, 98, 130, 132, 209, 27, 216, 112, 163, 241, 255, 82, 244, 201, 122, 205, 179, 101, 145, 150, 162, 128, 225, 160, 3, 142, 181, 153, 209, 130, 115, 83, 2, 81, 167, 184 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 64, 135, 127, 204, 176, 218, 47, 18, 155, 31, 178, 178, 41, 4, 198, 45, 1, 117, 109, 200, 96, 146, 214, 101, 224, 75, 39, 200, 189, 170, 174, 223, 5, 186, 78, 58, 190, 138, 181, 201, 84, 39, 202, 246, 139, 237, 38, 173, 237, 151, 165, 161, 164, 253, 112, 0, 55, 50, 14, 78, 172, 159, 220, 235 }, new byte[] { 60, 5, 38, 31, 221, 14, 13, 243, 176, 31, 0, 161, 127, 148, 25, 5, 210, 106, 138, 163, 174, 151, 37, 52, 186, 253, 238, 228, 10, 95, 88, 63, 236, 49, 161, 129, 28, 101, 141, 6, 123, 159, 178, 54, 55, 0, 121, 37, 146, 6, 110, 199, 92, 216, 155, 205, 239, 233, 68, 135, 154, 81, 244, 254, 185, 251, 11, 4, 152, 162, 58, 106, 48, 247, 255, 27, 224, 15, 133, 184, 207, 191, 198, 86, 56, 82, 164, 148, 79, 58, 10, 107, 210, 116, 239, 110, 58, 115, 205, 84, 191, 222, 13, 208, 40, 11, 143, 143, 140, 150, 184, 107, 117, 5, 155, 237, 254, 245, 24, 235, 223, 6, 139, 75, 100, 248, 226, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 119, 128, 125, 11, 157, 132, 161, 35, 238, 46, 181, 25, 193, 121, 7, 249, 212, 101, 226, 198, 102, 164, 158, 4, 13, 150, 208, 244, 103, 48, 104, 250, 106, 149, 14, 185, 196, 164, 0, 100, 165, 184, 77, 74, 11, 34, 76, 47, 93, 164, 108, 46, 47, 148, 116, 119, 38, 144, 17, 112, 210, 7, 97, 22 }, new byte[] { 14, 201, 221, 244, 180, 154, 133, 186, 93, 95, 140, 171, 235, 215, 150, 67, 250, 174, 46, 33, 204, 149, 176, 77, 241, 125, 1, 219, 199, 24, 80, 224, 58, 11, 216, 65, 253, 58, 250, 232, 211, 154, 71, 61, 182, 212, 210, 54, 201, 214, 39, 246, 105, 64, 23, 10, 36, 242, 49, 214, 220, 206, 7, 17, 72, 146, 212, 115, 50, 98, 119, 239, 205, 202, 120, 155, 14, 101, 58, 171, 84, 19, 200, 215, 110, 105, 205, 120, 236, 16, 35, 155, 248, 104, 42, 155, 1, 236, 42, 64, 176, 138, 186, 60, 176, 181, 59, 65, 127, 19, 42, 105, 57, 228, 20, 13, 9, 60, 37, 107, 158, 98, 80, 57, 146, 59, 15, 102 } });
        }
    }
}
