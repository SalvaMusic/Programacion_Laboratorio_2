using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public void AtenderCliente()
        {
            foreach (string c in this.filaClientes)
            {
                Thread.Sleep(2000);
                Console.WriteLine("{0}\t{1}", c, Thread.CurrentThread.Name);
            }
        }
        
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

    }
}
