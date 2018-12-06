using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patentes;
using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        List<Thread> hilos;
        Queue<Patente> cola;

        public FrmPpal()
        {
            InitializeComponent();
            this.hilos = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += this.ProximaPatente;
            vistaPatente2.finExposicion += this.ProximaPatente;
            //vistaPatente1.MostrarPatente(vistaPatente2);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<List<Patente>> xml = new Xml<List<Patente>>();
            List<Patente> listaPatentes = new List<Patente>();
            try
            {
                xml.Leer("patentes.xml", out listaPatentes);
                foreach (Patente p in listaPatentes)
                {
                    cola.Enqueue(p);
                }
                this.IniciarSimulacion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            try
            {
                texto.Leer("Patentes.txt", out this.cola);
                this.IniciarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            try
            {
                sql.Leer("Patentes.bak", out cola);
                this.IniciarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ProximaPatente(VistaPatente vp)
        {
            Thread hilo = new Thread(vp.MostrarPatente);
            hilo.Start(cola.Dequeue());
            this.hilos.Add(hilo);
        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(vistaPatente1);
            this.ProximaPatente(vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            for (int i = 0; i < hilos.Count; i++)
            {
                if (hilos[i].IsAlive)
                {
                    hilos[i].Abort();
                }
            }
        }
    }
}
