/*
Calculer la tva d'un produit ht et en donner son resultat.
Demander à l'utilisateur d'introduire un montant hors tva, ainsi que son taux de tva

le programme doit calculer ET afficher la TVA à payer en euros ET le montant total TVA.

Ebauche du programme :
             * Veuillez nous préciser le montant HT de votre produit ainsi que votre taux de Tva ? :
             * HT
             * Taux tva
             * Récap de vos frais :
             * taxe
             * TtC
             * Le montant total est de xx€ TTC
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
            string coutHt = "Veuillez préciser le montant Ht de votre produit";
            string tauxTva = "\nLe taux de vôtre Tva local étant de";
            string message = "\nLe montant Ttc de votre produit sera de ";
            string detailOperation = "\nDétail de vos opérations :";

            var c = 100;
            double taxe = 20.6;

            Console.WriteLine(coutHt);
            var ht = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(tauxTva+" "+taxe+" %");

            double prixTtc = (ht + (ht * taxe / c));
            double fTva = prixTtc - ht;

            Console.WriteLine(message+prixTtc+" euros");

            Console.WriteLine(detailOperation+ "\nTva : "+fTva+" euros"+"\nCout Ht : " + ht+" euros");
            Console.WriteLine("\nFin de l'opération, à bientôt.\n");

        }

    }

}