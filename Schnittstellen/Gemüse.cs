using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    class Gemüse : IProdukt
    {
        public string Name { get; set; }
        public decimal Preis { get; set; }

        public int Addieren(int z1, int z2)
        {
            throw new NotImplementedException();
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }
    }
}
