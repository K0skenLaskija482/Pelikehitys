
namespace PK_tehtävä5
{
    public class Oikea: RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä)
            {
                robotti.X++;
            }
        }
    }
}
