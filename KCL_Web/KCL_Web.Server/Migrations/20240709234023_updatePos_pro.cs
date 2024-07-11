using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KCL_Web.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatePos_pro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e1a0489-7d6f-4382-89e0-aaaab6f89450");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e71136ce-0443-4c18-b24c-bfb37c8d5a0c");

            migrationBuilder.AddColumn<string>(
                name: "IntroContent",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IntroContent",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "677934e9-3212-48ef-8ecb-15a8004e68fa", null, "User", "USER" },
                    { "f45fb86e-7310-45ce-898a-9378081af424", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "677934e9-3212-48ef-8ecb-15a8004e68fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f45fb86e-7310-45ce-898a-9378081af424");

            migrationBuilder.DropColumn(
                name: "IntroContent",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IntroContent",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e1a0489-7d6f-4382-89e0-aaaab6f89450", null, "User", "USER" },
                    { "e71136ce-0443-4c18-b24c-bfb37c8d5a0c", null, "Admin", "ADMIN" }
                });
        }
    }
}
