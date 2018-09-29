using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
           : base(nombre, apellido, documento) 
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get
            {
                StringBuilder datos = new StringBuilder();

                return datos.AppendFormat("{0}º{1}",this.anio, this.division).ToString();
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();

            return datos.AppendFormat("{0}, {1}\tDNI: {2}\t{3}", this.Apellido, this.Nombre, this.Documento, this.AnioDivision).ToString();
        }

        protected override bool ValidarDocumentacion(string dni)
        {
            bool retorno = false;
            
            if(dni.Length == 9)
            {
                for(int i=0; i< dni.Length;i++)
                {
                    if (i == 2 || i == 7)
                    {
                        if (dni[i] != '-')
                        {
                            return false;
                        }    
                    }
                    else
                    {
                        if (!char.IsNumber(dni[i]))
                        {
                            return false;
                        }
                    }
                    
                }
                retorno = true;
            }

            return retorno;
        }
    }
}
