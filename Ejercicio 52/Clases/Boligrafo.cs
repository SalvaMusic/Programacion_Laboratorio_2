using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo (int unidades,ConsoleColor colorTinta)
        {
            this.tinta = unidades;
            this.Color = colorTinta;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, this.Color);
            this.UnidadesDeEscritura -= (texto.Length * (float)0.3);
            
            return escritura;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Boligrafo");
            str.AppendFormat("Color {0}\tCantidad de Tinta: {1}", this.Color, this.UnidadesDeEscritura);
            return str.ToString();
        }
    }
}
