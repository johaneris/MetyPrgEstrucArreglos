using Reservacion.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservacion
{
    public partial class Form1 : Form
    {
        Asientos avion = new Asientos();
        int seccion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (rbFumar.Checked)
                {
                    seccion = 1;
                }
                else if(rbNoFuma.Checked){
                    seccion = 2;
                }
                else
                {
                    MessageBox.Show("Por favor selecciones una opcion de seccion");
                    return;
                }

                menu();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void menu()
        {
            switch (seccion)
            {
                case 1:
                    int Fumador = avion.Fumadores();
                    if (Fumador != -1)
                    {
                        lbResultados.Items.Add($"su asiento es {Fumador}, en la seccion de fumadores");
                    }
                    else
                    {
                        lbResultados.Items.Add(avion.Cambio(1));
                    }
                    break;

                case 2: 
                    int asientoNoFumador = avion.NoFumadores();
                    if (asientoNoFumador != -1)  
                    {
                        lbResultados.Items.Add($"Su asiento es  {asientoNoFumador} en la sección de no fumar.");
                    }
                    else  
                    {
                        lbResultados.Items.Add(avion.Cambio(2));  
                    }
                    break;
                default:
                    MessageBox.Show("opcion invalida");
                    break;

            }
        }
    }
}
