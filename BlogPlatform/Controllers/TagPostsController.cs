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

        public ViewResult Index()
        {
            var model = tagRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = tagRepo.GetByTagId(id);
            return View(model);
        }

    }
}