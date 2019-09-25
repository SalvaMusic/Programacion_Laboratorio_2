using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    enum Letra { A, B, X }
    enum Estado { Pendiente, Facturado }
    public class Factura
    {
        private DateTime fechaEmision;
        private int nroFactura;
        private int codEmision;
        private Letra letra;
        private Pedido detalles;
        private Estado estado;

        private Factura()
        {
            //this.detalles = new List<Pedido>();
        }

        public Factura(Pedido detalles) // : this()
        {
            this.detalles = detalles;
            this.fechaEmision = DateTime.Today;
            this.nroFactura++;
            this.codEmision = 12;
            this.letra = asignaLetra();

        }

        private Letra asignaLetra()
        {
            Letra retorno = Letra.B;
            switch(detalles.Cliente.CondIva)
            {
                case CIva.IVA_No_Responsable:
                    retorno = Letra.X;
                    break;
                case CIva.IVA_Responsable_Inscripto:
                    retorno = Letra.A;
                    break;
            }
            return retorno;
        }
        

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Fecha: {0}\tNro Factura: {1}\tCod Emision: {2}\tLetra: {3}\nCliente: {4}\n",
                fechaEmision.ToShortDateString(), nroFactura, codEmision, letra, detalles.Cliente.ToString());
            str.AppendFormat("------------------------------------------------------------------------\n");
            str.AppendFormat("{0}\n", detalles.ToString());
            str.AppendFormat("------------------------------------------------------------------------\n");
            str.AppendFormat("SUBTOTAL: ${0}  MONTO IVA: ${1} -------------------------------- TOTAL: ${2}", 
                detalles.TotalBrutoPedido, detalles.PorcIvaTotal, detalles.TotalNetoPedido);


            return str.ToString();
        }

        

        
    }
}
