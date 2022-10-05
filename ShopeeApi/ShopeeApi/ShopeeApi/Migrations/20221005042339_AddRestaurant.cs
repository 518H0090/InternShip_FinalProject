using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeApi.Migrations
{
    public partial class AddRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RsTitle = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    RsProvince = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    RsAddress = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    RsType = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    RsImageUrl = table.Column<string>(type: "nvarchar(600)", nullable: false),
                    RsStar = table.Column<float>(type: "real", nullable: false, defaultValue: 1f),
                    RsReviews = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RsOpenTime = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    RsPrinceRange = table.Column<string>(type: "nvarchar(800)", nullable: false),
                    RsRefeLike = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RsTitle",
                table: "Restaurants",
                column: "RsTitle",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
