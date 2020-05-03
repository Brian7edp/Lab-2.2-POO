using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Cuadrado: Rectangulo
    {


        public override void CalcularPerimetro()
        {
            Console.WriteLine("Ingrese longitud del lado");
            l1 = int.Parse(Console.ReadLine());
            int p = l1 * 4;
            Console.WriteLine("El perimetro es " + p);

        }

        public override void CalcularSuperficie()
        {
            double sup = Math.Pow(l1, 2);
            Console.WriteLine("La superficie es " + sup);
        }
    }
}
