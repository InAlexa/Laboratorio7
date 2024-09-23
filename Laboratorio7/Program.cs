using Laboratorio7;
using System;

class program
{
    static void Main(string[] args)
    {
        EvaluarTexto evaluarTexto = new EvaluarTexto();
        int cat = 0;
        while (cat == 0)
        {
            try
            {
                Console.WriteLine("Escriba su texto");
                string texto = Console.ReadLine();
                Console.WriteLine("¿Desea evaluarlo?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No (Salir del programa)");
                int opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        if (evaluarTexto.Balanceado(texto))
                        {
                            Console.WriteLine("Está balanceado");
                        }
                        else
                        {
                            Console.WriteLine("No está balanceado");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Has salido del programa.");
                        cat = 1;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo con una de las opciones.");
                        Console.WriteLine("Presiona una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }


            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("Ha ocurrido un error de formato. " + ex.Message);
                Console.WriteLine("Presiona una tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Ha ocurrido un error. " + ex.Message);
                Console.WriteLine("Presiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}