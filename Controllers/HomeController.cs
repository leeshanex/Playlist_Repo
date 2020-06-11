using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Playlist_Project.Data;
using Playlist_Project.Models;

namespace Playlist_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string genre = "Hip-Hop";
            Random r = new Random();
            var randomPlaylist = _context.Musics.Where(m => m.Genre == genre).OrderBy(m => r.Next()).Take(10);
            var displyRandomPlaylist = randomPlaylist;
            return View(displyRandomPlaylist);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
