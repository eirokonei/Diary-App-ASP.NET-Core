using Microsoft.AspNetCore.Mvc;
using MyDiary.Data;
using MyDiary.Models;

namespace MyDiary.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            
            List<DiaryEntry> diaryEntries = _db.DiaryEntries.ToList();

            return View(diaryEntries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3) 
            {
                ModelState.AddModelError("Error", "Title too short less than 3");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if(id==null || id==0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry != null)
            {
                return View(diaryEntry);
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Error", "Title too short less than 3");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
            if (diaryEntry != null)
            {
                return View(diaryEntry);
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
                _db.DiaryEntries.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
        }
    }
}
