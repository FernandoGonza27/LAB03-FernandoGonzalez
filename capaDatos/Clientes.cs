using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Clientes
    {


        private string cedula { get; set; }
        
        private string nombre { get; set; }
        private string primerApellido { get; set; }
        


        public Clientes( string pIdentificacion, string pNombre, string pPrimerApellido)
        {
            this.cedula = pIdentificacion;            
            this.nombre = pNombre;
            this.primerApellido = primerApellido;
        }
        public Clientes() { }

        public string Cedula   // property
        {
            get { return cedula; }   // get method
            set { cedula = value; }  // set method
        }
        public string Nombre   // property
        {
            get { return nombre; }   // get method
            set { nombre = value; }  // set method
        }
        public string Apellido   // property
        {
            get { return primerApellido; }   // get method
            set { primerApellido = value; }  // set method
        }

    }

}
