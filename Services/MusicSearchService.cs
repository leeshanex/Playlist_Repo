using Newtonsoft.Json;
using Playlist_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Playlist_Project.Services
{
    public class MusicSearchService
    {
        public MusicSearchService()
        {

        }
        public async Task<MusicSearch> GetMusicSearched()
        {
            string userInput = "odesza";
            string q = userInput.ToLower();
            string url = $"https://api.deezer.com/search?q={q}";
        HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                MusicSearch musicSearch = JsonConvert.DeserializeObject<MusicSearch>(json);
                return (musicSearch);
            }
            return null;
        }
    }
}
