using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.utils;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.mutacao
{
    //Implementa a estratégia de mutação através da troca de dois genes do indivíduo
    class MutacaoDoisGenes : IMutacao
    {
        public double taxaMutacao { get; set; }
        private Random random;

        public MutacaoDoisGenes(double taxaMutacao, Random random)
        {
            this.taxaMutacao = taxaMutacao;
            this.random = random;
        }

        public void mutar(Individuo individuo)
        {
            //Verifica a taxa de mutação
            if (random.NextDouble() <= this.taxaMutacao)
            {
                //Gera dois pontos aleatórios onde os genes serão trocados
                DoisPontos pontos = new DoisPontos(individuo.cromossomo.Length - 1, random);

                //Acessa os genes que serão trocados
                int geneA = individuo.cromossomo[pontos.pontoA];
                int geneB = individuo.cromossomo[pontos.pontoB];

                //Troca o valor de um gene pelo outro
                individuo.cromossomo[pontos.pontoA] = geneB;
                individuo.cromossomo[pontos.pontoB] = geneA;
            }
        }
    }
}
