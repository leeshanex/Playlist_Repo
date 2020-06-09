using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Project.Models
{
    public class Music
    {
        // We dont specify [Key] here becuase by using conventions it knows SongID is the PK based off of its name.
        [Key]
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        
    }


}
