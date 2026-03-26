
namespace PK_tehtävä5
{
    public class Ylös: RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.Y++;
            }
        }
    }
}
