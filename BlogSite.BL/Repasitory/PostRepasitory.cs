using BlogSite.BL.Interface;
using BlogSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BL.Repasitory
{
    public class PostRepasitory : IPostInterface
    {
        public Task<Post> AddPost(Post newPost)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPost(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
