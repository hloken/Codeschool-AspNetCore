using System.Collections.Generic;
using System.Linq;
using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpGet]
        public IActionResult Edit(string name)
        {
            ViewData["Title"] = "Edit " + name;

            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Characters";
            var model = _context.Characters.ToList();
            return View(model);
        }

        [HttpGet]
        public List<Character> GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return model;
        }

        [HttpGet("Character/{name}/Details")]
        public IActionResult Details(string name)
        {
            ViewData["Title"] = name;

            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Create(Character character)
        {
            if (_context.Characters.Any(e=>e.Name == character.Name))
                ModelState.AddModelError("Name", "Name is already in use.");

            if (!ModelState.IsValid)
                return View(character);

            _context.Characters.Add(character);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Character character)
        {
            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost("Character/{name}/Delete")]
        public IActionResult Delete(string name)
        {
            var original = _context.Characters.FirstOrDefault(e => e.Name == name);
            if (original != null)
            {
                _context.Characters.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
