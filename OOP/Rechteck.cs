using System;

namespace OOP
{
    class Rechteck : Grafik
    {
        public Rechteck(int höhe, int breite, string Farbe) : base(Farbe)
        {
            Höhe = höhe;
            Breite = breite;
        }
        public int Höhe { get; set; }
        public int Breite { get; set; }

        // Verstecken
        // new - Schlüsselwort kennzeichnet die Methode für das Verstecken
        // new -> optionales Schlüsselwort
        public void Zeichnen()
        {
            Console.WriteLine($"Ein Rechteck mit der Farbe {Farbe}, der Höhe {Höhe} und der Breite {Breite} wird gezeichnet");
        }

    }


}
