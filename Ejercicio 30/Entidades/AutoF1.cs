using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private int numero;
        private short vueltasRestantes;

        public AutoF1(int numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;

            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            string estado = "";

            if (this.enCompetencia)
            { estado = "En Competencia"; }
            else
            { estado = "Sin Competir"; }

            str.AppendFormat("Nro: {0}\tEscuderia: {1}\nEstado: {2}",this.numero,this.escuderia,estado);

            return str.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if ((a1.escuderia == a2.escuderia) && (a1.numero == a2.numero))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }


        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }


    }
}
