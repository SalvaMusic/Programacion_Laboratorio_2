using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estáticos__De_Clase_
{
    class Validacion
    {
        public static bool Validar(int valor, int max, int min)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            return false;
        }
    }
}
