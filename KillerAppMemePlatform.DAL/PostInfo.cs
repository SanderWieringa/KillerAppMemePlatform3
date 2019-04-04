using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.DAL
{
    public struct PostInfo
    {
        public int Post_id { get; set; }
        public string VideoPath { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int Account_id { get; set; }
        public int? Category_id { get; set; }
    }
}
