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

            Console.WriteLine("\nVotre identifiant qui est votre prenom, je vous pries");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            if (name != "Alex")//une liste de commercial par exemple
            {
                Console.WriteLine("\n\aVous n'avez pas acces, désolé !");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nBienvenu {name}, veuillez entrez votre mot de passe");
                var mdp = Console.ReadLine();
                if (mdp == "UserCom")//liste de mdp egalement...
                {
                    Console.WriteLine($"\n\n\beepQue souhaitez vous réaliser aujourd'hui {name}?");
                    Console.WriteLine("1. Visualiser :"); // faire une liste de consultation de client et de voyage en mode sql
                    Console.WriteLine("2. Dénicher :"); // idem ci dessus liste de voyage en dispo avec liste de client acheteur
                    Console.WriteLine("3. Prospecter :"); // liste client potentiel et voyage dispo avec promo enfant 12 ans et liste tranche d'age etc via sql ?
                    Console.WriteLine("Q : Revenir un peux plus tard finalement...");
                }
                Console.ReadKey();
            }
        }
    }
}
//            Console.ReadLine();

//            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t} tu cherches {chercher}!");

//            string yBoss = "Hey Jhonny";
//            string unBadasse = "Ok Badasse";
//            yBoss = yBoss.Replace("Hey", "La vache");
//            yBoss = yBoss.Remove(0);

//            Console.WriteLine($"{yBoss}, wait wait wait just a check, {unBadasse}");
//            int Verre = 0;
//            while (Verre < 10)
//            {
//                Console.WriteLine($"Je te fabrique, {Verre}, verres. ");
//                Verre++;
//            }
// //           int Verre = 0;
//            do
//            {
//                Console.WriteLine($"combien en reste t il? {Verre}");
//                Verre--;
//            } while (Verre<20)

//            Console.WriteLine("\nPress any key to exit...");
//            Console.ReadKey(true);

//            // le merge à fonctionné dans le sens Iteration 2 au master

//        }
//    }
//}
