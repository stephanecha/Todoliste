using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer le nombre entier");
            int entier = int.Parse(Console.ReadLine());

            if (entier > 0)
            {
                Console.WriteLine("Nombre positif");
            }
            else if (entier < 0)
            {
                Console.WriteLine("Nombre négatif");
            }
            else
            {
                Console.WriteLine("Rien à dire");
            }
            Console.ReadKey(true);

        }
    }
}