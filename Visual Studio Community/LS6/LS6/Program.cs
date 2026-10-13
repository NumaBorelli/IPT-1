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

                // PRÜFUNG: Ungültige Menge
                if (articleCount < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ungültige Eingabe! Die Menge muss mindestens 1 sein.");
                    Console.ReadLine();
                    return;
                }

                // VERARBEITUNG: Zwischentotal berechnen
                decimal subtotal = articlePrice * articleCount;

                // ENTSCHEIDUNG: Rabatt bestimmen
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

                // VERARBEITUNG: Rabatt und Endtotal berechnen
                decimal discountAmount = subtotal * discountPercent / 100;
                decimal finalTotal = subtotal - discountAmount;

                // AUSGABE: Beleg anzeigen
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

                Console.ReadLine();
            }
        }
    }