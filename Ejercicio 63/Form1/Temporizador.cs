using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    public delegate void encargadoTiempo();
    sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public event encargadoTiempo EventoTiempo;

        private void Corriendo()
        {
            while (true)
            {
                Thread.Sleep(intervalo);
                EventoTiempo.Invoke();
            }
        }

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
