using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KilllerAppMemePlatform1.BLL
{
    public class ParentPost
    {
        private IPostRepository PostDAL = KillerAppDALFactory.CreatePostDAL();

        List<Comment> commentList = new List<Comment>();
        List<Like> likeList = new List<Like>();

        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int StatusId { get; set; }
        

        protected void Update(int postId, string filePath, string title, int accountId, int statusId)
        {
            PostId = postId;
            FilePath = filePath;
            Title = title;
            AccountId = accountId;
            StatusId = statusId;
            
        }

        protected void AddCommentToPost(Comment comment)
        {
            commentList.Add(comment);
        }

        protected void AddLikeToPost(Like like)
        {
            likeList.Add(like);
        }

        
    }
}
