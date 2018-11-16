using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
      public class Dao : IArchivos<Votacion>
      {
            static SqlConnection conexion;
            static SqlCommand comando;

            static Dao()
            {
              conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=votacion-sp-2018; Integrated Security=True");
              comando = new SqlCommand();
              comando.Connection = conexion;
              comando.CommandType = System.Data.CommandType.Text;
            }

            public bool Guardar(string rutaArchivo, Votacion objeto)
            {
                try
                {
                    String consulta = String.Format("INSERT INTO Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                        objeto.NombreLey, objeto.Afirmativos, objeto.Negativos,objeto.Abstencion, "Salvador Pedrozo");
                    conexion.Open();
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
                
                return true;
            }

            public Votacion Leer(string rutaArchivo)
            {
              throw new NotImplementedException();
            }
      }
}
