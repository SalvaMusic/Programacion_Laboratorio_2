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
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            throw new NotImplementedException();
        }

        public bool Recargar(float unidades)
        {
            throw new NotImplementedException();
        }
    }
}
