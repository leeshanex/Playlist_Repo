using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist_Proj.Models
{
    public class FriendsList
    {
        public int Id { get; set; }

        [ForeignKey("Friend1")]
        public int Friend1Id { get; set; }
        public NewUser Friend1 { get; set; }

       [ForeignKey("Friend2")]

        public int Friend2Id { get; set; }
        public NewUser Friend2 { get; set; }
    }
}
