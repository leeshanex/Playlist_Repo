﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Project.Models
{
    public class UserProfile
    {
        [Key]
        [Display(Name = "Profile Picture")]
        public string Image { get; set; }

        [Display(Name = "Favorite Music Genre")]
        public string FavoriteMusicGenre { get; set; }

        [Display(Name = "Friends List" )]
        public string FriendsList { get; set; }

        [Display(Name = "Liked Music")]
        public string LikedMusic { get; set; }
    }
}