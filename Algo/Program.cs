using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Merci de rentrer votre note");
			int n = int.Parse(Console.ReadLine()); // Il s'agit de int Parse pour la convertion du string en int.
			int sommes = 0;
			int moyenne = 0;

			for (int i=0; i<n; i++) // for = boucle, une structure iterative | revoir boucle
			{
				int x = int.Parse(Console.ReadLine());
				sommes = sommes + x;
			}

				moyenne = sommes / n;
			Console.WriteLine($"ta mayonne{moyenne}");
			Console.ReadKey(true);
		}
	} 
}
