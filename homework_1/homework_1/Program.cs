//Kotitehtävä 4
//Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta. Muuta olion arvoja ja tulosta olion arvoja konsolille.
//Versio 1.0
//Kalle Sedergren


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtäviä_27._1
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }



        public void PrintData()
        {
            Console.WriteLine("Vehicle data: ");
            Console.WriteLine(" -Name : " + Name);
            Console.WriteLine(" -Speed : " + Speed);
            Console.WriteLine(" -Tyres : " + Tyres);
        }

        public override string ToString()
        {
            return "Vehicles Name: " + Name + ", " + "Vehicles speed: " + Speed + ", " + "Number of tyres: " + Tyres;
        }


        ~Vehicle()
        {
            Console.WriteLine("Vehicle object destroyed.");
        }


        class Program
        {
            static void Main(string[] args)
            {
                Vehicle Wagon = new Vehicle();
                Wagon.Name = "Hevosvankkurit";
                Wagon.Speed = 35;
                Wagon.Tyres = 4;
                Wagon.PrintData();
                Console.ReadLine();
                Console.WriteLine(Wagon);
                Console.ReadLine();

            }
        }
    }
}
