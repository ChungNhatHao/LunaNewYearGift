using Microsoft.AspNetCore.Mvc;

namespace LunaNewYearGift.Controllers
{
    public class CandyProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
