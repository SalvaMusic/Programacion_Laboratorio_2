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
        static SqlCommand comando;

        static PersonaDAO()
        {
            conexion = new SqlConnection("Data Source = ./SQLEXPRESS;Initial Catalog = Persona; Integrated Security = True");
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }


        public void Guardar(Persona p)
        {
            String consulta = String.Format("INSERT INTO Personas (Nombre, Apellido)  VALUES ('{0}', '{1}')", p.Nombre, p.Apellido); 
            conexion.Open();
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();
            String consulta = String.Format("SELECT ID, Nombre, Apellido FROM Persona");
            conexion.Open();
            comando.CommandText = consulta;
            SqlDataReader oDr = comando.ExecuteReader();

            while (oDr.Read())
            {
                lista.Add(new Persona (oDr["ID"].ToString(), oDr["Nombre"].ToString(), oDr["Apellido"].ToString()));
            }

            conexion.Close();
         
            return lista; 
        }

        public Persona LeerPorID(string id)
        {
            String consulta = String.Format("SELECT ID, Nombre, Apellido FROM Persona WHERE ID = {0}",id);
            conexion.Open();
            comando.CommandText = consulta;
            SqlDataReader oDr = comando.ExecuteReader();

            if (oDr.Read())
            {
                Persona p = new Persona(id, oDr["Nombre"].ToString(), oDr["Apellido"].ToString());
                conexion.Close();
                return p;
            }

            conexion.Close();
            return null;
        }

        public void Modificar(string id, Persona p)
        {
            
            String consulta = String.Format("UPDATE Persona SET Nombre = '{0}', Apellido = '{1}' WHERE ID = {2}", id, p.Nombre, p.Apellido);
            conexion.Open();
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Borrar(string id)
        {
            String consulta = String.Format("DELETE FROM Persona WHERE ID = {0}", id);
            conexion.Open();
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
