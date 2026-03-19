
namespace Pk_tehtävä4
{
    public class Tavara
    {
        public float Tilavuus { get; set; }
        public float Paino { get; set; }

        public Tavara(float tilavuus, float paino)
        {
            Tilavuus = tilavuus;
            Paino = paino;
        }
    }

    public class Nuoli : Tavara
    {
        public Nuoli() : base(0.05f, 0.1f)
        {

        }
    }

    public class Jousi : Tavara
    {
        public Jousi() : base(1f, 4f)
        {

        }
    }

    public class Koysi : Tavara
    {
        public Koysi() : base(1f, 1.5f)
        {

        }
    }

    public class Vesi : Tavara
    {
        public Vesi() : base(2f, 2f)
        {

        }
    }

    public class Ruoka : Tavara
    {
        public Ruoka() : base(1f, 0.5f)
        {

        }
    }
    public class Miekka : Tavara
    {
        public Miekka() : base(5f, 3f)
        {

        }
    }
}
