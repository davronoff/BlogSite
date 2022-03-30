using BlogSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BL.Interface
{
    public interface ICommentInterface
    {
        Task<List<Comment>> GetComments();
        Task<Comment> GetComment(Guid id);
        Task<Comment> AddComment(Comment newComment);
        Task<Comment> UpdateComment(Comment comment);
        Task DeleteComment(Guid id);
    }
}
