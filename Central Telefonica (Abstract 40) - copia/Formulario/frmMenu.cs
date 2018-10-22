using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Formulario
{
    public partial class frmMenu : Form
    {
        Centralita centralita;
        public frmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Pedrozo Telefonia");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonGrarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador llamador = new frmLlamador(centralita);
            llamador.Show();
        }

        private void buttonFactTotal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(centralita, Llamada.TipoLlamada.Todas);
            mostrar.Show();
        }

        private void buttonFacLocal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(centralita, Llamada.TipoLlamada.Local);
            mostrar.Show();
        }

        private void buttonFactProvincial_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(centralita, Llamada.TipoLlamada.Provincial);
            mostrar.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
