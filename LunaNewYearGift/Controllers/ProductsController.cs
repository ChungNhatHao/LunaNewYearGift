using Microsoft.AspNetCore.Mvc;

namespace LunaNewYearGift.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
