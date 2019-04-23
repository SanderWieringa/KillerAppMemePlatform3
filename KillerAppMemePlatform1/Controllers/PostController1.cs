using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KillerAppMemePlatform1.Logic.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using KillerAppMemePlatform1.Models;

namespace KillerAppMemePlatform1.Controllers
{
    public class PostController1 : Controller
    {
        

        // GET: Post
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase uploadFile, PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (uploadFile != null)
                    {
                        postModel.setFilePaths(Server.MapPath("~/UploadedFiles"));

                        string pathFile = postModel.FilePath;
                        uploadFile.SaveAs(pathFile);


                        return View("Success");
                    }
                    else
                    {
                        TempData["error"] = "Uploading the file failed!";
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

//    
    //}
//}