using BlogSite.BL.Interface;
using BlogSite.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlogSite.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentInterface _commentservice;

        public CommentController(ICommentInterface commentservice)
        {
            _commentservice = commentservice;
        }
        [HttpGet, Route("getall")]
        public async Task<IActionResult> GetComments()
        {
            var json = await _commentservice.GetComments();
            return Ok(json);
        }
        [HttpGet, Route("get/{id}")]
        public async Task<IActionResult> GetComment(Guid id)
        {
            var json = await _commentservice.GetComment(id);
            return Ok(json);
        }
        [HttpPost, Route("add")]
        public async Task<IActionResult> Add(Comment newComment)
        {
            var json = await _commentservice.AddComment(newComment);
            return Ok(json);
        }
        [HttpPut, Route("update")]
        public async Task<IActionResult> Update(Comment comment)
        {
            var json = await _commentservice.UpdateComment(comment);
            return Ok(json);
        }
        [HttpDelete, Route("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _commentservice.DeleteComment(id);
            return Ok();
        }
    }
}
