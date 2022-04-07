using BlogSite.BL.Interface;
using BlogSite.Domain;
using BlogSite.MVC.Service;
using BlogSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlogSite.MVC.Controllers
{
    public class PostController : Controller
    {
        private readonly IFileInterface _fileservice;
        private readonly IPostInterface _postservice;

        public PostController(IPostInterface postservice,
                             IFileInterface fileservice)
        {
            _fileservice = fileservice;
            _postservice = postservice;
        }
        public async Task<IActionResult> Index()
        {
            var listmodel = await _postservice.GetPosts();
            return View(listmodel);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddPostViewModel viewModel)
        {
            Post post = new Post()
            {
                Id = Guid.NewGuid(),
                Title = viewModel.Title,
                Description = viewModel.Description,
                CreatTime = DateTime.Now,
                Image = _fileservice.SaveImage(viewModel.Image)
            };
            await _postservice.AddPost(post);

            return RedirectToAction("Index");
        }
    }
}
