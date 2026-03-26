
namespace PK_tehtävä5
{
    public class Alas: IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.Y--;
            }
        }
    }
}
