using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class LearnBlogsRepostory : IBlogsRepostory
    {
        private readonly ICategoryRepostory _categoryRepostory = new LearnCategoryRepository();
        public IEnumerable<Blogs> GetAllBlogs =>
            new List<Blogs>
            {
                new Blogs { Id=1,Title="C#",IsShowBlog=true,ImageUrl="https://www.avenga.com/wp-content/uploads/2020/11/C-Sharp.png",Content="C# hello",Autors="Hatem",DateWrite="2021/06/17",CategoryId=1},
                new Blogs { Id=2,Title="Pyhon",IsShowBlog=true,ImageUrl="https://www.python.org/static/community_logos/python-logo.png",Content="Pyton hello",Autors="Ali",DateWrite="2021/05/17",CategoryId=2}

            };

        public IEnumerable<Blogs> AproveBlogs { get; }

        public void createBlog(Blogs blogs)
        {
            throw new NotImplementedException();
        }

        public Blogs GetBlogById(int blogId)
        {
            return GetAllBlogs.FirstOrDefault(p => p.Id == blogId);
        }
    //    public void createBlog(Blogs blog);
    }
}
