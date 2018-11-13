using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;


        public bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                if((value == true) && !hilo.IsAlive)
                {
                    hilo.Start();
                }
                else if((value == false) && hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

    }
}
