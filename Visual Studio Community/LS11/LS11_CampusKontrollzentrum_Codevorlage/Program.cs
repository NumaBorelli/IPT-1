using System;

namespace CampusKontrollzentrum
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapazitaet = 12;
            int anwesend = 0;
            bool laeuft = true;

            Console.WriteLine("CAMPUS EVENT – EINLASSKONTROLLE");

            while (laeuft)
            {
                Console.WriteLine();
                Console.WriteLine("Anwesend: " + anwesend + " / " + kapazitaet);
                Console.WriteLine("Freie Plaetze: " + (kapazitaet - anwesend));
                Console.WriteLine("1 = Gruppe einlassen");
                Console.WriteLine("2 = Gruppe verabschieden");
                Console.WriteLine("3 = Status anzeigen");
                Console.WriteLine("0 = Beenden");
                Console.Write("Auswahl: ");

                int auswahl = int.Parse(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.Write("Wie viele Personen kommen? ");
                    int gruppe = int.Parse(Console.ReadLine());

                    // TODO A: Prüfe die Gruppengroesse und freie Plaetze.
                    // Bei erfolgreichem Einlass: anwesend passend aendern.
                    Console.WriteLine("Einlass noch nicht umgesetzt.");
                }
                else if (auswahl == 2)
                {
                    Console.Write("Wie viele Personen gehen? ");
                    int gruppe = int.Parse(Console.ReadLine());

                    // TODO B: Pruefe Gruppengroesse und anwesende Personen.
                    // Bei gueltigem Ausgang: anwesend passend aendern.
                    Console.WriteLine("Ausgang noch nicht umgesetzt.");
                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Status: " + anwesend + " Personen anwesend.");
                    Console.WriteLine("Frei: " + (kapazitaet - anwesend) + " Plaetze.");
                }
                else if (auswahl == 0)
                {
                    laeuft = false;
                }
                else
                {
                    Console.WriteLine("Ungueltige Menueauswahl.");
                }
            }

            Console.WriteLine("Einlasskontrolle beendet.");
        }
    }
}
