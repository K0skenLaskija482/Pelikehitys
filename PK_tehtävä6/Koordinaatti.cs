using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_tehtävä6
{
    internal class Koordinaatti
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Koordinaatti(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool Etaisyys(Koordinaatti koordinaatti)
        {
            int dx = Math.Abs(this.x - koordinaatti.x);
            int dy = Math.Abs(this.y - koordinaatti.y);

            return dx <= 1 && dy <= 1;
        }
    }
}
