using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Form1
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(AsignarHora);
        }

        private void AsignarHora()
        {
            
                if(this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate () { this.lblHora.Text = DateTime.Now.ToString(); });                
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString();
                }
            
            
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Start();
        }
    }
}
