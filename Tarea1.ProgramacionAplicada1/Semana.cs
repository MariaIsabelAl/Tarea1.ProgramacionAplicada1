using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Semana
    {
        public void semana()
        {
            int numero;
            string va = " ";
            string respuesta = " ";

            do ////ciclo de poner otro numero y saber que dia de la semana es
            {
                Console.WriteLine(" Dame un numero del 1 al 7");
                va = Console.ReadLine();
                numero = Convert.ToInt32(va);
                /////////////////////////////opciones para saber el dia de la semana
                if (numero == 1) 
                    Console.WriteLine(" Es Lunes");
                else if (numero == 2)
                    Console.WriteLine(" Es Martes");
                else if (numero == 3)
                    Console.WriteLine(" Es Miercoles");
                else if (numero == 4)
                    Console.WriteLine(" Es Jueves");
                else if (numero == 5)
                    Console.WriteLine(" Es Viernes");
                else if (numero == 6)
                    Console.WriteLine(" Es Sabado");
                else if (numero == 7)
                    Console.WriteLine(" Es Domingo");
                else
                    Console.WriteLine(" numero incorrecto");
                Console.WriteLine(" Deseas poner otro numero (si / no) ?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");
        }
    }
}
