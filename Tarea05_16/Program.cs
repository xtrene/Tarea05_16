using System;

namespace Tarea05_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1, 2, 3, 4, 5, 5,4, 3, 2, 1};
            Boolean capicua = true;
            int mitad = lista.Length / 2;
            for (int i=0; i<mitad; i++)
            {

                if (lista[i] != lista[(lista.Length - 1) - i])
                {
                    capicua = false;
                }

            }

            if (capicua)
            {
                Console.WriteLine("El array es capicua...");
            }
            else
            {
                Console.WriteLine("El array NO es capicua...");
            }



            Console.ReadKey();
        }
    }
}
