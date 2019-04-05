using KillerAppMemePlatform.DAL;
using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Factory
{
    public static class KillerAppFactory
    {
        public static IPostDAL CreatePostDAL()
        {
            return new PostDAL();
        }
    }
}
