using System.Threading.Tasks;
using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View(Character.GetAll());
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(string characterName)
		{
			Character.Create(characterName);

			return RedirectToAction("Index");
		}
	}
}
