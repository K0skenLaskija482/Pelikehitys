
namespace PK_tehtävä5
{
    public class Robotti
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool OnKäynnissä { get; set; }
        public IRobottiKäsky?[] Käskyt { get; } = new IRobottiKäsky?[3];

        public void Suorita()
        {
            foreach (IRobottiKäsky? käsky in Käskyt)
            {
                käsky?.Suorita(this);
                Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
            }
        }
    }
}
