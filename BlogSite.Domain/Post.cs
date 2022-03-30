using System;
using System.ComponentModel.DataAnnotations;

namespace BlogSite.Domain
{
    public class Post
    {
        [Required, Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreatTime { get; set; }
        public string Comments { get; set; } 
    }
}
