using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL
{
    public interface ILikeContext
    {
        void AddLike(LikeStruct likeStruct);

        void RemoveLike(int LikeId);
    }
}
