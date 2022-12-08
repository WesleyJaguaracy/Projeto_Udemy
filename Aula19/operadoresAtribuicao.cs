using System;

namespace Aula19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10; // a recebe 10
            Console.WriteLine(a);

            a += 2; // a recebe a + 2, o que já tinha no a.
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);*/

            int a = 10;
            int b = ++a;
            //a++;
            //a--;
            Console.WriteLine(a); // ++a quando feita desse modo, ela primeiro incrementa para ele mesmo, e depois ele incrementa para b.
            //Console.WriteLine(a); //  a++ Primeiro ele vai jogar o valor inicial para b e depois variável a vai ser incrementada.
            Console.WriteLine(b); // A b recebe o valor de a inicial

            // Atribuição
            // ++ incrementação a++; ou ++a; a = a + 1; <- Esse ultimo é o significado.
            // -- descrementação a--; ou --a; a = a - 1; <- Esse ultimo é o significado.
        }
    }
}
