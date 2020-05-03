using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la fecha de nacimiento");
            DateTime e = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            string n = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido");
            string a = Console.ReadLine();
            Console.WriteLine("Ingrese el dni");
            string d = Console.ReadLine();
            
            Console.Clear();

            Persona p1 = new Persona(n,a,d,e);

            p1.GetFullName();
            p1.GetAge();


        }
    }
}
