using System;

namespace Exercicio1
{
    internal class Piramide
    {
        public int N { get; private set; }

        public Piramide(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException("O valor de N não pode ser menor que 1!");
            }

            N = n;
        }

        public void Desenha()
        {
            for (int i = 1; i <= N; i++)
            {
                string aux = "";

                for (int j = 1; j <= (N - i); j++)
                {
                    aux += " ";
                }

                aux += PreencheLinha(i);

                Console.WriteLine(aux);
            }
        }

        private string PreencheLinha(int n)
        {
            string line = "";
            int aux = 1;

            do
            {
                if (line.Length < n)
                {
                    line += aux;

                    if (aux < n)
                        aux++;
                }
                else
                {
                    line += --aux;
                }
            } while (line.Length < (n * 2 - 1));

            return line;
        }
    }
}
