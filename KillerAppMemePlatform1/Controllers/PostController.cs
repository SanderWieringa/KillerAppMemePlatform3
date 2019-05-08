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

        public ActionResult Create(HttpPostedFileBase uploadFile, PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (uploadFile != null)
                    {
                        // save the upload filepath
                        postModel.setFilePaths(Server.MapPath("~/UploadedFiles"));

                        // save the files to the server folder
                        string pathFile = postModel.FilePath;
                        uploadFile.SaveAs(pathFile);


                    }

                    else
                    {
                        TempData["error"] = "Het uploaden van het bestand is niet gelukt.";
                        return RedirectToAction("Create");
                    }
                }
                catch
                {
                    // one or more errors encountered
                    TempData["error"] = "Er is iets fout gegaan bij het uploaden";
                    return RedirectToAction("Create");
                }
            }
            return View("Index");
        }

        

        public ActionResult Trending()
        {
            ViewBag.Message = "Your Trending page.";

            return View(ConvertToPostModelList());
        }

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