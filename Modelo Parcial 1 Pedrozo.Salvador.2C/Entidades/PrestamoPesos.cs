using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {  
        private float porcentaInteres;

        public PrestamoPesos(float monto, DateTime vencimiento,float porcentaInteres)
            : base (monto,vencimiento)
        {
            this.porcentaInteres = porcentaInteres;
        }

        public PrestamoPesos(Prestamo prestamo, float PorcentajeInteres)
            :this(prestamo.Monto,prestamo.Vencimiento, PorcentajeInteres)
        {

        }

        private float CalcularInteres()
        {
            float retorno = this.Monto + ((this.Monto * this.porcentaInteres) / 100); 
            return retorno;
        }

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.Vencimiento = nuevoVencimiento;
            TimeSpan diasAgregados = nuevoVencimiento - this.Vencimiento;

            this.porcentaInteres += (diasAgregados.Days * (float)0.25);
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0}\tPESOS\tInteres: {1}",base.Mostrar(), this.Interes);

            return datos.ToString();
        }
    }
}
