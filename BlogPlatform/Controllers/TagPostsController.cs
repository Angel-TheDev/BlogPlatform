using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Model;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Controllers
{
    public class TagPostsController : Controller
    {
        IRepository<TagPosts> tagpostsRepo;

        public TagPostsController(IRepository<TagPosts> tagpostsRepo)
        {
            this.tagpostsRepo = tagpostsRepo;
        }

        //public ViewResult Index()
        //{
        //    var model = tagRepo.GetAll();
        //    return View(model);
        //}

        //public ViewResult Index(int id)
        //{
        //    var model = tagRepo.GetByTagId(id);
        //    return View(model);
        //}

        //public ViewResult Details(int id)
        //{
        //    var model = tagRepo.GetById(id);
        //    return View(model);
        //}


        [HttpGet]
        public ViewResult Create(int id)
        {

            ViewBag.PostId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Create(TagPosts tagposts)
        {
            tagpostsRepo.Create(tagposts);
            return RedirectToAction("../TagPosts//");
        }
    }
}