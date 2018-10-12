using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
     public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3  
        }

        public override bool Equals(object objeto)
        {
            if (objeto is Provincial)
            {
                return true;
            }

            return false;
        }

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float precio = 0;
            float franja1 = (float)0.99;
            float franja2 = (float)1.25;
            float franja3 = (float)0.66;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    precio = franja1 * this.Duracion;
                    break;
                case Franja.Franja_2:
                    precio = franja2 * this.Duracion;
                    break;
                case Franja.Franja_3:
                    precio = franja3 * this.Duracion;
                    break;
            }
            return precio;
        }

        public Provincial(Franja miFranja, Llamada llamada) 
        	: this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
        	: base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        protected override string Mostrar()
        {
     
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {0}\tOrigen: {1}\tDestino: {2}\tCosto llamada: {3}\tFranja horaria: {3}", this.Duracion, this.NroOrigen, this.NroDestino, this.CostoLlamada, this.franjaHoraria);

            return str.ToString();
        }
    }
}
