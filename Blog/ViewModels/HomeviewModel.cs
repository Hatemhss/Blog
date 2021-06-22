using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class HomeviewModel
    {
        public IEnumerable<Blogs> AproveBlogs { get; set; }
    }
}
