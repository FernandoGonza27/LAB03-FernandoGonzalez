using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static List<string> consultarClientes ()
        {
            try
            {
                List<string > clientes = new List<string>();

                string[] datos = { "cedula", "nombre", "apellido_1", "sexo", "fecha_nacimiento" };
                DataTable informacionClientes = new DataTable();

                informacionClientes = consultarTodosElementos("clientes", datos);
                if (informacionClientes.Rows.Count != 0)
                {
                    for (int i = 0; i < informacionClientes.Rows.Count; i++)
                    {
                        string cliente = "";
                        string cedula = (string)informacionClientes.Rows[i]["cedula"];
                        
                        string nombre = (string)informacionClientes.Rows[i]["nombre"];


                        cliente += cedula + " " + nombre;
                        clientes.Add(cliente);
                    }
                }
                else
                {
                    MessageBox.Show("La tabla no contiene datos ");
                }

            


                return clientes;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            return null;
        }
        public static List<string> consultarProductos()
        {
            try
            {
                
                List<string> productos = new List<string>();

                string[] datos = { "id_producto", "descripccion", "precio"};
                DataTable informacionProductos = new DataTable();

                informacionProductos = consultarTodosElementos("productos", datos);
                if (informacionProductos.Rows.Count != 0)
                {
                    for (int i = 0; i < informacionProductos.Rows.Count; i++)
                    {
                        string producto = "";
                        string id = (string)informacionProductos.Rows[i]["id_producto"];
                        string descripccion = (string)informacionProductos.Rows[i]["descripccion"];
                        string precio = (string)informacionProductos.Rows[i]["precio"];

                        producto += id +" "+ descripccion + " " + precio;
                        productos.Add(producto);

                    }
                }
                else
                {
                    MessageBox.Show("La tabla no contiene datos ");
                }




                return productos;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            return null;
        }

    }
}

