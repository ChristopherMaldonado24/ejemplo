using System;
class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("== Ventas de Perfumes ==");
            Console.WriteLine("1. Damas");
            Console.WriteLine("2. Caballeros");
            Console.WriteLine("3. Infantiles");
            Console.WriteLine("4. Salir");
            Console.WriteLine("============");
            Console.Write("Seleccione una opción: ");

            string Categoria =Console.ReadLine();
            Double Precio = 0;

            switch (Categoria)
            {
                case "1":
                    // Llogica para la opción 1
                    Console.WriteLine(" Perfumes para damas");
                    Console.WriteLine("1. Givenchy ");
                    Console.WriteLine("2. Paco Rabanne ");
                    Console.WriteLine("3. Carolina Herrera ");
                    string Pdamas =Console.ReadLine();
                    
                    switch (Pdamas)
                    { case "1":
                            Console.WriteLine(" Seccion de Givenchy ");
                            Console.WriteLine("Elija el modelo deseado");
                            Console.WriteLine("  1. Linterdit Absolute Intense EAU de PARFUM 80ML Costo:3,929.Lps");
                            Console.WriteLine("  2. Irresistible VeryFloral EAU de PATFUM 50ML Costo:3,097.Lps");
                            Console.WriteLine("  3. L´interdit Rouge Ultime EAU de PARFUM 80ML Costo:3,865.Lps");
                            string Modelo;
                            Modelo= Console.ReadLine();

                            if (Modelo == "1")
                            {
                                Precio = 3929;
                            }
                            else if (Modelo == "2")
                            {
                                Precio = 3097;
                            }
                            else if (Modelo == "3")
                            {
                                Precio = 3865;
                            }
                            else
                            {
                                Console.WriteLine("no tenemos el producto seleccionado");
                            }

                            break;

                      case "2":
                            Console.WriteLine(" Seccion de Paco Rabanne ");
                            Console.WriteLine("Elija el modelo deseado");
                            Console.WriteLine("  1. Olympea Absolu PARFUM 80ML Costo:3,735.Lps");
                            Console.WriteLine("  2. Fame PARFUM 80ML Costo:3,879.Lps");
                            Console.WriteLine("  3. Lady Million Royal EAU de PARFUM 50ML Costo:2,591.Lps");

                            Modelo = Console.ReadLine();

                            if (Modelo == "1")
                            {
                                Precio = 3735;
                            }
                            else if (Modelo == "2")
                            {
                                Precio = 3879;
                            }
                            else if (Modelo == "3")
                            {
                                Precio = 2591;
                            }
                            else
                            {
                                Console.WriteLine("no tenemos el producto seleccionado");
                            }

                            break;

                        case "3":
                            Console.WriteLine(" Seccion de Carolina Herrera");
                            Console.WriteLine("Elija el modelo deseado");
                            Console.WriteLine("  1. Good Girl Blush EAU de PARFUM 80ML Costo:4,367.Lps");
                            Console.WriteLine("  2. 212 VIP EAU de PARFUM 80ML Costo:3521.Lps");
                            Console.WriteLine("  3. Very Good Girl Glam EDP 80ML Costo:4,645.Lps");

                            Modelo = Console.ReadLine();

                            if (Modelo == "1")
                            {
                                Precio = 4367;
                            }
                            else if (Modelo == "2")
                            {
                                Precio = 3521;
                            }
                            else if (Modelo == "3")
                            {
                                Precio = 4645;
                            }
                            else
                            {
                                Console.WriteLine("no tenemos el producto seleccionado");
                            }


                            break;
                    }

                    break;

                case "2":
                    Console.WriteLine("Perfumes para caballeros");
                    Console.WriteLine("1. Givenchy ");
                    Console.WriteLine("2. Gucci ");
                    Console.WriteLine("3. Carolina Herrera ");
                    string PCaballero= Console.ReadLine();

                    switch (PCaballero)
                    {
                        case "1":
                            Console.WriteLine(" Seccion de Givenchy ");
                            Console.WriteLine("Elija el modelo deseado");
                            Console.WriteLine("  1. GENTLEMAN SOCIETY EAU DE PARFUM EXTREME 100ML Costo:3,713.Lps");
                            Console.WriteLine("  2. GENTLEMAN EAU DE PARFUM RESERVE PRIVEE 60ML Costo:2,771.Lps");
                            Console.WriteLine("  3. PI EAU DE TOILETTE 100ML Costo:2,997.Lps");
                            string Modelo;
                            Modelo = Console.ReadLine();

                            if (Modelo == "1")
                            {
                                Precio = 3713;
                            }
                            else if (Modelo == "2")
                            {
                                Precio = 2771;
                            }
                            else if (Modelo == "3")
                            {
                                Precio = 2997;
                            }
                            else
                            {
                                Console.WriteLine("no tenemos el producto seleccionado");
                            }
                            break;
                            

                        case "2":
                            Console.WriteLine(" Seccion de Gucci ");
                            Console.WriteLine("Elija el modelo deseado");
                            Console.WriteLine("  1. GUCCI GUILTY POUR HOMME INTENSE EAU DE TOILETTE 90ML Costo:4,261.Lps");
                            Console.WriteLine("  2. Gucci Guilty Essence Pour Homme Eau de Toilette, 90ML Costo:3,286.Lps");
                            Console.WriteLine("  3. Gucci Guilty Pour Homme, eau de parfum 90ML Costo:3,752.Lps");

                            Modelo = Console.ReadLine();

                            if (Modelo == "1")
                            {
                                Precio = 4261;
                            }
                            else if (Modelo == "2")
                            {
                                Precio = 3286;
                            }
                            else if (Modelo == "3")
                            {
                                Precio = 3752;
                            }
                            else
                            {
                                Console.WriteLine("no tenemos el producto seleccionado");
                            }
                            break;


                        case "3":
                            Console.WriteLine(" Seccion de Hugo Boss ");
                            Console.WriteLine("Elija el modelo deseado");
                            Console.WriteLine("  1. BOSS BOTTLED TONIC EAU DE TOILETTE 100ML Costo:3,523.Lps");
                            Console.WriteLine("  2. HUGO JEANS EAU DE TOILETTE 125ML Costo:3,119");
                            Console.WriteLine("  3. SET HUGO BOSS MENS THE SCENT EDT 100ML Costo:3,177.Lps");

                            Modelo = Console.ReadLine();

                            if (Modelo == "1")
                            {
                                Precio = 3523;
                            }
                            else if (Modelo == "2")
                            {
                                Precio = 3119;
                            }
                            else if (Modelo == "3")
                            {
                                Precio = 3177;
                            }
                            else
                            {
                                Console.WriteLine("no tenemos el producto seleccionado");
                            }
                            break;
                    }
                    break ;

                case "3":
                    Console.WriteLine("Perfumes Infantiles");
                    Console.WriteLine("seleccione para quien lo necesita");
                    Console.WriteLine(" 1. Niño ");
                    Console.WriteLine(" 2. Niña ");
                    string Niñx = Console.ReadLine();

                    if (Niñx == "1")
                    {
                        Console.WriteLine("EMOJI EAU DE TOILETTE 100ML Costo:581.Lps");
                        Console.WriteLine("Desea realizar la compra del articulo?");
                        Console.WriteLine(" 1. SI ");
                        Console.WriteLine(" 2. NO ");
                        string op = Console.ReadLine();

                        if (op == "1") 
                        {
                            Precio = 581;
                        }
                        else if (op == "2")
                        {
                            Precio = 0;
                        }
                    }
                    else if (Niñx == "2")
                    {
                        Console.WriteLine("Selecione la de su preferencia ");
                        Console.WriteLine("BARBIE FASHION EAU DE TOILETTE 100ML Costo:581.Lps");
                        Console.WriteLine(" Disney FROZEN EAU DE TOILETTE 100ML Costo:581.Lps");
                        Console.WriteLine(" Kids Korner HARLEY QUINN EAU DE TOILETTE 100ML Costo:495.Lps");
                        string Modelo1;
                        Modelo1= Console.ReadLine();

                        if (Modelo1== "1")
                        {
                            Precio= 581;
                        }
                        else if (Modelo1 == "2")
                        {
                            Precio = 581;
                        }
                        else if (Modelo1== "3")
                        {
                            Precio = 495;
                        }
                        else
                        {
                            Console.WriteLine("no tenemos el producto seleccionado");
                        }

                    }


                    break;

                case "4":
                    Console.WriteLine("Saliendo del programa");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion no valida. intente de nuevo.");
                    break;

            }

            Console.WriteLine($"El precio del producto es:{Precio} ");
            Console.WriteLine();
            Console.WriteLine("Ingese la cantidad a Comprar");
            int Cantidad = Convert.ToInt32( Console.ReadLine() );
            double Subtotal = Precio * Cantidad;
            double Impuesto = 0;
            if (Categoria=="1")
            {
                Impuesto = Subtotal * 0.04;
            }
            else if (Categoria=="2")
            {
                Impuesto = Subtotal * 0.10;
            }
            else if (Categoria=="3")
            {
                Impuesto = Subtotal * 0.2;
            }

            double descuento= 0;
            if (Cantidad > 10 & Cantidad < 40)
            {
                descuento = Subtotal * 0.20;
            }
            else if (Cantidad > 40 & Cantidad < 70 )
            {
                descuento = Subtotal * 0.35;
            }
            else if (Cantidad > 70 & Cantidad < 100)
            {
                descuento = Subtotal * 0.45;
            }
            else if (Cantidad > 100)
            {
                descuento = Subtotal * 0.50;
            }

            Console.WriteLine($"lleva un subtotal de {Subtotal}");

            double Total = Subtotal + Impuesto - descuento;

            Console.WriteLine($"El valor a pagar es de: {Total} usted esta pagando un impuesto de {Impuesto} y un descuento de: {descuento}");

            if (continuar)
                    {
                        Console.WriteLine("Precione cualquier tecla para continuar... ");
                        Console.ReadKey();
                    }
                   
            
        }
    }
}