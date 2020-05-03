using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {
        private string nombre;
        //constructor por defecto
        public A()
        {
            nombre = "Instancia sin nombre";
        }

        //Constructor por parámetro
        public A(string n)
        {
            nombre = n;
        }

        //propiedad
        public string NombreInstancia
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //metodos
        public string MostrarNombre()
        {
            return nombre;
        }

        public virtual void M1()
        {
            Console.WriteLine("El metodo M1 fue invocado");
        }

        public void M2()
        {
            Console.WriteLine("El metodo M2 fue invocado");
        }

        public void M3()
        {
            Console.WriteLine("El metodo M3 fue invocado");
        }
    }
}
