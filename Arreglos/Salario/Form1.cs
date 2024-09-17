using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salario.models;

namespace Salario
{
    public partial class Form1 : Form
    {
        Salario2 comisiones = new Salario2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ventas;

            // Validar que el usuario haya ingresado un número válido
            if (double.TryParse(tbVentas.Text, out ventas))
            {
                // Calcular el salario y actualizar el contador correspondiente
                comisiones.CalcularSalario(ventas);

                // Mostrar el resultado en el ListBox
                lbResultados.Items.Clear();
                lbResultados.Items.Add(comisiones.MostrarResultados());
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido");
            }
        }
    }
}
