using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            A p1 = new A();
            Console.WriteLine(p1.NombreInstancia);
            p1.M1();
            B p2 = new B();
           Console.WriteLine(p2.MostrarNombre());
           p2.M3();
           p2.M4();
            Console.ReadKey();

        }
    }
}
