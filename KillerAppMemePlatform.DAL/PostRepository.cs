using KillerAppMemePlatform.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL
{
    public class PostRepository : IPostCollectionRepository, IPostRepository
    {
        public IPostContext Context { get; set; }

        public PostRepository(IPostContext context)
        {
            Context = context;
        }

        public void Add(PostStruct postStruct)
        {
            Context.Add(postStruct);
        }

        public List<PostStruct> GetAllPosts()
        {
            List<PostStruct> list = new List<PostStruct>();
            foreach (var post in Context.GetAll())
            {
                list.Add(post);
            }
            //Context.GetAll();
            return list;
        }

        public bool Update(PostStruct postStruct)
        {
            throw new NotImplementedException();
        }
    }
}
