using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CharacterSheetApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(string characterName)
        //{
        //    Character.Create(characterName);

        //    return RedirectToAction("Index");
        //}
    }
}
