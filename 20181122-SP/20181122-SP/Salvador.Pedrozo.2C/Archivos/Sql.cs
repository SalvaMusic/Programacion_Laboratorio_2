using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    /// <summary>
    /// Clase para Trabajar con base de datos
    /// </summary>
    public class Sql : IArchivo<Patente>
    {
        #region Atributos
        static SqlConnection conexion;
        static SqlCommand comando;
        #endregion

        #region Constructores
        static Sql()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=patentes-sp-2018; Integrated Security=True");
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Guardará objetos del tipo patente.
        /// </summary>
        /// <param name="archivo">Nombre del archivo donde se guardará</param>
        /// <param name="datos">Patente que se guardará</param>
        public void Guardar(string archivo, Patente datos)
        {
            String consulta = String.Format("INSERT INTO Patentes (patente, tipo) VALUES ('{0}', '{1}')", datos.CodigoPatente, datos.TipoCodigo);
            conexion.Open();
            comando.CommandText = consulta;
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// Leerá objetos del tipo patente.
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se leerá</param>
        /// <param name="datos">Patente que leerá</param>
        public void Leer(string archivo, out Patente datos)
        {
            String consulta = String.Format("SELECT patente, tipo FROM Patentes");
            conexion.Open();
            comando.CommandText = consulta;
            SqlDataReader oDr = comando.ExecuteReader();
           
            datos = new Patente(oDr["patente"].ToString(), (Patente.Tipo)oDr["tipo"]);
        } 
        #endregion
    }
}
