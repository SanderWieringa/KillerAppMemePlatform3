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

        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }

        public IPostDAL PostDAL { get; private set; } = KillerAppDALFactory.CreatePostDAL();

        public Post(PostStruct postStruct)
        {
            PostId = postStruct.PostId;
            FilePath = postStruct.FilePath;
            Title = postStruct.Title;
            AccountId = postStruct.AccountId;
            CategoryId = postStruct.CategoryId;
            StatusId = postStruct.StatusId;
        }

        public Post()
        {

        }

        public void Update()
        {
            PostStruct postStruct = new PostStruct(PostId, FilePath, Title, AccountId, CategoryId, StatusId);
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
