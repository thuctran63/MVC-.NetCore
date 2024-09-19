using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
