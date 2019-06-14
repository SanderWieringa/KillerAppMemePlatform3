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

        private ILikeRepository LikeDAL = KillerAppDALFactory.CreateLikeDAL();

        List<Like> likeList = new List<Like>();

        private PostModel ConvertToPostModel(PostStruct PostObject)
        {
            PostModel postModel = new PostModel();
            postModel.PostId = PostObject.PostId;
            postModel.FilePath = PostObject.FilePath;
            postModel.Title = PostObject.Title;

            return postModel;
        }

        private LikeModel ConvertToLikeModel(LikeStruct likeStruct)
        {
            LikeModel likeModel = new LikeModel();
            likeModel.LikeId = likeStruct.LikeId;
            likeModel.PostObject = ConvertToPostModel(likeStruct.PostObject);

            return likeModel;
        }

        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }

        public Post(int postId, string filePath, string title)
        {
            PostId = postId;
            FilePath = filePath;
            Title = title;
        }

        public Post(PostStruct postStruct) : this(postStruct.PostId, postStruct.FilePath, postStruct.Title)
        {

        }

        public Post(PostModel postModel) : this(postModel.PostId, postModel.FilePath, postModel.Title)
        {

        }

        public void Update(IPost iPost)
        {
            PostId = iPost.PostId;
            FilePath = iPost.FilePath;
            Title = iPost.Title;
        }

        public Post()   
        {

        }

        //public void AddLikeToPost(ConvertToLikeModel(LikeStruct ))
        //{
        //    LikeDAL.AddLike();
        //}

        //public void AddLikeToPost(Like like)
        //{
        //    LikeDAL.AddLike((like as Like).Convert(like));
        //}

        public PostStruct Convert(IPost post)
        {
            return new PostStruct(post.PostId, post.FilePath, post.Title);
        }
    }
}
