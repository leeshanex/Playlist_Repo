using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Proj.Models
{
    public class User
    {
        [KEY]
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        public string Image { get; set; }

        [ForeignKey("IdentityUser")]

        public string ApplicationUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
