using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    enum Letra { A, B, X }
    public class Factura
    {   
        private DateTime fechaEmision;
        private int nroFactura;
        private int codEmision;
        private Letra letra;
        private Pedido detalles;

        private Factura ()
        {
            //this.detalles = new List<Pedido>();
        }

        public Factura (Pedido detalles) : this()
        {
            this.detalles = detalles;
            this.fechaEmision = DateTime.Today;
            this.nroFactura++;
            this.codEmision = 12;
            this.letra = Letra.A;

        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Fecha: {0}\tNro Factura: {1}\tCod Emision: {2}\tLetra: {3}\nCliente: {4}\n", 
                fechaEmision.ToShortDateString(), nroFactura, codEmision, letra, detalles.Cliente.ToString());
            str.AppendFormat("------------------------------------------------------------------------\n");
            str.AppendFormat("{0}\n", detalles.ToString());
            str.AppendFormat("------------------------------------------------------------------------\n");
            str.AppendFormat("TOTAL: $________");


            return str.ToString();
        }
    }
}
