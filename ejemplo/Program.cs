using System;
class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("== Ventas variadas ==");
            Console.WriteLine("1. Transistores");
            Console.WriteLine("2. Capacitores");
            Console.WriteLine("3. Leds");
            Console.WriteLine("4. Salir");
            Console.WriteLine("============");
            Console.Write("Seleccione una opción: ");

            string opcion =Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Has seleccionado la opcion 1.");
                    // Llogica para la opción 1
                    break;

                case "2":
                    Console.WriteLine("Has seleccionado la opcion 2.");
                    // Llogica para la opción 2
                    break;

                case "3":
                    Console.WriteLine("Has seleccionado la opcion 3.");
                    // Llogica para la opción 3
                    break;

                case "4":
                    Console.WriteLine("Has seleccionado la opcion 4.");
                    // Llogica para la opción 4
                    break;

                default:
                    Console.WriteLine("Opcion no valida. intente de nuevo.");
                    break;

                if (continuar)
                    {
                        Console.WriteLine("Precione cualquier tecla para continuar... ");
                        Console.ReadKey();
                    }
                   
            }
        }
    }
}