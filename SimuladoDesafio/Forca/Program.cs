using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "abacaxi", "banana", "laranja", "morango", "uva" };
            Random random = new Random();
            string palavraAleatoria = palavras[random.Next(palavras.Length)];

            char[] letrasAdivinhadas = new char[palavraAleatoria.Length];
            for (int i = 0; i < letrasAdivinhadas.Length; i++)
            {
                letrasAdivinhadas[i] = '_';
            }

            bool palavraAcertada = false;
            List<char> letrasDigitadas = new List<char>();

            while (!palavraAcertada)
            {
                Console.Clear();
                Console.WriteLine("forca");
                Console.WriteLine("palavra: " + new string(letrasAdivinhadas));
                Console.WriteLine("letras ja digitadas: " + string.Join(", ", letrasDigitadas));
                Console.WriteLine("digite uma letra");
                char letra = Console.ReadKey().KeyChar;

                if (letrasDigitadas.Contains(letra))
                {
                    Console.WriteLine("voce ja digitou esta letra");
                    Console.ReadKey();
                    continue;
                }

                letrasDigitadas.Add(letra);

                bool letraAdivinhada = false;
                for (int i = 0; i < palavraAleatoria.Length; i++)
                {
                    if (palavraAleatoria[i] == letra)
                    {
                        letrasAdivinhadas[i] = letra;
                        letraAdivinhada = true;
                    }
                }

                if (new string(letrasAdivinhadas) == palavraAleatoria) {
                    palavraAcertada = true;
                }
            }

            Console.Clear();
            if (palavraAcertada)
            {
                Console.WriteLine("voce acertou a palavra: " + palavraAleatoria);
            }

            Console.ReadKey();
        }
    }
}
