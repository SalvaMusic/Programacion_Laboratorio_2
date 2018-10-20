using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadDeVueltas;
        private List<AutoF1> listaAutosF1;

        private Competencia()
        {
            listaAutosF1 = new List<AutoF1>();
        }

        public Competencia(short cantVueltas, short cantCompetidores)
            : this()
        {
            this.cantidadDeVueltas = cantVueltas;
            this.cantidadCompetidores = cantCompetidores;
        }


        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Cantidad de Competidores: {0}\tCantidad de Vueltas: {1}", this.cantidadCompetidores, this.cantidadDeVueltas);

            foreach(AutoF1 auto in this.listaAutosF1)
            {
                str.AppendLine();
                str.Append(auto.MostrarDatos());
            }
            str.AppendLine("\n");

            return str.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.listaAutosF1)
            {
                if (auto == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if((c.listaAutosF1.Count < c.cantidadCompetidores) && (c != a))
            {
                c.listaAutosF1.Add(a);
                Random rnd = new Random();
                rnd.Next(15, 100);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadDeVueltas;
                a.CantidadCombustible = (short)rnd.Next(15, 100);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if (c.listaAutosF1.Contains(a))
            {
                retorno = true;
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                c.listaAutosF1.Remove(a);
            }

            return retorno;

        }

    }
}
