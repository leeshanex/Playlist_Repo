using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Proj.Data.Migrations
{
    public partial class idUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewUser",
                table: "NewUser");

            migrationBuilder.RenameTable(
                name: "UserProfile",
                newName: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "NewUser",
                newName: "NewUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "UserProfiles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "UserProfiles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "NewUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "NewUserId",
                table: "NewUsers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "UserProfileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewUsers",
                table: "NewUsers",
                column: "NewUserId");

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friend1Id = table.Column<int>(nullable: false),
                    Friend2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friends_NewUsers_Friend1Id",
                        column: x => x.Friend1Id,
                        principalTable: "NewUsers",
                        principalColumn: "NewUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friends_NewUsers_Friend2Id",
                        column: x => x.Friend2Id,
                        principalTable: "NewUsers",
                        principalColumn: "NewUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongTitle = table.Column<string>(nullable: true),
                    Artist = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.SongId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_Friend1Id",
                table: "Friends",
                column: "Friend1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_Friend2Id",
                table: "Friends",
                column: "Friend2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Musics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewUsers",
                table: "NewUsers");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "NewUserId",
                table: "NewUsers");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "UserProfile");

            migrationBuilder.RenameTable(
                name: "NewUsers",
                newName: "NewUser");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "UserProfile",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "NewUser",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile",
                column: "Image");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewUser",
                table: "NewUser",
                column: "FirstName");
        }
    }
}
