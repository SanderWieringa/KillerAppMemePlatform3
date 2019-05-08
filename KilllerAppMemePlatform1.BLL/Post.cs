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
        public IPostRepository PostDAL { get; private set; } = KillerAppDALFactory.CreatePostDAL();

        List<Comment> commentList = new List<Comment>();
        List<Like> likeList = new List<Like>();

        //public int PostId { get; private set; }
        //public string FilePath { get; private set; }
        //public string Title { get; private set; }
        //public int AccountId { get; private set; }
        //public int CategoryId { get; private set; }
        //public int StatusId { get; private set; }

        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }

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

        public PostStruct Convert(IPost post)
        {
            return new PostStruct(post.PostId, post.FilePath, post.Title, post.AccountId, post.CategoryId, post.StatusId); // TODO invullen
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

        bool IPost.Update()
        {
            throw new NotImplementedException();
        }
    }
}
