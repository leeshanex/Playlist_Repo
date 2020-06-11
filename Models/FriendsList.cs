using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Project.Models
{
    public class FriendsList
    {
        public int Id { get; set; }
        public string friendName { get; set; }

        [ForeignKey("friendId1")]
        public int friendId { get; set; }
        public NewUser friendId1 { get; set; }

        [ForeignKey("friendId2")]

        public int friendIdTwo { get; set; }
        public NewUser friendId2 { get; set; }
    }
}
