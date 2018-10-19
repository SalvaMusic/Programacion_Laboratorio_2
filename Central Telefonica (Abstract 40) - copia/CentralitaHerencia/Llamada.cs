using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public abstract class Llamada
    {
    	protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        public abstract float CostoLlamada
        {
            get;
        }

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

        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Duracion: {0}\tOrigen: {1}\tDestino: {2}", this.Duracion, this.NroOrigen, this.NroDestino);

            return str.ToString();
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            bool retorno = false;
            if((llamada1.Equals(llamada2)) && (llamada1.NroDestino == llamada2.NroDestino) && (llamada1.NroOrigen == llamada2.NroOrigen))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
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
