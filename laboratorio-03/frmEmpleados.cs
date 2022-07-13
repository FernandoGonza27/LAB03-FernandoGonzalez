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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] datos = { "cedula", "nombre", "apellido_1", "sexo", "fecha_nacimiento" };

                DataTable informacionEmpleados = new DataTable();

                informacionEmpleados = Consultas.consultarTodosElementos("clientes", datos);

                dgvClientes.DataSource = informacionEmpleados;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {          
            try
            {
                if (!"".Equals(txbCedula.Text) && !"".Equals(txbNombre.Text) &&
                    !"".Equals(txbApellido.Text) && !"".Equals(txbSexo.Text))
                {
                    if (txbSexo.Text=="F" || txbSexo.Text =="M")
                    {
                        dynamic datos = new dynamic[5];
                        datos[0] = txbCedula.Text;
                        datos[1] = txbNombre.Text;
                        datos[2] = txbApellido.Text;
                        datos[3] = char.Parse(txbSexo.Text);
                        datos[4] = dtpFechaNacimineto.Value.ToString("dd/MM/yyyy");
                        
                        Consultas.enviarElementos("clientes", datos);
                        limpiar();
                        MessageBox.Show("Refresque con el boton de mostrar para ver cambios");
                    }
                    else
                    {
                        MessageBox.Show("El valor de sexo debe se indicado con F o M, de lo contrario sera rechazado");
                    }

                }
                else
                {
                    MessageBox.Show("No se pueden registrar empleados si existen espacios en blanco!!!");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!"".Equals(txbCedula.Text))
                {
                    Consultas.borrarElemento("clientes",txbCedula.Text);                    
                    MessageBox.Show("Refresque con el boton de mostrar para ver cambios");
                    limpiar();
                }
                else 
                {
                    MessageBox.Show("Debe colocar la cedula que desea borrar!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {

             txbCedula.Text = "";
             txbNombre.Text ="";
             txbApellido.Text = "";
             dtpFechaNacimineto.Value = DateTime.Now;
             txbSexo.Text = "";

        }
    }
}
