using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public interface IPostDAL
    {
        bool Update(PostStruct postStruct);
    }
}
