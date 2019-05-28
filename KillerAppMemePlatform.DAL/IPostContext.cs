using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL
{
    public interface IPostContext
    {
        void Update(PostStruct postStruct);

        void Add(PostStruct postStruct);

        List<PostStruct> GetAll();

        PostStruct GetById(int PostId);
    }
}
