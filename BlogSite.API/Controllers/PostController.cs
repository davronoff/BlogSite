using BlogSite.BL.Interface;
using BlogSite.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlogSite.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostInterface _postservice;

        public PostController(IPostInterface postservice)
        {
            _postservice = postservice;
        }
        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetPosts()
        {
            var json = await _postservice.GetPosts();
            return Ok(json);
        }
        [HttpGet, Route("get/{id}")]
        public async Task<IActionResult> GetPost(Guid id)
        {
            var json = await _postservice.GetPost(id);
            return Ok(json);
        }
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(Post newPost)
        {
            var json = await _postservice.AddPost(newPost);
            return Ok(json);
        }
        [HttpPut, Route("update")]
        public async Task<IActionResult> Update(Post post)
        {
            var json = await _postservice.UpdatePost(post);
            return Ok(json);
        }
        [HttpDelete, Route("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _postservice.DeletePost(id);
            return Ok();
        }
    }
}
