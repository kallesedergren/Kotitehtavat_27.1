using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class CD
    {
        public string Artist { get; set; }
        public string AlbumTitle { get; set; }
        public string Price { get; set; }

        private List<Track> tracklist;

        public CD()
        {
            tracklist = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            tracklist.Add(track);
        }

        public void PrintData()
        {
            Console.WriteLine("************************************");
            Console.WriteLine(" " + Artist);
            Console.WriteLine(" " + AlbumTitle);
            Console.WriteLine(" " + Price);
            Console.WriteLine();
            foreach (Track track in tracklist)
            {
                Console.WriteLine(" - " + track.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("************************************");
        }
    }
}