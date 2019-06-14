using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class PostCollection : IPostCollection
    {
        private IPostCollectionRepository postCollectionDAL = KillerAppDALFactory.CreatePostCollectionDAL();

        private PostModel ConvertToPostModel(PostStruct postStruct)
        {
            PostModel postModel = new PostModel();
            postModel.PostId = postStruct.PostId;
            postModel.FilePath = postStruct.FilePath;
            postModel.Title = postStruct.Title;
            return postModel;
        }

        public PostModel GetById(int PostId)
        {
            return ConvertToPostModel(postCollectionDAL.GetById(PostId));
        }

        public List<IPost> GetAllPosts()
        {
            List<IPost> postList = new List<IPost>();
            foreach (PostStruct postStruct in postCollectionDAL.GetAllPosts())
            {
                postList.Add(new Post(postStruct));
            }
            return postList;
        }

        public void Add(PostModel postModel)
        {
            Post post = new Post(postModel);
            if (post.Title != "")
            {
                postCollectionDAL.Add((post as Post).Convert(post));
            }
            else
            {
                throw new ArgumentException("Title can not be null");
            }
        }
    }
}
