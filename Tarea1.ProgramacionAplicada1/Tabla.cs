using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Tabla
    {
        public void tabla()
        {
            int nu=0;
            string val = " ";
            int resul;

            Console.WriteLine(" Dame un numero para calcular la tabla");
            val = Console.ReadLine();
            nu = Convert.ToInt32(val);

            for(int y = 0; y <=10;y++) /// ciclo para calcular la tabla de multiplicacion
            {
                resul = nu * y;
                Console.WriteLine(" {0} x {1} = {2}", nu, y, resul);
            }

                
        }
    }
}
