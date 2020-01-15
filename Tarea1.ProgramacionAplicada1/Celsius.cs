using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Celsius
    {
        public void celsius()
        {
            float c = 0.0f;
            float resultado = 0.0f;
            string valor = " ";

            Console.WriteLine(" Dame la temperatura en Celsius");
            valor = Console.ReadLine();
            c = Convert.ToSingle(valor);
            
            resultado = ((32 * c) * (9 / 5)) + 32;
            Console.WriteLine(" Conversion de Celsius {0} a Fahrenheit es {1}",c,resultado);


        }

     
    }
}
