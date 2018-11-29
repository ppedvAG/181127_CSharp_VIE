using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variante 1:
            Obst o1 = new Obst();
            o1.Name = "Apfel";
            o1.Herkunft = "Steiermark";
            o1.Preis = 2;
            o1.Kcal = 80;

            Händler max = new Händler();
            max.Produkt = o1;
            max.Anzahl = 500;

            // Variante 2:
            Obst o2 = new Obst("Banane", "Brasilien", 3, 120);
            Händler moritz = new Händler(o2, 1000);

            // Variante 3: Objektinitialisierer:
            // Konstruktor ist frei wählbar

            // Variante für den parameterlosen Konstruktor
            Obst o3 = new Obst {Name = "Orange",Herkunft = "Spanien"};

            Händler lisa = new Händler
            {
                Produkt = new Gemüse()
                {
                    Name = "Gurke",
                    Preis= 1
                },
                Anzahl = 5000
            };

            // Das selbe Konzept für Arrays:
            // int[] zahlen = new int[] { 12, 3, 7, 4, 3, 5 };
            // zahlen[0] = 12;

            // Anonyme Objekt:
            var meinObjekt = new { Vorname = "Tom", Nachame = "Ate" };

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
