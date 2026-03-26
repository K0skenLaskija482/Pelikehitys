
namespace PK_tehtävä5
{
    public class Käynnistä: RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = true;
        }
    }
}
