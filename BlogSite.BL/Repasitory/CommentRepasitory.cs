using BlogSite.BL.Interface;
using BlogSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BL.Repasitory
{
    public class CommentRepasitory : ICommentInterface
    {
        public Task<Comment> AddComment(Comment newComment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComment(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetComment(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetComments()
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
