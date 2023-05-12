using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma palavra:");
            string palindromo = Console.ReadLine().Replace(" ", "").ToLower();
            string palindromoReverse = new string(palindromo.ToCharArray().Reverse().ToArray());
            
            string saida = palindromo == palindromoReverse ? $"A string {palindromo} é um palíndromo" : $"A string {palindromo} não é um palíndromo";
            Console.WriteLine(saida);

            Console.ReadKey();
        }
    }
}
