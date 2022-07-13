using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void abrirForm(Form formNuevo)
        {

            formNuevo.TopLevel = false;
            formNuevo.FormBorderStyle = FormBorderStyle.None;
            formNuevo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formNuevo);
            formNuevo.BringToFront();
            formNuevo.Show();
        }
       

        private void btnCompras_Click_1(object sender, EventArgs e)
        {
            abrirForm(new frmCompras());
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            abrirForm(new frmEmpleados());
        }
    }
}
