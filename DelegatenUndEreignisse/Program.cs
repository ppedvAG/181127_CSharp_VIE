using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEreignisse
{
    class Program
    {
        // Delegat-Typ - Methodensignatur
        public delegate void MeinDelegat(); // -> Gilt für Methoden die "void" sind und keine Parameter haben
        static void Main(string[] args)
        {
            #region Delegaten
            ////A();
            ////B();
            ////C(12);

            ////MeinDelegat del = new MeinDelegat(A);
            ////del += B;
            ////del += C;

            //// typeof(Program).GetMethods()

            //// del.Invoke();

            //// Action<T> -> void     (sub)
            //// Func<T>   -> rückgabe (funktionen)


            //// Action a = new Action(A);
            //Action a = A;
            //Action<int> fürC = C; // Action void mit int als Parameter

            //a.Invoke();
            //fürC.Invoke(12345);

            //// Func<T> -> gibt immer einen Wert zurück
            //Func<int, int, int> rechenart = Add;
            //int ergebnis = rechenart.Invoke(12, 5);
            //Console.WriteLine(ergebnis); 
            #endregion

            Button b = new Button();
            b.KlickEvent += MeinButtonKlick;
            b.KlickEvent += Logger;

            b.Klick();

            // b.KlickEvent = null;            // absolut verboten !!!

            b.Klick();
            b.Klick();

            b.KlickEvent -= Logger;

            b.Klick();
            b.Klick();

            // b.KlickEvent.Invoke();      // verboten

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static void Logger()
        {
            Console.WriteLine($"[{DateTime.Now}] Button wurde geklickt");
        }

        private static void MeinButtonKlick()
        {
            Console.WriteLine("*klick*");
            Console.Beep();
        }

        public static void A()
        {
            Console.WriteLine("A");
        }
        public static void B()
        {
            Console.WriteLine("B");
        }
        public static void C(int zahl)
        {
            Console.WriteLine("C");
        }

        public static int Add(int z1,int z2)
        {
            return z1 + z2;
        }
    }
}
