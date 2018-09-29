using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, acumulador = 0;
            bool retorno = true;
            string numeroStr;
            char respuesta;

            while (retorno)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: ");
                    numeroStr = Console.ReadLine();
                    if (int.TryParse(numeroStr, out numero))
                    {
                        retorno = true;
                    }
                } while (!retorno);
                acumulador += numero;
                Console.WriteLine("¿Continuar? (S/N) ");
                numeroStr = Console.ReadLine();
                respuesta = Convert.ToChar(numeroStr);
                retorno = ValidarRespuesta.ValidarS_N(respuesta);

            }
            
            Console.WriteLine("Suma Total: " + acumulador);
            Console.ReadKey();
        }
    }
}
