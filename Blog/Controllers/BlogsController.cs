using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogsRepostory _blogsRepostory;
        private readonly ICategoryRepostory _categoryRepostory;
        public BlogsController(IBlogsRepostory blogsRepostory, ICategoryRepostory categoryRepostory)
        {
            _blogsRepostory = blogsRepostory;
            _categoryRepostory = categoryRepostory;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {

            BlogsListViewModel blogsListViewModel = new BlogsListViewModel();
            blogsListViewModel.Blogss = _blogsRepostory.GetAllBlogs;
            blogsListViewModel.CurrentCategory = "Blogs";
            return View(blogsListViewModel);
            // ViewBag.CurrentCategory = "Blogs";
            //return View(_blogsRepostory.GetAllBlogs);
        }
        [Authorize]
        public IActionResult Details(int id)
        {
            var blog = _blogsRepostory.GetBlogById(id);
            if (blog == null)
                return NotFound();

            return View(blog);
        }
      
        public IActionResult AddBlogs()
        {

            return View();
        }
       
        [HttpPost]
        public IActionResult AddBlogs(Blogs blogs)
        {

            
            if (ModelState.IsValid)
            {
                _blogsRepostory.createBlog(blogs);
                return RedirectToAction("done");
            }
           
            
            return View(blogs);
        }

        public IActionResult done()
        {




            return View();
        }
        //   [HttpPost]
        //   [ValidateAntiForgeryToken]

        /*public IActionResult Create([Bind("Title","Content","id","imageUrl")]Blogs blogs)
        {
            if (ModelState.IsValid)
            {

          //      _blogsRepostory.Add(blogs);
            }



            _blogsRepostory.createBlog(blogs);
            return View(blogs);
        }*/
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

           // var book = await _.Book.FindAsync(id);
          //  _context.Book.Remove(book);
        //    await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


            var blog = _blogsRepostory.GetBlogById(id);
          //  _blogsRepostory.Remove(blog);
            // _blogsRepostory();
            return RedirectToAction(nameof(Index));
        }



  
    }
}
