using System;
namespace BibliothekDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;
            Console.WriteLine("Bibliothek – Gebührenprüfung");
            while (weiter)
            {
                Console.WriteLine("\n1 = Gebühr berechnen\n0 = Beenden\n");
                Console.Write("Auswahl: ");
                
                int auswahl = int.Parse(Console.ReadLine());
                if (auswahl == 0)
                {
                    weiter = false;
                }
                
                else if (auswahl == 1)
                {
                    Console.Write("Ausleihtage: ");
                    int tage = int.Parse(Console.ReadLine());
                    if (tage <= 0)
                    {
                        Console.WriteLine("Ungültige Ausleihdauer.");
                    }
                    else
                    {
                        decimal gebuehr = 0m;
                        int zusatztage = 0;
                        if (tage > 7)
                        {
                            zusatztage = tage - 7;
                        }
                        gebuehr = zusatztage * 0.50m;
                        if (gebuehr > 10m)
                        {
                            gebuehr = 10m;
                        }
                        Console.WriteLine("Zusätzliche Tage: " + zusatztage);
                        Console.WriteLine("Gebühr: CHF " + gebuehr.ToString("0.00"));
                    }
                }
                else
                {
                    Console.WriteLine("Bitte 0 oder 1 wählen.");
                }
            }
            Console.WriteLine("Programm beendet.");
        }
    }
}