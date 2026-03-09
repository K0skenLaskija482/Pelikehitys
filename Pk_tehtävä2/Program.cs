namespace Pk_tehtävä2
{
    internal class Program
    {
        enum PaaRaakaAine
        {
            Nautaa = 1,
            Kanaa = 2,
            Kasviksia = 3
        }

        enum Lisuke
        {
            Perunaa = 1,
            Riisia = 2,
            Pastaa = 3
        }

        enum Kastike
        {
            Curry = 1,
            Hapanimela = 2,
            Pippuri = 3,
            Chili = 4
        }

        class Ateria
        {
            public PaaRaakaAine paa;
            public Lisuke lisuke;
            public Kastike kastike;
        }

        internal class MainProgram
        {
            static void Main(string[] args)
            {
                Ateria ateria = new Ateria();

                Console.WriteLine("Valitse pääraaka-aine:");
                Console.WriteLine("1. Nautaa");
                Console.WriteLine("2. Kanaa");
                Console.WriteLine("3. Kasviksia");
                int paaValinta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nValitse lisuke:");
                Console.WriteLine("1. Perunaa");
                Console.WriteLine("2. Riisiä");
                Console.WriteLine("3. Pastaa");
                int lisukeValinta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nValitse kastike:");
                Console.WriteLine("1. Curry");
                Console.WriteLine("2. Hapanimelä");
                Console.WriteLine("3. Pippuri");
                Console.WriteLine("4. Chili");
                int kastikeValinta = Convert.ToInt32(Console.ReadLine());

                // Tallennetaan valinnat
                ateria.paa = (PaaRaakaAine)paaValinta;
                ateria.lisuke = (Lisuke)lisukeValinta;
                ateria.kastike = (Kastike)kastikeValinta;

                // Tulostus
                Console.WriteLine("\nValitsemasi annos:");
                Console.WriteLine(
                    ateria.paa.ToString().ToLower() +
                    " ja " +
                    ateria.lisuke.ToString().ToLower() +
                    " " +
                    ateria.kastike.ToString().ToLower() +
                    "-kastikkeella"
                );

                Console.ReadKey();
            }
        }
    }

}