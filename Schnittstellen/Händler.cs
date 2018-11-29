namespace Schnittstellen
{
    class Händler
    {
        public Händler(){}
        public Händler(IProdukt produkt, int anzahl)
        {
            Produkt = produkt;
            Anzahl = anzahl;
        }
        public IProdukt Produkt { get; set; }
        public int Anzahl { get; set; }
    }

}
