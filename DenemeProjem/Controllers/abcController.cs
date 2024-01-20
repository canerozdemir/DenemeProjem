using Microsoft.AspNetCore.Mvc;

namespace DenemeProjem.Controllers
{
	public class abcController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
