using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Like
    {
        public int LikeId { get; set; }
        public int AccountId { get; set; }
        public int? PostId { get; set; }
        public int? CommentId { get; set; }

    }
}
