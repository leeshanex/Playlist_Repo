using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Playlist_Proj.Models;

namespace Playlist_Proj.Data
{
    public class Playlist_ProjContext : DbContext
    {
        public Playlist_ProjContext (DbContextOptions<Playlist_ProjContext> options)
            : base(options)
        {
        }

        public DbSet<Playlist_Proj.Models.User> User { get; set; }
    }
}
