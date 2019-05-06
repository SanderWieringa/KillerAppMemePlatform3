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
            // Versneld do not have grades for OIS or FUN
            
            if (ModelState.IsValid)
            {

                try
                {
                    if (uploadFile != null)
                    {


                        // save the CV and Motivation upload filepaths
                        postModel.setFilePaths(Server.MapPath("~/UploadedFiles"));

                        // save the files to the server folder
                        string pathFile = postModel.FilePath;
                        uploadFile.SaveAs(pathFile);

                        // store the model to DB
                        
                        return View("Succes");
                    }

                    else
                    {
                        TempData["error"] = "Het uploaden van de bestanden is niet gelukt. Controleer of het gaat om PDF bestanden kleiner dan 4MB";
                        return RedirectToAction("Create");
                    }
                }
                catch
                {
                    // one or more errors encountered
                    TempData["error"] = "Er is iets fout gegaan bij het solliciteren. Probeer het nog een keer en controleer of alle invoer klopt";
                    return RedirectToAction("Create");
                }
            }
            return View();
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