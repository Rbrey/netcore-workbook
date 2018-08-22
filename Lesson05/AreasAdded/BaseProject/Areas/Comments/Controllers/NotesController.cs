using System.Collections.Generic;
using System.Threading;
using BaseProject.Area.Models;
using BaseProject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Area.Controllers
{
    [Area("Comments")]
    [Route("[area]/Notes")]
    public class NotesController : Controller
    {
        private readonly ApplicationContext _context;

        public NotesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Comment
        [Route("Index")]
        public ActionResult Index()
        {
            return View(new List<Note>());
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comment/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<ActionResult> CreateAsync(Note note, CancellationToken cancellationToken)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                    return View(note);
                _context.Users.Add(note);
                await _context.SaveChangesAsync(cancellationToken);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comment/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

