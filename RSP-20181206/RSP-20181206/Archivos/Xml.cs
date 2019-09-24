using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
  public class Xml<T> : IArchivos<T>
  {
    public void Guardar(string destino, T dato)
    {
      XmlTextWriter writer = new XmlTextWriter(destino, Encoding.UTF8);
      XmlSerializer ser = new XmlSerializer(typeof(T));
      ser.Serialize(writer, dato);

      if (!(writer is null))
      {
        writer.Close();
      }
    }

    public T Leer(string origen)
    {
      XmlTextReader reader = new XmlTextReader(origen);
      XmlSerializer ser = new XmlSerializer(typeof(T));

      T dato = (T)ser.Deserialize(reader);
      if (!(reader is null))
      {
        reader.Close();
      }
      return dato;
    }
  }
}
