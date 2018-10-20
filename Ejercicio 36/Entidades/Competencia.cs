using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Tipo { F1, MotoCross}
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadDeVueltas;
        private List<VehiculoDeCarrera> listaCompetidores;
        private Tipo tipoCompetencia;


        private Competencia()
        {
            listaCompetidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCompetidores, Tipo tipoCompetencia)
            : this()
        {
            this.cantidadDeVueltas = cantVueltas;
            this.cantidadCompetidores = cantCompetidores;
            this.Tipo = tipoCompetencia;
        }
    

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Competencia: {0}\nCantidad de Competidores: {1}\tCantidad de Vueltas: {2}",this.Tipo, this.cantidadCompetidores, this.cantidadDeVueltas);
            str.AppendLine("\n------ COMPETIDORES ------");
                          
            foreach(VehiculoDeCarrera vehiculo in this.listaCompetidores)
            {                
                switch(this.Tipo)
                {
                    case Tipo.F1:
                        if (vehiculo is AutoF1)
                        {
                            str.Append(vehiculo.MostrarDatos());
                        }
                        break;
                    case Tipo.MotoCross:
                        if (vehiculo is MotoCross)
                        {
                            str.Append(vehiculo.MostrarDatos());
                        }
                        break;
                }

                str.AppendLine();
            }
            str.AppendLine("\n");

            return str.ToString();
        }

        public Tipo Tipo
        {
            get
            {
                return this.tipoCompetencia;
            }
            set
            {
                this.tipoCompetencia = value;
            }
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            foreach (VehiculoDeCarrera vehiculo in c.listaCompetidores)
            {
                if (vehiculo == v)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if((c.listaCompetidores.Count < c.cantidadCompetidores) && (c != v))
            {
                if ((c.Tipo == Tipo.F1 && v is AutoF1) || (c.Tipo == Tipo.MotoCross && v is MotoCross))
                {
                    c.listaCompetidores.Add(v);
                    Random rnd = new Random();
                    rnd.Next(15, 100);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadDeVueltas;
                    v.CantidadCombustible = (short)rnd.Next(15, 100);
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if (c.listaCompetidores.Contains(a))
            {
                retorno = true;
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                c.listaCompetidores.Remove(a);
            }

            return retorno;

        }

    }
}
