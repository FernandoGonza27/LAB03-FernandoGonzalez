using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace capaDatos
{
    public class Conexion
    {

        private static NpgsqlConnection conn = new NpgsqlConnection("Server =localhost; Database=Codexa; User Id=Administrador; Password=1234;");

        public static void conectarPostgreSQL()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la base de datos realizada");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static void desconectarPostgreSQL()
        {
            conn.Close();
            Console.WriteLine("Desconexion con la base de datos realizada");

        }
        public static string insertarDatos(string tabla, dynamic[] datos)
        {
            try
            {
                //se conecta sql 
                conectarPostgreSQL();

                string campos = "(";

                for (int i = 0; i < datos.Length; i++)
                {
                    campos += "'" + datos[i] + "'";
                    if (i != datos.Length - 1)
                    {
                        campos += ",";

                    }

                }
                campos += ")";

                string insertSQL = "Insert into \"" + tabla + "\" (cedula,nombre,apellido_1,sexo,fecha_nacimiento) Values" + campos;//se crea el insert con los datos



                NpgsqlCommand ejecutar = new NpgsqlCommand(insertSQL, conn);//se crea el la consulta como comando

                ejecutar.ExecuteNonQuery();// se ejecuta la consulta ejecutar
                desconectarPostgreSQL();
            }
            catch (Exception)
            {

                return "Error";
            }
            finally
            {

                desconectarPostgreSQL();
            }
            return "OK";
        }

        public static DataTable consultarUnDato(string querry)
        {

            try
            {
                conectarPostgreSQL();

                NpgsqlCommand conector = new NpgsqlCommand(querry, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                desconectarPostgreSQL();



                return tabla;
            }
            catch (Exception)
            {
                return null;

            }

        }
        public static void borarUnDato(string tabla, string identificacion)
        {

            try
            {
                conectarPostgreSQL();
                string querry = "delete from \"" + tabla + "\" where cedula ="+"'"+ identificacion + "'";//se crea el delete con los datos
                NpgsqlCommand conector = new NpgsqlCommand(querry, conn);
                conector.ExecuteNonQuery();// se ejecuta la consulta ejecutar
                desconectarPostgreSQL();



                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

    }

}

