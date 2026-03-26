
namespace PK_tehtävä5
{
    public class Vasen: RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.X--;
            }
        }
    }
}
