using Exercicio2;
using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do X do vertice 1 do Triângulo 1");
            double xv1t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y do vertice 1 do Triângulo 1");
            double yv1t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X do vertice 2 do Triângulo 1");
            double xv2t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y do vertice 2 do Triângulo 1");
            double yv2t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X do vertice 3 do Triângulo 1");
            double xv3t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y do vertice 3 do Triângulo 1");
            double yv3t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X do vertice 1 do Triângulo 2");
            double xv1t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y do vertice 1 do Triângulo 2");
            double yv1t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X do vertice 2 do Triângulo 2");
            double xv2t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y do vertice 2 do Triângulo 2");
            double yv2t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X do vertice 3 do Triângulo 2");
            double xv3t2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y do vertice 3 do Triângulo 2");
            double yv3t2 = double.Parse(Console.ReadLine());

            Triangulo triangulo1 = new Triangulo(
                new Vertice(xv1t1, yv1t1),
                new Vertice(xv2t1, yv2t1),
                new Vertice(xv3t1, yv3t1));

            Triangulo triangulo2 = new Triangulo(
                new Vertice(xv1t2, yv1t2),
                new Vertice(xv2t2, yv2t2),
                new Vertice(xv3t2, yv3t2));

            Console.WriteLine("Perimetro do Triângulo 1 é: " + triangulo1.Perimetro + " e Triângulo 2 é: " + triangulo2.Perimetro);
            
            Console.WriteLine("O tipo do Triângulo 1 é: " + triangulo1.Tipo + " e Triângulo 2 é: " + triangulo2.Tipo);

            Console.WriteLine("A área do Triângulo 1 é: " + triangulo1.Area + " e Triângulo 2 é: " + triangulo2.Area);

            Console.WriteLine("A área do Triângulo 1 é: " + triangulo1.Area + " e Triângulo 2 é: " + triangulo2.Area);


            Console.WriteLine("Os Triângulos são iguais? " + triangulo1.Equals(triangulo2));
        }
    }
}
