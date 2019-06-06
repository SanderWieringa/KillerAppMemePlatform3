using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Account
    {
        List<Post> postList = new List<Post>();
        List<Comment> commentList = new List<Comment>();

        public int account_id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePhotoPath { get; set; }

        public void AddPost(Post post)
        {
            postList.Add(post);
        }

        public void AddComment(Comment comment)
        {
            commentList.Add(comment);
        }
    }
}
