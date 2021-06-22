using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Blogs
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Please Write Title")]
        [Display(Name="Title")]
        [StringLength(45)]

        public string  Title { get; set; }
        [Required(ErrorMessage = "Please Write ")]
        [Display(Name = "Content")]
        [StringLength(1000)]
        public string Content { get; set; }
        public string Autors { get; set; }
        public string DateWrite { get; set; }
        public string ImageUrl { get; set; }
        public bool  IsShowBlog { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
