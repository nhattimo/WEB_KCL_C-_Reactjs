using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KCL_Web.Server.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PostingCategories_PostingCategoryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProductCatogories_ProductCatogoryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_AppUserId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCatogories_CatogoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCatogories");

            migrationBuilder.DropIndex(
                name: "IX_Products_AppUserId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PostingCategoryId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProductCatogoryId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57bfda48-b15c-494d-a488-cf9fc4423395");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59707eef-ee39-45e1-816f-d84651f8013b");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PostingCategoryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProductCatogoryId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CatogoryId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatogoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "PostingCategories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategorys_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a5e8357-1fa8-4d49-928b-c2988cbafc74", null, "User", "USER" },
                    { "db062853-2999-462d-b77a-5b12e08837d3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppUserId",
                table: "Products",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AppUserId",
                table: "Posts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingCategories_AppUserId",
                table: "PostingCategories",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategorys_AppUserId",
                table: "ProductCategorys",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostingCategories_AspNetUsers_AppUserId",
                table: "PostingCategories",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AppUserId",
                table: "Posts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_AppUserId",
                table: "Products",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategorys_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategorys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostingCategories_AspNetUsers_AppUserId",
                table: "PostingCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AppUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_AppUserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategorys_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategorys");

            migrationBuilder.DropIndex(
                name: "IX_Products_AppUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AppUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_PostingCategories_AppUserId",
                table: "PostingCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a5e8357-1fa8-4d49-928b-c2988cbafc74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db062853-2999-462d-b77a-5b12e08837d3");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CatogoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_CatogoryId");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "PostingCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostingCategoryId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCatogoryId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductCatogories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCatogories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57bfda48-b15c-494d-a488-cf9fc4423395", null, "User", "USER" },
                    { "59707eef-ee39-45e1-816f-d84651f8013b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppUserId1",
                table: "Products",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PostingCategoryId",
                table: "AspNetUsers",
                column: "PostingCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProductCatogoryId",
                table: "AspNetUsers",
                column: "ProductCatogoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PostingCategories_PostingCategoryId",
                table: "AspNetUsers",
                column: "PostingCategoryId",
                principalTable: "PostingCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ProductCatogories_ProductCatogoryId",
                table: "AspNetUsers",
                column: "ProductCatogoryId",
                principalTable: "ProductCatogories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_AppUserId1",
                table: "Products",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCatogories_CatogoryId",
                table: "Products",
                column: "CatogoryId",
                principalTable: "ProductCatogories",
                principalColumn: "Id");
        }
    }
}
