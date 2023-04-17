namespace LabSintaxis3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] array = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine("Ingrese el valor para la posición {0}:", i);
                array[i] = Console.ReadLine();
            }

            for (int i = cantIteraciones - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();

        }
    }
}