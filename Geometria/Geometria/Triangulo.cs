using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Triangulo
    {

        public int CalcularPerimetro(int b, int l1, int l2)
        {
           int suma = b + l1 + l2;
            return suma;

        }

        public int CalcularSuperficie(int b, int a)
        {
            int sup = b * a;
            return sup;       
        }


    }

   
}
