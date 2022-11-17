using System;
using System.Globalization;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataInicial1 = DateTime.Parse("14/08/2005");
            var dataFinal1 = DateTime.Parse("14/09/2005");

            Intervalo intervalo1 = new Intervalo(dataInicial1, dataFinal1);

            Console.WriteLine("Duração " + intervalo1.Duracao());

            var dataInicial2 = DateTime.Parse("20/08/2005");
            var dataFinal2 = DateTime.Parse("20/09/2005");

            Intervalo intervalo2 = new Intervalo(dataInicial2, dataFinal2);

            Console.WriteLine("Os intervalos possuem intersecção? " + intervalo1.TemIntersecao(intervalo2));
        }
    }
}
