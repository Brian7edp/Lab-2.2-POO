using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public class B: A
    {

        public B():base("Instancia de B")
        {
          //  NombreInstancia = "Instancia de B";

        }

        //metodos de clase hija
        public void M4()
        {
            Console.WriteLine("Metodo clase hija invocado");
        }

        




    }
}
