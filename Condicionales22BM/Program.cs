using System;
namespace Condicionales22BM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales if, else

            Console.WriteLine("---------------------------------");
            Console.WriteLine("--------Tramite Licencia---------");
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Ingresa tu nombre: ");
            string Nombre = Console.ReadLine();

            Console.WriteLine("\nIngresa tu edad: ");
            int Edad = int.Parse(Console.ReadLine());

            if (Edad >= 18)
            {
                Console.WriteLine("Ingresa el pago de 500");
                int pago = int.Parse(Console.ReadLine());
                if (pago >= 500)
                {
                    Console.WriteLine("Pago aceptado.");
                    Console.WriteLine("Tramite realizado.");
                }
                else
                {
                    Console.WriteLine("\nEl pago no esta completo.");
                    pago = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tramite realizado.");
                }
            }
            else
            {
                Console.WriteLine("No es posible realizar en este momento tu tramite.");
            }

        }
    }
}