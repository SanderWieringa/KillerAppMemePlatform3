using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public struct PostStruct
    {
        public int Post_id { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int Account_id { get; set; }
        public int Category_id { get; set; }

        public PostStruct(int post_id, string filePath, string title,
                          int account_id, int category_id)
        {
            
            Post_id = post_id;
            if (filePath != null)
            {
                FilePath = filePath;
            }
            else
            {
                FilePath = "";
            }
            Title = title;
            Account_id = account_id;
            Category_id = category_id;
        }
    }
}
