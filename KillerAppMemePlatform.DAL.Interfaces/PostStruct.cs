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
        public string VideoPath { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int Account_id { get; set; }
        public int Category_id { get; set; }

        public PostStruct(int post_id, string videoPath, string title,
                    string imagePath, int account_id, int category_id)
        {
            Post_id = post_id;
            VideoPath = videoPath;
            Title = title;
            ImagePath = imagePath;
            Account_id = account_id;
            Category_id = category_id;
        }
    }
}
