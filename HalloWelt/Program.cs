using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        // Einstiegspunkt in das Konsolenprogramm
        static void Main(string[] args)
        {
            #region Hallo Welt
            //Console.WriteLine("Demo 12345");

            //// Snippets: cw + TAB + TAB
            //// STRG + C / V / X gilt für die gesamte Zeile, wenn nichts ausgewählt ist

            //// STRG + K + C   --- Auskommentieren
            //// STRG + K + U   --- Kommentar entfernen
            //Console.WriteLine("Hallo Welt");
            //Console.WriteLine("Hallo Welt");
            //Console.WriteLine("Hallo Welt");
            //Console.WriteLine("Hallo Welt");
            #endregion

            #region Variablen
            //// Datentyp Name;
            //// Datentyp Name = Startwert;

            //int zahl1;          // Deklaration: "Ab diesem Zeitpunkt existiert diese Variable"
            //int zahl2 = 10;     // Initialisierung: "Variable existiert und hat einen Startwert"
            //int z1, z2, z3;     // 3 Integer-Variablen
            //int z4 = 5, z5 = 10, z6 = 20;

            //// Alternative: var - Schlüsselwort
            //var x = 12.5; // var => Compiler entscheidet anhand der Zuweisung, welcher Datentyp es wird

            //zahl1 = 5;
            //zahl2 = 10;
            //int zahl3 = zahl1 + zahl2;
            #endregion

            #region Konvertieren
            //Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            //string eingabe = Console.ReadLine();
            //Console.WriteLine("Ihre Eingabe war: " + eingabe);

            //// Implizite Konvertieren
            //int zahl1 = 5;   // Int32
            //long zahl2 = 10; // Int64

            //zahl2 = zahl1;   // Implizites Konvertieren: Der kleinere Wertebereich passt jederzeit in den größeren Wertebereich hinein
            //double gleitkommazahl = zahl1;

            //zahl2 = 10;     // technisch gesehen gültig für Int32
            //                // zahl1 = gleitkommazahl;

            //// Explizites Konvertieren
            //// Klasse Convert beinhaltet alle wichtigen Konvertierungsfunktionen
            //zahl1 = Convert.ToInt32(zahl2);
            //// Variante 2
            //// zahl1 = Int32.Parse("123");

            //// Mini-Übung:
            //// Konsolenprogramm: 2 Zahlen einlesen
            //// Summe ausgeben 
            #endregion

            #region Zeichenketten
            //string text = "Hallo Welt";
            //string text2 = text + "--- Demo";
            //int zahl1 = 5, zahl2 = 10, ergebnis = 15;

            //// Stringverkettung
            //Console.WriteLine("Die Summe von " + zahl1 + " und " + zahl2 + " ist " + (zahl1 + zahl2));
            //// String.Format
            //Console.WriteLine("Die Summe von {0} und {1} ist {2}",zahl1,zahl2,ergebnis);
            //// C# 6 - String-Interpolation
            //Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist {zahl1 + zahl2}"); 
            #endregion


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
