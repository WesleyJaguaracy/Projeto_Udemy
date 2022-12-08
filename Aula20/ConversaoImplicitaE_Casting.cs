using System;

namespace Aula20
{
    class ConversaoImplicitaE_Casting
    {
        static void Main(string[] args)
        {
            //Conversão implicita entre tipos é quando um conteudo de um certo tipo pode ser naturalmente atribuido pra uma variável de outro tipo.

            //Casting é uma conversão explícita entre tipos COMPATÍVEIS.

            /*float x = 4.5f;
            double y = x;
            Console.WriteLine(y);*/

            /*double a;
            int b; //float b;

            a = 5.1;
            b = (int)a;  //Colocando int em parênteses faz o casting.
            //b = (float)a; //Colocando float em parênteses faz o casting.*/

            int a = 5;
            int b = 2;

            double resultado = (double) a / b; //Colocando double em parênteses faz o casting. Sem o casting ele vai dividir por inteiro.

            Console.WriteLine(resultado);
        }
    }
}
