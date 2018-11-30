using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class GanzerSatz
    {
        public string Satz { get; set; }

        // indexer + TAB + TAB

        public string this[int index]
        {
            get
            {
                string[] teile = Satz.Split(); // automatisch nach leerzeichen
                return teile[index];
            }
            set
            {
                string[] teile = Satz.Split();
                teile[index] = value;
                Satz = string.Join(" ", teile);
            }
        }
    }
}
