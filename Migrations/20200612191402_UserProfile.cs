using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Project.Migrations
{
    public partial class UserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47af8efa-1039-438d-b51d-76602a2f9967");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "NewUsers");

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    FavoriteMusicGenre = table.Column<string>(nullable: true),
                    FriendsList = table.Column<string>(nullable: true),
                    LikedMusic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d128da00-6fc1-46ad-bc4b-2a7795c3e1be", "51eda51c-b430-485c-a04b-b965b8615b86", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d993c0fd-d7ef-487a-b9bb-1f85d39c2c5a", "aec3e072-219f-465b-8c5b-24cebf99ba61", "NewUser", "NEWUSER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d128da00-6fc1-46ad-bc4b-2a7795c3e1be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d993c0fd-d7ef-487a-b9bb-1f85d39c2c5a");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "NewUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47af8efa-1039-438d-b51d-76602a2f9967", "d74c1f39-1db8-4c32-898b-4da6f2b311f0", "NewUser", "NEWUSER" });
        }
    }
}
