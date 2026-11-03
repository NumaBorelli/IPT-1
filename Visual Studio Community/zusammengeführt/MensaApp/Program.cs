using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Zusammengeführte Mensa-App: enthält den Stoff von LS5 bis LS8
namespace MensaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zu der Mensa-App!");
            Console.WriteLine();

            // ---------- LS5: EINGABE / VERARBEITUNG / AUSGABE ----------
            Console.Write("Artikel: ");
            string articleName = Console.ReadLine();

            Console.Write("Preis: ");
            decimal articlePrice = Convert.ToDecimal(Console.ReadLine());

            // ---------- LS6 + LS8: Prüfung der Menge ----------
            // LS6: if-Prüfung auf ungültige Menge (Programm brach ab)
            // LS8: do-while wiederholt die Eingabe, bis sie gültig ist
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

            // LS5: Zwischentotal berechnen
            decimal subtotal = articlePrice * articleCount;

            // ---------- LS6: ENTSCHEIDUNG (if / else if / else) ----------
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

            // ---------- AUSGABE: Beleg ----------
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

            // ---------- LS7 + LS8: Schleifen ----------
            // for: Anzahl Durchläufe steht fest -> ein Etikett pro Artikel
            Console.WriteLine();
            for (int i = 1; i <= articleCount; i++)
            {
                Console.WriteLine($"Etikett {i}: {articleName}");
            }

            // while: Ausgabe der noch offenen Artikel herunterzählen (aus LS7)
            Console.WriteLine();
            int offen = articleCount;
            while (offen > 0)
            {
                Console.WriteLine("Noch " + offen + " offen");
                offen--;
            }
            Console.WriteLine("Alle Artikel verarbeitet.");

            Console.ReadLine();

            Console.ReadKey
        }
    }
}
