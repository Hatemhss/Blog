using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class LearnCategoryRepository : ICategoryRepostory
    {
        public IEnumerable<Category> AllCategories =>

            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="C#"},
                new Category{CategoryId=2,CategoryName="Python"},
                new Category{CategoryId=3,CategoryName="IOS"},
                new Category{CategoryId=4,CategoryName="Kotlin"}


            };
    }
}
