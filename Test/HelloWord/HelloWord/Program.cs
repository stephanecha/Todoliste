/* Première application "Hello Word !"
Utilisation des Methodes ;
  Console.WriteLine(ce que l'on souhaite afficher) : permet l'affichage du résultat demandé à la console
  Console.Readkey(...) & Console.ReadLine(...)     : permet à la console de recuperer 'la ligne || la touche' tapé par l'utilsateur
*/

using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
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
                string administrateur = ("gtm@gmail.com");

                {
                    Console.WriteLine($"\n\aVous n'êtes pas autoriser à acceder à notre site, veuillez vous rapprocher de votre administrateur, {administrateur} désolé !");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"\nBienvenu {name}, veuillez entrez votre mot de passe");
                var mdp = Console.ReadLine();
                if (mdp == "UserCom")//liste de mdp egalement...
                {
                    Console.Beep(52, 33);

                    Console.WriteLine($"\n\nQue souhaitez vous réaliser aujourd'hui {name}?\n");
                    Console.WriteLine("1 . Visualiser : 1"); // faire une liste de consultation de client et de voyage en mode sql
                    Console.WriteLine("2 . Dénicher   : 2"); // idem ci dessus liste de voyage en dispo avec liste de client acheteur
                    Console.WriteLine("3 . Prospecter : 3"); // liste client potentiel et voyage dispo avec promo enfant 12 ans et liste tranche d'age etc via sql ?
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.WriteLine(".qQ : Revenir un peux plus tard finalement... : Qq..");
                    var choixMenu = Console.ReadLine();
                    switch (choixMenu)
                    {
                        case "1":
                            Console.WriteLine("Aller qu'est ce qu'il y a dans cette armoire...");
                            break;
                        case "2":
                            Console.WriteLine("Dennicher de bonnes affaire ? Oui tout de suite.");
                            break;
                        case "3":
                            Console.WriteLine("Allons pêcher ça faisait un que ça me trote dans la tete .!");
                            break;
                        case "q":
                        case "Q":
                            Console.WriteLine("\nEn souhaitant vous revoir très prochainement, à tres bientôt !");
                            break;
                        default:
                            Console.WriteLine("\nEn souhaitant vous revoir très prochainement, à tres bientôt !");
                            break;
                    }

                }
            }
        }
    }
}