using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();

            cd.Artist = "Artist - Devin Townsend";
            cd.AlbumTitle = "Album Title - Terria";
            cd.Price = "Price - 19.90";

            Track song1 = new Track { Title = "Olives", Length = "3:21" };
            Track song2 = new Track { Title = "Mountain", Length = "6:33" };
            Track song3 = new Track { Title = "Earth Day", Length = "9:35" };
            Track song4 = new Track { Title = "Deep Peace", Length = "7:35" };
            Track song5 = new Track { Title = "Canada", Length = "6:53" };
            Track song6 = new Track { Title = "Down and Under", Length = "3:43" };
            Track song7 = new Track { Title = "The Fluke", Length = "7:16" };
            Track song8 = new Track { Title = "Nobody's Here", Length = "6:54" };
            Track song9 = new Track { Title = "Tiny Tears", Length = "9:13" };
            Track song10 = new Track { Title = "Stagnant", Length = "5:26" };
            Track song11 = new Track { Title = "Hidden Track", Length = "5:30" };

            cd.AddTrack(song1);
            cd.AddTrack(song2);
            cd.AddTrack(song3);
            cd.AddTrack(song4);
            cd.AddTrack(song5);
            cd.AddTrack(song6);
            cd.AddTrack(song7);
            cd.AddTrack(song8);
            cd.AddTrack(song9);
            cd.AddTrack(song10);
            cd.AddTrack(song11);

            cd.PrintData();
        }
    }
}
