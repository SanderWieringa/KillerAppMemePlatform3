using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public struct PostStruct
    {
        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }

        public PostStruct(int postId, string filePath, string title,
                          int accountId, int categoryId)
        {

            PostId = postId;
            if (filePath != null)
            {
                FilePath = filePath;
            }
            else
            {
                FilePath = "";
            }
            Title = title;
            AccountId = accountId;
            CategoryId = categoryId;
        }
    }
}
