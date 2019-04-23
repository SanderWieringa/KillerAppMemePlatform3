using KillerAppMemePlatform1.Logic.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using KillerAppMemePlatform1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppMemePlatform1.Controllers
{
    public class PostController : Controller
    {
        public IPostCollection PostCollectionLogic { get; private set; } = KillerAppLogicFactory.CreatePostCollection();

        public IPost PostLogic { get; private set; } = KillerAppLogicFactory.CreatePost();

        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        public List<PostModel> ConvertToPostModelList()
        {
            List<PostModel> postModelList = new List<PostModel>();

            foreach (var post in PostCollectionLogic.GetAllPosts())
            {
                postModelList.Add(new PostModel(post));
            }

            return postModelList;
        }
    }
}