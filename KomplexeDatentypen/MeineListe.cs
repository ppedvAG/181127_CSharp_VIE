using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class MeineListe<T>
    {
        public MeineListe() : this(100) {}
        public MeineListe(int kapazität)
        {
            data = new T[kapazität];
            position = 0; // erste freie stelle
        }

        private T[] data;
        private int position;

        public void Add(T wert)
        {
            data[position] = wert;
            position++;
        }

        public void Remove() // das letzte element
        {
            position--;
            data[position] = default(T); // Defaultwert für den Datentypen
        }
        public void Remove(int position)
        {
            data[position] = default(T);

            T[] newData = new T[data.Length];
            int j = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] != null)
                {
                    newData[j] = data[i];
                    j++;
                }
            }

            // this.position = j; // j == die nächste freie stelle
            this.position--; // eins zurücksetzen, da ein element entfernt wurde
            data = newData;
        }

        public T this[int index]
        {
            get { return data[index]; }
            set
            {
                if (index > data.Length)
                    throw new IndexOutOfRangeException("Die Liste ist leider zu klein");
                data[index] = value;
                // optional: lücke füllen
            }
        }
    }
}
