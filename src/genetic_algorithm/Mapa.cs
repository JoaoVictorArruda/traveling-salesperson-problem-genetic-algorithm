using System;
using System.Collections;
using System.Collections.Generic;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm
{
    public class Mapa
    {
        private static Mapa instance;
        private List<int> coordenadaX = new List<int>();
        private List<int> coordenadaY = new List<int>();
        private double[,] tabelaDistancia;
        public int quantidadePontos = 0;

        public static Mapa getInstance()
        {
            if(instance == null)
            {
                instance = new Mapa();
            }
            return instance;
        }

        public void adicionarPonto(int x, int y)
        {
            coordenadaX.Add(x);
            coordenadaY.Add(y);
            quantidadePontos++;
            gerarTabela();
        }

        public object getCoordenadaX(int i)
        {
            return coordenadaX[i];
        }

        public object getCoordenadaY(int i)
        {
            return coordenadaY[i];
        }

        public void gerarTabela()
        {
            tabelaDistancia = new double[quantidadePontos, quantidadePontos];

            for (int i = 0; i < quantidadePontos; i++)
            {
                for (int j = 0; j < quantidadePontos; j++)
                {
                    tabelaDistancia[i, j] = Math.Sqrt(Math.Pow(int.Parse(coordenadaX[i].ToString())
                                                          - int.Parse(coordenadaX[j].ToString()), 2)
                                                          + Math.Pow(int.Parse(coordenadaY[i].ToString())
                                                          - int.Parse(coordenadaY[j].ToString()), 2));
                }
            }
            Configuracao.tamanhoCromossomo = quantidadePontos;
        }

        public double getDistanciaEntrePontos(int ponto1, int ponto2)
        {
            return tabelaDistancia[ponto1, ponto2];
        }

        public int[] getCordenadas(int ponto)
        {

            int[] coordenadas = new int[2];
            coordenadas[0] = int.Parse(coordenadaX[ponto].ToString());
            coordenadas[1] = int.Parse(coordenadaY[ponto].ToString());
            return coordenadas;
        }

        public void limpar()
        {
            coordenadaX.Clear();
            coordenadaY.Clear();
            quantidadePontos = 0;
            tabelaDistancia = null;
        }
    }
}
