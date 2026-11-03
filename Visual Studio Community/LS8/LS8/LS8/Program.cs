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

            // EINGABE
            Console.Write("Artikel: ");
            string articleName = Console.ReadLine();

            Console.Write("Preis: ");
            decimal articlePrice = Convert.ToDecimal(Console.ReadLine());

            int articleCount;

            do
            {
                Console.Write("Anzahl: ");
                articleCount = Convert.ToInt32(Console.ReadLine());

                if (articleCount < 1)
                {
                    Console.WriteLine("Ungültige Eingabe! Die Menge muss mindestens 1 sein.");
                }

            } while (articleCount < 1);

            // VERARBEITUNG
            decimal subtotal = articlePrice * articleCount;

            // ENTSCHEIDUNG
            decimal discountPercent;

            if (articleCount >= 5)
            {
                discountPercent = 20;
            }
            else if (articleCount >= 3)
            {
                discountPercent = 10;
            }
            else
            {
                discountPercent = 0;
            }

            decimal discountAmount = subtotal * discountPercent / 100;
            decimal finalTotal = subtotal - discountAmount;

            // AUSGABE
            Console.WriteLine();
            Console.WriteLine("Zusammenfassung");
            Console.WriteLine("--------------------");
            Console.WriteLine("Artikel: " + articleName);
            Console.WriteLine("Einzelpreis: CHF " + articlePrice.ToString("F2"));
            Console.WriteLine("Anzahl: " + articleCount);
            Console.WriteLine("Zwischentotal: CHF " + subtotal.ToString("F2"));
            Console.WriteLine("Rabatt: " + discountPercent + "%");
            Console.WriteLine("Rabattbetrag: CHF " + discountAmount.ToString("F2"));
            Console.WriteLine("Endtotal: CHF " + finalTotal.ToString("F2"));

            // Etiketten
            Console.WriteLine();
            for (int i = 1; i <= articleCount; i++)
            {
                Console.WriteLine($"Etikett {i}: {articleName}");
            }

            Console.ReadLine();
        }
    }
}