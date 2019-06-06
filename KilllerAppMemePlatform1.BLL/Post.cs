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
        private IPostRepository PostDAL = KillerAppDALFactory.CreatePostDAL();

        List<Comment> commentList = new List<Comment>();
        List<Like> likeList = new List<Like>();

        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        //public int AccountId { get; set; }
        //public int StatusId { get; set; }
        //public int CategoryId { get; set; }

        public Account account { get; private set; }

        public Post(PostStruct postStruct)
        {
            PostId = postStruct.PostId;
            FilePath = postStruct.FilePath;
            Title = postStruct.Title;
            //AccountId = postStruct.AccountId;
            //CategoryId = postStruct.CategoryId;
            //StatusId = postStruct.StatusId;
        }

        public Post(PostModel postModel)
        {
            PostId = postModel.PostId;
            FilePath = postModel.FilePath;
            Title = postModel.Title;
            //AccountId = postModel.AccountId;
            //CategoryId = postModel.CategoryId;
            //StatusId = postModel.StatusId;
        }

        public void Update(IPost iPost)
        {
            PostId = iPost.PostId;
            FilePath = iPost.FilePath;
            Title = iPost.Title;
            //CategoryId = iPost.CategoryId;
            //AccountId = iPost.AccountId;
            //StatusId = iPost.StatusId;
        }

        public Post()   
        {

        }

        public void AddCommentToPost(Comment comment)
        {
            commentList.Add(comment);
        }

        //public void AddLikeToPost(LikeModel likeModel)
        //{
        //    likeList.Add(likeModel);
        //}

        public void AddLikeToPost(Like like)
        {
            likeList.Add(like);
        }

        public PostStruct Convert(IPost post)
        {
            return new PostStruct(post.PostId, post.FilePath, post.Title/*, post.AccountId, post.CategoryId, post.StatusId*/); // TODO invullen
        }
    }
}
