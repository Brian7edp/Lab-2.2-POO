using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Persona
    {

        //propiedades 
        public string Apellido
        { get; set; }

        public string Nombre
        { get; set; }

        public DateTime FechaNac
        { get; set; }

        public string Dni
        { get; set; }

        public int Edad
        {
            get { return DateTime.Today.Year - FechaNac.Year;}
            /* no hace falta que setee la edad en una variable
           ya que cada vez que quiera saber la edad realizo la resta y la devuelvo*/ 
        }

        //Constructor por parámetro
        public Persona(string n, string a, string d, DateTime e)
        {
            Apellido = n;
            Nombre = a;
            Dni = d;
            FechaNac = e;
            Console.WriteLine("Objeto creado exitosamente");
            Console.WriteLine();
        }

        //Destructor
        ~Persona()
         {
           Console.WriteLine("Instancia destruida exitosamente");
         }

    //metodos
    public void GetFullName()
        {
            Console.WriteLine("El nombre completo es: " + Nombre + " " + Apellido);
            Console.ReadKey();
        }

        public void GetAge()
        {
            Console.WriteLine("La edad aproximada es " + Edad);
            Console.ReadKey();
        }


    }
}
