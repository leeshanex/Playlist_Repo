using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Proj.Data.Migrations
{
    public partial class KeyForMusic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewUser",
                columns: table => new
                {
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewUser", x => x.FirstName);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Image = table.Column<string>(nullable: false),
                    FavoriteMusicGenre = table.Column<string>(nullable: true),
                    FriendsList = table.Column<string>(nullable: true),
                    LikedMusic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Image);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewUser");

            migrationBuilder.DropTable(
                name: "UserProfile");
        }
    }
}
