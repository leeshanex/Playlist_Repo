using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Proj.Models
{
    public class NewUser
    {
        [Key]
        public int NewUserId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}
