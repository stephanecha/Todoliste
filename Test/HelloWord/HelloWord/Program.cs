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
            //Console.WriteLine("les données à afficher dans la console sont écrites ici")
            //L'éxecution de l'instruction ne se fera uniquement si l'on ajoute le ';' autrement impossible de passer la commande

            Console.WriteLine("Hello Blue World !");
            Console.WriteLine("What can you tell me about Nature ?\n");

            //Console.ReadKey(*aucune surcharge de possible, cad ; aucune information ne opeut être inscrite ici, car on "recupère" des info, on ne les transmets pas)
            //Console.ReadKey();

            //Console.ReadLine(*récupérè et affiche la ligne de caractères tapée au clavié par l'utilisateur, dans la console -même remarque que po) 
            //Console.ReadLine();
        }
    }
}
