using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Klassen
            ////Person p;           // Deklaration: ist noch null
            ////p = new Person();   // Instanziierung: Personen-Objekt wird erstellt

            ////p.vorname = "Max";
            ////p.nachname = "Mustermann";
            //////p.alter = 255;
            ////p.kontostand = -21312312312345;

            //////p.AlterSetzen(200);
            //////Console.WriteLine(p.AlterAuslesen());

            ////p.Alter = 100;
            ////Console.WriteLine(p.Alter);

            //Fahrzeug audi = new Fahrzeug();
            //audi.Geschwindigkeit = 200;

            //Console.WriteLine(audi.Kilometerstand);
            //audi.Fahren(5);
            //Console.WriteLine(audi.Kilometerstand);

            //audi = null; // "Löschen"
            //GC.Collect();
            ////GC.Collect(0, GCCollectionMode.Forced, true); 
            #endregion

            // Einrückung Korrigieren: STRG + K + D
            // Alternative: letzte klammer löschen und neu schreiben :)

            LKW l = new LKW();
            l.Geschwindigkeit = 200;
            Console.WriteLine(l.Kilometerstand);
            l.Fahren(10);
            Console.WriteLine(l.Kilometerstand);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
