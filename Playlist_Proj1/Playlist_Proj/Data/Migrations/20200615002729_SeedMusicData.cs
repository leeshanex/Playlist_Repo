using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Proj.Data.Migrations
{
    public partial class SeedMusicData : Migration
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
                name: "Id",
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

            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Music",
                columns: new[] { "SongId", "Artist", "Genre", "SongTitle" },
                values: new object[,]
                {
                    { 1, "Roddy Ricch", "Hip-Hop", "The Box" },
                    { 28, "*NSYNC", "Pop", "Bye Bye Bye" },
                    { 29, "Michael Jackson", "Pop", "Thriller" },
                    { 30, "Britney Spears", "Pop", "Toxic" },
                    { 31, "Daft Punk", "Electronic", "One More Time" },
                    { 32, "Martin Garrix", "Electronic", "Animals" },
                    { 33, "Rihanna", "Electronic", "We Found Love" },
                    { 34, "Lil Jon", "Electronic", "Turn Down For What" },
                    { 35, "Swedish House Mafia", "Electronic", "Don't You Worry Child" },
                    { 36, "Mr. Probz", "Electronic", "Waves" },
                    { 37, "Zedd", "Electronic", "I Want you To Know" },
                    { 38, "Diplo, Skrillex, Justin Bieber", "Electronic", "Where Are U Now" },
                    { 39, "Robin Schulz", "Electronic", "Sugar" },
                    { 40, "Disclose", "Electronic", "White Noise" },
                    { 41, "Ginuwine", "R&B", "Pony" },
                    { 42, "Destiny's Child", "R&B", "Say My Name" },
                    { 43, "Shaggy", "R&B", "It Wasn't Me" },
                    { 44, "Beyonce", "R&B", "Halo" },
                    { 45, "Brandy, Monica", "R&B", "The Boy Is Mine" },
                    { 46, "Ella Mai", "R&B", "Trip" },
                    { 47, "Snoh Aalegra", "R&B", "I Want You Around" },
                    { 48, "TLC", "R&B", "Waterfalls" },
                    { 27, "Drake", "Pop", "Hotline Bling" },
                    { 26, "Gotye", "Pop", "Somebody That I Used To Know" },
                    { 25, "Rihanna", "Pop", "Umbrella" },
                    { 24, "Justin Timberlake", "Pop", "My Love" },
                    { 2, "Meg Thee Stallion, Beyonce", "Hip-Hop", "Savage Remix" },
                    { 3, "Run-D.M.C.", "Hip-Hop", "It's Tricky" },
                    { 4, "DaBaby", "Hip-Hop", "BOP" },
                    { 5, "Drake, Future", "Hip-Hop", "Life Is Good" },
                    { 6, "Kendrick Lamar", "Hip-Hop", "DNA" },
                    { 7, "Big Sean", "Hip-Hop", "I Don't F**k With You" },
                    { 8, "Cardi B", "Hip-Hop", "I Like It" },
                    { 9, "Jay-Z", "Hip-Hop", "Big Pimpin" },
                    { 10, "Kanye West", "Hip-Hop", "All Of The Lights" },
                    { 11, "Prince", "Rock", "When Doves Cry" },
                    { 49, "Childish Gambino", "R&B", "Redbone" },
                    { 12, "Weezer", "Rock", "Island In The Sun" },
                    { 14, "The Beatles", "Rock", "Come Together" },
                    { 15, "Journey", "Rock", "Don't Stop Believin" },
                    { 16, "AC/DC", "Rock", "Back In Black" },
                    { 17, "Red Hot Chili Peppers", "Rock", "Can't Stop" },
                    { 18, "The Black Keys", "Rock", "Heavy Soul" },
                    { 19, "Nirvana", "Rock", "Come As You Are" },
                    { 20, "Guns N' Roses", "Rock", "Sweet Child O' Mine" },
                    { 21, "Aviccii", "Pop", "Wake Me Up" },
                    { 22, "Imagine Dragons", "Pop", "Radioactive" },
                    { 23, "Sara Baraeilles", "Pop", "Love Song" },
                    { 13, "The Killers", "Rock", "Mr. Brightside" },
                    { 50, "Usher, Alica Keys", "R&B", "My Boo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Music");

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
