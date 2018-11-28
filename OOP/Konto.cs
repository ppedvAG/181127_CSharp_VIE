using System;

namespace OOP
{
    public class Konto
    {
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
    }

}
