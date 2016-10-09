using System.Collections.Generic;
using System.Linq;
using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CharacterSheetApp.Controllers
{
    public class QuestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Quest quest)
        {
            _context.Quests.Add(quest);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            //Set Title Here

            var model = _context.Quests.ToList();
            return View(model);
        }

        public IActionResult Details(string name)
        {
            var model = _context.Quests.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        public IActionResult Update(Quest quest)
        {
            _context.Entry(quest).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            var quest = _context.Quests.FirstOrDefault(e => e.Name == name);
            _context.Quests.Remove(quest);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
