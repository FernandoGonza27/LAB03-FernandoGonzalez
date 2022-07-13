using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    class Productos
    {


        private string id { get; set; }

        private string nombre { get; set; }
        private double precio { get; set; }



        public Productos(string pIdentificacion, string pNombre, double pPrecio)
        {
            this.id = pIdentificacion;
            this.nombre = pNombre;
            this.precio = pPrecio;
        }
        public Productos() { }

        public string Id   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public string Nombre   // property
        {
            get { return nombre; }   // get method
            set { nombre = value; }  // set method
        }
        public double Precio   // property
        {
            get { return precio; }   // get method
            set { precio = value; }  // set method
        }
    }
}
