using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pk_tehtävä7
{
    internal class VaritettyTavara<T>
    {
        public T Tavara { get; set; }
        public ConsoleColor Vari { get; set; }

        public VaritettyTavara(T tavara, ConsoleColor vari)
        {
            Tavara = tavara;
            Vari = vari;
        }

        public void NaytaTavara()
        {
            Console.ForegroundColor = Vari;

            Console.WriteLine(Tavara.ToString());

            Console.ResetColor();
        }
    }
}
