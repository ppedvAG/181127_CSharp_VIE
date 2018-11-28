using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Fahrzeug
    {
        // Konstruktor: Methode ohne Rückgabe (KEIN VOID o.Ä) + Name der Klasse
        // ctor + TAB + TAB
        //public Fahrzeug()
        //{
        //    Kennzeichen = "XXXXX12345";
        //    Kilometerstand = 100_000;
        //    Geschwindigkeit = 10;
        //}

        //public Fahrzeug(string Kennzeichen)
        //{   // this = selbstverweis
        //    this.Kennzeichen = Kennzeichen;
        //}

        // Konstruktor generieren lassen: "QuickActions and Refactoring" -> "Generate Constructor"

        #region Variante1 für mehrere Konstruktoren
        //public Fahrzeug()
        //{
        //    Kennzeichen = "Musterkennzeichen";
        //    Kilometerstand = 100_000;
        //    Geschwindigkeit = 200;
        //}
        //public Fahrzeug(string Kennzeichen)
        //{
        //    this.Kennzeichen = Kennzeichen;
        //    Kilometerstand = 100_000;
        //    Geschwindigkeit = 200;
        //}
        //public Fahrzeug(string Kennzeichen,int Kilometerstand)
        //{
        //    this.Kennzeichen = Kennzeichen;
        //    this.Kilometerstand = Kilometerstand;
        //    Geschwindigkeit = 200;
        //}
        //public Fahrzeug(string Kennzeichen, int Kilometerstand, int Geschwindigkeit)
        //{
        //    this.Kennzeichen = Kennzeichen;
        //    this.Kilometerstand = Kilometerstand;
        //    this.Geschwindigkeit = Geschwindigkeit;
        //}
        #endregion

        #region Variante 2 : Konstruktorverkettung
        public Fahrzeug() : this("abcde") { }
        public Fahrzeug(string Kennzeichen) : this(Kennzeichen, 100_000) { }
        public Fahrzeug(string Kennzeichen, int Kilometerstand) : this(Kennzeichen,Kilometerstand,100){}
        public Fahrzeug(string Kennzeichen, int Kilometerstand, int Geschwindigkeit)
        {
            this.Kennzeichen = Kennzeichen;
            this.Kilometerstand = Kilometerstand;
            this.Geschwindigkeit = Geschwindigkeit;
        }
        #endregion


        // Destruktor
        ~Fahrzeug()
        {
            Console.WriteLine("Ich werde gelöscht");
        }

        public string Kennzeichen { get; set; }
        public int Kilometerstand { get; private set; }
        private int geschwindigkeit;

        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set
            {
                if (value > 0 && value <= 300)
                    geschwindigkeit = value;
                else
                    Console.WriteLine("Geschwindigkeit muss zwischen 0 und 300 sein");
            }
        }

        public void Fahren(int Stunden)
        {
            if (Stunden < 0)
                throw new ArgumentException("Bitte geben Sie nur positive Zahlen für die Stunden ein");

            Kilometerstand += Stunden * Geschwindigkeit;
        }





    }
}
