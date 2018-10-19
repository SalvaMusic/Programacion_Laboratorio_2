using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Factura : Documento
    {
        public Factura(int numero)
        : base(numero)
        {   }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Factura nro: {0}", this.Numero);
            datos.AppendLine();

            return datos.ToString();
        }
    }
}
