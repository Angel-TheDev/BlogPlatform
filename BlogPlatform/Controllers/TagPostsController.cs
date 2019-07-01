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
        IRepository<TagPosts> tagRepo;

        public TagPostsController(IRepository<TagPosts> tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        //public ViewResult Index()
        //{
        //    var model = tagRepo.GetAll();
        //    return View(model);
        //}

        public ViewResult Index(int id)
        {
            var model = tagRepo.GetByTagId(id);
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = tagRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.tags = tagRepo.GetAllTags();
            var model = tagRepo.GetByLast();
            ViewBag.PID = model.PostId;
            return View();
        }

        [HttpPost]
        public ActionResult Create(TagPosts tagpost)
        {
            tagRepo.Create(tagpost);
            return Redirect("~/Post/AllBlogs");
        }
    }
}