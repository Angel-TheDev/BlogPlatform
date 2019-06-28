using BlogPlatform.Model;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlogPlatform.Controllers
{
    public class CategoryController /*: Contoller*/
    {
        IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        //public ViewResult Index()
        //{
        //    var model = categoryRepo.GetAll();
        //    return View(model);
        //}

        //public ViewResult Details(int id)
        //{
        //    var model = categoryRepo.GetById(id);
        //    return View(model);
        //}
    }
}
    

