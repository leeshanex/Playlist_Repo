using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Project.Data.Migrations
{
    public partial class userS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17b6548f-4180-40aa-ae1d-0076a924113c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5599027b-ba29-47cc-a32f-422d3ae3c933");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef7a9d6f-1ec4-4cac-8a85-f91a46832b42", "e472632f-7460-4396-8409-9f74b8d0862a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a4ea41f-a1b9-4e77-b2f0-2904b1cfd0c6", "2b15f80a-ff95-4ea1-9e97-db86caa2d426", "NewUser", "NewUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "17b6548f-4180-40aa-ae1d-0076a924113c", "31bdf00d-9394-46f0-b32e-accf4ed7681d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5599027b-ba29-47cc-a32f-422d3ae3c933", "52ee4cfe-004d-4a45-b6a2-0e653bd8908f", "New User", "New User" });
        }
    }
}
