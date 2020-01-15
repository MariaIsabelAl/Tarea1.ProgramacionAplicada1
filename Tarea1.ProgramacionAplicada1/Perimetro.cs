using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Perimetro
    {
        public void perimetro()
        {
            //variable 
            float lado = 0.0f;
            float bas = 0.0f;
            float altura = 0.0f;
            float longit = 0.0f;
            string valor = " ";
            float resultado = 0.0f;
            int opcion = 0;


            Console.WriteLine(" 1.Triangulo");
            Console.WriteLine(" 2.Cuadrado");
            Console.WriteLine(" 3.Rectangulo");

            Console.WriteLine(" Elija una opcion: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1) ///// opcion calcular perimetro triangulo
            {
                    Console.WriteLine(" Triangulo");
                    Console.WriteLine(" Dame la base");
                    valor = Console.ReadLine();
                    bas = Convert.ToSingle(valor);
                    Console.WriteLine(" Dame la altura");
                    valor = Console.ReadLine();
                    altura = Convert.ToSingle(valor);
                    Console.WriteLine(" Dame la longitud");
                    valor = Console.ReadLine();
                    longit = Convert.ToSingle(valor);
                    resultado = bas + altura + longit;
                    Console.WriteLine(" El perimetro del triangulo es {0}",resultado);
            }
            else if (opcion == 2)//////opcion calcular perimetro del cuadrado
                {
                        Console.WriteLine(" Cuadrado");
                        Console.WriteLine(" Dame el lado");
                        valor = Console.ReadLine();
                        lado = Convert.ToInt32(valor);
                        resultado = lado + lado + lado + lado ;
                        Console.WriteLine(" El perimetro del cuadrado es {0}", resultado);
                }
                else if (opcion == 3)/////opcion calcular perimetro del rectangulo
                {
                        Console.WriteLine(" Rectangulo");
                        Console.WriteLine(" Dame el altura");
                        valor = Console.ReadLine();
                        altura = Convert.ToSingle(valor);
                        Console.WriteLine(" Dame la base");
                        valor = Console.ReadLine();
                        bas = Convert.ToSingle(valor);
                        resultado =2 * (altura + bas);
                        Console.WriteLine(" El perimetro del rectangulo es {0}", resultado);
                }
                 else  
                    Console.WriteLine(" Opcion no valida");
                    
         
        }
    }
}
