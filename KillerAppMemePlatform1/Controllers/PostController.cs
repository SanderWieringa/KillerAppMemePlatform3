using KillerAppMemePlatform1.Logic.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
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
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Your Hot page.";

            return View(ConvertToPostModelList());
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

        public PostModel ConvertToPostModel(int id)
        {
            return PostCollectionLogic.GetById(id);
        }


        [HttpPost]
        public ActionResult Create(PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(postModel.ImageFile.FileName);
                    string extension = Path.GetExtension(postModel.ImageFile.FileName);
                    fileName = fileName + extension;
                    postModel.FilePath = "~/UploadedFiles/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/UploadedFiles/") + fileName);
                    postModel.ImageFile.SaveAs(fileName);
                    ModelState.Clear();

                    PostCollectionLogic.Add(postModel);
                }
                catch (Exception e)
                {
                    // one or more errors encountered
                    Console.WriteLine(e);
                    TempData["error"] = "Er is iets fout gegaan bij het uploaden";
                    return RedirectToAction("Create");

                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PostDetails(int id)
        {
            ViewBag.Message = "Your PostDetails page";

            return View(ConvertToPostModel(id));
        }

        [HttpGet]
        public ActionResult Trending()
        {
            ViewBag.Message = "Your Trending page.";

            return View(ConvertToPostModelList());
        }

        [HttpGet]
        public ActionResult Fresh()
        {
            ViewBag.Message = "Your Fresh page.";

            return View(ConvertToPostModelList());
        }

        public ActionResult Upload()
        {
            ViewBag.Message = "Your Upload page.";

            return View();
        }
    }
}