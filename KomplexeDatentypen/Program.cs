using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] alleZahlen = new int[10];
            //int[,] schachbrett = new int[8, 8]; // Mehrdimensional 
            #endregion

            #region System.Collections - ALT !!!
            //// ArrayList
            //ArrayList list = new ArrayList();
            //list.Add(12);
            //list.Add(1.5);
            //list.Add("Hallo Welt");
            //// alle datentypen erlaubt, da object

            //// Problem 1: Typensicherheit
            //int ergebnis = 5 + (int)list[0];
            //// Problem 2: Boxing: Performanceverlust beim Speichern und Auslesen von Wertetypen in einem Object(Array/List/usw,..)

            //// HashTable
            //Hashtable table = new Hashtable();
            //table.Add("Preis", 500);
            //table.Add("Lagerkosten", 500_000);
            //table.Add(12345, 500_000);
            //table.Add(new StringBuilder(), 500_000);

            //if (table.ContainsKey("abcde"))
            //    Console.WriteLine("abcde gibts bereits");

            //// table.Add("Lagerkosten", 500_000);

            //// Key muss eindeutig sein !

            //Console.WriteLine(table["Preis"]); 
            #endregion

            #region Generische Klasse nutzen
            //Demo<string> stringDemo = new Demo<string>();

            //stringDemo.MeineVariable = 55;
            //stringDemo.MachEtwas();

            //Demo<Double> doubleDemo = new Demo<double>();
            //doubleDemo.MachEtwas() 
            #endregion

            #region List<T>
            //List<int> zahlenListe = new List<int>(); // List(of Integer) in VB.NET
            //List<string> stringListe = new List<string>();

            //zahlenListe.Add(1234);
            //stringListe.Add("Demo"); 
            #endregion

            #region Dictionary<TKey,TValue>
            //Dictionary<string, string> länder = new Dictionary<string, string>();
            //länder.Add("Österreich", "Wien");
            //länder.Add("Deutschland", "Berlin");
            //länder.Add("Italien", "Rom");
            //länder.Add("Frankreich", "Paris");
            //länder.Add("Ungarn", "Budapest"); 
            #endregion

            #region Stack LIFO -> Last in, First out
            //Stack<int> zahlenStapel = new Stack<int>();
            //zahlenStapel.Push(12);
            //zahlenStapel.Push(3);
            //zahlenStapel.Push(9);

            //Console.WriteLine(zahlenStapel.Pop());
            //Console.WriteLine(zahlenStapel.Pop());
            //Console.WriteLine(zahlenStapel.Pop()); 
            #endregion

            #region Queue FIFO -> First in, First out
            //Queue<string> wortReihe = new Queue<string>();
            //wortReihe.Enqueue("Hallo");
            //wortReihe.Enqueue("Welt");
            //wortReihe.Enqueue("!");

            //Console.WriteLine(wortReihe.Dequeue());
            //Console.WriteLine(wortReihe.Dequeue());
            //Console.WriteLine(wortReihe.Dequeue()); 
            #endregion

            #region SortedList<TKey,TValue>
            //SortedList<int, string> wichtigeWörter = new SortedList<int, string>();

            //wichtigeWörter.Add(5, "demo");
            //wichtigeWörter.Add(60, "abcde");
            //wichtigeWörter.Add(1, "keine");
            //wichtigeWörter.Add(30, "ohne");

            //Console.WriteLine(wichtigeWörter.ElementAt(0));
            //Console.WriteLine(wichtigeWörter[30]);
            //Console.WriteLine("----");

            //foreach (var item in wichtigeWörter.Values)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Erweiterungsmethoden
            //List<int> zahlen = new List<int>() { 12, 5, 8, 3, 5, 0, 9, 77 };

            //string text = "Hallo Welt !";
            //int zahl1 = 5;

            //int erg = Erweiterungsmethoden.Verdoppeln(zahl1);
            //int erg2 = zahl1.Verdoppeln(); 
            #endregion

            #region Indexer
            //List<string> meineListe = new List<string> { "Hallo", "Welt", "!" };
            //Console.WriteLine(meineListe[0]);

            //GanzerSatz g = new GanzerSatz();
            //g.Satz = "Das ist mein Satz !";
            //Console.WriteLine(g[0]);

            //g[2] = "kein"; 
            // Console.WriteLine(g.Satz);
            #endregion

            #region Eigene Liste
            // Übung:

            // Eure eigene Liste nachbauen
            // class MeineListe mit interner string[] data...

            // Features:
            // Kontstruktor: 100 Elemente kapazität
            // void Add()    ...
            // void Remove() ...
            // indexer -> gibt das Element aus der Position X zurück  (zb meineListe[0])
            // indexer2 -> schreibt das ELement in die Liste rein (zb meineListe[123] = "neuesElement")


            //MeineListe<string> l = new MeineListe<string>();
            //l.Add("Hallo");
            //l.Add("Welt");
            //l.Add("!");

            //l.Remove();
            //l.Add("!!!");

            //l.Remove(1); // Welt

            //l.Add("lalalal");
            //Console.WriteLine(l[1]);

            //l[55] = "asd" ;

            //try
            //{
            //    l[100] = "asd";
            //    l[200] = "asd";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Lambda - Ausdrücke
            //// Action a = Button_Click;

            //// Anonyme Methode
            ////Action a = () => Console.WriteLine("Mach Was");
            ////Action a2 = () =>
            ////{
            ////    Console.WriteLine("Mach Was");
            ////    Console.WriteLine("Mach Was");
            ////    Console.WriteLine("Mach Was");
            ////}; 
            #endregion

            // LINQ - Language INntegrated Queries
            List<Person> personenListe = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=4000},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=-5000},
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=600000},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=70,Kontostand=-777700},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=100000},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=90,Kontostand=-100000},
                new Person{Vorname="Bill",Nachname="Dung",Alter=100,Kontostand=0},
            };

            // Aufgabe: 
            // Erstelle eine Liste mit allen Vornamen
            // Variante Liste:

            //List<string> alleVornamen = new List<string>();
            //foreach (var item in personenListe)
            //{
            //    alleVornamen.Add(item.Vorname);
            //}

            // Aufgabe 2: Liste mit allen VOrnamen von Personen, die einen negativen Kontostand haben
            //List<string> alleVornamenMitNegativemKontostand = new List<string>();
            //foreach (var item in personenListe)
            //{
            //    if(item.Kontostand < 0)
            //        alleVornamenMitNegativemKontostand.Add(item.Vorname);
            //}

            // Aufgabe 3 : Liste mit allen VOrnamen von Personen, die einen negativen Kontostand haben -> nach Alter sortiert

            //------------------

            // SELECT -> Gib für jedes Element X den Wert Y zurück

            // List<string> alleVornamen = personenListe.Select(PersonZuVornamenSelektor).ToList();
            List<string> alleVornamen = personenListe.Select(x => x.Vorname).ToList();
            decimal[] alleKontostände = personenListe.Select(x => x.Kontostand).ToArray();

            // durchschnittliche kontostand von allen personen ?
            // SUM, AVARAGE, MIN, MAX
            decimal durchschnitt = personenListe.Select(x => x.Kontostand).Average();
            decimal durchschnitt2 = personenListe.Average(x => x.Kontostand);

            // WHERE
            var list = personenListe.Where(x => x.Kontostand < 0)
                                    .Select(x => x.Vorname)
                                    .ToList();

            // ORDERBY , ORDERBYDESCENDING

            var konten = personenListe.Where(x => x.Kontostand > 0)
                                      .OrderBy(x => x.Alter)
                                      .ToArray();

            // Ausgabe: ToList(), ToArray()
            // FIRST, LAST
            Person steinreich = personenListe.OrderByDescending(x => x.Kontostand)
                                             .First();

            
            // Übung:


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static string PersonZuVornamenSelektor(Person p) => p.Vorname;
        //{
        //    return p.Vorname;
        //}

        public int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        public int Sub(int z1, int z2) => z1 - z2;
        public int Mul(int z1, int z2) => z1 * z2;
        public int Div(int z1, int z2) => z1 / z2;

        private int myVar;
        public int MyProperty
        {
            get => myVar;
            set => myVar = value;
        }

    }

    // Generics selber schreiben
    // class Demo<T>
    // {
    //     public T MeineVariable { get; set; }
    //     public T MachEtwas()
    //     {
    //         return MeineVariable;
    //     }
    // }

}
