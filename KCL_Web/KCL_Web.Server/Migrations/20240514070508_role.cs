using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KCL_Web.Server.Migrations
{
    /// <inheritdoc />
    public partial class role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PostingCategories_PostingCategoriesCategoryId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_ProductCatogories_ProductCatogoriesId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Products_ProductsId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_PostingCategories_Accounts_AccountId",
                table: "PostingCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCatogories_Accounts_AccountId",
                table: "ProductCatogories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Accounts_AccountId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccountId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductCatogories_AccountId",
                table: "ProductCatogories");

            migrationBuilder.DropIndex(
                name: "IX_PostingCategories_AccountId",
                table: "PostingCategories");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_PostingCategoriesCategoryId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ProductCatogoriesId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ProductsId",
                table: "Portfolios");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20dd8063-a438-43b2-ba0d-1df371661dc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f3026c3-0565-45d1-b435-34a4fbd43874");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PostingCategoriesCategoryId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProductCatogoriesId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Products",
                newName: "PortfolioId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "ProductCatogories",
                newName: "PortfolioId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "PostingCategories",
                newName: "PortfolioId");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioAppUserId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostingCategoryId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCatogoryId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71310366-5418-4e26-86d3-bd37c64e6ea9", null, "User", "USER" },
                    { "b63a6847-c9af-409c-a31c-833f8ed8fb78", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PortfolioAppUserId",
                table: "Products",
                column: "PortfolioAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PostingCategoryId",
                table: "Portfolios",
                column: "PostingCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ProductCatogoryId",
                table: "Portfolios",
                column: "ProductCatogoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PostingCategories_PostingCategoryId",
                table: "Portfolios",
                column: "PostingCategoryId",
                principalTable: "PostingCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_ProductCatogories_ProductCatogoryId",
                table: "Portfolios",
                column: "ProductCatogoryId",
                principalTable: "ProductCatogories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Portfolios_PortfolioAppUserId",
                table: "Products",
                column: "PortfolioAppUserId",
                principalTable: "Portfolios",
                principalColumn: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PostingCategories_PostingCategoryId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_ProductCatogories_ProductCatogoryId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Portfolios_PortfolioAppUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PortfolioAppUserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_PostingCategoryId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ProductCatogoryId",
                table: "Portfolios");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71310366-5418-4e26-86d3-bd37c64e6ea9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b63a6847-c9af-409c-a31c-833f8ed8fb78");

            migrationBuilder.DropColumn(
                name: "PortfolioAppUserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PostingCategoryId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ProductCatogoryId",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "Products",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "ProductCatogories",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "PortfolioId",
                table: "PostingCategories",
                newName: "AccountId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostingCategoriesCategoryId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductCatogoriesId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20dd8063-a438-43b2-ba0d-1df371661dc5", null, "User", "USER" },
                    { "2f3026c3-0565-45d1-b435-34a4fbd43874", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccountId",
                table: "Products",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatogories_AccountId",
                table: "ProductCatogories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PostingCategories_AccountId",
                table: "PostingCategories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PostingCategoriesCategoryId",
                table: "Portfolios",
                column: "PostingCategoriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ProductCatogoriesId",
                table: "Portfolios",
                column: "ProductCatogoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ProductsId",
                table: "Portfolios",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PostingCategories_PostingCategoriesCategoryId",
                table: "Portfolios",
                column: "PostingCategoriesCategoryId",
                principalTable: "PostingCategories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_ProductCatogories_ProductCatogoriesId",
                table: "Portfolios",
                column: "ProductCatogoriesId",
                principalTable: "ProductCatogories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Products_ProductsId",
                table: "Portfolios",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostingCategories_Accounts_AccountId",
                table: "PostingCategories",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCatogories_Accounts_AccountId",
                table: "ProductCatogories",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Accounts_AccountId",
                table: "Products",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId");
        }
    }
}
