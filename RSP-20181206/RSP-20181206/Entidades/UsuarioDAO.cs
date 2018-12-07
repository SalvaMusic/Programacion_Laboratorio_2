using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
  public class UsuarioDAO
  {
    #region Atributos
    static SqlConnection conexion;
    static SqlCommand comando;
    #endregion

    #region Constructores
    static UsuarioDAO()
    {
      conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802; Integrated Security=True");
      comando = new SqlCommand();
      comando.Connection = conexion;
      comando.CommandType = System.Data.CommandType.Text;
    }
    #endregion

    #region Métodos
    /// <summary>
    /// Guardará objetos del tipo Usuario.
    /// </summary>
    /// <param name="u">Usuario que se guardará</param>
    public void Guardar(Usuario u) 
    {
      try
      {
        
          String consulta = String.Format("INSERT INTO Usuarios (nombre, clave) VALUES ('{0}', '{1}')", u.Nombre, u.Clave);
          conexion.Open();
          comando.CommandText = consulta;
          comando.ExecuteNonQuery();
        
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
    /// Leerá objetos del tipo Usuario.
    /// </summary>
    /// <param name="archivo">Nombre del archivo que se leerá</param>
    /// <param name="datos">Patente que leerá</param>
    public Usuario Leer(string usuario, string clave)
    {
      Usuario u = null;
      try
      {
        String consulta = String.Format("SELECT nombre, clave FROM Usuarios");
        conexion.Open();
        comando.CommandText = consulta;
        SqlDataReader oDr = comando.ExecuteReader();
        while (oDr.Read())
        {
          if ((oDr["nombre"].ToString() == usuario) && (oDr["clave"].ToString() == clave))
          {
            u = new Usuario(usuario, clave);
          }
        }
        conexion.Close();

      }
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      {
        conexion.Close();
      }
      return u;
    }
    #endregion
  }
}
