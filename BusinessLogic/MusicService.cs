using Model;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MusicService
    {
        private Playlist playlist;
        private Playlist2 playlist2;
        private Playlist3 playlist3;

        public MusicService()
        {
            playlist = new Playlist();
            playlist2 = new Playlist2();
            playlist3 = new Playlist3();
        }

        public void AddSongToPlaylist(string title, string artist, string genre, string releaseYear)
        {
            Song song = new Song(title, artist, genre, releaseYear);
            playlist.AddSong(song);
        }

        public void AddSongToPlaylist2(string title, string artist, string genre, string releaseYear)
        {
            Song song = new Song(title, artist, genre, releaseYear);
            playlist2.AddSong2(song);
        }

        public void AddSongToPlaylist3(string title, string artist, string genre, string releaseYear)
        {
            Song song = new Song(title, artist, genre, releaseYear);
            playlist3.AddSong3(song);
        }

        public List<Song> GetPlaylistSongs()
        {
            return playlist.GetSong();
        }

        public List<Song> GetPlaylist2Songs()
        {
            return playlist2.GetSong2();
        }

        public List<Song> GetPlaylist3Songs()
        {
            return playlist3.GetSong3();
        }
    }
}
