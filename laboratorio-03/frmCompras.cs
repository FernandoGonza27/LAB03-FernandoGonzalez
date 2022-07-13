using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace laboratorio_03
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string[] datos = { "id_cliente", "id_producto", "fecha_compra"};

            DataTable informacionCompras = new DataTable();

            informacionCompras = Consultas.consultarTodosElementos("clientes", datos);

            dgvCompras.DataSource = informacionCompras;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
