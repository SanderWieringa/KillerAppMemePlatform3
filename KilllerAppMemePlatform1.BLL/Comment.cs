using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Comment
    {
        List<Like> likeList = new List<Like>();

        public int comment_id { get; set; }
        public string Text { get; set; }
        public int? account_id { get; set; }
        public int? post_id { get; set; }

        public void AddLikeToComment(Like like)
        {
            likeList.Add(like);
        }
    }
}
