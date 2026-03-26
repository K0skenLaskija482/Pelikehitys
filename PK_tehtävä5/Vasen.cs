
namespace PK_tehtävä5
{
    public class Vasen: IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.X--;
            }
        }
    }
}
