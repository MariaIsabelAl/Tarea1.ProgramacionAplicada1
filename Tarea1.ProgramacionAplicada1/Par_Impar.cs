using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Par_Impar
    {
        public void par_impar()
        {
            int nu ;
            string val = " ";
            string respuesta = " ";

            do
            {
                Console.WriteLine(" Dame un numero entero");
                val = Console.ReadLine();
                nu = Convert.ToInt32(val);
                if (nu % 2 == 0)   ///// calcular si es par o impar
                    Console.WriteLine(" {0} es Par", nu);
                else
                    Console.WriteLine(" {0} es Impar", nu);

                Console.WriteLine(" Deseas poner otro numero (si / no) ?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");

        }
    }
}
