namespace LabSintaxis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1
            Console.WriteLine("Ingrese el primer número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = numero1 + numero2;

            Console.WriteLine("El resultado de la suma de {0} y {1} es {2}.", numero1, numero2, resultado);

            Console.ReadLine();

            //EJERCICIO 2
            Console.WriteLine("Ingrese un año:");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} es un año bisiesto.", year);
            }
            else
            {
                Console.WriteLine("{0} no es un año bisiesto.", year);
            }

            Console.ReadLine();

            //EJERCICIO 3
            Console.WriteLine("Ingrese un límite para la serie de Fibonacci:");
            int limite = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            int suma = 0;

            while (suma <= limite)
            {
                suma = n1 + n2;
                n1 = n2;
                n2 = suma - n1;
                Console.WriteLine(suma);
            }

            Console.WriteLine("La suma de los números de la serie de Fibonacci hasta {0} es {1}.", limite, suma);

            Console.ReadLine();
        }
    }
}