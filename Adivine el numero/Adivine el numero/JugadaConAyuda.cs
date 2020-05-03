using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivine_el_numero
{
    class JugadaConAyuda : Jugada
    {

        //Constructor de clase hija
        public JugadaConAyuda(int max) : base(max)
        {
            
        }

        #region Metodo Comparar modificado
        public override int Comparar(int test)
        {
            while (test != Numero)
            {
                Console.WriteLine(Numero);
                int cercano = Math.Abs(test - Numero);
                Console.WriteLine("Numero incorrecto!");
                if(cercano >= 100 && (test < Numero))
                {
                    Console.WriteLine("El numero es mayor y esta lejos");
                }
                else if (cercano >= 100 && (test > Numero))
                {
                    Console.WriteLine("El numero es menor y esta lejos");
                }
                else if(cercano == 5)
                {
                    Console.WriteLine("Estas a cinco numeros");
                }
                Console.WriteLine();
                Intentos = Intentos + 1;
                Console.WriteLine("Es tu intento numero: " + Intentos);
                Console.WriteLine();
                Console.WriteLine("Vuelva a ingresar otro numero");
                test = int.Parse(Console.ReadLine()); 
            };
            Console.Clear();
            Console.WriteLine("Felicidades adivinaste el numero!!");
            return Intentos;
        }
        #endregion

    }
}
