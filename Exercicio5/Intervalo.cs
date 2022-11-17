using System;

namespace Exercicio5
{
    public class Intervalo
    {
        public DateTime Inicial { get; private set; }
        public DateTime Final { get; private set; }

        public Intervalo(DateTime inicial, DateTime final)
        {
            if (inicial > final)
                throw new Exception("Data e hora inicial informada é maior que a data e hora final");

            Inicial = inicial;
            Final = final;
        }

        public bool TemIntersecao(Intervalo intervalo)
        {
            return (Inicial <= intervalo.Inicial && Final > intervalo.Inicial) || (Final <= intervalo.Final && Inicial < intervalo.Final);
        }

        public TimeSpan Duracao()
        {
            return Final - Inicial;
        }

        public override bool Equals(object obj)
        {
            return obj is Intervalo intervalo &&
                Inicial == intervalo.Inicial &&
                Final == intervalo.Final;
        }

        public override string ToString()
        {
            return "Data inicial: " + Inicial + " Data final: " + Final;
        }
    }
}
