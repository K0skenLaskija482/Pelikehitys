namespace Pk_tehtava1
{
    internal class Program
    {
        // Enum oven tilalle ja pelaajan toiminnoille
        enum OvenTila
        {
            Auki,
            Kiinni,
            Lukossa
        }

        enum Toiminto
        {
            Avaa = 0,
            Lukitse = 1,
            AvaaLukko = 2,
            Sulje = 3
        }

        static void Main(string[] args)
        {
            // Oven alkutila
            OvenTila tila = OvenTila.Auki;

            string[] toiminnot = Enum.GetNames<Toiminto>();

            // Pääsilmukka
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Ovi on {tila}.");
                Console.WriteLine("Valitse toiminto:");

                // Tulosta valikko
                for (int i = 0; i < toiminnot.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {toiminnot[i]}");
                }

                // Lue vastaus
                string vastaus = Console.ReadLine();

                bool valintaOk = false;
                Toiminto valittu = Toiminto.Avaa;

                // Tarkista valinta
                for (int i = 0; i < toiminnot.Length; i++)
                {
                    if (toiminnot[i].ToLower() == vastaus.ToLower() ||
                        (i + 1).ToString() == vastaus)
                    {
                        valittu = (Toiminto)i;
                        valintaOk = true;
                        break;
                    }
                }

                if (!valintaOk)
                {
                    Console.WriteLine("Epäkelpo valinta!");
                    continue;
                }

                // Tilasiirtymät

                // AUKI -> SULJE
                if (tila == OvenTila.Auki && valittu == Toiminto.Sulje)
                {
                    tila = OvenTila.Kiinni;
                }
                // KIINNI -> AVAA
                else if (tila == OvenTila.Kiinni && valittu == Toiminto.Avaa)
                {
                    tila = OvenTila.Auki;
                }
                // KIINNI -> LUKOSSA
                else if (tila == OvenTila.Kiinni && valittu == Toiminto.Lukitse)
                {
                    tila = OvenTila.Lukossa;
                }
                // LUKOSSA -> KIINNI
                else if (tila == OvenTila.Lukossa && valittu == Toiminto.AvaaLukko)
                {
                    tila = OvenTila.Kiinni;
                }
                else
                {
                    Console.WriteLine("Tätä toimintoa ei voi tehdä nykyisessä tilassa!");
                }
            }
        }
    }
}
