using System;

namespace Aula22
{
    class EntradaDeDadosParte1
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            /*string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();*/

            //string s = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' '); 
            string a = v[0];
            string b = v[1];
            string c = v[2];

            /* Split cria uma matriz de subcadeias, dividindo a cadeia de caracteres de entrada com base em um ou mais delimitadores. 
             * Esse método geralmente é a maneira mais fácil de separar uma cadeia de caracteres em limites de palavra.
             * O Split vai analisar o string, cada pedaço do string que está em branco e vai armazenar em vetor de string.
             */

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);            
        }
    }
}
