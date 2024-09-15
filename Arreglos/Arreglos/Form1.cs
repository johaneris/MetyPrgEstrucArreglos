using Arreglos.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        Dados daditos = new Dados();
        private const int lanzamientos = 3600; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            Tirar();

        }

        private void Tirar()
        {
            daditos.TirarDados(lanzamientos);
            //lamar al metodo
            int[] resultados = daditos.Resultados();
            lbResultados.Items.Clear(); //limpiar la lb

            for(int i = 0; i <= 12; i++)
            {
                lbResultados.Items.Add($"Suma: {i}" + $"---------- Frecuencia: {resultados[i]}");
            }

            MessageBox.Show($"El numero 7 aparecio {resultados[7]} veces", "resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }
    }
}
