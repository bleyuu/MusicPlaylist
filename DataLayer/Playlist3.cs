﻿using Model;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Playlist3
    {
        private List<Song> songs;

        public Playlist3()
        {
            songs = new List<Song>();
        }

        public void AddSong3(Song song)
        {
            songs.Add(song);
        }

        public List<Song> GetSong3()
        {
            return songs;
        }
    }
}
