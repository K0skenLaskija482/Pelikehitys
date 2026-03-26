
namespace PK_tehtävä5
{
    public class Sammuta: RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = false;
        }
    }
}
