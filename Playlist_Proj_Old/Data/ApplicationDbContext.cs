using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Playlist_Project.Models;

namespace Playlist_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            {
                base.OnModelCreating(builder);

                builder
                    .HasAnnotation("ProductVersion", "3.0.1")
                    .HasAnnotation("Relational:MaxIdentifierLength", 128)
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                builder.Entity("Playlist_Project.Models.Music", b =>
                {
                    b.Property<int>("SongId")
                            .ValueGeneratedOnAdd()
                            .HasColumnType("int")
                            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist")
                            .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                            .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongTitle")
                            .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.ToTable("Music");

                    b.HasData(
                        new Music
                        {
                            SongId = 1,
                            SongTitle = "The Box",
                            Artist = "Roddy Ricch",
                            Genre = "Hip-Hop",
                        },
                            new Music
                            {
                                SongId = 2,
                                SongTitle = "Savage Remix",
                                Artist = "Meg Thee Stallion, Beyonce",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 3,
                                SongTitle = "It's Tricky",
                                Artist = "Run-D.M.C.",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 4,
                                SongTitle = "BOP",
                                Artist = "DaBaby",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 5,
                                SongTitle = "Life Is Good",
                                Artist = "Drake, Future",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 6,
                                SongTitle = "DNA",
                                Artist = "Kendrick Lamar",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 7,
                                SongTitle = "I Don't F**k With You",
                                Artist = "Big Sean",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 8,
                                SongTitle = "I Like It",
                                Artist = "Cardi B",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 9,
                                SongTitle = "Big Pimpin",
                                Artist = "Jay-Z",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 10,
                                SongTitle = "All Of The Lights",
                                Artist = "Kanye West",
                                Genre = "Hip-Hop",
                            },
                            new Music
                            {
                                SongId = 11,
                                SongTitle = "When Doves Cry",
                                Artist = "Prince",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 12,
                                SongTitle = "Island In The Sun",
                                Artist = "Weezer",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 13,
                                SongTitle = "Mr. Brightside",
                                Artist = "The Killers",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 14,
                                SongTitle = "Come Together",
                                Artist = "The Beatles",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 15,
                                SongTitle = "Don't Stop Believin",
                                Artist = "Journey",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 16,
                                SongTitle = "Back In Black",
                                Artist = "AC/DC",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 17,
                                SongTitle = "Can't Stop",
                                Artist = "Red Hot Chili Peppers",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 18,
                                SongTitle = "Heavy Soul",
                                Artist = "The Black Keys",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 19,
                                SongTitle = "Come As You Are",
                                Artist = "Nirvana",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 20,
                                SongTitle = "Sweet Child O' Mine",
                                Artist = "Guns N' Roses",
                                Genre = "Rock",
                            },
                            new Music
                            {
                                SongId = 21,
                                SongTitle = "Wake Me Up",
                                Artist = "Aviccii",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 22,
                                SongTitle = "Radioactive",
                                Artist = "Imagine Dragons",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 23,
                                SongTitle = "Love Song",
                                Artist = "Sara Baraeilles",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 24,
                                SongTitle = "My Love",
                                Artist = "Justin Timberlake",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 25,
                                SongTitle = "Umbrella",
                                Artist = "Rihanna",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 26,
                                SongTitle = "Somebody That I Used To Know",
                                Artist = "Gotye",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 27,
                                SongTitle = "Hotline Bling",
                                Artist = "Drake",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 28,
                                SongTitle = "Bye Bye Bye",
                                Artist = "*NSYNC",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 29,
                                SongTitle = "Thriller",
                                Artist = "Michael Jackson",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 30,
                                SongTitle = "Toxic",
                                Artist = "Britney Spears",
                                Genre = "Pop",
                            },
                            new Music
                            {
                                SongId = 31,
                                SongTitle = "One More Time",
                                Artist = "Daft Punk",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 32,
                                SongTitle = "Animals",
                                Artist = "Martin Garrix",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 33,
                                SongTitle = "We Found Love",
                                Artist = "Rihanna",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 34,
                                SongTitle = "Turn Down For What",
                                Artist = "Lil Jon",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 35,
                                SongTitle = "Don't You Worry Child",
                                Artist = "Swedish House Mafia",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 36,
                                SongTitle = "Waves",
                                Artist = "Mr. Probz",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 37,
                                SongTitle = "I Want you To Know",
                                Artist = "Zedd",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 38,
                                SongTitle = "Where Are U Now",
                                Artist = "Diplo, Skrillex, Justin Bieber",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 39,
                                SongTitle = "Sugar",
                                Artist = "Robin Schulz",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 40,
                                SongTitle = "White Noise",
                                Artist = "Disclose",
                                Genre = "Electronic",
                            },
                            new Music
                            {
                                SongId = 41,
                                SongTitle = "Pony",
                                Artist = "Ginuwine",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 42,
                                SongTitle = "Say My Name",
                                Artist = "Destiny's Child",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 43,
                                SongTitle = "It Wasn't Me",
                                Artist = "Shaggy",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 44,
                                SongTitle = "Halo",
                                Artist = "Beyonce",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 45,
                                SongTitle = "The Boy Is Mine",
                                Artist = "Brandy, Monica",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 46,
                                SongTitle = "Trip",
                                Artist = "Ella Mai",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 47,
                                SongTitle = "I Want You Around",
                                Artist = "Snoh Aalegra",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 48,
                                SongTitle = "Waterfalls",
                                Artist = "TLC",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 49,
                                SongTitle = "Redbone",
                                Artist = "Childish Gambino",
                                Genre = "R&B",
                            },
                            new Music
                            {
                                SongId = 50,
                                SongTitle = "My Boo",
                                Artist = "Usher, Alica Keys",
                                Genre = "R&B",
                            });

                });
            }
        }

        public DbSet<NewUser> NewUsers { get; set; }
       
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<FriendsList> FriendsLists { get; set; }

    }
}
