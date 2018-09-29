using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool retorno = true;
            string numeroStr;
            double binarioDecimal;
         
            do
            {
                Console.WriteLine("Ingrese un numero Decimal: ");
                numeroStr = Console.ReadLine();
                if (int.TryParse(numeroStr, out numero))
                {
                    retorno = true;
                }
            } while (!retorno);
            numeroStr = Conversor.DecimalBinario(numero);
            Console.WriteLine("Binario: "+numeroStr);

            Console.WriteLine("Ingrese un numero Binario: ");
            numeroStr = Console.ReadLine();

            binarioDecimal = Conversor.BinarioDecimal(numeroStr);
            Console.WriteLine("Decimal: " + binarioDecimal);

            Console.ReadKey();

        }
    }
}
