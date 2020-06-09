using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Playlist_Project.Data;
using Playlist_Project.Models;

namespace Playlist_Project.Controllers
{
    [Authorize(Roles = "NewUser")]
    public class NewUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewUserController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: NewUser
        public async Task<IActionResult> Index()
        {
            NewUser newUser;
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); //gets your nameIdentifer
                newUser = _context.NewUsers.Where(c => c.IdentityUserId == userId).Single(); 
            }
            catch (Exception)
            {

                return RedirectToAction("create"); //if fails then creates 
            }
            return View(newUser);
        }

        // GET: NewUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUsers.Include(c => c.IdentityUser).FirstOrDefaultAsync(m => m.Id == id);

            if (newUser == null)
            {
                return NotFound();
            }

            return View(newUser);
        }

        // GET: NewUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,ZipCode,Image")] NewUser newUser)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                newUser.IdentityUserId = userId;
                _context.NewUsers.Add(newUser);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        // GET: NewUser/Edit/5
        public async Task<ActionResult> Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            NewUser newUser = _context.NewUsers.Where(c => c.IdentityUserId == userId).Single();
            return View(newUser);
        }

        // POST: NewUser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,ZipCode,Image")] NewUser newUser)
        {
            if (id != newUser.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    NewUser newUserFromDb = _context.NewUsers.Where(c => c.IdentityUserId == userId).Single();
                    newUserFromDb.FirstName = newUser.FirstName;
                    newUserFromDb.LastName = newUser.LastName;
                    newUserFromDb.ZipCode = newUser.ZipCode;
                    newUserFromDb.Image = newUser.Image;
                    await _context.SaveChangesAsync();
                    // TODO: Add update logic here
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewUserExists(newUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { id = newUser.Id.ToString() });
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", newUser.IdentityUserId);
            return View(newUser.Id);
        }


        // GET: NewUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newUser = await _context.NewUsers.Include(c => c.IdentityUser).FirstOrDefaultAsync(m => m.Id == id);
            if (newUser == null)
            {
                return NotFound();
            }

            return View(newUser);
        }

        // POST: NewUser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var newUser = await _context.NewUsers.FindAsync(id);
            _context.NewUsers.Remove(newUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool NewUserExists(int id)
        {
            return _context.NewUsers.Any(c => c.Id == id);
        }
    }
}