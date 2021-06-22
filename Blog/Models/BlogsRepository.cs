using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class BlogsRepository : IBlogsRepostory
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICategoryRepostory _categoryRepostory;

        public BlogsRepository(AppDbContext appDbContext,ICategoryRepostory categoryRepostory)
        {
            _appDbContext = appDbContext;
            _categoryRepostory = categoryRepostory;
        }
        public IEnumerable<Blogs> GetAllBlogs
        {
            get
            {
                return _appDbContext.Blogs.Include(c => c.Category);
            }
        }
        public IEnumerable<Blogs> AproveBlogs
        {
            get
            {
                return _appDbContext.Blogs.Include(c => c.Category).Where(p => p.IsShowBlog);
            }
        }
        public Blogs GetBlogById(int blogId)
        {
            return _appDbContext.Blogs.FirstOrDefault(p => p.Id == blogId);
        }

        public void createBlog(Blogs blogs)
        {


            //    blogs.DateWrite = DateTime.Now.ToString();
            //   blogs.Id = 8;
            // blogs.Autors = "hatem";
            //   blogs.CategoryId = 2;
            //  blogs.ImageUrl = "s";
            // blogs.Content = "23";
            // blogs.Title = "aa";

            var cate = _categoryRepostory.AllCategories;
          
                var categ = new Category()
                {
                    CategoryName = "C#",
                    CategoryId = 1
                };
            
              //  _appDbContext.Categories.Add(categ);
            
           // var a = cate.Select(p => p.CategoryName == blogs.CategoryId);
          
            _appDbContext.Blogs.Add(blogs);
            _appDbContext.SaveChanges();



        }

        public  void DeleteConfirmed(int id)
        {


            var blogs = _appDbContext.Blogs.FindAsync(id);
           // _appDbContext.Blogs.Remove(blogs);
            _appDbContext.SaveChangesAsync();
           

        }


    }
}
