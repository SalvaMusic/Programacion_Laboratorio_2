using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cartuchera1
    {
        private List<IAcciones> listaIAcciones;

        public bool ProbarElementos()
        {
            foreach (IAcciones accion in listaIAcciones)
            {
                float aux = accion.UnidadesDeEscritura;
                accion.UnidadesDeEscritura -= 1;

                if (accion.UnidadesDeEscritura == aux)
                {
                    return false;
                }

                if (accion.UnidadesDeEscritura <= 1)
                {
                    accion.Recargar(3);
                }
            }
            return true;
        }

        public List<IAcciones> ListaAcciones
        {
            get { return this.listaIAcciones; }
            set { this.listaIAcciones = value; }
        }


            
    }
}
