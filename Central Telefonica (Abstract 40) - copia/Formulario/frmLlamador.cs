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
    public partial class frmLlamador : Form
    {
        private Centralita cLlamador;
        public frmLlamador(Centralita c)
        {
            InitializeComponent();
            this.cLlamador = c;
        }

        private void frmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        public Centralita CentralitaLlamador
        {
            get
            {
                return this.cLlamador;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();
            Random costo = new Random();

            if (txtNroDestino.Text[0] == '#')
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial llamada = new Provincial(txtNroDestino.Text, franjas, duracion.Next(1, 50), txtNroOrigen.Text);
                this.cLlamador += llamada;
            }
            else
            {
                Local llamada = new Local(txtNroDestino.Text, duracion.Next(1, 50), txtNroOrigen.Text, (float)(costo.NextDouble() * (5.6 - 0.5) + 0.5));
                this.cLlamador += llamada;
            }        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.Length > 0 && txtNroDestino.Text[0] != '#')
            {
                cmbFranja.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '9';
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '*';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '0';
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
            }
            txtNroDestino.Text += '#';
        }
    }
}
