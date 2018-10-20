using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            :base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("\n{0}", base.MostrarDatos());
            str.AppendFormat("{0} Cilindradas\n", this.Cilindrada);

            return str.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if ((m1.Escuderia == m2.Escuderia) && (m1.Numero == m2.Numero))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
    }
}
