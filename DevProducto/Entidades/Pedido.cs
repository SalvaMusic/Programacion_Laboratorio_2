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
            string porc = "";
            str.AppendFormat("Nro Pedido: {0}\n", NroPedido);
            str.AppendFormat("CODIGO \t\tNOMBRE \t\tPRECIO \t%IVA \tCANTIDAD\tPRECIO VENTA \tPRECIO NETO \tMONTO IVA\n");
            foreach (Producto producto in this.detalles)
            {
                switch (Cliente.CondIva)
                {
                    case CIva.IVA_No_Responsable:
                        porc = "70%";
                        break;
                    case CIva.IVA_Responsable_Inscripto:
                        porc = "10.05%";
                        break;
                    case CIva.Monotrivutista:
                        porc = "21%";
                        break;
                }
                str.AppendFormat("\n{0}\t{1}", producto.ToString(), porc);
            }
            return str.ToString();
        }

        public float TotalBrutoPedido
        {
            get { return calcularBrutoPedido(); }
        }

        public float PorcIvaTotal
        {
            get { return calcularPorcIvaTotal(); }
        }

        public float TotalNetoPedido
        {
            get { return calcularTotal(); }
        }

        private float calcularTotal()
        {
             return this.TotalBrutoPedido + this.PorcIvaTotal;
        }

        private float calcularPorcIvaTotal()
        {
            float bruto = this.TotalBrutoPedido;
            float porc = bruto * ((float)21 / 100);
            switch (Cliente.CondIva)
            {
                case CIva.IVA_No_Responsable:
                    porc =  bruto * ((float)70 / 100);
                    break;
                case CIva.IVA_Responsable_Inscripto:
                    porc = bruto * ((float)10.05 / 100);
                    break;
            }
            return porc;
        }

        private float calcularBrutoPedido()
        {
            float bruto = 0;
            foreach(Producto p in this.detalles)
            {
                bruto += p.Precio;
            }

            return bruto;
        }
    }
}
