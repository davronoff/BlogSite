using BlogSite.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.ViewModel
{
    public class AddPostViewModel
    {
        public string Title { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreatTime { get; set; }
    }
}
