using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppMemePlatform1.Models
{
    public class PersonModel
    {
        public int PostId { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }

        public PersonModel(IPost post)
        {
            PostId = post.PostId;
            FilePath = post.FilePath;
            Title = post.Title;
            AccountId = post.AccountId;
            CategoryId = post.CategoryId;
        }
    }
}