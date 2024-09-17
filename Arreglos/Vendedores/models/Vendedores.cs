using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores.models
{
    internal class Vendedores2
    {
        // la coma es lo que indica quee es un arreglo bidimensional, double para que las ventas puedan ser flotantes

        public double[,] ventas = new double[4, 5];
        string final;

        //crear un metodo para agregar las ventas al arreglo
        public void AgregarVenta(int vendedor, int producto, double monto)
        {

            if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5)
            {
                ventas[producto - 1, vendedor - 1] += monto;
            }
            else
            {
                throw new ArgumentException("El numero esta fuera del rango");
            }

        }

        public double TotalPorVendedor(int vendedor)
        {
            double total = 0;
            for(int i = 0; i < 5; i++)
            {
                total += ventas[i, vendedor - 1];
            }


            return total;



        }

        public double TotalPorProucto(int productos)
        {
            double total2 = 0;
            for (int i = 0;i < 4; i++)
            {
                total2 += ventas[productos - 1, i];

            }

            return total2;
        }


        public string Show1()
        {
          

            for (int i = 0; i < 5; i++)
            {
                 final = "ventas por producto y vendedor:\n";

                final += $"producto {i + 1} :";

                for (int j = 0; j < 4; j++)
                {
                    final += ventas[i, j].ToString("F2") + "\t"; //formato con dos decimales

                }

                final += "total producto: " + TotalPorProucto(i + 1).ToString("F2") + "\n";


            }

            final += "Totales por vendedor:\n";
            for(int k =0; k < 4; k++)
            {
                final += "Vendedor " + (k + 1) + ":" + TotalPorVendedor(k + 1) + ":" + TotalPorVendedor(k + 1).ToString("F2") + "\n";           
            }

            return final; 
        }

    }
}
