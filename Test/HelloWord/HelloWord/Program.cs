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
    {//la méthode Main est le point d'entré du programme, dans la class Program
        static void Main(string[] args)
        {
            //Console.WriteLine("donnés à afficher")
            //L'éxecution de l'instruction ne se fera uniquement si l'on ajoute le ';' autrement rien
            Console.WriteLine("Hello Word!");

            //Console.ReadKey("donnés que récupère la cosole")
            Console.ReadKey();
        }
    }
}
