using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Continental_App.Continentes;
using Continental_App.Continents;

namespace Continental_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Continente[] continents = new Continente[3];

            continents[0] = new Africa();
            continents[1] = new Asia();
            continents[2] = new America();

            foreach (Continente continent in continents)
            {
                Console.WriteLine(continent.GetType().Name + ":");
                foreach (Animal animal in continent.Animals)
                {
                    Console.WriteLine(" " + animal.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
