using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1VT24
{
    internal class Album
    {
        private string albumName;
        private string artistName;
        private int releaseYear;
        private int numberOfTracks;



        public void Start()
        {
          
            ReadAlbumInfo();
            ReadArtistOrBandName();
            ReadTracks();
            DisplayAlbumInfo();


        }

        public void ReadAlbumInfo()
        {
            //Read name of the album
            Console.WriteLine("What is the name of your favorit music album? ");
            albumName = Console.ReadLine();

            //Record release year of the album
            //Console.WriteLine($"What is the release year of the album? ");
            //releaseYear = int.Parse(Console.ReadLine());
        }

        public void ReadArtistOrBandName()
        {
            //Record name of the artist
            Console.WriteLine($"What is the name of the artist or Band for {albumName}? ");
            artistName = Console.ReadLine();
        }

        public void ReadTracks()
        {
            //Record number of tracks on the album
            Console.WriteLine($"How many tracks does {albumName} have? ");
            numberOfTracks = int.Parse(Console.ReadLine());
        }


        public void DisplayAlbumInfo()
        {
            Console.WriteLine();
            string info = "Album name: " + albumName + 
                "\nArtist/Band: " + artistName + 
                "\nNumber of tracks: " + numberOfTracks;
            Console.WriteLine(info);
            Console.WriteLine("Enjoy Listening!");
        }


    }
}
