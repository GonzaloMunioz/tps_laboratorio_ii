using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraXML<T> : ISerializadora<T> where T : class // TEMA 12 - TIPOS GENÉRICOS, TEMA 13 - INTERFACES
    {
        static string ruta;

        static SerializadoraXML()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializados\ArchivosXML";
        }

        /// <summary>
        /// Serializa un objeto y lo guarda en un archivo XML
        /// </summary>
        /// <param name="elemento"> Elemento a serializar </param>
        /// <param name="nombreArchivo"> Nombre del archivo a escribir </param>
        public void Serializar(T elemento, string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"\Serializadora-{nombreArchivo}.xml"; 

            try
            {
                if(!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta)) // TEMA 14 - ARCHIVOS
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T)); // TEMA 15 - SERIALIZACIÓN
                    xmlSerializer.Serialize(sw, elemento);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deserializa un archivo XML, retornando un objeto que contiene la información retribuida
        /// </summary>
        /// <param name="nombreArchivo"> Nombre del archivo a leer </param>
        /// <returns> Retorna el objeto deserializado </returns>
        public T Deserializar(string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"\Serializadora-{nombreArchivo}.xml";
            T elemento = null;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    elemento = (T) xmlSerializer.Deserialize(sr);
                }

                return elemento;
            }
            catch (Exception)
            {
                throw new ArchivoNoEncontradoException("No se ha encontrado el archivo o es inexistente"); // TEMA 10 - EXCEPCIONES
            }
        }
    }
}

