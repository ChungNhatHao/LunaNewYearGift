using Microsoft.AspNetCore.Mvc;

namespace LunaNewYearGift.Controllers
{
    public class DrinkProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
