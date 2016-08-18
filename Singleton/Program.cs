using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton s1 = new Singleton() <- ez így nem példányosítható, mert private konstruktora van
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance; // ez ugyan az a példány lesz mint az s1

            // írjuk is ki
            if (s1 == s2)
                Console.WriteLine("Valóban, a két példány ugyan az!");
            else
                Console.WriteLine("A két példány nem ugyan az!");

            Console.ReadLine();
        }
    }
}
