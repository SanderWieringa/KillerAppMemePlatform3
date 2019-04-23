using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform1.Logic.Interfaces
{
    public interface IPostCollection
    {
        void Add(IPost post);

        List<IPost> GetAllPosts();
    }
}
    