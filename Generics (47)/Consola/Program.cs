using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipoBasquet eB1 = new EquipoBasquet("Basquet Unidos", new DateTime(2005, 03, 20));
            EquipoBasquet eB2 = new EquipoBasquet("San Antonio Spurs", new DateTime(1955, 08, 29));
            EquipoBasquet eB3 = new EquipoBasquet("Chicago Bulls", new DateTime(1915, 09, 30));
            EquipoFutbol eF1 = new EquipoFutbol("River Plate", new DateTime(1905, 11, 15));
            EquipoFutbol eF2 = new EquipoFutbol("Rosario Central", new DateTime(1942, 02, 5));
            EquipoFutbol eF3 = new EquipoFutbol("Defensa y Justicia", new DateTime(1985, 06, 2));
            Torneo<EquipoFutbol> TorneoFutbol = new Torneo<EquipoFutbol>("Liga Argentina");
            Torneo<EquipoBasquet> TorneoBasquet = new Torneo<EquipoBasquet>("Relampago");

            TorneoFutbol += eF1;
            TorneoFutbol += eF2;
            TorneoFutbol += eF3;

            TorneoBasquet += eB1;
            TorneoBasquet += eB2;
            TorneoBasquet += eB3;

            Console.WriteLine(TorneoBasquet.Mostrar());
            Console.ReadKey();
            Console.WriteLine(TorneoFutbol.Mostrar());
            Console.ReadKey();

            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(TorneoBasquet.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(TorneoFutbol.JugarPartido);
            Console.ReadKey();

        }
    }
}
