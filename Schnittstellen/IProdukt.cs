using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    interface IProdukt
    {
        // keine Gültigkeitsspezifizierer wie public/private usw.. !
        string Name { get; set; } // MUSS get; und set; einbauen
        decimal Preis { get; }  // MUSS nur get; einbauen, kann aber bei Bedarf auch set; einbauen

        // Nur Methodensignatur, KEINE Implementierung
        void Demo();
        int Addieren(int z1, int z2);
    }
}
