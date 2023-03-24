using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenMarketPlace.Persistance.Migrations
{
    public partial class UDb006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetMediaLink_Assets_AssetId",
                table: "AssetMediaLink");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_AspNetUsers_RatedById",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_Assets_AssetId",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReviews_AspNetUsers_AuthorId",
                table: "AssetReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AspNetUsers_CreatedById",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetResources_AssetResourceId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Publishers_PublisherId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_Assets_AssetId",
                table: "AssetTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_Keywords_TagId",
                table: "AssetTags");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "EngineVersions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publishers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "Publishers",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Publishers",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Publishers",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "EngineVersions",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "EngineVersions",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "EngineVersions",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "EngineVersions",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetTypes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetTypes",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetTypes",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetTypes",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "AssetTags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetTags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetTags",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetTags",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetTags",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "AssetTags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Assets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NugetPackage",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "Assets",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "License",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LatestVersion",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IconImage",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "GitRepository",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EngineCompatibility",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Assets",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Assets",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BannerImage",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetResourceId",
                table: "Assets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AssetDraftId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetDraftReleaseStateId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetReviews",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AssetReviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetReviews",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetReviews",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "AssetReviews",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetResources",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IconImage",
                table: "AssetResources",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetResources",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetResources",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BannerImage",
                table: "AssetResources",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetReleaseStates",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetReleaseStates",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetReleaseStates",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetReleaseStates",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "RatedById",
                table: "AssetRatings",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "AssetRatings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetRatings",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetRatings",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetRatings",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "AssetRatings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetMediaLink",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "MediaLink",
                table: "AssetMediaLink",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetMediaLink",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetMediaLink",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "AssetMediaLink",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Asset",
                table: "AssetMediaLink",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAgreeingToPublisherTermsOfService",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.CreateTable(
                name: "AssetDraftReleaseStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
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
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tags_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tags_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssetDrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssetDraftStateId = table.Column<int>(type: "int", nullable: true),
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Reviews = table.Column<int>(type: "int", nullable: false),
                    BannerImage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IconImage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EngineCompatibility = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GitRepository = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LatestVersion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    License = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NugetPackage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ReleasedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetDrafts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDrafts_AspNetUsers_DeletedById",
                        column: x => x.DeletedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDrafts_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDrafts_AssetDraftStates_AssetDraftStateId",
                        column: x => x.AssetDraftStateId,
                        principalTable: "AssetDraftStates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetDrafts_AssetTypes_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetTypes",
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
                keyValue: 2,
                column: "Name",
                value: "InitDraft");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_CreatedById",
                table: "Publishers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_DeletedById",
                table: "Publishers",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_ModifiedById",
                table: "Publishers",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineVersions_CreatedById",
                table: "EngineVersions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineVersions_DeletedById",
                table: "EngineVersions",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineVersions_ModifiedById",
                table: "EngineVersions",
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

            migrationBuilder.CreateIndex(
                name: "IX_AssetTags_CreatedById",
                table: "AssetTags",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTags_DeletedById",
                table: "AssetTags",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTags_ModifiedById",
                table: "AssetTags",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetDraftId",
                table: "Assets",
                column: "AssetDraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetDraftReleaseStateId",
                table: "Assets",
                column: "AssetDraftReleaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_DeletedById",
                table: "Assets",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_ModifiedById",
                table: "Assets",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReviews_CreatedById",
                table: "AssetReviews",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReviews_DeletedById",
                table: "AssetReviews",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReviews_ModifiedById",
                table: "AssetReviews",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetResources_CreatedById",
                table: "AssetResources",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetResources_DeletedById",
                table: "AssetResources",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetResources_ModifiedById",
                table: "AssetResources",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReleaseStates_CreatedById",
                table: "AssetReleaseStates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReleaseStates_DeletedById",
                table: "AssetReleaseStates",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetReleaseStates_ModifiedById",
                table: "AssetReleaseStates",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRatings_CreatedById",
                table: "AssetRatings",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRatings_DeletedById",
                table: "AssetRatings",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRatings_ModifiedById",
                table: "AssetRatings",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetMediaLink_CreatedById",
                table: "AssetMediaLink",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetMediaLink_DeletedById",
                table: "AssetMediaLink",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetMediaLink_ModifiedById",
                table: "AssetMediaLink",
                column: "ModifiedById");

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
                name: "IX_AssetDrafts_AssetDraftStateId",
                table: "AssetDrafts",
                column: "AssetDraftStateId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_AssetTypeId",
                table: "AssetDrafts",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_CreatedById",
                table: "AssetDrafts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_DeletedById",
                table: "AssetDrafts",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDrafts_ModifiedById",
                table: "AssetDrafts",
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
                name: "IX_Tags_CreatedById",
                table: "Tags",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_DeletedById",
                table: "Tags",
                column: "DeletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ModifiedById",
                table: "Tags",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetMediaLink_AspNetUsers_CreatedById",
                table: "AssetMediaLink",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetMediaLink_AspNetUsers_DeletedById",
                table: "AssetMediaLink",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetMediaLink_AspNetUsers_ModifiedById",
                table: "AssetMediaLink",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetMediaLink_Assets_AssetId",
                table: "AssetMediaLink",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_AspNetUsers_CreatedById",
                table: "AssetRatings",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_AspNetUsers_DeletedById",
                table: "AssetRatings",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_AspNetUsers_ModifiedById",
                table: "AssetRatings",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_AspNetUsers_RatedById",
                table: "AssetRatings",
                column: "RatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_Assets_AssetId",
                table: "AssetRatings",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReleaseStates_AspNetUsers_CreatedById",
                table: "AssetReleaseStates",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReleaseStates_AspNetUsers_DeletedById",
                table: "AssetReleaseStates",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReleaseStates_AspNetUsers_ModifiedById",
                table: "AssetReleaseStates",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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
                name: "FK_AssetReviews_AspNetUsers_AuthorId",
                table: "AssetReviews",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReviews_AspNetUsers_CreatedById",
                table: "AssetReviews",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReviews_AspNetUsers_DeletedById",
                table: "AssetReviews",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReviews_AspNetUsers_ModifiedById",
                table: "AssetReviews",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AspNetUsers_CreatedById",
                table: "Assets",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AspNetUsers_DeletedById",
                table: "Assets",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AspNetUsers_ModifiedById",
                table: "Assets",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
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
                name: "FK_Assets_AssetResources_AssetResourceId",
                table: "Assets",
                column: "AssetResourceId",
                principalTable: "AssetResources",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Publishers_PublisherId",
                table: "Assets",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_AspNetUsers_CreatedById",
                table: "AssetTags",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_AspNetUsers_DeletedById",
                table: "AssetTags",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_AspNetUsers_ModifiedById",
                table: "AssetTags",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_Assets_AssetId",
                table: "AssetTags",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_Tags_TagId",
                table: "AssetTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_AspNetUsers_CreatedById",
                table: "AssetTypes",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_AspNetUsers_DeletedById",
                table: "AssetTypes",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_AspNetUsers_ModifiedById",
                table: "AssetTypes",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineVersions_AspNetUsers_CreatedById",
                table: "EngineVersions",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineVersions_AspNetUsers_DeletedById",
                table: "EngineVersions",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineVersions_AspNetUsers_ModifiedById",
                table: "EngineVersions",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_AspNetUsers_CreatedById",
                table: "Publishers",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_AspNetUsers_DeletedById",
                table: "Publishers",
                column: "DeletedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Publishers_AspNetUsers_ModifiedById",
                table: "Publishers",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetMediaLink_AspNetUsers_CreatedById",
                table: "AssetMediaLink");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetMediaLink_AspNetUsers_DeletedById",
                table: "AssetMediaLink");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetMediaLink_AspNetUsers_ModifiedById",
                table: "AssetMediaLink");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetMediaLink_Assets_AssetId",
                table: "AssetMediaLink");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_AspNetUsers_CreatedById",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_AspNetUsers_DeletedById",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_AspNetUsers_ModifiedById",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_AspNetUsers_RatedById",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRatings_Assets_AssetId",
                table: "AssetRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReleaseStates_AspNetUsers_CreatedById",
                table: "AssetReleaseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReleaseStates_AspNetUsers_DeletedById",
                table: "AssetReleaseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReleaseStates_AspNetUsers_ModifiedById",
                table: "AssetReleaseStates");

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
                name: "FK_AssetReviews_AspNetUsers_AuthorId",
                table: "AssetReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReviews_AspNetUsers_CreatedById",
                table: "AssetReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReviews_AspNetUsers_DeletedById",
                table: "AssetReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetReviews_AspNetUsers_ModifiedById",
                table: "AssetReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AspNetUsers_CreatedById",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AspNetUsers_DeletedById",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AspNetUsers_ModifiedById",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetDraftReleaseStates_AssetDraftReleaseStateId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetDrafts_AssetDraftId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetResources_AssetResourceId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Publishers_PublisherId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_AspNetUsers_CreatedById",
                table: "AssetTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_AspNetUsers_DeletedById",
                table: "AssetTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_AspNetUsers_ModifiedById",
                table: "AssetTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_Assets_AssetId",
                table: "AssetTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTags_Tags_TagId",
                table: "AssetTags");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_AspNetUsers_CreatedById",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_AspNetUsers_DeletedById",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_AspNetUsers_ModifiedById",
                table: "AssetTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineVersions_AspNetUsers_CreatedById",
                table: "EngineVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineVersions_AspNetUsers_DeletedById",
                table: "EngineVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineVersions_AspNetUsers_ModifiedById",
                table: "EngineVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_AspNetUsers_CreatedById",
                table: "Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_AspNetUsers_DeletedById",
                table: "Publishers");

            migrationBuilder.DropForeignKey(
                name: "FK_Publishers_AspNetUsers_ModifiedById",
                table: "Publishers");

            migrationBuilder.DropTable(
                name: "AssetDraftReleaseStates");

            migrationBuilder.DropTable(
                name: "AssetDrafts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "AssetDraftStates");

            migrationBuilder.DropIndex(
                name: "IX_Publishers_CreatedById",
                table: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Publishers_DeletedById",
                table: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Publishers_ModifiedById",
                table: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_EngineVersions_CreatedById",
                table: "EngineVersions");

            migrationBuilder.DropIndex(
                name: "IX_EngineVersions_DeletedById",
                table: "EngineVersions");

            migrationBuilder.DropIndex(
                name: "IX_EngineVersions_ModifiedById",
                table: "EngineVersions");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_CreatedById",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_DeletedById",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_ModifiedById",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTags_CreatedById",
                table: "AssetTags");

            migrationBuilder.DropIndex(
                name: "IX_AssetTags_DeletedById",
                table: "AssetTags");

            migrationBuilder.DropIndex(
                name: "IX_AssetTags_ModifiedById",
                table: "AssetTags");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetDraftId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetDraftReleaseStateId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_DeletedById",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_ModifiedById",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_AssetReviews_CreatedById",
                table: "AssetReviews");

            migrationBuilder.DropIndex(
                name: "IX_AssetReviews_DeletedById",
                table: "AssetReviews");

            migrationBuilder.DropIndex(
                name: "IX_AssetReviews_ModifiedById",
                table: "AssetReviews");

            migrationBuilder.DropIndex(
                name: "IX_AssetResources_CreatedById",
                table: "AssetResources");

            migrationBuilder.DropIndex(
                name: "IX_AssetResources_DeletedById",
                table: "AssetResources");

            migrationBuilder.DropIndex(
                name: "IX_AssetResources_ModifiedById",
                table: "AssetResources");

            migrationBuilder.DropIndex(
                name: "IX_AssetReleaseStates_CreatedById",
                table: "AssetReleaseStates");

            migrationBuilder.DropIndex(
                name: "IX_AssetReleaseStates_DeletedById",
                table: "AssetReleaseStates");

            migrationBuilder.DropIndex(
                name: "IX_AssetReleaseStates_ModifiedById",
                table: "AssetReleaseStates");

            migrationBuilder.DropIndex(
                name: "IX_AssetRatings_CreatedById",
                table: "AssetRatings");

            migrationBuilder.DropIndex(
                name: "IX_AssetRatings_DeletedById",
                table: "AssetRatings");

            migrationBuilder.DropIndex(
                name: "IX_AssetRatings_ModifiedById",
                table: "AssetRatings");

            migrationBuilder.DropIndex(
                name: "IX_AssetMediaLink_CreatedById",
                table: "AssetMediaLink");

            migrationBuilder.DropIndex(
                name: "IX_AssetMediaLink_DeletedById",
                table: "AssetMediaLink");

            migrationBuilder.DropIndex(
                name: "IX_AssetMediaLink_ModifiedById",
                table: "AssetMediaLink");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "EngineVersions");

            migrationBuilder.DropColumn(
                name: "AssetDraftId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AssetDraftReleaseStateId",
                table: "Assets");

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publishers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "Publishers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Publishers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Publishers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "EngineVersions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "EngineVersions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "EngineVersions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EngineVersions",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetTypes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetTypes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetTypes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetTypes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "AssetTags",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AssetTags",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetTags",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetTags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetTags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetTags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "AssetTags",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "NugetPackage",
                keyValue: null,
                column: "NugetPackage",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NugetPackage",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "License",
                keyValue: null,
                column: "License",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "License",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "LatestVersion",
                keyValue: null,
                column: "LatestVersion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "LatestVersion",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "IconImage",
                keyValue: null,
                column: "IconImage",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "IconImage",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "GitRepository",
                keyValue: null,
                column: "GitRepository",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "GitRepository",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "EngineCompatibility",
                keyValue: null,
                column: "EngineCompatibility",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "EngineCompatibility",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "Assets",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "CreatedById",
                keyValue: null,
                column: "CreatedById",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Assets",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "BannerImage",
                keyValue: null,
                column: "BannerImage",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "BannerImage",
                table: "Assets",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetResourceId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetReviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetReviews",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AssetReviews",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetReviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetReviews",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetReviews",
                keyColumn: "AuthorId",
                keyValue: null,
                column: "AuthorId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "AssetReviews",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetResources",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetResources",
                keyColumn: "IconImage",
                keyValue: null,
                column: "IconImage",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "IconImage",
                table: "AssetResources",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetResources",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetResources",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetResources",
                keyColumn: "BannerImage",
                keyValue: null,
                column: "BannerImage",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "BannerImage",
                table: "AssetResources",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetReleaseStates",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetReleaseStates",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetReleaseStates",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetReleaseStates",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetReleaseStates",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetRatings",
                keyColumn: "RatedById",
                keyValue: null,
                column: "RatedById",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "RatedById",
                table: "AssetRatings",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "AssetRatings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetRatings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetRatings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetRatings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "AssetRatings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedById",
                table: "AssetMediaLink",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetMediaLink",
                keyColumn: "MediaLink",
                keyValue: null,
                column: "MediaLink",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "MediaLink",
                table: "AssetMediaLink",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedById",
                table: "AssetMediaLink",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "AssetMediaLink",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "AssetMediaLink",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Asset",
                table: "AssetMediaLink",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAgreeingToPublisherTermsOfService",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedById = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedById = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsModified = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AssetReleaseStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Draft");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetMediaLink_Assets_AssetId",
                table: "AssetMediaLink",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_AspNetUsers_RatedById",
                table: "AssetRatings",
                column: "RatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRatings_Assets_AssetId",
                table: "AssetRatings",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetReviews_AspNetUsers_AuthorId",
                table: "AssetReviews",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AspNetUsers_CreatedById",
                table: "Assets",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetResources_AssetResourceId",
                table: "Assets",
                column: "AssetResourceId",
                principalTable: "AssetResources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Publishers_PublisherId",
                table: "Assets",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_Assets_AssetId",
                table: "AssetTags",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTags_Keywords_TagId",
                table: "AssetTags",
                column: "TagId",
                principalTable: "Keywords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
