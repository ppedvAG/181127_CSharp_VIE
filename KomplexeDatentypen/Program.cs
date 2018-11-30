using System;
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
            #endregion

            Console.WriteLine(g.Satz);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
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
