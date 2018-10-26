using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOo;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClaseException exception = new ClaseException(0);
                exception.mainException();
            }
            catch (UnaExcepcion e)
            {

                string fecha = DateTime.Today.ToString();
                ArchivoTexto.Guardar(String.Format("{0}.txt",fecha), e.Message);
                
                if (!(e.InnerException is null))
                {
                    //ArchivoTexto.Guardar(DateTime.Now.ToString(), e.InnerException.Message);
                }
            }
            
            Console.ReadKey();
        }
    }
}
