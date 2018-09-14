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
            string administrateur = "gtm@gmail.com";
            Console.WriteLine($"\n{date}\nVotre identifiant qui est votre prenom, je vous pries :");
            var presentation = Console.ReadLine();
            List<string> users = new List<string> { "Alex", "Ana", "Felipe"};
            //(string, bool) quitter = (Console.ReadLine(), "q" is "Q");
            bool quitter = "q" is "Q";

            foreach (string user in users)
                
                if (presentation != user)
                {
                    Console.Clear();

                    Console.WriteLine($"\n\aVous n'êtes pas autoriser à acceder à ce site, veuillez vous prendre contact avec notre administrateur, {administrateur}!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine($"\n{date}");
                    Console.ReadKey();
                }
                else
                {

                    Console.Clear();
                    Console.Beep(3000, 90);
                    Console.Beep(3900, 90);
                    Console.Beep(4100, 190);

                    Console.WriteLine($"\nBienvenu {presentation}, veuillez entrez votre mot de passe {date}");
                    string mdp = Console.ReadLine();
                    var clees = new List<string> { "root", "toor", "UserCom" };

                    foreach (var clee in clees)
                        if (mdp != clee)
                        {
                            Console.Clear();

                            Console.WriteLine($"\n\nQue souhaitez vous réaliser aujourd'hui {presentation}?");
                            Console.WriteLine("1 . Visualiser : 1"); // faire une liste de consultation de client et de voyage en mode sql
                            Console.WriteLine("2 . Dénicher   : 2"); // idem ci dessus liste de voyage en dispo avec liste de client acheteur
                            Console.WriteLine("3 . Prospecter : 3"); // liste client potentiel et voyage dispo avec promo enfant 12 ans et liste tranche d'age etc via sql ?
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine(".qQ : Revenir un peux plus tard finalement... : Qq..");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            int choixMenu = Console.Read();
                            switch (choixMenu)
                            {
                                case 1:
                                    Console.WriteLine("\nAller qu'est ce qu'il y a dans cette armoire...");
									//new LeVoyage();
									Voyage.menu(); // attention au "static" dans la methode, menu.
									/* var monobjet = new Voyage(); // instancier "minobjet" pour la creation */


                                    break;
                                case 2:
                                    Console.WriteLine("\nDennicher de bonnes affaire ? Oui tout de suite.");
                                    break;
                                case 3:
                                    Console.WriteLine("\nAllons pêcher ça faisait un que ça me trote dans la tete .!");
                                    break;
                                case 4 when quitter:

                                default:
                                    Console.WriteLine($"\nEn souhaitant vous revoir très prochainement, à tres bientôt !");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine($"\n{date}");
                                    break;
                            }
                        }
                }
        }
    }
}

