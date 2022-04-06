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
    public class PostRepasitory : IPostInterface
    {
        private readonly AppDbContext _postdb;

        public PostRepasitory(AppDbContext postdb)
        {
            _postdb = postdb;
        }

        //Add post fro site page
        public Task<Post> AddPost(Post newPost)
        {
            _postdb.posts.Add(newPost);
            _postdb.SaveChanges();
            return Task.FromResult(newPost);
        }

        //Delete post, this method delete from database
        public Task DeletePost(Guid id)
        {
            Post post =  _postdb.posts.FirstOrDefault(p => id == p.Id);
            _postdb.posts.Remove(post);
            _postdb.SaveChanges();
            return Task.FromResult(0);
        }

        //Get post only one post by PostId
        public Task<Post> GetPost(Guid id) => _postdb.posts.FirstOrDefaultAsync(p => id == p.Id);

        //Get posts for add all post 
        public Task<List<Post>> GetPosts() => _postdb.posts.ToListAsync();

        //Change post
        public Task<Post> UpdatePost(Post post)
        {
            _postdb.posts.Update(post);
            _postdb.SaveChanges();
            return Task.FromResult(post);
        }
    }
}
