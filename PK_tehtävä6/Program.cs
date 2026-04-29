namespace PK_tehtävä6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koordinaatti koordinaatti = new Koordinaatti();

            Console.WriteLine("Anna x-koordinaatti: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y-koordinaatti: ");
            int y = int.Parse(Console.ReadLine());
            bool result = koordinaatti.Etaisyys(koordinaatti);
        }
    }
}
