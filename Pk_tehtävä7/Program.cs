using Pk_tehtävä4;

namespace Pk_tehtävä7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VaritettyTavara<Miekka> tulimiekka =
            new VaritettyTavara<Miekka>(
                new Miekka(),
                ConsoleColor.Red
            );

            VaritettyTavara<Jousi> vihreaJousi =
                new VaritettyTavara<Jousi>(
                    new Jousi(),
                    ConsoleColor.Green
                );

            VaritettyTavara<Kirves> keltainenNuoli =
                new VaritettyTavara<Kirves>(
                    new Kirves(),
                    ConsoleColor.Blue
                );

            tulimiekka.NaytaTavara();
            vihreaJousi.NaytaTavara();
            keltainenNuoli.NaytaTavara();
        }
    }
}
