using Model;
using BusinessLogic;
using System;
using System.Collections.Generic;

namespace UI
{
    public class Program
    {
        private static MusicService musicService;
        
    static void Main(string[] args)
        {
            musicService = new MusicService();

            Console.WriteLine("Music Playlist System.");

            Console.Write("\nEnter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            AccountBL accountBL = new AccountBL();
            bool result = accountBL.VerifyAccount(username, password);

            if (result)
            {
                while (true)
                {
                    Console.WriteLine("\n---------------------------------------------");
                    Console.WriteLine("\nMusic Playlist.");

                    Console.WriteLine("\nPlaylist 1:");
                    Console.WriteLine("1. Add Song to Playlist 1.");
                    Console.WriteLine("2. Show Playlist 1.");

                    Console.WriteLine("\nPlaylist 2:");
                    Console.WriteLine("3. Add Song to Playlist 2.");
                    Console.WriteLine("4. Show Playlist 2.");

                    Console.WriteLine("\nPlaylist 3:");
                    Console.WriteLine("5. Add Song to Playlist 3.");
                    Console.WriteLine("6. Show Playlist 3.");

                    Console.WriteLine("\nExit.");
                    Console.WriteLine("7. Exit.");

                    Console.WriteLine("\nEnter a number (1-7):");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddSong();
                            break;
                        case "2":
                            ShowPlaylist();
                            break;
                        case "3":
                            AddSong2();
                            break;
                        case "4":
                            ShowPlaylist2();
                            break;
                        case "5":
                            AddSong3();
                            break;
                        case "6":
                            ShowPlaylist3();
                            break;
                        case "7":
                            Console.WriteLine("Do you want to exit? (y/n)");
                            string exitChoice = Console.ReadLine().ToLower();
                            if (exitChoice == "y")
                            {
                                return;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }

            else
            {
                Console.WriteLine("ERROR...");
            }
        }

        private static void AddSong()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.Write("\nEnter song title: ");
            string title = Console.ReadLine();

            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter release year: ");
            string releaseYear = Console.ReadLine();

            musicService.AddSongToPlaylist(title, artist, genre, releaseYear);
            Console.WriteLine("\nSong added successfully!");
        }

        private static void AddSong2()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.Write("\nEnter song title: ");
            string title = Console.ReadLine();

            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter release year:");
            string releaseYear = Console.ReadLine();

            musicService.AddSongToPlaylist2(title, artist, genre, releaseYear);
            Console.WriteLine("\nSong added successfully!");
        }

        private static void AddSong3()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.Write("\nEnter song title: ");
            string title = Console.ReadLine();

            Console.Write("Enter artist: ");
            string artist = Console.ReadLine();

            Console.Write("Enter genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter release year: ");
            string releaseYear = Console.ReadLine();

            musicService.AddSongToPlaylist3(title, artist, genre, releaseYear);
            Console.WriteLine("\nSong added successfully!");
        }

        private static void ShowPlaylist()
        {
            List<Song> songs = musicService.GetPlaylistSongs();

            if (songs.Count == 0)
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nPlaylist is empty.");
            }
            else
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nYour Playlist:");
                int index = 1;
                foreach (Song song in songs)
                {
                    Console.WriteLine($"{index}. {song.Title} - {song.Artist} ({song.Genre}, {song.ReleaseYear})");
                    index++;
                }
            }
        }

        private static void ShowPlaylist2()
        {
            List<Song> songs = musicService.GetPlaylist2Songs();

            if (songs.Count == 0)
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nPlaylist 2 is empty.");
            }
            else
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nYour Playlist 2:");
                int index = 1;
                foreach (Song song in songs)
                {
                    Console.WriteLine($"{index}. {song.Title} - {song.Artist} ({song.Genre}, {song.ReleaseYear})");
                    index++;
                }
            }
        }

        private static void ShowPlaylist3()
        {
            List<Song> songs = musicService.GetPlaylist3Songs();

            if (songs.Count == 0)
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nPlaylist 3 is empty.");
            }
            else
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nYour Playlist 3:");
                int index = 1;
                foreach (Song song in songs)
                {
                    Console.WriteLine($"{index}. {song.Title} - {song.Artist} ({song.Genre}, {song.ReleaseYear})");
                    index++;
                }
            }
        }
    }
}
