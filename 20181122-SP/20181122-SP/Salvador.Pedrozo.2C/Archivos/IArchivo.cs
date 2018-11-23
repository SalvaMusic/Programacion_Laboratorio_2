using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    /// <summary>
    /// Interface para manejar archivos
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IArchivo<T>
    {
        /// <summary>
        /// Guardará objetos.
        /// </summary>
        /// <param name="archivo">Nombre del archivo donde se guardará</param>
        /// <param name="datos">Objeto que se guardará</param>
        void Guardar(string archivo, T datos);

        /// <summary>
        /// Leerá objetos.
        /// </summary>
        /// <param name="archivo">Nombre del archivo que se leerá</param>
        /// <param name="datos">Objeto que leerá</param>
        void Leer(string archivo, out T datos);
    }
}
