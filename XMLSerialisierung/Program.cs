using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personenListe = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=4000},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=-5000},
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=600000},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=70,Kontostand=-777700},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=100000},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=90,Kontostand=-100000},
                new Person{Vorname="Bill",Nachname="Dung",Alter=100,Kontostand=0},
            };


            // Konstruktor: Datentyp für das Root-Element
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            FileStream stream = new FileStream("personenListe.xml", FileMode.Create);
            serializer.Serialize(stream, personenListe);
            stream.Close();

            // Limitierungen:
            // 1) ALLES muss public sein
            // 2) Wenn es Properties gibt, dann MÜSSEN get; und set; vorhanden sein
            // 3) Es muss ein parameterloser Konstruktor vorhanden sein

            // Variante Binär:
            BinaryFormatter binary = new BinaryFormatter();
            FileStream str = new FileStream("personenliste.bin", FileMode.Create);
            binary.Serialize(str, personenListe);
            str.Close();

            // Deserialisierung
            str = new FileStream("personenliste.bin", FileMode.Open);
            object deserialisiert = binary.Deserialize(str);
            str.Close();

            // Prozess ist in XML identisch !!!

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
