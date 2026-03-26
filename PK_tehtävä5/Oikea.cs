
namespace PK_tehtävä5
{
    public class Oikea: IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.X++;
            }
        }
    }
}
