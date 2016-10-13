using System.Collections.Generic;
using System.Linq;
using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterSheetApp.Controllers
{
    //[Route("[controller]/[action]")]
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View(Character.GetAll());
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(string characterName)
        //{
        //    Character.Create(characterName);

        //    return RedirectToAction("Index");
        //}

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Characters";
            var model = _context.Characters.ToList();
            return View(model);
        }

        //[HttpGet("active")]
        public List<Character> GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return model;
        }

        //[HttpGet("{name}")]
        public IActionResult Details(string name)
        {
            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        [HttpPut]
        public IActionResult Update(Character character)
        {
            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete("{name}")]
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
