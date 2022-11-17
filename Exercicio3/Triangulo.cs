using Exercicio2;
using System;

namespace Exercicio3
{
    internal class Triangulo
    {
        public Vertice Vertice1 { get; private set; }
        public Vertice Vertice2 { get; private set; }
        public Vertice Vertice3 { get; private set; }

        public double LadoA { get; private set; }
        public double LadoB { get; private set; }
        public double LadoC { get; private set; }

        public double Perimetro
        {
            get { return LadoA + LadoB + LadoC; }
        }

        public ETipoTriangulo Tipo
        {
            get
            {
                if (LadoA == LadoB && LadoB == LadoC)
                {
                    return ETipoTriangulo.Equilatero;
                } 
                else if (LadoA == LadoB || LadoB == LadoC || LadoA == LadoC)
                {
                    return ETipoTriangulo.Isosceles;
                }
                else
                {
                    return ETipoTriangulo.Escaleno;
                }
            }
        }

        public double Area
        {
            get
            {
                double s = (LadoA + LadoB + LadoC) / 2;

                return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
            }
        }

        public Triangulo(Vertice vertice1,Vertice vertice2, Vertice vertice3)
        {
            LadoA = vertice1.Distancia(vertice2);
            LadoB = vertice2.Distancia(vertice3);
            LadoC = vertice3.Distancia(vertice1);

            if (LadoA + LadoB <= LadoC || LadoA + LadoC <= LadoB || LadoC + LadoB <= LadoA)
                throw new Exception("Os vértices não correspondem a um triângulo!");

            Vertice1 = vertice1;
            Vertice2 = vertice2;
            Vertice3 = vertice3;
        }

        public override bool Equals(object obj)
        {
            return obj is Triangulo triangulo &&
                ((Vertice1.Equals(triangulo.Vertice1) &&
                  Vertice2.Equals(triangulo.Vertice2) &&
                  Vertice3.Equals(triangulo.Vertice3)) ||
                (Vertice1.Equals(triangulo.Vertice2) &&
                  Vertice2.Equals(triangulo.Vertice3) &&
                  Vertice3.Equals(triangulo.Vertice1)) ||
                (Vertice1.Equals(triangulo.Vertice3) &&
                  Vertice2.Equals(triangulo.Vertice1) &&
                  Vertice3.Equals(triangulo.Vertice2)) ||
                (Vertice1.Equals(triangulo.Vertice3) &&
                  Vertice2.Equals(triangulo.Vertice2) &&
                  Vertice3.Equals(triangulo.Vertice1)) ||
                (Vertice1.Equals(triangulo.Vertice2) &&
                  Vertice2.Equals(triangulo.Vertice1) &&
                  Vertice3.Equals(triangulo.Vertice3)) ||
                (Vertice1.Equals(triangulo.Vertice1) &&
                  Vertice2.Equals(triangulo.Vertice3) &&
                  Vertice3.Equals(triangulo.Vertice2)));
        }
    }
}
