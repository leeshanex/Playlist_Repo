using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Proj.Data.Migrations
{
    public partial class foreignKeyNewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "NewUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewUsers_IdentityUserId",
                table: "NewUsers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewUsers_AspNetUsers_IdentityUserId",
                table: "NewUsers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewUsers_AspNetUsers_IdentityUserId",
                table: "NewUsers");

            migrationBuilder.DropIndex(
                name: "IX_NewUsers_IdentityUserId",
                table: "NewUsers");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "NewUsers");
        }
    }
}
