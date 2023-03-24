using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenMarketPlace.Persistance.Migrations
{
    public partial class UDb011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "AssetResources",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "AssetResources");
        }
    }
}
