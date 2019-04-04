using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Post
    {
        List<Comment> commentList = new List<Comment>();
        List<Like> likeList = new List<Like>();

        public int Post_id { get; set; }
        public string VideoPath { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int Account_id { get; set; }
        public int? Category_id { get; set; }

        public Post(string videoPath, string title,
                    string imagePath, int account_id, int? category_id)
        {
            VideoPath = videoPath;
            Title = title;
            ImagePath = imagePath;
            Account_id = account_id;
            Category_id = category_id;
        }

        public void AddCommentToPost(Comment comment)
        {
            commentList.Add(comment);
        }

        public void AddLikeToPost(Like like)
        {
            likeList.Add(like);
        }

        public void setFilePaths(string serverFolder)
        {
            ImagePath = Path.Combine(serverFolder + "-image.png");
            VideoPath = Path.Combine(serverFolder + "-video.gif");
        }
    }
}
