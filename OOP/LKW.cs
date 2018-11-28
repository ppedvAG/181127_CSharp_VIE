using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class LKW : Fahrzeug        // LKW erbt von Fahrzeug
    {
        public LKW()
        {
            // eigener LKW-Konstruktor, ruft aber Konstruktor der Basisklasse (=Fahrzeug) auf !
            // Hier muss nur noch das gemacht werden, was beim LKW neu ist
            Höhe = 320; // cm
            MaximalesLadegewicht = 10000; //kg
        }

        // base: Ruft den gewünschten Konstruktor der Basisklasse auf
        // this: Ruft den gewünschten Konstruktor aus der eigenen Klasse auf
        public LKW(int Höhe) : base("NeuerLKW",99,99)
        {
            this.Höhe = Höhe;
        }

        public int Höhe { get; set; }
        public int MaximalesLadegewicht { get; set; }
    }
}
