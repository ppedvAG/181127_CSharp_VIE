using System;

namespace OOP
{
    public class JugendKonto : Konto
    {
        public override void Abheben(decimal Betrag)
        {
            if (Betrag > 50)
                throw new ArgumentException("Sie dürfen nicht mehr als 50€ auf einmal abheben.");

            if (Kontostand - Betrag < 0)
                throw new ArgumentException("Sie dürfen nicht mehr abheben als Sie besitzen");

            base.Abheben(Betrag);
        }
    }

}
