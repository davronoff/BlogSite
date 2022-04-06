using BlogSite.BL.Interface;
using BlogSite.Data.DataLayer;
using BlogSite.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BL.Repasitory
{
    public class CommentRepasitory : ICommentInterface
    {
        private readonly AppDbContext _commentdb;

        public CommentRepasitory(AppDbContext commentdb)
        {
            _commentdb = commentdb;
        }

        //Write comment
        public Task<Comment> AddComment(Comment newComment)
        {
            _commentdb.comments.Add(newComment);
            _commentdb.SaveChanges();
            return Task.FromResult(newComment);
        }

        //Delete comment, this method delete from database
        public Task DeleteComment(Guid id)
        {
            Comment comment = _commentdb.comments.FirstOrDefault(p => id == p.Id);
            _commentdb.comments.Remove(comment);
            _commentdb.SaveChanges();
            return Task.FromResult(0);
        }

        //Get comment only one by CommentID
        public Task<Comment> GetComment(Guid id) => _commentdb.comments.FirstOrDefaultAsync(p => id == p.Id);

        //Get comments for all written comments
        public Task<List<Comment>> GetComments() => _commentdb.comments.ToListAsync();

        //Change comment 
        public Task<Comment> UpdateComment(Comment comment)
        {
            _commentdb.comments.Update(comment);
            _commentdb.SaveChanges();
            return Task.FromResult(comment);
        }
    }
}
