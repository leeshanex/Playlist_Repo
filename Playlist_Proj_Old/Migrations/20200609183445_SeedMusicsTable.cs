using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Playlist_Project.Migrations
{
    public partial class SeedMusicsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Music");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
