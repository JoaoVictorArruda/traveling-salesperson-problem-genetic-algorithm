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

        private Individuo cruzar(Individuo paiA, Individuo paiB, Func<int, bool> crossoverPoint)
        {
            int[] individuo = new int[paiA.cromossomo.Length];
            int[] cruzamento = new int[individuo.Length];
            int[] genesSubstituidos = new int[individuo.Length];

            //Inicializa a lista de genes substituídos com o valor -1 para verificações posteriores
            for (int i = 0; i < genesSubstituidos.Length; i++)
            {
                genesSubstituidos[i] = -1;
            }

            //Realiza o crossover nos pontos de corte indicados
            for (int i = 0; i < cruzamento.Length; i++)
            {
                int gene = paiA.cromossomo[i];
                if (crossoverPoint(i))
                {
                    int novoGene = paiB.cromossomo[i];
                    genesSubstituidos[novoGene] = gene;
                    gene = novoGene;
                }
                cruzamento[i] = gene;
            }

            //Trata as duplicidades nos genes que não foram alterados
            for (int i = 0; i < cruzamento.Length; i++)
            {
                int gene = cruzamento[i];
                if (!crossoverPoint(i))
                {
                    while (genesSubstituidos[gene] != -1)
                    {
                        gene = genesSubstituidos[gene];
                    }
                }
                individuo[i] = gene;
            }

            //Retorna um novo indivíduo após o cruzamento
            return new Individuo(individuo);
        }
    }
}
