using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class PostCollection
    {
        public static IPostCollectionDAL postCollectionDAL = KillerAppFactory.CreatePostCollectionDAL();

        public static void Add(PostStruct postStruct)
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

        public static List<Post> GetAll()
        {
            List<Post> postList = new List<Post>();
            foreach (PostStruct postStruct in postCollectionDAL.GetAllPosts())
            {
                postList.Add(new Post(postStruct));
            }
            postCollectionDAL.GetAllPosts();
            return postList;
        }
    }
}
