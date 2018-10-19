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
            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Factura f3 = new Factura(3);
            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(2);
            Recibo r3 = new Recibo(3);
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            contabilidad += f1;
            contabilidad += f2;
            contabilidad += f3;

            contabilidad += r1;
            contabilidad += r2;
            contabilidad += r3;

            Console.Write((string)contabilidad);
            Console.ReadKey();

            
        }
    }
}
