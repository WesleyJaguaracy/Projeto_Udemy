﻿using System;

namespace Aula21
{
    class OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8; // Tem que fazer o casting ou 10.0, pelo menos um dos dois tem que estar com ponto para indicar que eu quero uma expressão double.

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0)  - 4.0 * a * c; // b * b significa b ao quadrado. Math.Pow() é muito utilizada para pontenciação.

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
