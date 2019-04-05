using KilllerAppMemePlatform1.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppMemePlatform1.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    BusinessLogic bl = new BusinessLogic();
                    Post post1 = new Post(1, "", "Nobody reads title", @"C:\Users\guita\Pictures\Memes\femaleStreamers.jpg", 1, 0);
                    int i = bl.PostInsert(post1);
                    if (post1.Title != "" && i == 1)
                    {
                        return View("Succes");
                    }
                    else
                    {
                        TempData["error"] = "Something went wrong!";
                        return RedirectToAction("Create");
                    }
                    
                }
                catch
                {
                    TempData["error"] = "Something went wrong!";
                    return RedirectToAction("Create");
                }
            }
            return View();
        }
    }
}
//if (uploadFile != null)
//{
//Post post, HttpPostedFileBase uploadFile

//post.setFilePaths(Server.MapPath(~/))
//string pathImage = post.ImagePath;
//uploadFile.SaveAs(pathImage);

//string pathVideo = post.VideoPath;
//uploadFile.SaveAs(pathVideo);

//    }
//    else
//    {
//        TempData["error"] = "Uploading the file failed!";
//        return RedirectToAction("Create");
//    }
    }
}