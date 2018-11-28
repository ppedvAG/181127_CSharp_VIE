using System;

namespace OOP
{
    class Grafik
    {
        public Grafik(string farbe)
        {
            Farbe = farbe;
        }
        public string Farbe { get; set; }

        public virtual void Zeichnen() // virtual ermöglicht das Überschreiben der Methode
        {
            Console.WriteLine($"Eine Grafik mit der Farbe {Farbe} wird gezeichnet");
        }
    }


}
