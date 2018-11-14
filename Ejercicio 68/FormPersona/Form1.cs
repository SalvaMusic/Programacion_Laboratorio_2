using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPersona
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private event DelegadoString evento;
        public Form1()
        {
            InitializeComponent();
        }

        private static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                buttonClear.Name = "Actualizar";
                NotificarCambio("Se ha creado Una Persona\n" + persona.Mostrar());
               
            }
            else
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                NotificarCambio("Se ha modificado Una Persona\n" + persona.Mostrar());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            evento += NotificarCambio;
            
        }
    }
}
