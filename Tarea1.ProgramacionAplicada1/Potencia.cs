using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Potencia
    {
        public void potencia()
        {
            int ba=0;
            int exp;
            int re = 1;
            string valor = " ";
            
            Console.WriteLine(" Dame una base");
            valor = Console.ReadLine();
            ba = Convert.ToInt32(valor);

            Console.WriteLine(" Dame una base");
            valor = Console.ReadLine();
            exp = Convert.ToInt32(valor);

            for (int i = 0; i < exp; i++) //calculando la potencia
                   re = re * ba;
           Console.WriteLine("{0} elevado {1} es {2}", ba, exp, re);
           

        }
    }
}

