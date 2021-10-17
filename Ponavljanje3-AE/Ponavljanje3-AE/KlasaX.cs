using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje3_AE
{
    class KlasaX
    {
        int[] arr = new int[100];
        int indeks;

        public KlasaX(int[] arr, int indeks)
        {
            this.arr = arr;
            this.indeks = indeks;
        }

        public int[] Arr { get => arr; set => arr = value; }
        public int Indeks { get => indeks; set => indeks = value; }

        public KlasaX()
        {
        }


    }
}
