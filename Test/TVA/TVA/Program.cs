/*
Calculer la tva d'un produit ht et en donner son resultat.
Demander à l'utilisateur d'introduire un montant hors tva, ainsi que son taux de tva

le programme doit calculer ET afficher la TVA à payer en euros ET le montant total TVA. ==>

Ebauche du programme :
             * Veuillez nous préciser le montant HT de votre produit ainsi que votre taux de Tva ? : >ok
             * HT > ok
             * Taux tva >ok
             * Récap de vos frais : >ok
             * taxe >ok
             * TtC >ok
             * Le montant total est de xx€ TTC >ok
*/
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace TVA

{

    class Program

    {

        static void Main(string[] args)

        {
            string coutHt = "Veuillez préciser le montant Ht de votre produit :";
            string tauxTva = "\nVeuillez preciser vôtre taux de Tva local :";
            string messageTtc = "\nLe montant Ttc de votre produit sera de ";
            string detailsOperation = "\nDétail de vos opérations :";
            string finOperation = "\nFin de votre opération, à bientôt !";
            
            Console.WriteLine(coutHt);                      // Apres avoir passer en console le string message, on convertie ensuite la valeur de la variable ht en var Double
            var ht = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(tauxTva);                     // Apres avoir passer en console le string tauxTva, on convertie ensuite la valeur de la variable taux en var Double
            var taux = Convert.ToDecimal(Console.ReadLine());

            var Ttc = ht + (ht * taux / 100);            // Formule de calcul pour l'obtention du Ttc en memorisant la valeur double dans l'objet Ttc
            var fTva = Ttc - ht;                             // Formule de calcul pour l'obtention du cout de la taxe

            Console.WriteLine(detailsOperation+ "\nTva : "+fTva+" euros"+"\nCout Ht : " + ht+" euros"); // On affiche le detail des operations

            Console.WriteLine(messageTtc + Ttc + " euros");                                             // On affiche le message avec les paramettres desirés pour indiquer le Ttc


            Console.WriteLine(finOperation+"\n\nVeuillez tapez sur la touche Entrée pour sortir du programme.");
            Console.Read();
        }

    }

}