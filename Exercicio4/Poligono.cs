using Exercicio2;
using System;
using System.Collections.Generic;

namespace Exercicio4
{
    internal class Poligono
    {
        public List<Vertice> Vertices { get; private set; }

        public int QuantidadeVertices { get { return Vertices.Count; } }

        public Poligono(List<Vertice> vertices)
        {
            if (vertices.Count < 3)
                throw new Exception("O Poligono deve possuir ao menos 3 vértices!");

            Vertices = vertices;
        }

        public bool AddVertice(Vertice v)
        {
            foreach(Vertice vert in Vertices)
            {
                if (vert.Equals(v))
                    return false;
            }

            Vertices.Add(v);
            return true;
        }

        public void RemoveVertice(Vertice v)
        {
            if (Vertices.Count == 3)
                throw new Exception("Não é possível remover o vértice porque o Poligono só possui 3 vértices!");

            Vertices.Remove(v);
        }

        public double Perimetro()
        {
            double perimetro = 0;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if (i == Vertices.Count - 1)
                {
                    perimetro += Vertices[i].Distancia(Vertices[0]);
                } 
                else
                {
                    perimetro += Vertices[i].Distancia(Vertices[i + 1]);
                }
            }

            return perimetro;
        }
    }
}
