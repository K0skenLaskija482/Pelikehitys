namespace PK_tehtävä3
{
    enum Karki
    {
        puu,
        teras,
        timantti
    }

    enum Sulat
    {
        lehti,
        kanansulka,
        kotkansulka
    }
    class Nuoli 
        {

        public Karki Karkityyppi
        {
            get;
            set;
        }

        public Sulat Sulkatyyppi
        {
            get;
            set;
        }

        public int Pituus
        {
            get;
            set;
        }

        public double PalautaHinta()
            {
                double hinta = 0;

                if (Karkityyppi == Karki.puu)
                    hinta += 3;
                else if (Karkityyppi == Karki.teras)
                    hinta += 5;
                else if (Karkityyppi == Karki.timantti)
                    hinta += 50;

                if (Sulkatyyppi == Sulat.lehti)
                    hinta += 0;
                else if (Sulkatyyppi == Sulat.kanansulka)
                    hinta += 1;
                else if (Sulkatyyppi == Sulat.kotkansulka)
                    hinta += 5;

                hinta += Pituus * 0.05;

                return hinta;
            }
        }
    
}
