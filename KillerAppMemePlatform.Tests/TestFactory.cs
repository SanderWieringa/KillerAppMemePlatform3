using KillerAppMemePlatform.DAL;
using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.Tests
{
    public static class TestFactory
    {
        public static IPostRepository CreateMemoryPostDAL()
        {
            return new PostRepository(new PostMemoryContext());
        }

        public static IPostCollectionRepository CreateMemoryPostCollectionDAL()
        {
            return new PostRepository(new PostMemoryContext());
        }
    }
}
