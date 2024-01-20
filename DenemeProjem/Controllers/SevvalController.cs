using Microsoft.AspNetCore.Mvc;

namespace DenemeProjem.Controllers
{
	public class SevvalController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
