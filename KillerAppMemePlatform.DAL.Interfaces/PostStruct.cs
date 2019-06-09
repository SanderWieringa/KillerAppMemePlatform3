using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KillerAppMemePlatform.DAL.Interfaces
{
    public struct PostStruct
    {
        public int PostId { get; private set; }
        public string FilePath { get; private set; }
        public string Title { get; private set; }

        public PostStruct(int postId, string filePath, string title)
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
        }
    }
}
