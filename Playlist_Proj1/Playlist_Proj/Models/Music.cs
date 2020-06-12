using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Proj.Models
{
    public class Music
    {
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
