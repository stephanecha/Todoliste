/* Première application "Hello Word !"
Utilisation des Methodes ;
  Console.WriteLine(ce que l'on souhaite afficher) : permet l'affichage du résultat demandé à la console
  Console.Readkey(...) & Console.ReadLine(...)     : permet à la console de recuperer 'la ligne || la touche' tapé par l'utilsateur
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWhat is your name ?");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            Console.WriteLine("\nQue cherches tu ?");
            var chercher = Console.ReadLine();

            Console.WriteLine("\nVraiment ?");
            Console.ReadLine();

            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t} tu cherches {chercher}!");

            string yBoss = "Hey Jhonny";
            string unBadasse = "Ok Badasse";
            yBoss = yBoss.Replace("Hey", "La vache");
            yBoss = yBoss.Remove(0);

            Console.WriteLine($"{yBoss}, wait wait wait just a check, {unBadasse}");
            int Verre = 0;
            while (Verre < 10)
            {
                Console.WriteLine($"Je te fabrique, {Verre}, verres. ");
                Verre++;
            }
 //           int Verre = 0;
            do
            {
                Console.WriteLine($"combien en reste t il? {Verre}");
                Verre--;
            } while (Verre<20)

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);

            // le merge à fonctionné dans le sens Iteration 2 au master

        }
    }
}
