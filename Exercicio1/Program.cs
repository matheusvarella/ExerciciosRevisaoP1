using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor maior ou igual a 1 para gerar a piramide");
            int n = int.Parse(Console.ReadLine());

            Piramide piramide = new Piramide(n);

            piramide.Desenha();
        }
    }
}
