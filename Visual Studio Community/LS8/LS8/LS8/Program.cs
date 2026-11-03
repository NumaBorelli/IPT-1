using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS8
{
    internal class Program
    {
        static void Main(string[] args)
        {


          

            int menge = 4;

            // Teil A: Etiketten nummerieren
            for (int i = 1; i <= menge; i++)
            {
                Console.WriteLine($"Etikett {i}: Apfelschorle");
            }

            // Teil B: Gültige Menge abfragen
            do
            {
                Console.Write("Menge: ");
                menge = Convert.ToInt32(Console.ReadLine());

                if (menge <= 0)
                {
                    Console.WriteLine("Ungültige Menge.");
                }

            } while (menge <= 0);

            Console.WriteLine($"Menge übernommen: {menge}");

            // Bug-Auftrag: Fehlerhafte Schleife
            for (int i = 1; i < menge; i++)
            {
                Console.WriteLine($"Etikett {i}");
            }

            // Korrigierte Schleife
            for (int i = 1; i <= menge; i++)
            {
                Console.WriteLine($"Etikett {i}");

            }

        }
    }
}
