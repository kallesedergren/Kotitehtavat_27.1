/* Suunnittele UML-editorilla Opiskelija-luokka, 
joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja. 
Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, 
joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). 
Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.

Kalle Sedergren
Versio 1.0*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt5
{
    class Opiskelija
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        private string Hobbies { get; set; }
        public bool Future { get; set; }

        public void Aging()
        {
            Age += 1;
            Console.WriteLine("In a year he/she is " + Age + " years old");
        }

        public void Learn()
        {
            if (Future == true)
            {
                Console.WriteLine("Good, you learned something new! It seems your future looks very bright.");
            }
            else
            {
                Console.WriteLine("It looks like you are unable to learn anything new, at least you tried.");
            }
        }

        public void Name()
        {
            string Wholename = FirstName + LastName;
        }



        public void PrintData()
        {
            Console.WriteLine(" -Age: " + Age);
            Console.WriteLine(" -First name: " + FirstName);
            Console.WriteLine(" -Last name: " + LastName);
            Console.WriteLine(" -Line of study: " + Education);
            Console.WriteLine(" -Hobbies: " + Hobbies);
            Console.WriteLine(" -Future? " + Future);
        }



        class Program
        {
            static void Main(string[] args)
            {
                string[] student = new string[1];



                for (int i = 0; i < student.Length; i++)
                {

                    Opiskelija eka = new Opiskelija();
                    eka.Age = 53;
                    eka.FirstName = "Hannu";
                    eka.LastName = "Karpo";
                    eka.Education = "School of live";
                    eka.Hobbies = "Politix";
                    eka.Future = true;

                    eka.PrintData();
                    Console.ReadLine();
                    eka.Aging();
                    Console.ReadLine();
                    eka.Learn();
                    Console.ReadLine();

                    Opiskelija toka = new Opiskelija();
                    toka.Age = 24;
                    toka.FirstName = "Marja";
                    toka.LastName = "Liisa";
                    toka.Education = "Music";
                    toka.Hobbies = "Music";
                    toka.Future = false;

                    toka.PrintData();
                    Console.ReadLine();
                    toka.Aging();
                    Console.ReadLine();
                    toka.Learn();
                    Console.ReadLine();

                    Opiskelija koka = new Opiskelija();
                    koka.Age = 2016;
                    koka.FirstName = "Jesus";
                    koka.LastName = "Nazarene";
                    koka.Education = "Divinity";
                    koka.Hobbies = "Whimpering and showing off"; //En parempaakaan keksinyt ruikutukselle ja pätemiselle
                    koka.Future = true;

                    koka.PrintData();
                    Console.ReadLine();
                    koka.Aging();
                    Console.ReadLine();
                    koka.Learn();
                    Console.ReadLine();

                }


            }
        }
    }
}

