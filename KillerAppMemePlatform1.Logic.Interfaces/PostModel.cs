using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace KillerAppMemePlatform1.Logic.Interfaces
{
    public class PostModel
    {
        public int PostId { get; set; }
        public string FilePath { get; set; }
        [Required]
        public string Title { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        
        public PostModel(IPost post)
        {
            PostId = post.PostId;
            FilePath = post.FilePath;
            Title = post.Title;
        }

        public PostModel(int postId, string filePath, string title)
        {
            PostId = postId;
            FilePath = filePath;
            Title = title;
        }

        public PostModel()
        {
           
        }
    }
}