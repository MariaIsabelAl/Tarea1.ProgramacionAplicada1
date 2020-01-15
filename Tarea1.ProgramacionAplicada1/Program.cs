using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea1.ProgramacionAplicada1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables a necesitar
            int opcion = 0; // opcion del switch
            string valor = " ";
            string respuesta = " "; //control del ciclo

            //declaracion de clases
            Minombre mi = new Minombre();
            Mensaje me = new Mensaje();
            Perimetro pe = new Perimetro();
            Grado_Rad gra = new Grado_Rad();
            Celsius te = new Celsius();
            Dolar_Euro dol = new Dolar_Euro();
            Par_Impar p = new Par_Impar();
            Semana s = new Semana();
            Area_Perimetro ap = new Area_Perimetro();
            Tabla ta = new Tabla();
            Potencia po = new Potencia();
            Edad e = new Edad();

            //mostrar menu pricipal
            Console.WriteLine("                                      MENU                          ");
            Console.WriteLine(" Capitulo 1");
            Console.WriteLine(" 1.Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.");
            Console.WriteLine(" 2.Agregue más mensajes a la aplicación que ha creado.");
            
            Console.WriteLine(" Capitulo 2");
            Console.WriteLine(" 3.Hacer un programa que calcule el perímetro de cualquier polígono regular.");
            Console.WriteLine(" 4.Hacer un programa que transforme de grados a radianes.");
            Console.WriteLine(" 5.Hacer un programa que transforme de grados centígrados a grados Fahrenheit.");
            Console.WriteLine(" 6.Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.");
            
            Console.WriteLine(" Capitulo 3");
            Console.WriteLine(" 7.Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.");
            Console.WriteLine(" 8.Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.");
            Console.WriteLine(" 9.Hacer un programa que pueda calcular el perímetro y el área de cualquier polígono regular, pero que le pregunte al usuario qué desea calcular.");
            
            Console.WriteLine(" Capitulo 4");
            Console.WriteLine(" 10.Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.");
            Console.WriteLine(" 11.Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.");
            Console.WriteLine(" 12.Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven.");
            do//////////ciclo para repetir el menu principal
            {
                Console.WriteLine(" Elija una opcion del menu principal: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" Capitulo 1, ejercicio 1");
                        mi.minombre();
                        break;
                    case 2:
                        Console.WriteLine(" Capitulo 1, ejercicio 5");
                        me.mensaje();
                        break;
                    case 3:
                        Console.WriteLine(" Capitulo 2, ejercicio 1");
                        pe.perimetro();
                        break;
                    case 4:
                        Console.WriteLine(" Capitulo 2, ejercicio 3");
                        gra.grado_rad();
                        break;
                    case 5:
                        Console.WriteLine(" Capitulo 2, ejercicio 4");
                        te.celsius();
                        break;
                    case 6:
                        Console.WriteLine(" Capitulo 2, ejercicio 5");
                        dol.dolar_euro();
                        break;
                    case 7:
                        Console.WriteLine(" Capitulo 3, ejercicio 1");
                        p.par_impar();
                        break;
                    case 8:
                        Console.WriteLine(" Capitulo 3, ejercicio 4");
                        s.semana();
                        break;
                    case 9:
                        Console.WriteLine(" Capitulo 3, ejercicio 5");
                        ap.area_perimetro();
                        break;
                    case 10:
                        Console.WriteLine(" Capitulo 4, ejercicio 1");
                        ta.tabla();
                        break;
                    case 11:
                        Console.WriteLine(" Capitulo 4, ejercicio 2");
                        po.potencia();
                        break;
                    case 12:
                        Console.WriteLine(" Capitulo 4, ejercicio 5");
                        e.edad();
                        break;

                    default:
                        Console.WriteLine(" Opcion no valida");
                        break;

                }
                Console.WriteLine("  ");
                Console.WriteLine(" Deseas volver al Menu Principal (si / no) ?");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");
            

        }
    }
}
