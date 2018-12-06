using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sw = new StreamWriter(archivo, true);
            foreach (Patente p in datos)
            {
                sw.WriteLine(p.ToString());
            }
            
            sw.Close();
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            Patente aux;
            String patente = "";
            datos = new Queue<Patente>();
            while (!(sr.EndOfStream))
            {
                patente = sr.ReadLine();
                aux = patente.MetodoExtendido();
                datos.Enqueue(aux);
            }
            sr.Close();
        }
    }
}
