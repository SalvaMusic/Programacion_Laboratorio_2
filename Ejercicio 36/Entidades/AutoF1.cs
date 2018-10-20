using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia)
            :base(numero,escuderia)
        {
            
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("\n{0}",base.MostrarDatos());
            str.AppendFormat("{0} Caballos de fuerza\n", this.CaballosDeFuerza);
                    
            return str.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if ((a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }


        


    }
}
