using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivine_el_numero
{
    class Juego
    {
        private int _record;


        //propiedad
        public int Record { get; set; }

        //constructor
        public Juego()
        {
            Console.WriteLine("Bienvenido al juego");
            Console.WriteLine();
        }

        //metodos
        public void ComenzarJuego()
        {
           string op;
            do
            {
                int max = PreguntarMaximo();
                JugadaConAyuda j = new JugadaConAyuda(max);
                int num = PreguntarNumero();
                int i = j.Comparar(num);
                CompararRecord(i);
                op = Continuar();
            } while (String.Equals(op, "si"));
        }

        public void CompararRecord(int test)
        {
            if(test < Record || Record == 0)
            {
                Record = test;
                Console.WriteLine("Lograste el nuevo record de intentos del juego con " + test + " intentos");
                Console.WriteLine();
            }
        }

        public string Continuar()
        {
            string op;
            do
            {
                Console.WriteLine("Desea jugar otra partida? escriba si/no");
                op = Console.ReadLine();
                op = op.ToLower();
            } while (op != "si" && op != "no");
            Console.Clear();
            return op;
        }

        public int PreguntarMaximo()
        {
            Console.WriteLine("Ingresar numero limite para generar numero a adivnar");
            int max = int.Parse(Console.ReadLine());
            return max;
        }

        public int PreguntarNumero()
        {
            Console.WriteLine("Ingresar numero para intentar adivinar");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
