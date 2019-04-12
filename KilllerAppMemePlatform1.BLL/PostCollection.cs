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
        public static IPostCollectionDAL postCollectionDAL = KillerAppDALFactory.CreatePostCollectionDAL();

        public void Add(PostStruct postStruct)
        {
            if (postStruct.Title != "")
            {
                postCollectionDAL.Add(postStruct);
            }
            else
            {
                throw new System.ArgumentException("Title can not be null");
            }
        }

        //public List<Post> GetAll()
        //{
        //    List<Post> postList = new List<Post>();
        //    foreach (PostStruct postStruct in postCollectionDAL.GetAllPosts())
        //    {
        //        postList.Add(new Post(postStruct));
        //    }
        //    postCollectionDAL.GetAllPosts();
        //    return postList;
        //}

        public void Add(IPost post)
        {
            throw new NotImplementedException();
        }

        public List<IPost> GetAllPosts()
        {
            List<IPost> postList = new List<IPost>();
            foreach (PostStruct postStruct in postCollectionDAL.GetAllPosts())
            {
                IPost post = new Post(postStruct);
                postList.Add(post);
            }
            return postList;
        }
    }
}
