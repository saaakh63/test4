using Microsoft.AspNetCore.Mvc;

namespace test4.Controllers
{
	public class TesttController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
