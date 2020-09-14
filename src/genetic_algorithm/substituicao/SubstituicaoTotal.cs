using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesperson_problem_genetic_algorithm.genetic_algorithm.substituicao
{
    //Implementa a estratégia de substituição total da população utilizando um novo conjunto de indivíduos
    class SubstituicaoTotal : ISubstituicao
    {
        public void substituir(Populacao populacao, List<Individuo> individuos)
        {
            for (int i = 0; i < populacao.tamanho; i++)
            {
                populacao.individuos[i] = individuos[i];
                populacao.individuos[i].index = i;
            }
        }
    }
}
