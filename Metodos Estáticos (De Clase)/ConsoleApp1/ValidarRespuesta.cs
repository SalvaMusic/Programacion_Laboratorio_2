using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char  respuesta)
        {
            string resp = Convert.ToString(respuesta);
            if (string.Compare(resp,"S",true) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
