using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        //static Program()
        //{
        //    GEHEIMZAHL = 123;
        //    NURAUSLESEN = 123;
        //}
        private const int GEHEIMZAHL = 99;              // Muss direkt den Wert haben, man kann nichts mehr zuweisen
        private static readonly int NURAUSLESEN = 999;  // Darf höchstens im Konstruktor gesetzt werden, sonst nirgends

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

            // Konto k1 = new Konto();

            JugendKonto j1 = new JugendKonto();
            Girokonto g1 = new Girokonto();

            Konto[] alleKonten = new Konto[10];
            alleKonten[0] = j1;
            alleKonten[1] = g1;
            // ....

            try
            {
                j1.Kontostand = 40;
                j1.Abheben(20);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #region Static Class und Konstante
            ////Taschenrechner t = new Taschenrechner();
            //int ergebnis = Taschenrechner.Addieren(12, 12);
            //Console.WriteLine(Taschenrechner.PI);

            //int zahl1 = 5;
            //zahl1 = 10;

            ////GEHEIMZAHL = 12;
            ////NURAUSLESEN = 12345; 
            #endregion

            SuperMegaGroßeKlasse abc = new SuperMegaGroßeKlasse();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

    // static class:
    // 1) es dürfen NUR static member in der Klasse sein
    // 2) es kann keine Instanz der Klasse erstellt werden
    //static class Taschenrechner
    //{
    //    // static Konstruktor: Wird aufgerufen, wenn das erste mal im Programm ein Feature der Klasse genutzt wird
    //    static Taschenrechner()
    //    {
    //        PI = 3.14;
    //    }

    //    // static member: property/feld/methode ...
    //    public readonly static int E = 123;
    //    public const double PI = 3.14; // Konstanten sind automatisch static
    //    // static -> Methode ist über die Klasse aufrufbar und -nicht- über eine Instanz der Klasse
    //    public static int Addieren(int z1, int z2)
    //    {
    //        return z1 + z2;
    //    }
    //    public static int Subtrahieren(int z1, int z2)
    //    {
    //        return z1 - z2;
    //    }
    //}
}
