using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public interface IBlogsRepostory
    {
        //  IEnumerable<Blogs> GetAllBlogs();
          IEnumerable<Blogs> GetAllBlogs { get; }
        IEnumerable<Blogs> AproveBlogs { get; }
        Blogs GetBlogById(int blogId);
        void createBlog(Blogs blogs);
    }
}
