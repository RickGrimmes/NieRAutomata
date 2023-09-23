class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar) { 

        Console.WriteLine("Elige una opción:");
        Console.WriteLine("1. Capturar cadena de entrada");
        Console.WriteLine("2. Créditos");
        Console.WriteLine("3. Salir");
            Console.WriteLine(" ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Inserte su cadena");
                Console.ReadLine();
                 
                break;
            case 2:
                Console.WriteLine("Victor Alejandro Monarrez Duran 21170054.");
                Console.WriteLine("Martín Ricardo Cabello Rodríguez 21170074");
                Console.WriteLine("Jonathan Benjamin Vela Silva 21170072");
                Console.WriteLine("Estructura de Datos");
                Console.WriteLine("4 B");
                break;
            case 3:
                Console.WriteLine("Hasta luego ;)");
                    continuar = false;
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 3.");
                break;
        }

        Console.ReadLine();
        }
    }
}