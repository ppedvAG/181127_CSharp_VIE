using System;

namespace OOP
{
    public class Girokonto : Konto
    {
        public override void Abheben(decimal Betrag)
        {
            if (Kontostand - Betrag < -10_000)
                throw new ArgumentException("Sie dürfen Ihren Überziehungsrahmen von -10.000€ nicht überschreiten");

            base.Abheben(Betrag);
        }
    }

}
