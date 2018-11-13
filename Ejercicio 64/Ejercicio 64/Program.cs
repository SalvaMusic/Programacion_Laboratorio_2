using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();
            Negocio n1 = new Negocio(c1, c2);
            n1.Clientes.Add("Marcelo Gallardo");
            n1.Clientes.Add("Franco Armani");
            n1.Clientes.Add("Pity Martinez");
            n1.Clientes.Add("Lucas Prato");
            n1.Clientes.Add("Leonardo Ponzio");
            n1.Clientes.Add("Nacho Scocco");
            Thread tn = new Thread(n1.AsignarCajas);
            Thread tc1 = new Thread(c1.AtenderCliente);
            Thread tc2 = new Thread(c2.AtenderCliente);
            tc1.Name = "Caja 1";
            tc2.Name = "Caja 2";
            tn.Start();
            tn.Join();
            tc1.Start();
            tc2.Start();
            Console.ReadKey();
        }
    }
}
