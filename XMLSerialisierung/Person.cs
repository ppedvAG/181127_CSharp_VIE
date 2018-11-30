using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialisierung
{
    [Serializable] // <---- NUR für BinaryFormatter notwending, bei XML nicht notwendig
    public class Person
    {
        [XmlElement("VornameDerPerson")]
        public string Vorname { get; set; }
        [XmlElement("Lalalala")]
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        [XmlIgnore]
        public decimal Kontostand { get; set; }
    }
}
