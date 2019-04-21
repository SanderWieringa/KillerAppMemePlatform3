using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public interface IPostCollectionDAL
    {
        void Add(PostStruct postStruct);

        List<PostStruct> GetAllPosts();

        //List<PostStruct> GetAllHotPosts();

        //List<PostStruct> GetAllTrendingPosts();

        //List<PostStruct> GetAllFreshPosts();
    }
}
