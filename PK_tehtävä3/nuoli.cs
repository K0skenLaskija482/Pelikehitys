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

    enum Eliitti
    {
        perusNuoli,
        aloittelijaNuoli,
        eliittiNuoli,
        omaValinta
    }
    class Nuoli
    {
        public Nuoli()
        {
            
        }
        public Nuoli(Karki karki, Sulat sulat, int pituus)
        {
            this.Karkityyppi = karki;
            this.Sulkatyyppi = sulat;
            this.Pituus = pituus;
        }
        public Eliitti Eliittivalinta
        {
            get;
            set;
        }
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


        public static Nuoli AloitelijaNuoli()
        {
            return new Nuoli(Karki.puu, Sulat.kanansulka, 70);
        }
        public static Nuoli PerusNuoli()
        {
            return new Nuoli(Karki.teras, Sulat.kanansulka, 85);
        }
        public static Nuoli EliittiNuoli()
        {
            return new Nuoli(Karki.timantti, Sulat.kotkansulka, 100);
        }
    }
}