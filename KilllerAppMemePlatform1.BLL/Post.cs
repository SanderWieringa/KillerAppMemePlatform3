using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Post : IPost
    {
        List<Comment> commentList = new List<Comment>();
        List<Like> likeList = new List<Like>();

        public int Post_id { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int Account_id { get; set; }
        public int Category_id { get; set; }

        public IPostDAL PostDAL { get; private set; } = KillerAppDALFactory.CreatePostDAL();

        public Post(PostStruct postStruct)
        {
            Post_id = postStruct.Post_id;
            FilePath = postStruct.FilePath;
            Title = postStruct.Title;
            Account_id = postStruct.Account_id;
            Category_id = postStruct.Category_id;
        }

        public Post()
        {

        }

        public void Update()
        {
            PostStruct postStruct = new PostStruct(Post_id, FilePath, Title, Account_id, Category_id);
            PostDAL.Update(postStruct);
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
            FilePath = Path.Combine(serverFolder + "-image.png");
        }

        
    }
}
