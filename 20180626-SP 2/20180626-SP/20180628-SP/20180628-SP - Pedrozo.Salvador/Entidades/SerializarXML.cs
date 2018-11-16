using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            { 
                XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);

                if (!(writer is null))
                {
                  writer.Close();
                }

            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e.Message);
            }
            return true;
        }

        public T Leer(string rutaArchivo)
        {
            T dato = default(T);
            try
            {
                XmlTextReader reader = new XmlTextReader(rutaArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));

                dato = (T)ser.Deserialize(reader);
                reader.Close();
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e.Message);
            }
                  

            return dato;
        }
    }
}
