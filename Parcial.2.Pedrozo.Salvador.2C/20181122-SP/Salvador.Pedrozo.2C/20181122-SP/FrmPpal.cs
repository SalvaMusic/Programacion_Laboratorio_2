using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.MostrarPatente(vistaPatente2);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<List<Patente>> xml = new Xml<List<Patente>>();
            List<Patente> lista = new List<Patente>();
            xml.Leer("patentes.xml", out lista);
            foreach (Patente p in lista)
            {
                cola.Enqueue(p);
            }
            this.IniciarSimulacion();
            
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            texto.Leer("Patentes.txt", out this.cola);
            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            sql.Leer("Patentes.bak", out cola);
            this.IniciarSimulacion();
        }

        public void ProximaPatente(VistaPatente vp)
        {
            while(cola.Count > 0)
            {
                Thread hilo = new Thread(vp.MostrarPatente);
                hilo.Start(cola.Dequeue());
                this.hilos.Add(hilo);
            }
        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(vistaPatente1);
            this.ProximaPatente(vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            int i;

            for (i = 0; i < hilos.Count; i++)
            {
                if (hilos[i].IsAlive)
                {
                    hilos[i].Abort();
                }
            }
        }
    }
}
