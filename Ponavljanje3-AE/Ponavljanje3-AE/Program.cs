using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje3_AE
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();
            for (x.Indeks = 0; x.Indeks < 100; x.Indeks++)
            {
                x.Arr[x.Indeks] = x.Indeks + 1;
            }
            Console.WriteLine("50. broj u polju Arr = " + x.Arr[49]);
            Console.ReadKey();
        }
    }
}
