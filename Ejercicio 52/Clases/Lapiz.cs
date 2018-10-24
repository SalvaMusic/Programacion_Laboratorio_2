using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina += unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto,ConsoleColor.Gray);
            this.tamanioMina -= (texto.Length * (float)0.1);

            return escritura;
        }

        bool IAcciones.Recargar(int unidades)
        {
            this.tamanioMina += unidades;

            return true;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Lapiz");
            str.AppendFormat("Color {0}\tTamaño mina: {1}", ConsoleColor.Gray, this.tamanioMina);
            return str.ToString(); 
        }
    }
}
