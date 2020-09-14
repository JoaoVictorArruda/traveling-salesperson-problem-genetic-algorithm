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

            //Calcula a aptidão do indivíduo somando as distâncias entre cada par de localidade que ele percorre até voltar para o início
            for (int i = 0; i < individuo.cromossomo.Length; i++)
            {
                int indiceA = i;
                int indiceB = i + 1 >= individuo.cromossomo.Length ? 0 : i + 1;

                distanciaTotal += this.mapa.getDistanciaEntrePontos(individuo.cromossomo[indiceA], individuo.cromossomo[indiceB]);
            }

            return distanciaTotal;
        }
    }
}
