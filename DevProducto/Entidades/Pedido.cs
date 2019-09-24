using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        protected int nroPedido;
        protected Cliente cliente;
        protected List<Producto> detalles;

        public Pedido(int nroPedido, Cliente cliente, List<Producto> detalles)
        {
            this.nroPedido = nroPedido;
            this.cliente = cliente;
            this.detalles = detalles;
        }

        public int NroPedido
        {
            get { return nroPedido; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public List<Producto> Detalles
        {
            get { return detalles; }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Nro Pedido: {0}\n", NroPedido);
            str.AppendFormat("CODIGO \t\tNOMBRE \t\tPRECIO \t%IVA \tCANTIDAD\tPRECIO VENTA \tPRECIO NETO \tMONTO IVA\n");
            foreach (Producto producto in this.detalles)
            {
                str.AppendLine(producto.ToString());
            }
            return str.ToString();
        }
    }
}
