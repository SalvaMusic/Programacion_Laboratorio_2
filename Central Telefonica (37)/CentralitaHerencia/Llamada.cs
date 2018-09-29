using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
    	protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int orden = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                orden = 1;
            }else if (llamada1.Duracion < llamada2.Duracion)
            {
                orden = -1;
            }
            return orden;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {0}\tOrigen: {1}\tDestino: {2}", this.Duracion, this.NroOrigen, this.NroDestino);
            // usar StringBuilder.

            return str.ToString();
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
                
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
    }
}
