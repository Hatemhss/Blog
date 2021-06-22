using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class BlogsListViewModel
    {
        public IEnumerable<Blogs>  Blogss { get; set; }
        public string CurrentCategory { get; set; }
    }
}
