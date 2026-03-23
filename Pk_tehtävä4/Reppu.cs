
using System.Security.Cryptography.X509Certificates;

namespace Pk_tehtävä4
{
    internal class Reppu
    {
        public float MaxTilavuus { get; set; }
        public float MaxPaino { get; set; }
        public float Maara { get; set; }
        public float NykyinenPaino
        {
            get
            {
                float paino = 0;
                foreach (var t in tavarat)
                {
                    paino += t.Paino;
                }
                return paino;
            }
        }
        public float NykyinenTilavuus
        {
            get
            {
                float tilavuus = 0;
                foreach (var t in tavarat)
                {
                    tilavuus += t.Tilavuus;
                }
                return tilavuus;
            }
        }
        public int NykyinenMaara
        {
            get
            {
                return tavarat.Count;
            }
        }

        public Reppu(float maxTilavuus, float maxPaino, float maara)
        {
            MaxTilavuus = maxTilavuus;
            MaxPaino = maxPaino;
            Maara = maara;
        }

        List<Tavara> tavarat = new List<Tavara>();

        public bool Lisaa(Tavara tavara)
        {
            if (tavarat.Count >= Maara)
            {
                Console.WriteLine("Reppu on täynnä, et voi lisätä enempää tavaroita.");
                return false;
            }
            if (this.NykyinenPaino + tavara.Paino > MaxPaino)
            {
                Console.WriteLine("Reppu ei kestä tätä painoa, et voi lisätä tätä tavaraa.");
                return false;
            }
            if (this.NykyinenTilavuus + tavara.Tilavuus > MaxTilavuus)
            {
                Console.WriteLine("Reppu ei mahdu tähän tilavuuteen, et voi lisätä tätä tavaraa.");
                return false;
            }
            tavarat.Add(tavara);

            return true;
        }
        public override string ToString()
        {
            if (tavarat.Count == 0)
            {
                return "Reppu on tyhjä.";
            }
            string sisalto = "Repussa on:";
            for (int i = 0; i < tavarat.Count; i++)
            {
                sisalto += tavarat[i].ToString();
                if (i != tavarat.Count - 1)
                {
                    sisalto += ", ";
                }
            }
            return sisalto;
        }
    }
}
