using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOo
{
    public static class ArchivoTexto
    {
        public static bool Guardar (string path, string texto)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(texto);
            sw.Close();
            return true;
        }

        public static string Leer (string path)
        {
            if (!(File.Exists(path)))
            {
                throw new FileNotFoundException(); 
            }
            StreamReader sr = new StreamReader(path);
            string str = sr.ReadToEnd();
            sr.Close();

            return str;
        }
    }
}
