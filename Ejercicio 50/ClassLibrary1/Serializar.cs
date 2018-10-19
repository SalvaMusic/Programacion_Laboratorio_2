using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S objeto)
        {
            return true;
        }

        public V Leer()
        {
            string str = "Texto Leído";

            return (V)Convert.ChangeType(str,typeof(V));
        }
    }
}
