using Model;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Playlist2
    {
        private List<Song> songs;

        public Playlist2()
        {
            songs = new List<Song>();
        }

        public void AddSong2(Song song)
        {
            songs.Add(song);
        }

        public List<Song> GetSong2()
        {
            return songs;
        }
    }
}
