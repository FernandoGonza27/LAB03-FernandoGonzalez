using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Consultas
    {

        public static DataTable consultarTodosElementos(string tabla, string[] datos)
        {
            try
            {
                string querry = "Select ";

                for (int i = 0; i < datos.Length; i++)
                {
                    querry += "\"" + datos[i] + "\"";
                    if (i != datos.Length - 1)
                    {
                        querry += ",";

                    }

                }

                querry += " from \"" + tabla + "\"";

                DataTable resultado = Conexion.consultarUnDato(querry);

                return resultado;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            return null;
        }
        public static void enviarElementos(string tabla, dynamic[] datos)
        {
            try
            {
                Conexion.insertarDatos(tabla, datos);

            }
            catch (Exception e)
            {

            }
        }

        public static void borrarElemento(string tabla, string cedula)
        {
            try
            {
                Conexion.borarUnDato(tabla, cedula);

            }
            catch (Exception e)
            {

            }
        }

    }
}

