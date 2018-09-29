using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {   }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public int Antiguedad
        {
            get
            {                
                TimeSpan antiguedad = (DateTime.Now - this.fechaIngreso);
                
                return antiguedad.Days;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();

            return datos.AppendFormat("{0}, {1}\tDNI: {2}\tAntiguedad: {3} dias", this.Apellido, this.Nombre, this.Documento,this.Antiguedad).ToString();
        }

        protected override bool ValidarDocumentacion(string dni)
        {
            bool retorno = false;

            if (dni.Length == 8)
            {
                for (int i = 0; i < dni.Length; i++)
                {
                    if (!char.IsNumber(dni[i]))
                    {
                        return false;
                    }
                }
                retorno = true;
            }

            return retorno;
        }
    }
}
