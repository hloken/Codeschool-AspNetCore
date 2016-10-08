using System.Collections.Generic;
using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CharacterSheetApp.Controllers
{
    public class QuestController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new List<Quest>());
        }
    }
}
