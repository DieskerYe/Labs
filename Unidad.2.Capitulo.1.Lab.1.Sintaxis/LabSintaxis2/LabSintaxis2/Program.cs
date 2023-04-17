using System;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ESTRUCTURAS DE DECISION

            string inputTexto;
            Console.WriteLine("Ingrese un texto por favor:");
            inputTexto = Console.ReadLine();
            if (inputTexto.Length == 0)
            {
                Console.WriteLine("no hay nada");
            }
            else
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1- Mostrar la frase en mayusculas");
                Console.WriteLine("2- Mostrar la frase en minusculas");
                Console.WriteLine("3- Contar los caracteres de la frase");
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine(inputTexto.Length);
                }
            }
                Console.ReadKey(); 

            //2. ESTRUCTURAS DE DECISION (BIS)
            
            string inputTexto;
            Console.WriteLine("Ingrese un texto por favor:");
            inputTexto = Console.ReadLine();
            if (inputTexto.Length == 0)
            {
                Console.WriteLine("no hay nada");
            }
            else
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1- Mostrar la frase en mayusculas");
                Console.WriteLine("2- Mostrar la frase en minusculas");
                Console.WriteLine("3- Contar los caracteres de la frase\n");
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(inputTexto.Length);
                        break;
                }
                Console.ReadKey(); 

            //3. ESTRUCTURAS DE ITERACION


            }
        }
    }
}