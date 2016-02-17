
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotus5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Power = false;

            Console.WriteLine();

            radio.Power = true;
            radio.Volume = 5;
            radio.Frequency = 20100.5;

            Console.WriteLine();

            radio.Power = true;
            radio.Volume = 15;
            radio.Frequency = 1000.5;
        }
    }
}