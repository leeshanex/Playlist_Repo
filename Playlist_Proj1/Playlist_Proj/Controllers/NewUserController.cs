using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Playlist_Proj.Data;
using Playlist_Proj.Models;

namespace Playlist_Proj.Controllers
{
    public class NewUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NewUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewUsers.ToListAsync());
        }

        // GET: NewUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUsers
                .FirstOrDefaultAsync(m => m.FirstName == id);
            if (newUser == null)
            {
                return NotFound();
            }

            return View(newUser);
        }

        // GET: NewUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,ZipCode")] NewUser newUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newUser);
        }

        // GET: NewUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUsers.FindAsync(id);
            if (newUser == null)
            {
                return NotFound();
            }
            return View(newUser);
        }

        // POST: NewUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,ZipCode")] NewUser newUser)
        {
            if (id != newUser.FirstName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewUserExists(newUser.FirstName))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(newUser);
        }

        // GET: NewUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUsers
                .FirstOrDefaultAsync(m => m.FirstName == id);
            if (newUser == null)
            {
                return NotFound();
            }

            return View(newUser);
        }

        // POST: NewUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var newUser = await _context.NewUsers.FindAsync(id);
            _context.NewUsers.Remove(newUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewUserExists(string id)
        {
            return _context.NewUsers.Any(e => e.FirstName == id);
        }
    }
}
