using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public interface IPostCollectionRepository
    {
        void Add(PostStruct postStruct);

        List<PostStruct> GetAllPosts();

        PostStruct GetById(int PostId);
        
    }
}
