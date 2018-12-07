using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivos<T>
    {
      void Guardar(string destino, T dato);
      T Leer(string origen);
    }
}
