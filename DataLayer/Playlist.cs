using Model;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Playlist
    {
        private List<Song> songs;

        public Playlist()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public List<Song> GetSong()
        {
            return songs;
        }
    }
}
