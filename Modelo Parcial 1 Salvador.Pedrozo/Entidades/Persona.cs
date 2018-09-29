using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private string documento;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;

        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        protected abstract bool ValidarDocumentacion(string dni);

        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();

            return datos.AppendFormat("{0}, {1}\tDNI: {2}",this.Apellido,this.Nombre,this.Documento).ToString();
        }
        

    }
}
