using Exercicio2;
using System;
using System.Collections.Generic;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do X1 do vertice");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y1 do vertice");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X2 do vertice");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y2 do vertice");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do X3 do vertice");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y3 do vertice");
            double y3 = double.Parse(Console.ReadLine());

            var vertices = new List<Vertice>();

            vertices.Add(new Vertice(x1, y1));
            vertices.Add(new Vertice(x2, y2));
            vertices.Add(new Vertice(x3, y3));

            var poligono = new Poligono(vertices);

            Console.WriteLine("Quantidade de vértices: " + poligono.QuantidadeVertices);

            Console.WriteLine("Informe o valor do X4 do vertice");
            double x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do Y4 do vertice");
            double y4 = double.Parse(Console.ReadLine());

            vertices.Add(new Vertice(x4, y4));

            Console.WriteLine("Quantidade de vértices: " + poligono.QuantidadeVertices);

            Console.WriteLine("O perimetro do poligono é: " + poligono.Perimetro());
        }
    }
}
