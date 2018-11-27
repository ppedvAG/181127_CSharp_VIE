using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {

        enum Wochentage
        {
            Montag,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag,
            Samstag,
            Sonntag
        }

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

            #region Operatoren
            // Arithmetische Operatoren
            // +,-,*,/,%    +=, -=,*=, /= , ++, --

            //int zahl1 = 5;
            //zahl1 = zahl1 + 1;
            //zahl1 += 5;

            //zahl1++; // increment 1
            //zahl1--; // decrement 1

            //// pre-increment    ++zahl1;
            //// post-increment   zahl++;

            //int eingabe = 10;

            //int ausgabe = eingabe++; // Postincrement
            //Console.WriteLine(eingabe);
            //Console.WriteLine(ausgabe);

            //eingabe = 10;
            //ausgabe = ++eingabe; // Preincrement
            //Console.WriteLine(eingabe);
            //Console.WriteLine(ausgabe);

            //eingabe = 50;
            //int zahlX = eingabe++ + ++eingabe; // Ratespiel ;)
            //Console.WriteLine(zahlX);


            // BitOperatoren
            // | -> OR
            // & -> AND
            // ~ -> Invertieren
            // ^ -> XOR

            //int zahl1 = 4; // 0100
            //int zahl2 = 2; // 0010

            //int ergebnis = zahl1 & zahl2; // 0110

            //// C# 7
            //int binär = 0b_0000_1111;
            //int hex = 0x_FF00FF;

            //int zehnmillionen = 10000000;
            //int zehnmillionen2 = 10_000_000;
            //int hundertdreiundzwanzig = 1________2_________________________3;
            //Console.WriteLine(hundertdreiundzwanzig);


            //short zahl1 = short.MaxValue;
            //Console.WriteLine(zahl1);

            //checked // Prüft auf Überläufe
            //{
            //    zahl1 += 1;
            //}
            //Console.WriteLine(zahl1);

            // Vergleichsoperatoren
            // <,>,<=,>=,==,!=, !

            // Veknüpfungsoperatoren
            // |, &, ||, &&, ^ (XOR) 
            #endregion

            #region IF und Switch
            //// If
            //int zahl1 = 7;

            ////if (zahl1 > 5)
            ////{
            ////    Console.WriteLine("größer");
            ////}
            ////else if(zahl1 == 5)
            ////    Console.WriteLine("exakt 5");
            ////else
            ////{
            ////    Console.WriteLine("kleiner");
            ////}

            //if (zahl1 == 1)
            //    ;
            //else if (zahl1 == 2)
            //    if (true)
            //        ;
            //    else
            //        ;
            //else if (zahl1 == 3)
            //    ;
            //else if (zahl1 == 4)
            //    ;
            //else if (zahl1 == 5)
            //    ;

            //switch (zahl1)
            //{
            //    case 1:
            //        ;
            //        break;
            //    case 2:
            //        ;
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        ;
            //        break;
            //    default:
            //        ;
            //        break;
            //} 
            #endregion

            #region Enum und Switch
            //Wochentage heute = Wochentage.Dienstag;
            //// Switch + TAB + TAB  ... variable eingeben + ENTER
            //switch (heute)
            //{
            //    case Wochentage.Montag:
            //        break;
            //    case Wochentage.Dienstag:
            //        break;
            //    case Wochentage.Mittwoch:
            //        break;
            //    case Wochentage.Donnerstag:
            //        break;
            //    case Wochentage.Freitag:
            //        break;
            //    case Wochentage.Samstag:
            //        break;
            //    case Wochentage.Sonntag:
            //        break;
            //    default:
            //        break;
            //} 
            #endregion

            #region Schleifen
            //// Zählergesteuert:
            //// for(initialisierung;bedingung;aktualisierung)
            //for (int zähler = 0; zähler < 20; zähler++)
            //{
            //    Console.WriteLine(zähler);

            //    // continue // -> springe zum nächsten durchgang
            //    // break    // -> beendet die schleife
            //}

            //// Bedingungsgesteuert:
            //// while(bedinung)

            //// Kopfgesteuert
            //int z = 0;
            //while(z < 10) // while(true) <- "Endlosschleife"
            //{
            //    Console.WriteLine(z);
            //    z++;
            //}
            //// Fußgesteuert
            //do
            //{

            //} while (z < 100);

            //// foreach -> siehe "Arrays/List<T>" 
            #endregion

            #region Tenäre Operator
            ////string text;
            ////int zahl1 = 5;

            ////if (zahl1 > 10)
            ////    text = "größer als 10";
            ////else
            ////    text = "kleiner als 10";

            //int zahl1 = 5;
            ////          = (Bedingung) ? TRUE : FALSE;
            //string text = (zahl1 > 10) ? "größer" : "kleiner"; 
            #endregion

            #region Null Coalescing Operator
            //// ?? 

            //// .NET 2.0 Nullable-ValueTypes
            //int? alter = null;
            //int meineZahl = 10;

            //// alter = meineZahl; // kein problem
            //// meineZahl = alter; // problem, da null ungültig für Int32

            ////if (alter == null)
            ////    meineZahl = 0;
            ////else
            ////    meineZahl = Convert.ToInt32(alter);

            ////                ?? Alternative, falls der wert "null" ist
            //meineZahl = alter ?? 0; 
            #endregion

            #region Unterschiede: Referenztypen und Wertetypen
            //int zahl1 = 5;
            //int zahl2 = 5;

            //if(zahl1 == zahl2) // Wertevergleich
            //    Console.WriteLine("Gleich");
            //else
            //    Console.WriteLine("Ungleich");

            //int zahl3 = zahl2; // Wertekopie

            //if (zahl3 == zahl2) // Wertevergleich
            //    Console.WriteLine("Gleich");
            //else
            //    Console.WriteLine("Ungleich");

            //Console.WriteLine("------------");

            //object o1 = 5;
            //object o2 = 5;

            //if (o1 == o2) // Referenzvergleich
            //    Console.WriteLine("Gleich");
            //else
            //    Console.WriteLine("Ungleich");

            //object o3 = o2; // Referenzkopie

            //if (o3 == o2) // Referenzvergleich
            //    Console.WriteLine("Gleich");
            //else
            //    Console.WriteLine("Ungleich");

            //// Wertevergleich bei Referenzen
            //if (o1.Equals(o2)) // Wertevergleich
            //    Console.WriteLine("Gleich");
            //else
            //    Console.WriteLine("Ungleich"); 
            #endregion

            #region Arrays
            //int zahl = 12;
            //int[] zahlen = new int[10]; // 10 Stück -> 0...9
            //zahlen[0] = 12;
            //zahlen[1] = 7; // ...
            //Console.WriteLine(zahlen[0]);

            //// Alternative Schreibweisen: (Compiler-Magie)
            //int[] zahlen2 = new int[] { 12, 6, 3, 6, 8, 9 };
            //int[] zahlen3 = { 12, 6, 3, 6, 8, 9 }; 
            #endregion

            #region Methoden und Parameter
            ////MachEtwas();
            ////MachEtwas();
            ////MachEtwas();
            ////MachEtwas();
            ////MachEtwas();

            ////int zahl1 = Verdoppeln(5);
            ////int zahl2 = Verdoppeln(50);
            ////int zahl3 = Verdoppeln(500);

            //// Übergabe per ref bei wertetypen
            //int zahl1 = 5;
            //VerdoppelDieReferenz(ref zahl1);
            //Console.WriteLine(zahl1);

            //Addieren(5, 10);
            //Addieren(5, 10, 15);
            //Addieren(5, 5, 5, 5, 5, 5, 5, 5, 5);
            //Addieren(5, 5, 5, 5, 5, 5, 5);
            //Addieren(5, 5, 5, 5, 5, 5, 5,9,9,9,9,9,9,9,9,9);
            //Demo("hallo Welt", 12);
            //Demo(new int[] { 12, 4, 6, 7 }, 12,12.5);

            //OptionalDemo();
            //OptionalDemo(12);

            //bool sinnDesLebens = false;
            //int wert = BerechneEtwas(out sinnDesLebens); 
            #endregion

            //Exceptions

            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            string eingabe = Console.ReadLine();
            int zahl1;

            try
            {
                zahl1 = Convert.ToInt32(eingabe);
            }
            catch(FormatException)
            {
                Console.WriteLine("Bitte nur ganze Zahlen eingeben");
                Console.ReadKey();
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Zahl war zu groß oder zu klein");
                Console.ReadKey();
                return;
            }
            catch (Exception ex) // Exception = "Alles abfangen"
            {
                Console.WriteLine("Es gab einen Fehler ...");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return; // Programm beenden
            }
            finally
            {
                Console.WriteLine("Finally !!!");
                Console.ReadKey();
            }

            //try + TAB +TAB

            //try
            //{
            //}
            //catch (Exception)
            //{
            //    throw; // wirft den originalen fehler weiter
            //}
            //finally
            //{
            //    // wird IMMER ausgeführt, egal ob es eine Exception gibt oder nicht
            //}

            Console.WriteLine($"Das Doppelte von deiner Zahl ist: {zahl1*2}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }


        // Methodensignatur:
        // gültigkeitsspezifizierer rückgabetyp Name (parametern...)
        // void == "subprozedur"
        // int/etc == "function"

        // Paramter: Standardfall: übergabe per wert
        // ref => übergabe per referenz

        public static void MachEtwas()
        {
            // Logik
            Console.WriteLine("Ich mache etwas .....");
        }

        public static int Verdoppeln(int eingabe)
        {
            return eingabe * 2; // return -> liefert das Ergebnis zurück
        }

        public static void VerdoppelDieReferenz(ref int eingabe)
        {
            eingabe = eingabe * 2;
        }

        // Überladen von Methoden
        public static int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Addieren(int z1, int z2,int z3)
        {
            return z1 + z2 +z3;
        }
        public static int Addieren(int z1, int z2, int z3,int z4)
        {
            return z1 + z2 + z3 + z4;
        }

        // params -> man kann so viele werte angeben, wie man will
        public static int Addieren(params int[] zahlen)
        {
            return zahlen.Sum();
        }

        public static void Demo(params object[]alles)
        {
            // ...
        }

        //Optionale Parameter
        public static void OptionalDemo(int zahl = 5)
        {
            // ....
        }

        // ---------------

        //public static int BerechneEtwas(ref bool sinnDesLebensGefunden)
        //{
        //    // sinnDesLebensGefunden = true;
        //    return 42;
        //}

        // out: erzwingt eine rückgabe über den parameter
        // unterschied zu ref: bei ref "kann" man etwas zurückgeben bzw neu zuweisen, bei out "MUSS" man es machen
        public static int BerechneEtwas(out bool sinnDesLebensGefunden)
        {
            sinnDesLebensGefunden = true;
            return 42;
        }

        // in: "readonly ref"
        // in -> Referenz, die aber readonly ist und nicht verändert werden kann
        public static void ReadonlyReferenceDemo(in int zahl)
        {
            // zahl = 12; // kann nicht verändert werden im vergleich zu ref
        }
    }
}
