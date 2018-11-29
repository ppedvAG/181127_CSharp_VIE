using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEreignisse
{
    class Button
    {
        // Variante "Lang"
        //private Action KlickLogik;
        //public event Action KlickEvent
        //{
        //    add
        //    {
        //        KlickLogik += value;
        //    }
        //    remove
        //    {
        //        KlickLogik -= value;
        //    }
        //}

        // "AutoProperty" für Events
        public event Action KlickEvent;

        public void Klick()
        {
            if (KlickEvent != null)
                KlickEvent.Invoke();
        }
    }
}
