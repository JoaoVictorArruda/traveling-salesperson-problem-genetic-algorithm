using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.utils;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.crossover
{
    //Implementa a estratégia de crossover com a técnica PMX
    class CrossoverPmx : ICrossover
    {
        private Random random;
        public double taxaCrossover { get; set; }

        public CrossoverPmx(Random random, double taxaCrossover)
        {
            this.random = random;
            this.taxaCrossover = taxaCrossover;
        }

        public bool verificar()
        {
            return random.NextDouble() <= this.taxaCrossover;
        }

        public ParIndividuo cruzar(Individuo paiA, Individuo paiB)
        {
            //Define de forma aleatória os pontos de corte
            DoisPontos points = new DoisPontos(paiA.cromossomo.Length - 1, random);

            //Gera um primeiro indivíduo considerando o cruzamento entre os pontos de corte
            Individuo individuoA = cruzar(paiA, paiB, points.dentro);

            //Gera um segundo indivíduo considerando o cruzamento fora dos pontos de corte
            Individuo individuoB = cruzar(paiB, paiA, points.fora);

            //Retorna os indivíduos gerados
            return new ParIndividuo(individuoA, individuoB);
        }

        //@todo: não implementado
        private Individuo cruzar(Individuo paiA, Individuo paiB, Func<int, bool> crossoverPoint)
        {
            int[] individuo = new int[paiA.cromossomo.Length];

            for (int i = 0; i < individuo.Length; i++)
            {
                individuo[i] = paiA.cromossomo[i];
            }

            return new Individuo(individuo);
        }
    }
}
