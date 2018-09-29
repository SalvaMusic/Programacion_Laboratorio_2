using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public Local(Llamada llamada, float costo) 
        	: base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo; 
        }

        public Local(string origen, float duracion, string destino, float costo) 
        	:  this(new Llamada(duracion,destino,origen),costo)
        {
            
        }

        public new string Mostrar()
        {
            
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {0}\tOrigen: {1}\tDestino {2}\tCosto llamada: {3}", this.Duracion, this.NroOrigen, this.NroDestino, this.CostoLlamada);
            
            return str.ToString();
        }


    }
}
