using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        private void AgregarLlamada(Llamada llamada)
        {
            this.listaDeLlamadas.Add(llamada);
        }

        public Centralita ()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita (string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTodas
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float recaudado = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            recaudado = recaudado + ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            recaudado = recaudado + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            recaudado = recaudado + ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            recaudado = recaudado + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }
            }
            return recaudado;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Razon Social: {0}\nGanancia Local: {1}\nGanancia Provincial: {2}\nGanancia Total: {3}",
                this.razonSocial, this.GananciasPorLocal, this.GananciasPorProvincial, this.GananciasPorTodas);
            str.Append("\n \n \t DETALLES DE LLAMADAS");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                str.Append("\n");
                str.Append(llamada.ToString());
            }
            str.Append("\n\n");
            return str.ToString();
        }

    }
}
