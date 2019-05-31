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

        public PostModel ConvertToPostModel(PostStruct p)
        {
            PostModel postModel = new PostModel();
            postModel.PostId = p.PostId;
            postModel.FilePath = p.FilePath;
            postModel.Title = p.Title;
            postModel.AccountId = p.AccountId;
            postModel.CategoryId = p.CategoryId;
            postModel.StatusId = p.StatusId;
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
            //postCollectionDAL.GetAllPosts();
            return postList;
        }

        public void Add(PostStruct postStruct)
        {
            if (postStruct.Title != "")
            {
                postCollectionDAL.Add(postStruct);
            }
            else
            {
                throw new ArgumentException("Title can not be null");
            }
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
