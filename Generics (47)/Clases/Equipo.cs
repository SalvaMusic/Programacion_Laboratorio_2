using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Ficha()
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendFormat("{0} fundado el {1}", this.nombre,this.fechaCreacion.ToShortDateString());

            return ficha.ToString();
        }
            
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if ((e1.fechaCreacion == e2.fechaCreacion) && (e1.nombre == e2.nombre))
            {
                return true;
            }

            return false;
        }

        public static bool operator != (Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }


    }
}
