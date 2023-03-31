using Microsoft.AspNetCore.Mvc;

namespace LunaNewYearGift.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
