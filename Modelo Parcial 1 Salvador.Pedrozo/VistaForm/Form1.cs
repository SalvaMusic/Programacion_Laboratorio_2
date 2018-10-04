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

namespace VistaForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }
        Curso curso;
        private void btnCrearCurso_Click(object sender, EventArgs e, Curso curso)
        {
            string nombre = txtNombreProfe.Text;
            string apellido = txtApellidoProfe.Text;
            string documento = txtDocumentoProfe.Text; 
            DateTime fechaIngreso = Convert.ToDateTime(dtpFechaIngreso.Text);
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            short anio = Convert.ToInt16(nudAnioCurso.Value);
            curso = new Curso(anio,division,new Profesor(nombre,apellido,documento,fechaIngreso));

            if (curso is null)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("Grupo Creado con Exito!");
            }

            txtApellidoProfe.Text = "";
            txtNombreProfe.Text = "";
            txtDocumentoProfe.Text = "";

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e, Curso curso)
        {
            rbdDatos.Text = ((string)curso);
             
        }
    }
}
