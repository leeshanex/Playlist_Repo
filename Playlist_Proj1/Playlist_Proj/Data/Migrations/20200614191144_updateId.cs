using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Proj.Data.Migrations
{
    public partial class updateId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_NewUsers_Friend1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_NewUsers_Friend2Id",
                table: "Friends");

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserProfiles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "NewUsers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewUsers",
                table: "NewUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_NewUsers_Friend1Id",
                table: "Friends",
                column: "Friend1Id",
                principalTable: "NewUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_NewUsers_Friend2Id",
                table: "Friends",
                column: "Friend2Id",
                principalTable: "NewUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_NewUsers_Friend1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_NewUsers_Friend2Id",
                table: "Friends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewUsers",
                table: "NewUsers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "NewUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserProfileId",
                table: "UserProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NewUserId",
                table: "NewUsers",
                type: "int",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_NewUsers_Friend1Id",
                table: "Friends",
                column: "Friend1Id",
                principalTable: "NewUsers",
                principalColumn: "NewUserId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_NewUsers_Friend2Id",
                table: "Friends",
                column: "Friend2Id",
                principalTable: "NewUsers",
                principalColumn: "NewUserId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
