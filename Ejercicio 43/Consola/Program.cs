using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c2 = new Competencia(35, 10, Tipo.MotoCross);
            Competencia c1 = new Competencia(15, 3, Tipo.F1);
            AutoF1 a1 = new AutoF1(1, "Mercedes", 500);
            AutoF1 a2 = new AutoF1(2, "Ferrari", 465);
            AutoF1 a3 = new AutoF1(3, "RedBull", 355);
            MotoCross m1 = new MotoCross(66, "Honda", 3500);
            MotoCross m2 = new MotoCross(99, "Honda Twister", 300);
            MotoCross m3 = new MotoCross(23, "Motomel", 250);

            if (c1 + a1 && c1 + a2 && c1 + a3)
            {
                Console.WriteLine(c1.MostrarDatos());
            }

            Console.ReadKey();

            if (c2 + m1 && c2 + m2 && c2 + m3)
            {
                Console.WriteLine(c2.MostrarDatos());
            }

            Console.ReadKey();

        }
    }
}
