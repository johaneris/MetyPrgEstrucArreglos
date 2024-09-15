using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.models
{
    internal class Dados
    {
        //Arreglo d 13 supongo q pq el indicie empieza con 0

        private int[] contador = new int[13];

        public void TirarDados(int intentos)
        {
            Random rand = new Random();
            

            Random random = new Random();

            for(int i = 0; i < intentos; i++)
            {
                int dado1 = rand.Next(1, 7);
                int dado2 = rand.Next(1, 7);
                int suma = dado1 + dado2;

                //incrementar el contador a medida que se ritere dentro del arreglo

                contador[suma]++;

            }
        }

        //hacer un metodo para obtener las suas
        public int[] Resultados()
        {
            return contador;
        }
    }
}
