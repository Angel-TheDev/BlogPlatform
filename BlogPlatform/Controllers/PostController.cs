using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogPlatform.Model;
using BlogPlatform.Repositories;

namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }

        public ViewResult Details(int id)
        {
            var model = postRepo.GetByTagId(id);
            return View(model);
        }

        public ViewResult AllBlogs()
        {
            var model = postRepo.GetAll();
            return View(model);
        }
    }
}