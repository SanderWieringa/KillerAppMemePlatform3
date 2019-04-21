using KillerAppMemePlatform1.Logic.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppMemePlatform1.Models
{
    public class PostCollectionModel : IPostCollection
    {
        public static IPostCollection postCollection = KillerAppLogicFactory.CreatePostCollection();

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Add(IPost post)
        {
            throw new NotImplementedException();
        }

        public List<PostModel> GetAllPosts()
        {
            List<PostModel> postList = new List<PostModel>();
            foreach (IPost post in )
            {
                PostModel postModel = new PostModel(IPost);
                postList.Add(post);
            }
            return postList;
        }

        List<IPost> IPostCollection.GetAllPosts()
        {
            throw new NotImplementedException();
        }
    }
}