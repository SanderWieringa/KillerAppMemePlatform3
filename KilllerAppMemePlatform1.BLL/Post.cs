using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilllerAppMemePlatform1.BLL
{
    public class Post : ParentPost, IPost
    {
        public int CategoryId { get; set; }
        
        public Post(PostStruct postStruct)
        {
            PostId = postStruct.PostId;
            FilePath = postStruct.FilePath;
            Title = postStruct.Title;
            AccountId = postStruct.AccountId;
            CategoryId = postStruct.CategoryId;
            StatusId = postStruct.StatusId;
        }

        public Post(PostModel postModel)
        {
            PostId = postModel.PostId;
            FilePath = postModel.FilePath;
            Title = postModel.Title;
            AccountId = postModel.AccountId;
            CategoryId = postModel.CategoryId;
            StatusId = postModel.StatusId;
        }

        public void Update(int categoryId)
        {
            CategoryId = categoryId;
            Update(PostId, FilePath, Title, AccountId, StatusId);
        }

        public Post()   
        {

        }

        public PostStruct Convert(IPost post)
        {
            return new PostStruct(post.PostId, post.FilePath, post.Title, post.AccountId, post.CategoryId, post.StatusId); // TODO invullen
        }

        bool IPost.Update()
        {
            throw new NotImplementedException();
        }
    }
}
