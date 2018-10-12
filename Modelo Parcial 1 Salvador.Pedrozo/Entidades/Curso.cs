using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> listaAlumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;
        
        

        private Curso()
        {
            listaAlumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision
        {
            get
            {
                StringBuilder datos = new StringBuilder();

                return datos.AppendFormat("{0}º{1}", this.anio, this.division).ToString();
            }
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Division: {0}\tProfesor: {1}\n", c.AnioDivision, c.profesor.ExponerDatos());
            datos.AppendLine("\n\tALUMNOS:");
            foreach (Alumno alumno in c.listaAlumnos)
            {
                datos.AppendLine(alumno.ExponerDatos());
            }
            datos.Append("\n");

            return datos.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;

            if (c.AnioDivision == a.AnioDivision)
            {
                retorno = true;
            }

            return retorno;

        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        { 
            if((c==a))
            {
                c.listaAlumnos.Add(a);
            }

            return c;
        }

    }
}
