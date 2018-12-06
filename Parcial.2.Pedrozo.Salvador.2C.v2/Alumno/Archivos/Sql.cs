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
    public class Sql : IArchivo<Queue<Patente>>
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
        /// Guardará objetos del tipo Cola de patentes.
        /// </summary>
        /// <param name="archivo">Nombre del archivo donde se guardará</param>
        /// <param name="datos">Cola de patentes que se guardará</param>
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            try
            {
                foreach (Patente p in datos)
                {
                    String consulta = String.Format("INSERT INTO Patentes (patente, tipo) VALUES ('{0}', '{1}')", p.CodigoPatente, p.TipoCodigo.ToString());
                    conexion.Open();
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

        /// <summary>
        /// Leerá objetos del tipo patente.
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se leerá</param>
        /// <param name="datos">Patente que leerá</param>
        public void Leer(string archivo, out Queue<Patente> datos)
        {
            try
            {
                String consulta = String.Format("SELECT patente, tipo FROM Patentes");
                conexion.Open();
                comando.CommandText = consulta;
                SqlDataReader oDr = comando.ExecuteReader();
                Queue<Patente> patenesAux = new Queue<Patente>();
                while (oDr.Read())
                {
                    if (oDr["tipo"].ToString() == Patente.Tipo.Mercosur.ToString())
                    {
                        patenesAux.Enqueue(new Patente(oDr["patente"].ToString(), Patente.Tipo.Mercosur));
                    }
                    else
                    {
                        patenesAux.Enqueue(new Patente(oDr["patente"].ToString(), Patente.Tipo.Vieja));
                    }
                }
                conexion.Close();
                datos = patenesAux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion
    }
}
