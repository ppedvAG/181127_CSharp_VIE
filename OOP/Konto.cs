using System;

namespace OOP
{

    // abstract
    // -> Bedeutet: Kann nicht instanziiert werden
    // -> abstract member: Jede Klasse, die von der abstrakten Klasse erbt, muss alle Member (= Properties und Methoden) einbauen
    public abstract class Konto
    {
        public Konto()
        {
            Console.WriteLine("Kontokonstruktor");
        }

        public string Inhaber { get; set; }
        public decimal Kontostand { get; set; }

        public virtual void Einzahlen(decimal Betrag)
        {
            if (Betrag > 0)
                Kontostand += Betrag;
            else
                throw new ArgumentException("Sie können nur einen positiven Betrag einzahlen !");
        }

        public virtual void Abheben(decimal Betrag)
        {
            if (Betrag > 0)
                Kontostand -= Betrag;
            else
                throw new ArgumentException("Sie können nur einen positiven Betrag abheben !");
        }

        // public abstract void PINÄndern();
    }

}
