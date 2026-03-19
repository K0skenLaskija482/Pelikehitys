namespace Pk_tehtävä4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reppu reppu = new Reppu(20, 30, 10);
            while (true)
            {
                Tavara t;

                Console.WriteLine($"Repussa on tällä hetkellä {reppu.NykyinenMaara}/{reppu.Maara} tavaraa, {reppu.NykyinenPaino}/{reppu.MaxPaino} painoa, ja {reppu.NykyinenTilavuus}/{reppu.MaxTilavuus} tilavuus");
                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1. Nuoli");
                Console.WriteLine("2. Jousi");
                Console.WriteLine("3. Köysi");
                Console.WriteLine("4. Vettä");
                Console.WriteLine("5. Ruokaa");
                Console.WriteLine("6. Miekka");
                Console.WriteLine("7. Lopeta");
                string tavara = Console.ReadLine();

                switch (tavara)
                {
                    case "1": t = new Nuoli(); reppu.Lisaa(t); break; 
                    case "2": t = new Jousi(); reppu.Lisaa(t); break;
                    case "3": t = new Koysi(); reppu.Lisaa(t); break;
                    case "4": t = new Vesi(); reppu.Lisaa(t); break;
                    case "5": t = new Ruoka(); reppu.Lisaa(t); break;
                    case "6": t = new Miekka(); reppu.Lisaa(t); break;
                    case "7": return;
                    default:
                        break;
                }
                
            }
        }
    }
}
