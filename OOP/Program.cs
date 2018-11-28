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

            #region Vererbung
            // Einrückung Korrigieren: STRG + K + D
            // Alternative: letzte klammer löschen und neu schreiben :)

            //LKW l = new LKW();
            //l.Geschwindigkeit = 200;
            //Console.WriteLine(l.Kilometerstand);
            //l.Fahren(10);
            //Console.WriteLine(l.Kilometerstand); 
            #endregion

            #region Polymorphie
            //Grafik g1 = new Grafik("Rot");
            //Kreis k1 = new Kreis(20, "Gelb");
            //Rechteck r1 = new Rechteck(10, 10, "Grün");

            //g1.Zeichnen();
            //k1.Zeichnen();
            //r1.Zeichnen();

            //// Polymorphie - Vielgestaltigkeit
            //// Objekte der Subklasse können genauso verwendet werden wie Objekte der Basisklasse
            //Console.WriteLine("------------------------ Überschreiben -------------------------");

            //Grafik g2 = new Kreis(50,"Orange");
            //g2.Zeichnen();

            //// Wir wissen, dass in g2 ein Kreis drinnen ist

            //// Variante 1: Casten
            //Kreis k2 = (Kreis)g2;
            //k2.Farbe = "Violett";

            //g2.Zeichnen();

            //Console.WriteLine("------------------------ Verstecken -------------------------");

            //Grafik g3 = new Rechteck(20, 50, "Pink");
            //g3.Zeichnen();

            //// Variante 2: as - Operator
            //Rechteck r3 = g3 as Rechteck;
            //r3.Höhe = 99;

            //r3.Zeichnen();

            //// Unterschied zwischen Casten und "as"-Operator
            //// Kreis k5 = (Kreis)g3; // in wirklichkeit ein Rechteck
            //// Bei einem falschen Cast gibt es eine "InvalidCastException"
            //Kreis k6 = g3 as Kreis; // in wirklichkeit ein Rechteck
            //// Bei einem Fehler: null (=> KEINE EXCEPTION)

            //// as - Anwendungsfall
            //Kreis k7 = g3 as Kreis ?? new Kreis(10, "Transparent");
            //// -> Versuche g3 zu einem Kreis zu machen, wenn das nicht geht, mach einen neuen Kreis

            //Console.WriteLine("------------------------ Anwendungsfall -------------------------");

            //Grafik[] alleGrafiken = new Grafik[3];
            //alleGrafiken[0] = k1;
            //alleGrafiken[1] = r1;
            //alleGrafiken[2] = g1;
            //// ... 

            //foreach (var item in alleGrafiken)
            //{
            //    item.Zeichnen();
            //    // is - operator
            //    if(item is Kreis)
            //    {
            //        // Kreislogik
            //    }
            //    else if (item is Rechteck)
            //    {
            //        // Recktecklogik mit Casten oder "as" - operator
            //        Rechteck temp = (Rechteck)item;
            //        temp.Zeichnen();
            //    }
            //}
            #endregion



            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
