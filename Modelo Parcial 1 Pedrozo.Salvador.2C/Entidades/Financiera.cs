using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;


namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;

            }
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Razon Social: {0}\n", financiera.RazonSocial);
            datos.AppendFormat("Ganancia Intereses en Pesos: {0}\n", financiera.InteresesEnPesos);
            datos.AppendFormat("Ganancia Intereses en Dolares: {0}\n", financiera.InteresesEnDolares);
            datos.AppendFormat("Ganancia Intereses Totales: {0}\n", financiera.InteresesTotales);

            financiera.OrdenarPrestamos();
            foreach(Prestamo prestamo in financiera.ListaDePrestamos)
            {
                datos.AppendLine();
                datos.AppendFormat("{0}",prestamo.Mostrar());

            }
                                   

            return datos.ToString();
        }
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }


        public float CalcularInteresesGanados(TipoDePrestamo tipoPrestamo)
        {
            float retorno = 0;

            foreach (Prestamo prestamo in this.ListaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Pesos:
                        if (prestamo is PrestamoPesos)
                        {
                            retorno = retorno + ((PrestamoPesos)prestamo).Interes;
                        }
                        break;
                    case TipoDePrestamo.Dolares:
                        if (prestamo is PrestamoDolar)
                        {
                            retorno = retorno + ((PrestamoDolar)prestamo).Interes;
                        }                                            
                        break;
                    case TipoDePrestamo.Todos:
                        if (prestamo is PrestamoPesos)
                        {
                            retorno = retorno + ((PrestamoPesos)prestamo).Interes;
                        }
                        if (prestamo is PrestamoDolar)
                        {
                            retorno = retorno + ((PrestamoDolar)prestamo).Interes;
                        }
                        break;
                }
            }

            return retorno;
        }

        public float InteresesEnDolares
        {
            get
            {
                return CalcularInteresesGanados(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return CalcularInteresesGanados(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return CalcularInteresesGanados(TipoDePrestamo.Todos);
            }
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;

            
                if (financiera.listaDePrestamos.Contains(prestamo))
                {
                    retorno = true;
                }

            
            
            return retorno;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if (financiera != prestamo)
            {
                financiera.listaDePrestamos.Add(prestamo);
            }

            return financiera;
        }

    }
}
