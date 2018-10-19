using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IGuardar<T,V>
    {
        bool Guardar(T objeto);
        V Leer();
        
    }
}
