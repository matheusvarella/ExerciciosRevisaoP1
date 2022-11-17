using Exercicio5;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio6
{
    internal class ListaIntervalo
    {
        public List<Intervalo> Intervalos { get; private set; }

        public ListaIntervalo()
        {
            Intervalos = new List<Intervalo>();
        }

        public void Add(Intervalo intervalo)
        {
            foreach (var item in Intervalos)
            {
                if (item.TemIntersecao(intervalo))
                    throw new Exception("Não é possível adicionar o intervalo porque possue intersecção!");
            }

            Intervalos.Add(intervalo);
        }

        public void Imprime()
        {
            List<Intervalo> lista = Intervalos.OrderBy(x => x.Inicial).ToList();

            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
