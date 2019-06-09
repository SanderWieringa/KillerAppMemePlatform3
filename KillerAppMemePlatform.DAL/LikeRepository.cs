using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL
{
    public class LikeRepository : ILikeRepository, IPostRepository
    {
        public ILikeContext Context { get; set; }

        public LikeRepository(ILikeContext context)
        {
            Context = context;
        }

        public void AddLike(LikeStruct likeStruct)
        {
            Context.AddLike(likeStruct);
        }

        public void RemoveLike(int LikeId)
        {
            Context.RemoveLike(LikeId);
        }

        public bool Update(PostStruct postStruct)
        {
            throw new NotImplementedException();
        }
    }
}
