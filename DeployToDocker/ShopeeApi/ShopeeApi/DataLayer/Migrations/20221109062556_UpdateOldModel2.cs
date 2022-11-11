using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class UpdateOldModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "RestaurantOrders");

            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "BillOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 1,
                column: "RsDistance",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 2,
                column: "RsDistance",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 3,
                column: "RsDistance",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 4,
                column: "RsDistance",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 5,
                column: "RsDistance",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 6,
                column: "RsDistance",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 8,
                column: "RsDistance",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 9,
                column: "RsDistance",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 146, 100, 71, 157, 52, 118, 76, 83, 62, 176, 172, 131, 230, 203, 148, 24, 78, 253, 174, 222, 104, 172, 109, 242, 211, 155, 112, 214, 231, 120, 63, 232, 240, 75, 110, 162, 244, 129, 7, 34, 240, 14, 157, 193, 106, 138, 241, 130, 120, 171, 47, 232, 181, 220, 175, 76, 118, 16, 30, 184, 51, 117, 184 }, new byte[] { 154, 41, 118, 27, 20, 117, 180, 1, 131, 81, 199, 239, 224, 1, 132, 233, 202, 40, 162, 46, 128, 56, 49, 235, 233, 54, 239, 197, 51, 30, 242, 69, 160, 89, 82, 175, 68, 125, 234, 238, 59, 76, 134, 208, 14, 229, 212, 178, 144, 205, 79, 229, 80, 163, 20, 248, 71, 32, 91, 188, 39, 157, 165, 102, 185, 132, 158, 37, 125, 188, 24, 57, 159, 22, 192, 224, 165, 54, 63, 222, 180, 164, 40, 43, 153, 16, 59, 65, 153, 54, 32, 44, 106, 239, 196, 91, 173, 104, 40, 150, 111, 214, 60, 20, 29, 76, 96, 210, 126, 104, 222, 194, 155, 217, 99, 178, 93, 69, 128, 206, 138, 147, 58, 72, 228, 142, 207, 173 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 214, 220, 226, 89, 114, 176, 61, 159, 83, 24, 58, 43, 207, 52, 111, 140, 141, 194, 207, 91, 87, 37, 223, 30, 92, 188, 106, 245, 145, 163, 79, 200, 211, 222, 249, 169, 90, 232, 68, 159, 65, 185, 198, 187, 255, 107, 45, 196, 116, 12, 171, 201, 146, 254, 195, 246, 117, 55, 88, 42, 128, 251, 20 }, new byte[] { 198, 96, 199, 70, 82, 191, 51, 175, 140, 199, 0, 245, 30, 219, 90, 117, 18, 219, 249, 202, 105, 31, 61, 223, 243, 17, 173, 132, 31, 148, 66, 252, 89, 138, 2, 13, 198, 236, 76, 229, 160, 144, 27, 200, 44, 69, 173, 136, 52, 244, 180, 79, 252, 171, 1, 249, 39, 159, 250, 23, 63, 231, 37, 172, 57, 191, 20, 160, 251, 165, 159, 57, 107, 71, 60, 33, 197, 249, 141, 102, 30, 164, 59, 11, 213, 14, 93, 177, 218, 27, 104, 48, 23, 118, 93, 191, 240, 91, 215, 18, 16, 249, 44, 202, 33, 137, 191, 55, 113, 99, 192, 153, 124, 153, 250, 28, 254, 230, 189, 236, 218, 45, 27, 0, 54, 171, 225, 184 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 116, 152, 106, 179, 63, 190, 181, 119, 34, 120, 151, 44, 14, 106, 156, 130, 74, 171, 182, 16, 91, 71, 13, 219, 171, 55, 248, 213, 68, 72, 10, 194, 47, 216, 105, 63, 120, 1, 243, 191, 197, 255, 156, 201, 42, 169, 232, 89, 216, 60, 58, 168, 103, 227, 105, 153, 175, 123, 100, 202, 131, 202, 157, 203 }, new byte[] { 181, 29, 53, 77, 191, 114, 89, 69, 85, 139, 43, 214, 188, 75, 123, 49, 172, 116, 157, 188, 41, 115, 236, 159, 126, 2, 56, 167, 97, 237, 74, 158, 118, 251, 128, 201, 10, 86, 190, 168, 110, 255, 5, 238, 89, 141, 2, 141, 149, 108, 105, 16, 54, 27, 170, 211, 131, 130, 72, 100, 105, 140, 63, 0, 240, 37, 159, 166, 224, 183, 111, 135, 87, 156, 81, 52, 18, 28, 110, 188, 4, 222, 142, 184, 18, 138, 208, 50, 50, 38, 72, 142, 17, 237, 242, 246, 236, 70, 55, 234, 65, 34, 101, 109, 63, 247, 39, 19, 30, 2, 59, 126, 179, 60, 163, 167, 16, 103, 171, 45, 118, 46, 210, 245, 16, 209, 218, 65 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 12, 94, 144, 70, 67, 131, 139, 119, 86, 251, 215, 30, 153, 234, 83, 212, 120, 32, 133, 1, 186, 87, 63, 128, 90, 243, 182, 48, 233, 69, 90, 108, 6, 186, 150, 29, 23, 224, 130, 235, 3, 138, 112, 243, 161, 160, 122, 110, 78, 177, 47, 199, 67, 62, 220, 109, 194, 168, 75, 192, 109, 171, 94, 63 }, new byte[] { 34, 34, 105, 88, 207, 149, 89, 63, 219, 123, 30, 239, 45, 47, 227, 80, 2, 141, 65, 121, 167, 19, 36, 158, 18, 39, 213, 227, 182, 32, 251, 202, 208, 49, 173, 222, 81, 133, 9, 202, 75, 183, 250, 57, 129, 204, 80, 175, 214, 65, 209, 244, 86, 253, 246, 136, 2, 73, 191, 144, 200, 85, 83, 206, 205, 254, 59, 178, 79, 95, 68, 230, 98, 65, 182, 26, 175, 212, 91, 54, 49, 200, 222, 14, 178, 238, 185, 19, 244, 130, 69, 85, 19, 172, 65, 4, 152, 147, 5, 245, 58, 184, 88, 238, 184, 203, 174, 105, 55, 213, 19, 81, 100, 8, 98, 154, 34, 44, 172, 231, 165, 57, 197, 119, 53, 120, 184, 242 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "BillOrders");

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
    }
}
