using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenMarketPlace.Persistance.Migrations
{
    public partial class UDb010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "Assets",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "AssetDrafts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "AssetDrafts");
        }
    }
}
