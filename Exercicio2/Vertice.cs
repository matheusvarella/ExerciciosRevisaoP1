using System;

namespace Exercicio2
{
    public class Vertice
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distancia(Vertice vertice)
        {
            double x = Math.Pow((X - vertice.X), 2);
            double y = Math.Pow((Y - vertice.Y), 2);

            double result = Math.Sqrt(x + y);

            return result;
        }

        public void Move(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Vertice vertice &&
                X == vertice.X &&
                Y == vertice.Y;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
