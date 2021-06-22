using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public interface ICategoryRepostory
    {
        IEnumerable<Category>  AllCategories { get; }
    }
}
