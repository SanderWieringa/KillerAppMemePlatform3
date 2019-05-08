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
        IPostContext context;

        public PostRepository(IPostContext context)
        {

        }

        public void Add(PostStruct postStruct)
        {
            context.Add(postStruct);
        }

        public List<PostStruct> GetAllPosts()
        {
            List<PostStruct> list = new List<PostStruct>();
            foreach (var post in context.GetAll())
            {
                list.Add(post);
            }
            context.GetAll();
            return list;
        }

        public bool Update(PostStruct postStruct)
        {
            throw new NotImplementedException();
        }
    }
}
