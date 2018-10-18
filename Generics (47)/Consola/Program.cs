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
            EquipoBasquet eB1 = new EquipoBasquet();
            EquipoBasquet eB2 = new EquipoBasquet();
            EquipoBasquet eB3 = new EquipoBasquet();
            EquipoFutbol eF1 = new EquipoFutbol();
            EquipoFutbol eF2 = new EquipoFutbol();
            EquipoFutbol eF3 = new EquipoFutbol();
            Torneo<EquipoFutbol> TorneoFutbol = new Torneo<EquipoFutbol>();
            Torneo<EquipoBasquet> TorneoBasquet = new Torneo<EquipoBasquet>();
        }
    }
}
