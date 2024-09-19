using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Model
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
