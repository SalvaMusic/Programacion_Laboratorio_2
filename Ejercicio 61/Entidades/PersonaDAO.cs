using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        static SqlConnection conexion;
        private SqlCommand comando;

        static PersonaDAO()
        {
            conexion = new SqlConnection("Data Source = ./SQLEXPRESS;Initial Catalog = Persona; Integrated Security = True");
        }


        public void Guardar(Persona p)
        {
            String consulta = String.Format("INSERT INTO Personas (Nombre, Apellido)  VALUES ('{0}', '{1}')", p.Nombre, p.Apellido); 
            conexion.Open();
            comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Persona> Leer()
        {
            List<Persona> lista = null;

            "SELECT nombre FROM Personas";
            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();

            while (oDr.Read())
            {
                string aux = oDr["nombre"].ToString();
            }




            return lista; 
        }
    }
}
