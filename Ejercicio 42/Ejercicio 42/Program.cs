using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Mensaje: {0}", e.Message);
                
                if (!(e.InnerException is null))
                {
                Console.WriteLine("InnerException: {0}", e.InnerException.Message);
                }
            }
            
            Console.ReadKey();
        }
    }
}
