using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estáticos__De_Clase_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, max, min, acumulador = 0, cantidad = 0;
            bool retorno = false;
            float promedio;
            string numeroStr;

            min = int.MaxValue;
            max = int.MinValue;

            while (cantidad != 10)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    numeroStr = Console.ReadLine();
                    if (int.TryParse(numeroStr, out numero))
                    {
                        retorno = Validacion.Validar(numero, 100, -100);
                    }
                } while (!retorno);
                
                if (numero > max)
                {
                    max = numero;
                }
                else if (numero < min)
                {
                    min = numero;
                }
                acumulador += numero;
                cantidad++;
            } 
            promedio = acumulador / cantidad;
            Console.WriteLine("Promedio: " +promedio);
            Console.ReadKey();
        }
    }
}
