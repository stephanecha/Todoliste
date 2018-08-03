/*Calculer la tva d'un produit ht et en donner son resultat.
Demander à l'utilisateur d'introduire un montant hors tva, ainsi que son taux de tva

 

le programme doit calculer ET afficher la TVA a payer en euros et le montant total TVA.

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

            double tauxTva = 1.206;



            Console.WriteLine("Quel est le Montant HT de votre article :");

            Console.ReadLine();

            Console.WriteLine("\nVeuillez préciser votre taux TVA local :");

            Console.ReadLine();



            Console.WriteLine("\nLe coût de la TVA à payer est de :");



            Console.WriteLine("\nLe prix TTC de votre article sera de :");

        }

        private static void CoutTva(double())

        {

            // coût tva à payer = (montant ht + Tva)- montant ht            

        }

        static void CoutTtc()

        {



        }----

    }

}