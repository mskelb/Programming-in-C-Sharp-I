using System;
using System.Reflection;
using System.Xml.Linq;

namespace KidsFair
{
    public class Album
    {
        // Album name, artist name, and number of tracks
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            GetAlbumName();
            GetArtistName();
            GetTracks();
            DisplayAlbumInfo(); 
        }
        public void GetAlbumName()
        {
            Console.WriteLine("\nWhat is the name of your favorit music album?");
            albumName = Console.ReadLine();
            while (string.IsNullOrEmpty(albumName) || albumName.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or an integer. Try again.");
                Console.WriteLine("What is the name of your favorit music album?");
                albumName = Console.ReadLine();
            }
        }
        public void GetArtistName()
        {
            Console.WriteLine("What is the name of the Artist or Band for " + albumName);
            artistName = Console.ReadLine();
            while (string.IsNullOrEmpty(artistName) || artistName.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or an integer. Try again.");
                Console.WriteLine("What is the name of the Artist or Band for " + albumName);
                artistName = Console.ReadLine();
            }
        }
        public void GetTracks()
        {
            Console.WriteLine("How many tracks does " + albumName + " have?");
            String temp = Console.ReadLine();
            while (string.IsNullOrEmpty(temp) || !temp.All(char.IsDigit))
            {
                Console.WriteLine("Your input is null or not an integer. Try again.");
                Console.Write("How many tracks does " + albumName + " have?");
                temp = Console.ReadLine();
            }
            numOfTracks = Int32.Parse(temp);
        }
        public void DisplayAlbumInfo()
        {
            Console.WriteLine("\nAlbum name: " + albumName + "\n" +
                "Artist/Band: " + artistName + "\n" + "Number of Tracks: " + numOfTracks + "\nEnjoy listening!");
        }
    }
}