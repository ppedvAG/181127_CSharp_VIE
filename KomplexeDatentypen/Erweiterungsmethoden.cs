using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    // 1) Erweriterungsmethoden benötigen eine statische Klasse
    static class Erweiterungsmethoden
    {
        // 2) this - Schlüsselwort beim Parameter
        public static int Verdoppeln(this int wert)
        {
            return wert * 2;
        }
    }
}
