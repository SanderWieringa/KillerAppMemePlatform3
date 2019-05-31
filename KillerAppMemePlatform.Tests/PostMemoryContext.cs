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
        public void Add(PostStruct postStruct)
        {
            List<PostStruct> postStructList = new List<PostStruct>();
            postStructList.Add(postStruct);
        }

        public List<PostStruct> GetAll()
        {
            List<PostStruct> postStructList = new List<PostStruct>();
            return postStructList;
        }

        public void Update(PostStruct postStruct)
        {
            throw new NotImplementedException();
        }

        public PostStruct GetById(int PostId)
        {
            List<PostStruct> postStructList = new List<PostStruct>();
            PostStruct postStruct = postStructList.Find(x => x.PostId == PostId);
            return postStruct;
        }
    }
}
