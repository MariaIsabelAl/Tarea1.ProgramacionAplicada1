using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Area_Perimetro
    {
        public void area_perimetro()
        {
            //variable 
            float lado = 0.0f;
            float bas = 0.0f;
            float altura = 0.0f;
            float longit = 0.0f;
            string valor = " ";
            float resultado = 0.0f;
            int opcion = 0;
            string respuesta = " ";

            do     // ciclo para repetir el menu del area y perimetro
            {
                Console.WriteLine(" 1. AREA ------2. PERIMETRO");
                Console.WriteLine(" Elija una opcion: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1) // opcion area
                {
                    Console.WriteLine("  AREA ");
                    Console.WriteLine(" 1.Triangulo");
                    Console.WriteLine(" 2.Cuadrado");
                    Console.WriteLine(" 3.Rectangulo");
                    Console.WriteLine(" Elija una opcion: ");
                    valor = Console.ReadLine();
                    opcion = Convert.ToInt32(valor);
                    switch (opcion)  /// opcion de diferentes poligino
                    {
                        case 1:
                            Console.WriteLine(" Triangulo");
                            Console.WriteLine(" Dame la base");
                            valor = Console.ReadLine();
                            bas = Convert.ToSingle(valor);
                            Console.WriteLine(" Dame la altura");
                            valor = Console.ReadLine();
                            altura = Convert.ToSingle(valor);
                            resultado = (bas * altura) / 2;
                            Console.WriteLine(" El Area del triangulo es {0}", resultado);
                            break;
                        case 2:
                            Console.WriteLine(" Cuadrado");
                            Console.WriteLine(" Dame el lado");
                            valor = Console.ReadLine();
                            lado = Convert.ToSingle(valor);
                            resultado = lado * lado;
                            Console.WriteLine(" El Area del cuadrado es {0}", resultado);
                            break;
                        case 3:
                            Console.WriteLine(" Rectangulo");
                            Console.WriteLine(" Dame el altura");
                            valor = Console.ReadLine();
                            altura = Convert.ToSingle(valor);
                            Console.WriteLine(" Dame la base");
                            valor = Console.ReadLine();
                            bas = Convert.ToSingle(valor);
                            resultado = altura * bas;
                            Console.WriteLine(" El Area del rectangulo es {0}", resultado);
                            break;
                        default:
                            Console.WriteLine(" Opion no valida");
                            break;
                    }



                }else if (opcion == 2) // opcion perimetro
                {
                    Console.WriteLine("  PERIMETRO ");
                    Console.WriteLine(" 1.Triangulo");
                    Console.WriteLine(" 2.Cuadrado");
                    Console.WriteLine(" 3.Rectangulo");
                    Console.WriteLine(" Elija una opcion: ");
                    valor = Console.ReadLine();
                    opcion = Convert.ToInt32(valor);
                    switch (opcion)
                    {
                        case 1:
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
                            Console.WriteLine(" El perimetro del triangulo es {0}", resultado);
                            break;
                        case 2:
                            Console.WriteLine(" Cuadrado");
                            Console.WriteLine(" Dame el lado");
                            valor = Console.ReadLine();
                            lado = Convert.ToSingle(valor);
                            resultado = lado + lado + lado + lado;
                            Console.WriteLine(" El perimetro del cuadrado es {0}", resultado);
                            break;
                        case 3:
                            Console.WriteLine(" Rectangulo");
                            Console.WriteLine(" Dame el altura");
                            valor = Console.ReadLine();
                            altura = Convert.ToSingle(valor);
                            Console.WriteLine(" Dame la base");
                            valor = Console.ReadLine();
                            bas = Convert.ToSingle(valor);
                            resultado = 2 * (altura + bas);
                            Console.WriteLine(" El perimetro del rectangulo es {0}", resultado);
                            break;
                        default:
                            Console.WriteLine(" Opion no valida");
                            break;
                    }
                }else
                    Console.WriteLine(" Opion no valida");

                Console.WriteLine(" Deseas volver al menu del area y el perimetro (si / no) ?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");/// fin del ciclo
            
        }
    }
}
