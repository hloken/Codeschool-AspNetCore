using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
	        var model = new Character
	        {
		        Name = "Hux"
	        };
	        return View("Index", model);
        }
    }
}
