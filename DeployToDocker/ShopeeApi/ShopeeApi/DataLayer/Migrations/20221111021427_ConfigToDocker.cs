using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class ConfigToDocker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 1,
                column: "RsDistance",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 2,
                column: "RsDistance",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 3,
                column: "RsDistance",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 4,
                column: "RsDistance",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 5,
                column: "RsDistance",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 6,
                column: "RsDistance",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 7,
                column: "RsDistance",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 8,
                column: "RsDistance",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RsId",
                keyValue: 9,
                column: "RsDistance",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 54, 182, 53, 130, 161, 194, 155, 203, 233, 212, 41, 8, 102, 30, 162, 217, 24, 24, 160, 161, 131, 245, 77, 133, 3, 8, 219, 87, 133, 200, 10, 225, 82, 255, 67, 207, 195, 202, 112, 226, 80, 194, 49, 200, 44, 2, 196, 201, 91, 123, 94, 136, 246, 115, 247, 134, 1, 141, 247, 175, 73, 135, 127, 84 }, new byte[] { 238, 47, 210, 151, 211, 104, 228, 76, 1, 181, 159, 170, 198, 9, 42, 157, 39, 31, 51, 231, 50, 49, 17, 176, 213, 82, 245, 104, 124, 69, 202, 14, 55, 224, 174, 225, 78, 40, 177, 134, 97, 108, 225, 101, 126, 56, 90, 249, 3, 1, 68, 16, 81, 34, 48, 180, 157, 230, 253, 67, 4, 27, 200, 238, 160, 146, 220, 242, 131, 229, 85, 169, 201, 198, 102, 9, 122, 149, 188, 26, 144, 143, 185, 7, 100, 65, 217, 224, 48, 250, 0, 40, 247, 25, 145, 229, 133, 80, 51, 33, 138, 36, 71, 86, 188, 130, 212, 251, 121, 234, 118, 43, 66, 249, 92, 237, 111, 152, 82, 41, 169, 36, 206, 1, 25, 181, 96, 115 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 44, 250, 76, 18, 102, 223, 216, 14, 204, 248, 141, 177, 26, 187, 167, 155, 192, 1, 89, 245, 144, 75, 199, 145, 182, 220, 2, 136, 226, 243, 188, 167, 181, 173, 235, 66, 150, 89, 19, 242, 161, 149, 135, 70, 146, 100, 192, 56, 94, 27, 74, 170, 200, 77, 243, 245, 105, 35, 255, 184, 234, 76, 115 }, new byte[] { 39, 85, 108, 5, 16, 94, 102, 7, 138, 210, 108, 87, 211, 19, 101, 158, 250, 106, 95, 71, 49, 11, 155, 98, 232, 110, 111, 91, 189, 196, 117, 148, 127, 132, 133, 131, 249, 125, 139, 139, 62, 137, 245, 208, 63, 55, 165, 119, 52, 205, 146, 196, 101, 13, 43, 87, 224, 190, 163, 218, 78, 167, 149, 91, 71, 44, 211, 210, 120, 188, 67, 135, 156, 196, 185, 225, 185, 244, 25, 122, 89, 137, 236, 125, 15, 143, 73, 248, 101, 233, 37, 194, 42, 248, 159, 254, 81, 121, 148, 168, 84, 193, 126, 127, 143, 214, 158, 77, 178, 96, 91, 209, 153, 213, 57, 128, 143, 111, 159, 59, 98, 229, 61, 227, 137, 244, 14, 193 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 169, 26, 137, 70, 24, 194, 5, 128, 18, 48, 185, 228, 70, 33, 27, 124, 169, 153, 181, 65, 230, 35, 240, 251, 113, 213, 129, 59, 227, 49, 33, 239, 106, 149, 249, 40, 63, 23, 239, 202, 150, 53, 209, 232, 95, 225, 156, 165, 41, 208, 125, 252, 132, 80, 31, 211, 227, 186, 167, 241, 208, 202, 79, 130 }, new byte[] { 146, 202, 90, 120, 21, 56, 43, 102, 164, 149, 34, 224, 161, 105, 160, 239, 241, 13, 149, 165, 216, 0, 125, 222, 28, 95, 14, 199, 58, 101, 68, 94, 185, 24, 223, 236, 107, 163, 35, 200, 61, 153, 174, 220, 69, 212, 24, 150, 94, 161, 103, 14, 194, 22, 183, 149, 63, 155, 203, 213, 184, 254, 184, 87, 38, 105, 0, 238, 62, 160, 25, 226, 197, 118, 214, 47, 121, 53, 162, 247, 5, 249, 47, 148, 63, 98, 6, 115, 4, 162, 3, 224, 195, 231, 17, 122, 155, 132, 165, 21, 4, 19, 196, 16, 95, 215, 54, 58, 93, 78, 85, 90, 165, 198, 142, 39, 63, 69, 207, 211, 107, 12, 123, 22, 126, 168, 50, 77 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 26, 242, 191, 52, 248, 100, 180, 107, 230, 29, 8, 144, 70, 245, 89, 52, 182, 190, 233, 8, 82, 9, 10, 74, 24, 53, 94, 76, 69, 142, 150, 134, 3, 39, 157, 3, 160, 249, 97, 114, 172, 11, 230, 190, 19, 68, 122, 125, 205, 30, 105, 229, 43, 159, 118, 152, 130, 57, 234, 125, 254, 62, 39 }, new byte[] { 167, 122, 47, 179, 114, 70, 18, 138, 68, 56, 175, 45, 230, 3, 152, 205, 197, 194, 91, 230, 124, 96, 154, 117, 59, 17, 177, 216, 176, 39, 147, 196, 244, 181, 20, 108, 97, 216, 253, 187, 155, 18, 129, 6, 161, 199, 69, 163, 105, 105, 152, 106, 165, 38, 74, 183, 250, 47, 164, 112, 55, 145, 43, 83, 66, 70, 140, 110, 156, 29, 226, 237, 47, 9, 5, 247, 96, 159, 110, 147, 203, 106, 143, 24, 31, 241, 210, 14, 46, 125, 211, 148, 216, 53, 54, 51, 10, 247, 151, 217, 166, 180, 96, 192, 226, 74, 141, 48, 151, 56, 162, 206, 104, 195, 169, 219, 45, 176, 187, 143, 208, 124, 239, 246, 111, 21, 152, 33 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 7,
                column: "RsDistance",
                value: 18);

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
    }
}
