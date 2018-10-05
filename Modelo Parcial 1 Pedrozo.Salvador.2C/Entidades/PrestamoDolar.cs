using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        PeriodicidadDePagos periocidad;

        public PrestamoDolar (float monto, DateTime vencimiento, PeriodicidadDePagos periocidad)
            : base (monto, vencimiento)        
        {
            this.periocidad = periocidad;
        }

        public PrestamoDolar (Prestamo prestamo, PeriodicidadDePagos periocidad)
            :this(prestamo.Monto, prestamo.Vencimiento,periocidad)
        {

        }

        private float CalcularInteres()
        {
            float retorno = 0;

            switch (this.periocidad)
            {
                case PeriodicidadDePagos.Mensual:
                    retorno = this.Monto + ((this.Monto * (float)25) / 100);
                    break;
                case PeriodicidadDePagos.Bimestral:
                    retorno = this.Monto + ((this.Monto * (float)35) / 100);
                    break;
                case PeriodicidadDePagos.Trimestral:
                    retorno = this.Monto + ((this.Monto * (float)40) / 100);
                    break;
            }
            
            return retorno;
        }

        public PeriodicidadDePagos Periocidad
        {
            get
            {
                return this.periocidad;
            }
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
            this.monto += (diasAgregados.Days * (float)2.25);
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            
            datos.AppendFormat("{0}\tDOLAR\tInteres: {1}",base.Mostrar(), this.Interes);

            return datos.ToString();
        }
    }
}
