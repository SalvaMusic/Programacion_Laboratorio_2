using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> lista;
        private string nombre;

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (Equipo e in torneo.lista)
            {
                if (e == equipo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.lista.Add(equipo);
            }

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Torneo {0}\n", this.nombre);

            foreach (Equipo equipo in lista)
            {
                datos.AppendFormat("{0}\n", equipo.Ficha());
            }

            return datos.ToString();
        }


        public string CalcularPartido(T equipo1, T equipo2)
        {
            StringBuilder datos = new StringBuilder();
            Random rnd = new Random();

            int puntosE1 = rnd.Next(10);
            int puntosE2 = rnd.Next(10);

            datos.AppendFormat("{0} {1} - {2} {3}", equipo1.nombre, puntosE1, puntosE2, equipo2.nombre);

            return datos.ToString();
        }

        public string JugarPartido
        {
            get
            {
                Random rnd = new Random();

                return CalcularPartido(lista[rnd.Next(lista.Count)], lista[rnd.Next(lista.Count)]);
            }


        }

    
    }
}
