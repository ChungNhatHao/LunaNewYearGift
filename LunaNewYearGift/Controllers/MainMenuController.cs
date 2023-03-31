using Microsoft.AspNetCore.Mvc;

namespace LunaNewYearGift.Controllers
{
    public class MainMenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
