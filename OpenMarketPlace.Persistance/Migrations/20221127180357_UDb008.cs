using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenMarketPlace.Persistance.Migrations
{
    public partial class UDb008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetDrafts_AssetDraftStates_AssetDraftStateId",
                table: "AssetDrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetDrafts_AssetTypes_AssetTypeId",
                table: "AssetDrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetDraftReleaseStates_AssetDraftReleaseStateId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetDrafts_AssetDraftId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetReleaseStates_AssetReleaseStateId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetResources_AssetResourceId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeId",
                table: "Assets");

            migrationBuilder.DropTable(
                name: "AssetDraftReleaseStates");

            migrationBuilder.DropTable(
                name: "AssetDraftStates");

            migrationBuilder.DropTable(
                name: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetDraftId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetDraftReleaseStateId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetReleaseStateId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetResourceId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_AssetDrafts_AssetDraftStateId",
                table: "AssetDrafts");

            migrationBuilder.DropIndex(
                name: "IX_AssetDrafts_AssetTypeId",
                table: "AssetDrafts");

            migrationBuilder.DropColumn(
                name: "AssetDraftReleaseStateId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AssetReleaseStateId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AssetResourceId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "GitRepository",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "LatestVersion",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "GitRepository",
                table: "AssetDrafts");

            migrationBuilder.DropColumn(
                name: "LatestVersion",
                table: "AssetDrafts");

            migrationBuilder.RenameColumn(
                name: "NugetPackage",
                table: "Assets",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "AssetTypeId",
                table: "Assets",
                newName: "AssetStatusId");

            migrationBuilder.RenameColumn(
                name: "IconImage",
                table: "AssetResources",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "BannerImage",
                table: "AssetResources",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NugetPackage",
                table: "AssetDrafts",
                newName: "Version");

            migrationBuilder.RenameColumn(
                name: "AssetTypeId",
                table: "AssetDrafts",
                newName: "AssetId");

            migrationBuilder.RenameColumn(
                name: "AssetDraftStateId",
                table: "AssetDrafts",
                newName: "AssetDraftStatusId");

            migrationBuilder.AddColumn<int>(
                name: "Asset",
                table: "AssetResources",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "AssetResources",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "AssetReleaseStates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssetDraftStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AssetDraftId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsModified = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDraftStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetDraftStatuses_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftStatuses_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftStatuses_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftStatuses_AssetDrafts_AssetDraftId",
                        column: x => x.AssetDraftId,
                        principalTable: "AssetDrafts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AssetDraftStatuses",
                columns: new[] { "Id", "AssetDraftId", "CreatedAt", "CreatedById", "DeletedAt", "DeletedById", "IsDeleted", "IsModified", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { 0, null, null, null, null, null, null, null, null, null, "Draft" },
                    { 1, null, null, null, null, null, null, null, null, null, "DraftReleased" }
                });

            migrationBuilder.UpdateData(
                table: "AssetReleaseStates",
                keyColumn: "Id",
                keyValue: 0,
                column: "Name",
                value: "Published");

            migrationBuilder.UpdateData(
                table: "AssetReleaseStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Draft");

            migrationBuilder.CreateIndex(
                name: "IX_AssetResources_AssetId",
                table: "AssetResources",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReleaseStates_AssetId",
                table: "AssetReleaseStates",
                column: "AssetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_AssetId",
                table: "AssetDrafts",
                column: "AssetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStatuses_AssetDraftId",
                table: "AssetDraftStatuses",
                column: "AssetDraftId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStatuses_CreatedById",
                table: "AssetDraftStatuses",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStatuses_DeletedById",
                table: "AssetDraftStatuses",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStatuses_ModifiedById",
                table: "AssetDraftStatuses",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDrafts_Assets_AssetId",
                table: "AssetDrafts",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReleaseStates_Assets_AssetId",
                table: "AssetReleaseStates",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetResources_Assets_AssetId",
                table: "AssetResources",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetDrafts_Assets_AssetId",
                table: "AssetDrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReleaseStates_Assets_AssetId",
                table: "AssetReleaseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetResources_Assets_AssetId",
                table: "AssetResources");

            migrationBuilder.DropTable(
                name: "AssetDraftStatuses");

            migrationBuilder.DropIndex(
                name: "IX_AssetResources_AssetId",
                table: "AssetResources");

            migrationBuilder.DropIndex(
                name: "IX_AssetReleaseStates_AssetId",
                table: "AssetReleaseStates");

            migrationBuilder.DropIndex(
                name: "IX_AssetDrafts_AssetId",
                table: "AssetDrafts");

            migrationBuilder.DropColumn(
                name: "Asset",
                table: "AssetResources");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetResources");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetReleaseStates");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "Assets",
                newName: "NugetPackage");

            migrationBuilder.RenameColumn(
                name: "AssetStatusId",
                table: "Assets",
                newName: "AssetTypeId");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "AssetResources",
                newName: "IconImage");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AssetResources",
                newName: "BannerImage");

            migrationBuilder.RenameColumn(
                name: "Version",
                table: "AssetDrafts",
                newName: "NugetPackage");

            migrationBuilder.RenameColumn(
                name: "AssetId",
                table: "AssetDrafts",
                newName: "AssetTypeId");

            migrationBuilder.RenameColumn(
                name: "AssetDraftStatusId",
                table: "AssetDrafts",
                newName: "AssetDraftStateId");

            migrationBuilder.AddColumn<int>(
                name: "AssetDraftReleaseStateId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetReleaseStateId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetResourceId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GitRepository",
                table: "Assets",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LatestVersion",
                table: "Assets",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "GitRepository",
                table: "AssetDrafts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LatestVersion",
                table: "AssetDrafts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssetDraftReleaseStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsModified = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDraftReleaseStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetDraftReleaseStates_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftReleaseStates_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftReleaseStates_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssetDraftStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsModified = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDraftStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetDraftStates_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftStates_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDraftStates_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedById = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsModified = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetTypes_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetTypes_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetTypes_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AssetDraftReleaseStates",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "DeletedById", "IsDeleted", "IsModified", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { 0, null, null, null, null, null, null, null, null, "Available" },
                    { 1, null, null, null, null, null, null, null, null, "UnAvailaible" }
                });

            migrationBuilder.InsertData(
                table: "AssetDraftStates",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "DeletedById", "IsDeleted", "IsModified", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { 0, null, null, null, null, null, null, null, null, "Draft" },
                    { 1, null, null, null, null, null, null, null, null, "DraftReleased" }
                });

            migrationBuilder.UpdateData(
                table: "AssetReleaseStates",
                keyColumn: "Id",
                keyValue: 0,
                column: "Name",
                value: "Released");

            migrationBuilder.UpdateData(
                table: "AssetReleaseStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "InitDraft");

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "DeletedById", "IsDeleted", "IsModified", "ModifiedAt", "ModifiedById", "Name" },
                values: new object[,]
                {
                    { 0, null, null, null, null, null, null, null, null, "TwoD" },
                    { 1, null, null, null, null, null, null, null, null, "ThreeD" },
                    { 2, null, null, null, null, null, null, null, null, "Audio" },
                    { 3, null, null, null, null, null, null, null, null, "Scripts" },
                    { 4, null, null, null, null, null, null, null, null, "Templates" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetDraftId",
                table: "Assets",
                column: "AssetDraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetDraftReleaseStateId",
                table: "Assets",
                column: "AssetDraftReleaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetReleaseStateId",
                table: "Assets",
                column: "AssetReleaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetResourceId",
                table: "Assets",
                column: "AssetResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_AssetDraftStateId",
                table: "AssetDrafts",
                column: "AssetDraftStateId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_AssetTypeId",
                table: "AssetDrafts",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftReleaseStates_CreatedById",
                table: "AssetDraftReleaseStates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftReleaseStates_DeletedById",
                table: "AssetDraftReleaseStates",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftReleaseStates_ModifiedById",
                table: "AssetDraftReleaseStates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStates_CreatedById",
                table: "AssetDraftStates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStates_DeletedById",
                table: "AssetDraftStates",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDraftStates_ModifiedById",
                table: "AssetDraftStates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_CreatedById",
                table: "AssetTypes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_DeletedById",
                table: "AssetTypes",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_ModifiedById",
                table: "AssetTypes",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDrafts_AssetDraftStates_AssetDraftStateId",
                table: "AssetDrafts",
                column: "AssetDraftStateId",
                principalTable: "AssetDraftStates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetDrafts_AssetTypes_AssetTypeId",
                table: "AssetDrafts",
                column: "AssetTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetDraftReleaseStates_AssetDraftReleaseStateId",
                table: "Assets",
                column: "AssetDraftReleaseStateId",
                principalTable: "AssetDraftReleaseStates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetDrafts_AssetDraftId",
                table: "Assets",
                column: "AssetDraftId",
                principalTable: "AssetDrafts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetReleaseStates_AssetReleaseStateId",
                table: "Assets",
                column: "AssetReleaseStateId",
                principalTable: "AssetReleaseStates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetResources_AssetResourceId",
                table: "Assets",
                column: "AssetResourceId",
                principalTable: "AssetResources",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id");
        }
    }
}
