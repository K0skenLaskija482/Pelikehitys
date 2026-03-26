
namespace PK_tehtävä5
{
    public class Ylös: IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.Y++;
            }
        }
    }
}
