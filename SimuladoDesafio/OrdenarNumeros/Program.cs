using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 3, 5, 1, 63, 56, 34 };

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
