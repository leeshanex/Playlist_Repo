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
    public class PlaylistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaylistController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Playlist
        public async Task<IActionResult> Index()
        {
            var listOfSongs = await _context.Musics.ToListAsync();
            return View(listOfSongs);
        }

        // GET: Playlist/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Musics
                .FirstOrDefaultAsync(m => m.SongId == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(music);
        }

        // GET: Playlist/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SongId,SongTitle,Artist,Genre")] Music music)
        {
            if (ModelState.IsValid)
            {
                _context.Add(music);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(music);
        }

        // GET: Playlist/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Musics.FindAsync(id);
            if (music == null)
            {
                return NotFound();
            }
            return View(music);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongId,SongTitle,Artist,Genre")] Music music)
        {
            if (id != music.SongId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(music);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicExists(music.SongId))
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
            return View(music);
        }

        // GET: Playlist/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Musics
                .FirstOrDefaultAsync(m => m.SongId == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(music);
        }

        // POST: Playlist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var music = await _context.Musics.FindAsync(id);
            _context.Musics.Remove(music);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicExists(int id)
        {
            return _context.Musics.Any(e => e.SongId == id);
        }
        [HttpGet]

        public ActionResult Random()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Random(string genre)
        {
            Random r = new Random();
            var Playlist = _context.Musics.Where(m => m.Genre == genre).ToList();
            var RandomPlaylist = Playlist.OrderBy(m => r.Next()).Take(10);
            return View(RandomPlaylist);
        }

        [HttpGet]

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string Name, string Genre)
        {
            var searchedSong = _context.Musics.Where(m => m.SongTitle == Name && m.Genre == Genre);
            return View(searchedSong);
        }
    }
}
