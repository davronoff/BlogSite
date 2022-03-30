using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Domain
{
    public class Comment
    {
        [Required, Key]
        public Guid Id { get; set; }
        [Required]
        public string CommentBody { get; set; }
    }
}
