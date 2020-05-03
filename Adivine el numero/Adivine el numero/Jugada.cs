using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivine_el_numero
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public bool Adivino
        {
            get { return _adivino; }
            set { _adivino = value; }
        }

        public int Intentos { get; set; }


        public int Numero { get; set; }

         public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
            Intentos = 1;
        }

        public virtual int Comparar(int test)
        {
            while (test != Numero)
            {
                Console.WriteLine("Numero incorrecto!");
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

    }
}
