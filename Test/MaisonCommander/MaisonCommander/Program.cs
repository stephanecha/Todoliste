using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var FicheDePersonne = new List<string>();

            Console.WriteLine("Nom?");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Prenom?");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Age?");
            FicheDePersonne.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Bonjour " + FicheDePersonne[1] + " " + FicheDePersonne[0] + ",\nTu as " + FicheDePersonne[2] + " " + "ans.");


            Console.ReadKey();
        }
    }
}