using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medicare.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Title { get; set; }
        [Required, StringLength(200)]

        public string Image { get; set; }
        [Required]

        public int CommentCount { get; set; }
        [Required]

        public int LikeCount { get; set; }
        public List<BlogTag> BlogTags { get; set; }

    }
}
