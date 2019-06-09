using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Like
    {
        public int LikeId { get; set; }
        public Account Account { get; private set; }
        public Post PostObject { get; private set; }
        public Comment Comment { get; private set; }

        public Like(LikeStruct likeStruct)
        {
            LikeId = likeStruct.LikeId;
            PostObject = new Post(likeStruct.PostObject);
        }

    }
}
