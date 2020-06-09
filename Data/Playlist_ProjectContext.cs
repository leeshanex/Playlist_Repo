using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Playlist_Project.Models;

namespace Playlist_Project.Data
{
    public class Playlist_ProjectContext : DbContext
    {
        public Playlist_ProjectContext (DbContextOptions<Playlist_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Playlist_Project.Models.Music> Music { get; set; }
    }
}
