using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Contabilidad <T, U> 
        where T : Documento 
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public static explicit operator string(Contabilidad<T,U> c)
        {
            StringBuilder datos = new StringBuilder();
                               
            foreach (T t in c.egresos)
            {
                datos.AppendFormat(t.ToString());
            }
            datos.Append("\n");
            foreach (U u in c.ingresos)
            {
                datos.AppendFormat(u.ToString());
            }
            datos.Append("\n");

            return datos.ToString();
        }





    }
}
