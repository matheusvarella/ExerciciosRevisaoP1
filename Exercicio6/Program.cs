using Exercicio5;
using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataInicial1 = DateTime.Parse("14/08/2005");
            var dataFinal1 = DateTime.Parse("14/09/2005");

            Intervalo intervalo1 = new Intervalo(dataInicial1, dataFinal1);

            ListaIntervalo lista = new ListaIntervalo();

            lista.Add(intervalo1);

            var dataInicial2 = DateTime.Parse("20/08/2005");
            var dataFinal2 = DateTime.Parse("20/09/2005");

            Intervalo intervalo2 = new Intervalo(dataInicial2, dataFinal2);

            // lista.Add(intervalo2);

            var dataInicial3 = DateTime.Parse("20/10/2003");
            var dataFinal3 = DateTime.Parse("20/09/2004");

            Intervalo intervalo3 = new Intervalo(dataInicial3, dataFinal3);

            lista.Add(intervalo3);

            lista.Imprime();
        }
    }
}
