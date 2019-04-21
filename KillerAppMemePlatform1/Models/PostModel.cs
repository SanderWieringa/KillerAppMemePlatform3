using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KillerAppMemePlatform1.Models
{
    public class PostModel
    {
        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }

        public PostModel(IPost post)
        {
            PostId = post.PostId;
            FilePath = post.FilePath;
            Title = post.Title;
            AccountId = post.AccountId;
            CategoryId = post.CategoryId;
            StatusId = post.StatusId;
        }

        public void setFilePaths(string serverFolder)
        {
            FilePath = Path.Combine(serverFolder + "-post.png");
        }
    }
}