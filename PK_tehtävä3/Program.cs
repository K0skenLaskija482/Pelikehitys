using System.Security.Cryptography.X509Certificates;

namespace PK_tehtävä3
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Nuoli nuoli = new Nuoli();

            bool valintaKarki = false;
            while (!valintaKarki)
            {
                Console.WriteLine("Valitse kärki:");
                Console.WriteLine("1. Puu");
                Console.WriteLine("2. Teräs");
                Console.WriteLine("3. Timantti");
                string karkiValinta = Console.ReadLine();

                switch (karkiValinta)
                {
                    case "1": valintaKarki = true; nuoli.Karkityyppi = Karki.puu; break;
                    case "2": valintaKarki = true; nuoli.Karkityyppi = Karki.teras; break;
                    case "3": valintaKarki = true; nuoli.Karkityyppi = Karki.timantti; break;
                    default:
                        break;
                }
            }
            bool valintaSulka = false;
            while (!valintaSulka)
            {
                Console.WriteLine("Valitse sulka:");
                Console.WriteLine("1. Lehti");
                Console.WriteLine("2. Kanan sulka");
                Console.WriteLine("3. Kotkan sulka");
                string sulkaValinta = Console.ReadLine();

                switch (sulkaValinta)
                {
                    case "1": valintaSulka = true; nuoli.Sulkatyyppi = Sulat.lehti; break;
                    case "2": valintaSulka = true; nuoli.Sulkatyyppi = Sulat.kanansulka;  break;
                    case "3": valintaSulka = true; nuoli.Sulkatyyppi = Sulat.kotkansulka; break;
                    default:
                        break;
                }
            }
            bool valintaPitus = false;
            while (!valintaPitus)
            {
                Console.WriteLine("Nuolen pituus sentteinä(60 - 100): ");
                string pitusValinta = Console.ReadLine();
                int pituusout;

                if (int.TryParse(pitusValinta, out pituusout))
                {
                    nuoli.Pituus = pituusout;
                    if (nuoli.Pituus > 59 && nuoli.Pituus < 101)
                    { 
                        valintaPitus = true; 
                    }
                    
                }
            }
            Console.WriteLine($"Hinta on: {nuoli.PalautaHinta()}");
        }
    }
            
}
