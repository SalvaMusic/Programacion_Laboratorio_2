using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Ejercicio_57
{
    
    public class Persona
    {
        private string apellido;
        private string nombre;

        public Persona() { }
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public static void Guardar(Persona persona, string path)
        {
            
            XmlTextWriter writer = null;  //Objeto que escribirá en XML.
            XmlSerializer ser;     //Objeto que serializará.

            //Se indica ubicación del archivo XML y su codificación.
            try
            {
                writer = new XmlTextWriter(path, Encoding.UTF8);
                //Se indica el tipo de objeto ha serializar.
                ser = new XmlSerializer(typeof(Persona));
                //Serializa el objeto persona en el archivo contenido en writer.
                ser.Serialize(writer, persona);
            }
            catch(InvalidOperationException e)
            {
                
            }
            catch (FileNotFoundException e)
            {

            }
            catch(ArgumentException)
            {
                Persona.Guardar(persona, "Personas.xml");
            }
            finally
            {
                //Se cierra la conexión al archivo
                if (!(writer is null))
                writer.Close();

            }
            
            
            
            

        }

        public static Persona Leer(string path)
        {
            XmlTextReader reader;   //Objeto que leerá XML.
            XmlSerializer ser;      //Objeto que Deserializará.

            //Se indica ubicación del archivo XML.
            reader = new XmlTextReader(path);
            //Se indica el tipo de objeto ha serializar.
            ser = new XmlSerializer(typeof(Persona));
            //Deserializa el archivo contenido en reader, lo guarda en aux.
            Persona aux = (Persona)ser.Deserialize(reader);
            //Se cierra el objeto reader.
            reader.Close();

            return aux;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0}, {1}", this.Apellido, this.Nombre);
        
            return datos.ToString();
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


    }
}
