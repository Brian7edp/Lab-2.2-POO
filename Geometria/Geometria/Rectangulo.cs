using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo : Poligono
    {
        private int m_l1, m_l2;

        public int l1 { get; set; }
        public int l2 { get; set; }
        
        public override void CalcularPerimetro()
        {
            Console.WriteLine("Ingrese longitud de uno de los lados");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese longitud del otro lado");
            l2 = int.Parse(Console.ReadLine());
            int p = ((l2 * 2) + (l1 * 2));
            Console.WriteLine("El perimetro es " + p);
            Console.WriteLine();
        }

        public override void CalcularSuperficie()
        {
            int sup = l1 * l2;
            Console.WriteLine("La superficio es " + sup);
        }


    }
}
