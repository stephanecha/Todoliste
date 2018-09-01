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
            var date = DateTime.Now;
            var users = new List<string> { "<user>", "Ana", "Felipe", "Alex" };
            var clees = new List<string> { "<clee>", "root", "toor", "UserCom" };
            string administrateur = "gtm@gmail.com";

            Console.WriteLine($"\nVotre identifiant qui est votre prenom, je vous pries {date}");
            var presentation = Console.ReadLine();

            foreach (var user in users)
                if (presentation != user)
                {
                    Console.WriteLine($"\n\aVous n'êtes pas autoriser à acceder à notre site, veuillez vous rapprocher de votre administrateur, {administrateur}! {date}");
                    Console.ReadKey();
                }
                else
                {
                    Console.Beep(3000, 900);
                    Console.WriteLine($"\nBienvenu {presentation}, veuillez entrez votre mot de passe {date}");
                    var mdp = Console.ReadLine();

                    foreach (var clee in clees)
                        if (mdp == clee)
                        {
                            Console.WriteLine($"\n\nQue souhaitez vous réaliser aujourd'hui {presentation}?");
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
                                    Console.WriteLine("\nAller qu'est ce qu'il y a dans cette armoire...");
                                    new menuVisualiser();

                                    break;
                                case "2":
                                    Console.WriteLine("\nDennicher de bonnes affaire ? Oui tout de suite.");
                                    break;
                                case "3":
                                    Console.WriteLine("\nAllons pêcher ça faisait un que ça me trote dans la tete .!");
                                    break;
                                case "q":
                                case "Q":
                                default:
                                    Console.WriteLine($"\nEn souhaitant vous revoir très prochainement, à tres bientôt ! {date}");
                                    break;
                            }
                        }
                }
        }
    }
}

