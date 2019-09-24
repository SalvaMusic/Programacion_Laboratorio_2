using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DevProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(001, "Estadus Unidos 1221", CIva.ResponsableInscripto, TDocum.DNI, "39708318");
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("2526", "Cuerdas de Guitarra", 150));
            productos.Add(new Producto("2527", "Puas de Guitarra", 50));
            productos.Add(new Producto("2528", "Afinador de Guitarra", 500));
            productos.Add(new Producto("2529", "Bafles de Guitarra", 12000));

            Pedido pedido = new Pedido(124, c1, productos);
            Factura factura = new Factura(pedido);

            Console.Write(factura.ToString());
            Console.ReadKey();

        }
    }
}
