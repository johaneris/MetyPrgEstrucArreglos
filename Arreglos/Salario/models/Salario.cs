using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario.models
{
    internal class Salario2
    {
        public int[] contadores = new int[9];

        // Método para calcular el salario 
        public void CalcularSalario(double ventasBrutas)
        {
            // Calcula el salario del vendedor
            double salario = 200 + (ventasBrutas * 0.09);

            // rando del salario 
            if (salario >= 200 && salario < 300)
            {
                contadores[0]++;
            }
            else if (salario >= 300 && salario < 400)
            {
                contadores[1]++;
            }
            else if (salario >= 400 && salario < 500)
            {
                contadores[2]++;
            }
            else if (salario >= 500 && salario < 600)
            {
                contadores[3]++;
            }
            else if (salario >= 600 && salario < 700)
            {
                contadores[4]++;
            }
            else if (salario >= 700 && salario < 800)
            {
                contadores[5]++;
            }
            else if (salario >= 800 && salario < 900)
            {
                contadores[6]++;
            }
            else if (salario >= 900 && salario < 1000)
            {
                contadores[7]++;
            }
            else if (salario >= 1000)
            {
                contadores[8]++;
            }
        }

        // Método para obtener los resultados 
        public string MostrarResultados()
        {
            string resultado = "Salarios:\n";
            resultado += "$200 - $299: " + contadores[0] + "\n";
            resultado += "$300 - $399: " + contadores[1] + "\n";
            resultado += "$400 - $499: " + contadores[2] + "\n";
            resultado += "$500 - $599: " + contadores[3] + "\n";
            resultado += "$600 - $699: " + contadores[4] + "\n";
            resultado += "$700 - $799: " + contadores[5] + "\n";
            resultado += "$800 - $899: " + contadores[6] + "\n";
            resultado += "$900 - $999: " + contadores[7] + "\n";
            resultado += "$1000 o más: " + contadores[8] + "\n";
            return resultado;
        }
    }
}
