using KillerAppMemePlatform1.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using KilllerAppMemePlatform1.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Logic.Factory
{
    public static class KillerAppLogicFactory
    {
        public static IPost CreatePost()
        {
            return new Post();
        }

        public static IPostCollection CreatePostCollection()
        {
            return new PostCollection(KillerAppDALFactory.CreatePostCollectionDAL());
        }
    }
}
