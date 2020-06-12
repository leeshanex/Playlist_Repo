﻿using Newtonsoft.Json;
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
        public async Task<Datum> GetMusicSearched()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            string userInput = "odesza";
            string q = userInput.ToLower();
            string url = $"https://deezerdevs-deezer.p.rapidapi.com/search?q=odesza";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "deezerdevs-deezer.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", APIKeys.OpenMusicSearchKey);

            HttpResponseMessage response = await client.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Datum musicSearch = JsonConvert.DeserializeObject<Datum>(json);
                return (musicSearch);
            }
            return null;
        }
        

        
    }
}
