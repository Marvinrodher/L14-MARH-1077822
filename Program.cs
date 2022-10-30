using System;

namespace LAB_SEMANA_12_EJEMPLO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Opcion 1: ------>  Empleados y su fechas de nacimiento ");
            Console.WriteLine("Opcion 2: ------>  Empleados y salario a pagar ");
            Console.WriteLine("Opcion 3: ------>  Salir del programa");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    string[] nombredelostrabajadores  = new string[5];
                    int[] añodenacimiento = new int[5];

                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("Ingrese el nombre de la persona:");
                        nombredelostrabajadores[f] = Console.ReadLine();
                        Console.WriteLine("Ingrese año de nacimiento de la persona");
                        añodenacimiento[f] = int.Parse(Console.ReadLine());

                    }

  
                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("La edad de " + nombredelostrabajadores[f]);
                    }

                    break;
                case "2":
                    string[] puesto = new string[5];
                    int[] salario = new int[5];

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el puesto:  ");
                        puesto[i] = Console.ReadLine();

                        Console.WriteLine("Ingrese el salario: ");
                        salario[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("El puesto de " + puesto[i] + " un salario de " + salario[i]);
                    }


                    break;
                case "3":
                    Console.WriteLine("Finalazando programa");
                    break;

                default:
                    Console.WriteLine("Ninguna opcion seleccionada, cerrar el programa");
                    break;

            }
        }
    }   
}
   
