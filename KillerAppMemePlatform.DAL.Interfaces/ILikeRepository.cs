using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public interface ILikeRepository
    {
        void AddLike(LikeStruct likeStruct);

        void RemoveLike(int LikeId);
    }
}
