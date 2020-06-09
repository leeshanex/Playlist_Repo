using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Project.Models
{
    public class Music
    {
        // We dont specify [Key] here becuase by using conventions it knows SongID is the PK based off of its name.
        [Key]
        public int SongId { get; set; }
        [Display(Name = "Song Title")]
        public string SongTitle { get; set; }
        [Display(Name = "Artist")]
        public string Artist { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }

    }


}
