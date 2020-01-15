using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Mensaje
    {
        public void mensaje()
        {
            string valor = " ";
            Minombre mi = new Minombre();
            Console.WriteLine("   HOLA   ");
            Console.WriteLine("   Ya sabes mi nombre. ");
            mi.minombre();
            Console.WriteLine("   Cual es el tuyo? ");
            valor = Console.ReadLine();
            Console.WriteLine("  Tienes un bonito nombre.");
            Console.WriteLine("  Fue un placer charlar contigo, BYE.");

        }
    }
}
