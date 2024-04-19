using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Song
    {
        public string Title;
        public string Artist;
        public string Genre;
        public string ReleaseYear;

        public Song(string title, string artist, string genre, string releaseYear)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
    }
}
