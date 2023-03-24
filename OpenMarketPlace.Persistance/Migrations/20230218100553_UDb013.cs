using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenMarketPlace.Persistance.Migrations
{
    public partial class UDb013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetResources_AspNetUsers_CreatedById",
                table: "AssetResources");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetResources_AspNetUsers_DeletedById",
                table: "AssetResources");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetResources_AspNetUsers_ModifiedById",
                table: "AssetResources");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetResources_Assets_AssetId",
                table: "AssetResources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetResources",
                table: "AssetResources");

            migrationBuilder.RenameTable(
                name: "AssetResources",
                newName: "AssetDownloadLinks");

            migrationBuilder.RenameIndex(
                name: "IX_AssetResources_ModifiedById",
                table: "AssetDownloadLinks",
                newName: "IX_AssetDownloadLinks_ModifiedById");

            migrationBuilder.RenameIndex(
                name: "IX_AssetResources_DeletedById",
                table: "AssetDownloadLinks",
                newName: "IX_AssetDownloadLinks_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_AssetResources_CreatedById",
                table: "AssetDownloadLinks",
                newName: "IX_AssetDownloadLinks_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_AssetResources_AssetId",
                table: "AssetDownloadLinks",
                newName: "IX_AssetDownloadLinks_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetDownloadLinks",
                table: "AssetDownloadLinks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDownloadLinks_AspNetUsers_CreatedById",
                table: "AssetDownloadLinks",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDownloadLinks_AspNetUsers_DeletedById",
                table: "AssetDownloadLinks",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDownloadLinks_AspNetUsers_ModifiedById",
                table: "AssetDownloadLinks",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDownloadLinks_Assets_AssetId",
                table: "AssetDownloadLinks",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetDownloadLinks_AspNetUsers_CreatedById",
                table: "AssetDownloadLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetDownloadLinks_AspNetUsers_DeletedById",
                table: "AssetDownloadLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetDownloadLinks_AspNetUsers_ModifiedById",
                table: "AssetDownloadLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetDownloadLinks_Assets_AssetId",
                table: "AssetDownloadLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetDownloadLinks",
                table: "AssetDownloadLinks");

            migrationBuilder.RenameTable(
                name: "AssetDownloadLinks",
                newName: "AssetResources");

            migrationBuilder.RenameIndex(
                name: "IX_AssetDownloadLinks_ModifiedById",
                table: "AssetResources",
                newName: "IX_AssetResources_ModifiedById");

            migrationBuilder.RenameIndex(
                name: "IX_AssetDownloadLinks_DeletedById",
                table: "AssetResources",
                newName: "IX_AssetResources_DeletedById");

            migrationBuilder.RenameIndex(
                name: "IX_AssetDownloadLinks_CreatedById",
                table: "AssetResources",
                newName: "IX_AssetResources_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_AssetDownloadLinks_AssetId",
                table: "AssetResources",
                newName: "IX_AssetResources_AssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetResources",
                table: "AssetResources",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetResources_AspNetUsers_CreatedById",
                table: "AssetResources",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetResources_AspNetUsers_DeletedById",
                table: "AssetResources",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetResources_AspNetUsers_ModifiedById",
                table: "AssetResources",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetResources_Assets_AssetId",
                table: "AssetResources",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");
        }
    }
}
