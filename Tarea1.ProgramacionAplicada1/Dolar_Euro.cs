using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Dolar_Euro
    {
        public void dolar_euro()
        {
            float dolar = 0.0f;
            float euro = 0.0f;
            string valor1 = " ";
            float resultado = 0.0f;
            int opcion = 0;

            Console.WriteLine("1. Convertir de Dolar a Euro");
            Console.WriteLine("2. Convertir de Euro a Dolar");

            Console.WriteLine(" Dame una opcion");
            valor1 = Console.ReadLine();
            opcion = Convert.ToInt32(valor1);


            if (opcion == 1) //convertir de dolar a euro con tasa actual
            {
                Console.WriteLine(" Tasa de cambio actual del Dolar a Euro");
                valor1 = Console.ReadLine();
                dolar = Convert.ToSingle(valor1);
                Console.WriteLine(" Dame los euro");
                valor1 = Console.ReadLine();
                euro = Convert.ToSingle(valor1);
                resultado = dolar * euro;
                Console.WriteLine(" De Dolar a Euro  es {0} ", resultado);
            }
            else //////////////igual
                Console.WriteLine(" De Dolar a Euro  es {0} ", resultado);


        }
    }
}
