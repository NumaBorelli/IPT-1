using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while
            int anzahl;
            do
            {
                Console.Write("Anzahl Bücher (1-5): ");
                anzahl = Convert.ToInt32(Console.ReadLine());
            } while (anzahl < 1 || anzahl > 5);

            // for
            for (int i = 1; i <= anzahl; i++)
            {
                Console.WriteLine("Buch " + i + " registriert");
            }

            // while
            int x = anzahl;
            while (x > 0)
            {
                Console.WriteLine("Noch " + x + " offen");
                x--;
            }

            // Abschluss
            Console.WriteLine("Alle Bücher verarbeitet.");
        }
            }
        }