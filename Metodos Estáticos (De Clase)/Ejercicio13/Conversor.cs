using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double valor)
        {
            string binario = string.Empty,binarioNew = string.Empty, restoStr;
            double resto;

            
            do
            {
                resto = valor%2;
                restoStr = Convert.ToString(resto);
                binario += restoStr;
                valor = (int) valor / 2;
            } while (valor >= 2) ;
            binario += valor;
            for (int i=(binario.Length-1);i>=0;i--)
            {
                binarioNew += binario[i]; 
            }

                return binarioNew;
        }

        public static double BinarioDecimal(string binarioStr)
        {
            double entero = 0;
           
           

            for (int i = (binarioStr.Length-1); i>=0;i--)
            {
                
                if (binarioStr[i] == '1')
                {
                    entero += (double)Math.Pow(2,i);
                }
            }
            return entero;
        }

    }
}
