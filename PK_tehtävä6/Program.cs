namespace PK_tehtävä6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koordinaatti koordinaatti = new Koordinaatti(0, 0);

            Console.WriteLine("Anna x-koordinaatti: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y-koordinaatti: ");
            int y = int.Parse(Console.ReadLine());
            bool result = koordinaatti.Etaisyys(koordinaatti);

            Console.WriteLine($"Annettu koordinaatti {x - 1}, {y - 1} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x - 1}, {y} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x - 1}, {y + 1} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x}, {y - 1} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x}, {y} on koordinaatissa {x}, {y}.");
            Console.WriteLine($"Annettu koordinaatti {x}, {y - 1} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x + 1}, {y - 1} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x + 1}, {y} on koordinaatin {x}, {y} vieressä.");
            Console.WriteLine($"Annettu koordinaatti {x + 1}, {y + 1} on koordinaatin {x}, {y} vieressä.");
        }
    }
}
