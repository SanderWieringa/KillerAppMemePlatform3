using KillerAppMemePlatform1.Logic.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppMemePlatform1.Controllers
{
    public class HomeController : Controller
    {
        public IPost PostLogic { get; private set; } = KillerAppLogicFactory.CreatePost();
        public IPostCollection PostCollectionLogic { get; private set; } = KillerAppLogicFactory.CreatePostCollection();

        public ActionResult Index()
        {
            ViewBag.Message = "Your Hot page.";
            return View(PostCollectionLogic.GetAllPosts());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Fresh()
        {
            ViewBag.Message = "Your Fresh page.";

            return View(PostCollectionLogic.GetAllPosts());
        }

        public ActionResult Trending()
        {
            ViewBag.Message = "Your Trending page.";

            return View(PostCollectionLogic.GetAllPosts());
        }

        public ActionResult Upload()
        {
            ViewBag.Message = "Your Upload page.";

            return View();
        }
    }
}