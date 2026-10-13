using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Willkommen zu der Mensa-App!");
            Console.WriteLine();

            // EINGABE: Daten vom Benutzer erfassen
            Console.Write("Artikel: ");
            string articleName = Console.ReadLine();

            Console.Write("Preis: ");
            decimal articlePrice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Anzahl: ");
            int articleCount = Convert.ToInt32(Console.ReadLine());


            // VERARBEITUNG: Gesamtpreis berechnen
            decimal totalPrice = articlePrice * articleCount;


            // AUSGABE: Ergebnis anzeigen
            Console.WriteLine();
            Console.WriteLine("Zusammenfassung");
            Console.WriteLine("Artikel: " + articleName);
            Console.WriteLine("Preis: CHF " + articlePrice);
            Console.WriteLine("Anzahl: " + articleCount);
            Console.WriteLine("Gesamtpreis: CHF " + totalPrice);


            Console.ReadLine();
        }
    }
}

