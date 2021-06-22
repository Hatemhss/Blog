using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.ViewModels;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogsRepostory _blogsRepostory;
        private readonly ICategoryRepostory _categoryRepostory;
        public HomeController(IBlogsRepostory blogsRepostory)
        {
            _blogsRepostory = blogsRepostory;
         
        }
        public IActionResult Index()
        {
            var homeviewModel = new HomeviewModel
            {
                AproveBlogs = _blogsRepostory.AproveBlogs
            };
            return View(homeviewModel);
        }
    }
}
