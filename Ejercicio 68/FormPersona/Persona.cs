using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersona
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Mostrar()
        {
            return string.Format("{0} {1}", this.Apellido, this.Nombre);
        }
       


        

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

    }
}
