using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerializadoraJSON<T> : ISerializadora<T> where T : class // TEMA 12 - TIPOS GENÉRICOS, TEMA 13 - INTERFACES
    {
        static string ruta;

        static SerializadoraJSON()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializados\ArchivosJSON";
        }
        
        /// <summary>
        /// Serializa un objeto y lo guarda en un archivo JSON
        /// </summary>
        /// <param name="elemento"> Elemento a serializar </param>
        /// <param name="nombreArchivo"> Nombre del archivo a escribir </param>
        public void Serializar(T elemento, string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"\Serializadora-{nombreArchivo}.json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string elementoJSON = JsonSerializer.Serialize(elemento); // TEMA 15 - SERIALIZACIÓN
                File.WriteAllText(rutaCompleta, elementoJSON); // TEMA 14 - ARCHIVOS
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deserializa un archivo JSON, retornando un objeto que contiene la información retribuida
        /// </summary>
        /// <param name="nombreArchivo"> Nombre del archivo a leer </param>
        /// <returns></returns>
        public T Deserializar(string nombreArchivo)
        {
            string rutaCompleta = ruta + @$"\Serializadora-{nombreArchivo}.json";
            T elemento = null;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string elementoJson = File.ReadAllText(rutaCompleta);
                elemento = JsonSerializer.Deserialize<T>(elementoJson);

                return elemento;
            }
            catch (Exception)
            {
                throw new ArchivoNoEncontradoException("No se ha encontrado el archivo especificado o es inexistente"); // TEMA 10 - EXCEPCIONES
            }
        }
    }
}
