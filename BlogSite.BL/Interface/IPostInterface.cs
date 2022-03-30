using BlogSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BL.Interface
{
    public interface IPostInterface
    {
        Task<List<Post>> GetPosts();
        Task<Post> GetPost(Guid id);
        Task<Post> AddPost(Post newPost);
        Task<Post> UpdatePost(Post post);
        Task DeletePost(Guid id);

        
    }
}
