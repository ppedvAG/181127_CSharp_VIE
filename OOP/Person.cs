using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Gültigkeitsspezifizierer

    // public           -> Überall sichtbar und zugreifbar
    // private          -> Nur innerhalb der eigenen Klasse sichtbar und zugreifbar
    // protected        -> Nur innerhalb der eigenen Klasse und allen Klassen, die davon erben, sichtbar und zugreifbar

    // internal         -> Innerhalb der eigenen Assembly wie "public", ausserhalb wie "private"
    // internal protected -> kombi aus protected und internal
    // private protected -> protected, das nur in der eigenen Assembly gilt (ausserhalb wie "private")

    // Member in der Klasse (z.B. Variablen und Methoden): Standardfall "private"
    // Klasse/Struct/Interface: Standardfall "internal"

    class Person
    {
        // Variable -> Feld (muss immer private sein)

        //public string vorname;
        //public string nachname;


        // Autoproperty
        // prop + TAB + TAB
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        private byte alter;
        public byte Alter
        {
            get // Lesezugriff
            {
                return alter;
            }
            set // Schreibzugriff
            {
                if (value > 0 && value <= 130)
                    alter = value;
                else
                    Console.WriteLine("Ungültige Eingabe für Alter");
            }
        }

        // propfull + TAB + TAB
        private decimal kontostand;
        public decimal Kontostand
        {
            get { return kontostand; }
            set { kontostand = value; }
        }



        // ReadOnly-Property

        private string vorname;
        private string nachname;
        public string GanzerName // hat nur einen get; - Block
        {
            get
            {
                return vorname + " " + nachname;
            }
        }

        // Mini-Übung:
        // Klasse Fahrzeug:
        // string kennzeichen
        // int geschwindigkeit (0 - 300)
        // int kilometerstand (nur auslesbar, setter privat)
        // public void Fahren(int Stunden)
        //  ---> Methode erhöht den Kilometerstand um die gefahrene Strecke 


        //public void AlterSetzen(byte neuesAlter)
        //{
        //    if (neuesAlter > 0 && neuesAlter <= 130)
        //        alter = neuesAlter;
        //    else
        //        Console.WriteLine("Ungültige Eingabe für Alter");
        //}
        //public byte AlterAuslesen()
        //{
        //    return alter;
        //}
    }
}
