using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservacion.models
{

    internal class Asientos
    {
        //numero de asientos
        private int[] asientos = new int[10];


        //constructor
        public Asientos()
        {
            for (int i = 0; i < 10; i++)
            {
                asientos[i] = 0;
            }

        }

        //metodo para asignar los asientos a los fumadores

        public int Fumadores()
        {
            for (int i = 0; i < 5; i++)
            {
                if (asientos[i] == 0)
                {
                    asientos[i] = 1;
                    return i + 1;
                }
            }

            return -1;
        }

        public int NoFumadores()
        {
            for (int i = 5; i < 10; i++)
            {
                if (asientos[i] == 0)
                {
                    asientos[i] = 1;
                    return i + 1;
                }
            }

            return -1;

        }

        public string Cambio(int seccion)
        {
            if(seccion == 1)
            {
                int asientoNoFuma = NoFumadores();
                if(asientoNoFuma != -1)
                {
                    return $"La seccion de fumadores esta llena, se le asigno el asiento {asientoNoFuma} en la seccion de no fumadores";
                }
                else if(seccion == 2){
                    int asientoFumador = Fumadores();
                    if( asientoFumador != -1)
                    {
                        return $"LA seccion de o fumadores esta llena. Se le ha asignador el asiento {asientoFumador} en la seccion de los fumadores";
                    }

                }

                
            }
            return "el vuelo esta lleno, el siguiente sale en 3 horas";
        }




        }

    }
