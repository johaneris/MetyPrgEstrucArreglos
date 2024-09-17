using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendedores.models;

namespace Vendedores
{
    public partial class Form1 : Form
    {
        Vendedores2 ventas = new Vendedores2();
        int vendedor;
        int producto;
        double monto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
            try
            {
                //int vendedor = int.Parse(tbVendedor.Text);
                //int producto = int.Parse(tbProducto.Text);
                //double total = double.TryParse(tbMonto.Text);

                //ventas.AgregarVenta(vendedor, producto, total);
                //MessageBox.Show("Se agrego la venta");

                //lbResultados.Items.Clear();
                //lbResultados.Items.Add(ventas.Show1());

                if(!int.TryParse(tbVendedor.Text, out vendedor) || vendedor < 1 || vendedor >4)
                {
                    MessageBox.Show("Ingrese un numero valido");
                    return;
                }

                if(!int.TryParse(tbProducto.Text, out producto) || producto < 1 || producto > 5)
                {
                    MessageBox.Show("ingrese un numero valido");
                    return;
                }

                if(!double.TryParse(no.Text, out monto) || monto <= 0){
                    MessageBox.Show("Ingrese un numero valido");
                    return;
                }
                //aqui agrego la venta
                ventas.AgregarVenta(vendedor, producto, monto);
                MessageBox.Show("Se agrego la venta");

                lbResultados.Items.Clear();
                lbResultados.Items.Add("Se agrego la venta");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
