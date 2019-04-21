﻿using KillerAppMemePlatform1.Logic.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using KillerAppMemePlatform1.Models;
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

        //private List<PostModel> postModels;
        //public HomeController()
        //{
        //    postModels = new List<PostModel>()
        //    {
        //        new PostModel() { postID = 1 }
            
        //    };
        //}

        public List<PostModel> ConvertToPostModelList()
        {
            List<PostModel> postModelList = new List<PostModel>();

            foreach (var post in PostCollectionLogic.GetAllPosts())
            {
                postModelList.Add(new PostModel(post));
            }

            return postModelList;
        }
        //public List<PostModel> ConvertHotToPostModelList()
        //{
        //    List<PostModel> postModelList = new List<PostModel>();

        //    foreach (var post in PostCollectionLogic.GetAllHotPosts())
        //    {
        //        postModelList.Add(new PostModel(post));
        //    }

        //    return postModelList;
        //}
        //public List<PostModel> ConvertTrendingToPostModelList()
        //{
        //    List<PostModel> postModelList = new List<PostModel>();

        //    foreach (var post in PostCollectionLogic.GetAllTrendingPosts())
        //    {
        //        postModelList.Add(new PostModel(post));
        //    }

        //    return postModelList;
        //}
        //public List<PostModel> ConvertFreshToPostModelList()
        //{
        //    List<PostModel> postModelList = new List<PostModel>();

        //    foreach (var post in PostCollectionLogic.GetAllFreshPosts())
        //    {
        //        postModelList.Add(new PostModel(post));
        //    }

        //    return postModelList;
        //}


        public ActionResult Index()
        {
            ViewBag.Message = "Your Hot page.";
            
            return View(ConvertToPostModelList());
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

            return View(ConvertToPostModelList());
        }

        public ActionResult Trending()
        {
            ViewBag.Message = "Your Trending page.";

            return View(ConvertToPostModelList());
        }

        public ActionResult Upload()
        {
            ViewBag.Message = "Your Upload page.";

            return View();
        }
    }
}