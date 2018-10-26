using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_42
{
    public class ClaseException
    {
        public ClaseException()
        {
            try
            {
                DivExcepcion();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        public ClaseException(int num)
        {
            try
            {
                ClaseException exception = new ClaseException();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Trato de dividir por 0", e);
            }
        }

        public void mainException()
        {
            try
            {
                ClaseException exception = new ClaseException(0);
            }
            catch (UnaExcepcion e)
            {
                throw new MiException("Trato de dividir por 0", e);
            }
        }
        

        public static void DivExcepcion()
        {
            try
            {
                int i = 7;
                int j = 0;
                int k = i / j;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
    }
}
