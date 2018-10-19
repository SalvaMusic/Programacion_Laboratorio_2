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

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }  

        public override bool Equals(object objeto)
        {
            if (objeto is Local)
            {
                return true;
            }

            return false;
        }

        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public Local(Llamada llamada, float costo) 
        	: this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino, costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) 
        	:  base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {0}\tOrigen: {1}\tDestino: {2}\nCosto llamada: {3}", this.Duracion, this.NroOrigen, this.NroDestino, this.CostoLlamada);
            
            return str.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
