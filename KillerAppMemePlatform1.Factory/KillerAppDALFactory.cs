using KillerAppMemePlatform.DAL;
using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Factory
{
    public static class KillerAppDALFactory
    {
        public static IPostRepository CreatePostDAL()
        {
            return new PostRepository(new PostSQLContext());
        }

        public static IPostCollectionRepository CreatePostCollectionDAL()
        {
            return new PostRepository(new PostSQLContext());
        }
    }
}
