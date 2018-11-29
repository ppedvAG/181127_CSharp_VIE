namespace Schnittstellen
{
    class Obst : IProdukt
    {
        public Obst() { }
        public Obst(string name, string herkunft, decimal preis, int kcal)
        {
            Name = name;
            Herkunft = herkunft;
            Preis = preis;
            Kcal = kcal;
        }

        public string Name { get; set; }
        public string Herkunft { get; set; }
        public decimal Preis { get; set; }
        public int Kcal { get; set; }

        public int Addieren(int z1, int z2)
        {
            throw new System.NotImplementedException();
        } 
        public void Demo()
        {
            throw new System.NotImplementedException();
        }
    }

}
