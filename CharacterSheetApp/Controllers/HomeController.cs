using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
