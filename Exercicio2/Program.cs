using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de X do vertice 1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de Y do vertice 1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de X do vertice 2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de Y do vertice 2");
            double y2 = double.Parse(Console.ReadLine());

            Vertice vertice1 = new Vertice(x1, y1);
            Vertice vertice2 = new Vertice(x2, y2);

            Console.WriteLine("A distancia entre os dois vértices é: " + vertice1.Distancia(vertice2));

            Console.WriteLine("Informe o valor de X do vertice 1 para move-lo");
            double moveX1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de Y do vertice 1 para move-lo");
            double moveY1 = double.Parse(Console.ReadLine());

            vertice1.Move(moveX1, moveY1);

            Console.WriteLine("Os dois vertices são iguais? " + vertice1.Equals(vertice2));
        }
    }
}
