using Microsoft.AspNetCore.Mvc;

namespace BlogSite.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
