using System;

namespace Clase_con_Repositorio
{
    class Program
    {
        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Calculadora de Operaciones ===");
                Console.WriteLine("1) Potencia");
                Console.WriteLine("2) SumaNaturales");
                Console.WriteLine("3) Fibonacci");
                Console.WriteLine("Presiona 'Esc' para salir");
                Console.Write("Selecciona una opción: ");

                // Si el usuario presiona Esc, salimos del bucle
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Potencia.Ejecutar();
                        break;
                    case "2":
                        SumaNaturales.Ejecutar();
                        break;
                    case "3":
                        Fibonacci.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presiona cualquier tecla para volver al menú, o 'Esc' para salir.");
                var tecla = Console.ReadKey(true).Key;
                if (tecla == ConsoleKey.Escape)
                    salir = true;
            }
        }
    }
}
