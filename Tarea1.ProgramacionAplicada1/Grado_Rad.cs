using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Grado_Rad
    {
        public void grado_rad()
        {
            //variable
            float grado = 0.0f;
            float pi = 3.1415f;
            string valor = " ";
            float resultado = 0.0f;

            Console.WriteLine(" Dame el grado a convertir ");
            valor = Console.ReadLine();
            grado = Convert.ToSingle(valor);

            if (grado == 0)
                Console.WriteLine(" Radianes es cero");
            else
                resultado = (grado * pi) / 180; ///convertir de grado a radianes

            Console.WriteLine(" Conversion de grado {0} a radianes es {1}", grado, resultado);


        }
    }
}
