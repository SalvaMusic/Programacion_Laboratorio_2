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
    public partial class frmMostrar : Form
    {
        private Centralita cMostrar;
        private Local.TipoLlamada tipo;

        public  Local.TipoLlamada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }

        private frmMostrar(Centralita c)
        {
            InitializeComponent();
            this.cMostrar = c;
        }

        public frmMostrar(Centralita c, Local.TipoLlamada tipo)
            :this(c)
        {
            this.Tipo = tipo;
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            rtbMostrar.Text = this.cMostrar.ToString();
        }

        private void rtbMostrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
