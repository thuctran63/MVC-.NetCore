using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Model
{
    public class Post
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public string PostContent { get; set; }

        public string UrlSlug { get; set; }

        [Required]
        public bool Published { get; set; }

        public DateTime PostedOn { get; set; }

        public DateTime Modified { get; set; }

        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
