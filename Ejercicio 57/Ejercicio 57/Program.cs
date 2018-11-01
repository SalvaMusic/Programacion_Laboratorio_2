using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Roberto", "Funez");

            
            
                Persona.Guardar(p1, "/ /Personas.xml");
            
            
            
            

            Console.WriteLine("Persona Guardada: {0}", p1.ToString());
            Console.ReadKey();

            Persona p2 = Persona.Leer("Personas.xml");
            Console.WriteLine("Persona Leida: {0}", p2.ToString());
            Console.ReadKey();
        }
    }
}
