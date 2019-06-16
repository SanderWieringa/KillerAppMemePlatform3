using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerAppMemePlatform.DAL.Interfaces;

namespace KillerAppMemePlatform.DAL
{
    public class PostMemoryContext : IPostContext
    {
        private List<PostStruct> postStructList = new List<PostStruct>();
        public List<PostStruct> GetPostStructList { get => postStructList; }

        private void PreFillLists()
        {
            postStructList.Add(new PostStruct(1, "FilePath", "Title"));
            postStructList.Add(new PostStruct(2, "FilePath", "Title"));
        }

        public void Add(PostStruct postStruct)
        {
            postStructList.Add(postStruct);
        }

        public List<PostStruct> GetAll()
        {
            List<PostStruct> postStructList = new List<PostStruct>();
            PreFillLists();
            return postStructList;
        }

        public void Update(PostStruct postStruct)
        {
            throw new NotImplementedException();
        }

        public PostStruct GetById(int PostId)
        {
            List<PostStruct> postStructList = new List<PostStruct>();
            PreFillLists();
            PostStruct postStruct = postStructList.Find(x => x.PostId == PostId);
            return postStruct;
        }
    }
}
