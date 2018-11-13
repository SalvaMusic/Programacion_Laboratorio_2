using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja c1, Caja c2)
        {
            clientes = new List<string>();
            this.caja1 = c1;
            this.caja2 = c2;
        }

        public void AsignarCajas()
        {
            Console.WriteLine("Asignando cajas...");
            foreach(string c in clientes)
            {
                Thread.Sleep(1000);
                if (Caja1.FilaClientes.Count <= Caja2.FilaClientes.Count)
                {
                    Caja1.FilaClientes.Add(c);
                }
                else
                {
                    Caja2.FilaClientes.Add(c);
                }
            }
        }

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

    }
}
