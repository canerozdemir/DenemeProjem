using Microsoft.AspNetCore.Mvc;

namespace DenemeProjem.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int MyProperty { get; set; }
    }
}
