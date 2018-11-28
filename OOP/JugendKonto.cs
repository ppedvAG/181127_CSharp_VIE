using System;

namespace OOP
{
    // sealed -> Verhindert, das andere Klassen von dieser Klasse erben können
    public sealed class JugendKonto : Konto
    {
        // sealed override -> Verhindert ein erneutes Überschreiben
        public sealed override void Abheben(decimal Betrag)
        {
            if (Betrag > 50)
                throw new ArgumentException("Sie dürfen nicht mehr als 50€ auf einmal abheben.");

            if (Kontostand - Betrag < 0)
                throw new ArgumentException("Sie dürfen nicht mehr abheben als Sie besitzen");

            base.Abheben(Betrag);
        }

    }

    //public class NeugeborenesKonto : JugendKonto
    //{

    //}

}
