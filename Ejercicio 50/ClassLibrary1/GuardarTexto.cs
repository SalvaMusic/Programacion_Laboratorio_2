using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class GuardarTexto<T,V> : IGuardar<T,V>
    {


        public bool Guardar(T objeto)
        {
            return true;
        }

        public V Leer()
        {
            string str = "Objeto Leído";

            return (V)Convert.ChangeType(str, typeof(V));
        }
    }
}
