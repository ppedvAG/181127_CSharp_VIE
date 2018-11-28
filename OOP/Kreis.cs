using System;

namespace OOP
{
    class Kreis : Grafik
    {
        public int Radius { get; set; }

        public Kreis(int radius, string Farbe) : base(Farbe)
        {
            this.Radius = radius;
        }

        // Überschreiben:
        // override -  Schlüsselwort
        // Man kann nur Methoden überschreiben, die vorher als virtual gekennzeichnet sind (oder auch selbst override sind)
        // Mithilfe von "sealed" kann man ein weiteres Überschreiben verhindern
        public override void Zeichnen() // override -> gilt auch gleichezeitig als virtual
        {
            // base.Zeichnen(); // --> Ruft das originale Zeichnen der Basisklasse auf
            Console.WriteLine($"Ein Kreis mit der Farbe {Farbe} und dem Radius {Radius} wird gezeichnet");
        }
    }


}
