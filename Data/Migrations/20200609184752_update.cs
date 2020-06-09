using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Project.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a4ea41f-a1b9-4e77-b2f0-2904b1cfd0c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef7a9d6f-1ec4-4cac-8a85-f91a46832b42");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ee75284-be2e-4353-80a3-907f7be503ff", "1eddbc41-f97a-4065-91b8-f5c49402d542", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "712ef39a-7eb4-43ef-85bd-5ce7af975dd4", "62bdb8f5-c5ae-4b30-acbb-75ff7bdb2ab8", "NewUser", "NewUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee75284-be2e-4353-80a3-907f7be503ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "712ef39a-7eb4-43ef-85bd-5ce7af975dd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef7a9d6f-1ec4-4cac-8a85-f91a46832b42", "e472632f-7460-4396-8409-9f74b8d0862a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a4ea41f-a1b9-4e77-b2f0-2904b1cfd0c6", "2b15f80a-ff95-4ea1-9e97-db86caa2d426", "NewUser", "NewUser" });
        }
    }
}
