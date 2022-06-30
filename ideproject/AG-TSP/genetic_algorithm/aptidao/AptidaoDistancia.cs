using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.aptidao
{
    //Implementa a estratégia de aptidão do indivíduo considerando a distância
    public class AptidaoDistancia : IAptidao
    {
        private Mapa mapa;

        public AptidaoDistancia(Mapa mapa)
        {
            this.mapa = mapa;
        }

        public double calcular(Individuo individuo)
        {

            double distanciaTotal = 0.0;

            for (int i = 0; i < individuo.cromossomo.Length; i++)
            {
                if (i < (individuo.cromossomo.Length - 1))
                {
                    distanciaTotal += this.mapa.getDistanciaEntrePontos(individuo.cromossomo[i], individuo.cromossomo[i + 1]);
                }
                else
                {
                    distanciaTotal += this.mapa.getDistanciaEntrePontos(individuo.cromossomo[i], individuo.cromossomo[0]);
                }
            }

            return distanciaTotal;
        }
    }
}
