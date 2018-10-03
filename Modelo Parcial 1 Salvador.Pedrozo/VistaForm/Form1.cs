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
        private List<Curso> listaCursos;
        public Form1()
        {
            InitializeComponent();
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            listaCursos = new List<Curso>();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProfe.Text;
            string apellido = txtApellidoProfe.Text;
            string documento = txtDocumentoProfe.Text; 
            DateTime fechaIngreso = Convert.ToDateTime(dtpFechaIngreso.Text);
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            short anio = Convert.ToInt16(nudAnioCurso.Value);
            Curso curso = new Curso(anio,division,new Profesor(nombre,apellido,documento,fechaIngreso));

            if (curso is null)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("Grupo Creado con Exito!");
                this.listaCursos.Add(curso);
            }

            txtApellidoProfe.Text = "";
            txtNombreProfe.Text = "";
            txtDocumentoProfe.Text = "";

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
            short anio = Convert.ToInt16(nudAnioCurso.Value);
            string auxAnioDivision = string.Format("{0}º{1}", anio, division);
            bool flag = false;
            
            for (int i = 0; i < listaCursos.Count; i++)
            {
                if (listaCursos[i].AnioDivision == auxAnioDivision)
                {
                    rbdDatos.Text = (string)listaCursos[i];
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
            Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, division);

            if (alumno is null)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < listaCursos.Count; i++)
                {
                    if (listaCursos[i] == alumno)
                    {
                        listaCursos[i] += alumno;
                        MessageBox.Show("Alumno Agregado con Exito!");
                        break;
                    }
                }
                
            }

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
        }
    }
}
