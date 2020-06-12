using System;

namespace Playlist_Project.Services
{
    internal class RestRequest
    {
        private object gET;

        public RestRequest(object gET)
        {
            this.gET = gET;
        }

        internal void AddHeader(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}