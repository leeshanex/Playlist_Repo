using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Playlist_Project.Models;
using Playlist_Project.Services;

namespace Playlist_Project.Controllers
{
    public class HomeController : Controller
    {
        private MusicSearchService _musicSearchService;
        public HomeController(MusicSearchService musicSearchService)
        {
            _musicSearchService = musicSearchService;
        }

        public async Task<IActionResult> Index()
        {  
            return View();
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
        public async Task<IActionResult> MusicSearch()
        {
            
            Datum searchedMusic = await _musicSearchService.GetMusicSearched();

            var displaySampleTrack = searchedMusic;
            return View(displaySampleTrack);
        }
    }
}
