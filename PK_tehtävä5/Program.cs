namespace PK_tehtävä5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robotti robotti = new Robotti();
            
            robotti.Käskyt[0] = new Käynnistä();
            robotti.Käskyt[1] = new Ylös();
            robotti.Käskyt[2] = new Sammuta();
            robotti.Suorita();
        }
    }
}
