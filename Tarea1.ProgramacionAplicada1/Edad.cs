using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Edad
    {
        public void edad()
        {
            //variables
            int ed;
            string valor = " ";
            int mayor = 0;
            int menor = 0;
            float promedio = 0.0f;
            int cat = 0;
            float suma = 0;

            Console.WriteLine(" Dame la cantidad de edad");
            valor = Console.ReadLine();
            cat = Convert.ToInt32(valor);

            for(int i = 0; i < cat ;i++)// ciclo para que se repita dependiendo de la cantidad de edad
            {

                Console.WriteLine(" Dame una edad");
                valor = Console.ReadLine();
                ed = Convert.ToInt32(valor);

                suma += ed;
               ////saber cual es el menor y mayor
                if (i == 0)
                {
                    mayor = ed;
                    menor = ed;
                }else if (i != 0)
                {
                    if (ed < menor)
                        menor = ed;

                    if (ed > mayor)
                        mayor = ed;
                        
                }
                    
               

            } 
            promedio = suma / cat;//////calculamos el promedio
            Console.WriteLine(" El promedio de edad es {0}", promedio);
            Console.WriteLine(" la edad mas grande {0}", mayor);
            Console.WriteLine(" la edad menor {0}", menor);
        }
       
    }
}
